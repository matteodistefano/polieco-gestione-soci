Public Class WordReportManager
    Public Function GetReport(ByVal TemplatePath As String, ByVal Data As String, ByVal BasePath As String) As Boolean
        Try
            Cursor.Current = Cursors.WaitCursor
            If (Windows.Forms.Control.ModifierKeys And Keys.Control) <> 0 Then
                Dim F As New mdsUIControls.dlgStringEdit
                F.Apri(Data, "Dati comunicati", False)
                Return False
            End If

            Dim tmpDoc As String = System.IO.Path.GetTempFileName
            tmpDoc = tmpDoc.Replace(".tmp", ".docx")

            System.IO.File.Copy(TemplatePath, tmpDoc)

            Dim w As New NetOffice.WordApi.Application '= CreateObject("Word.Application")
            'Dim d As NetOffice.WordApi.Document = w.Documents.Open(tmpDoc)
            Dim d As NetOffice.WordApi.Document = w.Documents.Add(tmpDoc)

            MergeData(d, Data, BasePath, "")
            d.Saved = True

            w.Visible = True
            w.Activate()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Function

    Public Sub GetReport(ByVal TemplatePath As String,
                         TbIn As DataTable,
                         Logger As Func(Of Integer, DataRow, Boolean))

        Dim w As NetOffice.WordApi.Application
        Dim dFinal As NetOffice.WordApi.Document
        Dim d As NetOffice.WordApi.Document

        Try
            If TbIn.Rows.Count = 0 Then Return
            Cursor.Current = Cursors.WaitCursor
            Trace.TraceInformation("Inizializzazione")


            Dim Data As String

            If (Windows.Forms.Control.ModifierKeys And Keys.Control) <> 0 Then
                Data = GetXmlRow(TbIn.Rows(0))
                Dim F As New mdsUIControls.dlgStringEdit
                F.Apri(Data, "Dati comunicati", False)
                Return
            End If

            Dim tmpDoc As String = System.IO.Path.GetTempFileName
            tmpDoc = tmpDoc.Replace(".tmp", ".docx")
            System.IO.File.Copy(TemplatePath, tmpDoc)

            w = New NetOffice.WordApi.Application
            dFinal = w.Documents.Add()
            d = w.Documents.Add(tmpDoc)

            Dim XmlPartId As String = ""
            For r As Integer = 0 To TbIn.Rows.Count - 1
                Dim rw As DataRow = TbIn.Rows(r)
                Data = "<data>" & GetXmlRow(rw) & "</data>"
                XmlPartId = MergeData(d, Data, "/data/", XmlPartId)
                If r = 0 Then
                    d.Content.Copy()
                    dFinal.Content.PasteAndFormat(NetOffice.WordApi.Enums.WdRecoveryType.wdPasteDefault)
                Else
                    d.Content.Copy()
                    Dim p As NetOffice.WordApi.Paragraph = dFinal.Range.Paragraphs.Add()
                    p.Range.InsertBreak()
                    p.Range.PasteAndFormat(NetOffice.WordApi.Enums.WdRecoveryType.wdPasteDefault)
                End If

                If Logger IsNot Nothing Then
                    If Not Logger(r, rw) Then

                        If d IsNot Nothing Then d.Close(False)
                        If dFinal IsNot Nothing Then dFinal.Close(False)
                        w.Dispose()

                        Exit Sub
                    End If
                End If

            Next

            d.Saved = True
            d.Close()
            dFinal.Saved = True
            dFinal.Activate()
            w.Visible = True
            w.Activate()



        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Function GetXmlRow(rw As DataRow) As String

        Dim sb As New System.Text.StringBuilder
        For Each c As DataColumn In rw.Table.Columns
            Dim V As Object = rw(c.ColumnName)
            If IsDBNull(V) Then
                V = ""
            ElseIf c.DataType Is GetType(DateTime) Then
                V = CType(V, DateTime).ToShortDateString
            End If
            sb.AppendFormat("<{0}><![CDATA[{1}]]></{0}>", c.ColumnName, V)
            sb.AppendLine()
        Next
        Return sb.ToString
    End Function

    Private Function MergeData(d As NetOffice.WordApi.Document, XmlData As String, basepath As String, CustomPartID As String) As String
        Dim Data As String = mdsUtility.XMLHelper.ReplaceBlankNodes(XmlData, "")

        Dim xmlP As NetOffice.OfficeApi.CustomXMLPart

        If CustomPartID = "" Then
            xmlP = d.CustomXMLParts.Add(Data)

        Else
            xmlP = d.CustomXMLParts.SelectByID(CustomPartID)
            xmlP.Delete()
            'xmlP.LoadXML(Data)
            xmlP = d.CustomXMLParts.Add(Data)
        End If

        For Each rng As NetOffice.WordApi.Range In d.StoryRanges
            For i As Integer = 1 To rng.ContentControls.Count
                Dim cc As NetOffice.WordApi.ContentControl
                cc = rng.ContentControls(i)
                cc.XMLMapping.SetMapping(basepath & cc.Title, "", xmlP)
            Next
        Next


        Return xmlP.Id
    End Function


    Public Shared Sub CreatePrintMenu(ByVal cms As ContextMenuStrip, ByVal BasePath As String, CustomFolder As String, ByVal HandlerRoutine As System.EventHandler)
        cms.Items.Clear()
        Dim F() As String = System.IO.Directory.GetFiles(BasePath, "*.docx")
        Dim tsi As ToolStripItem
        For i As Integer = 0 To F.Length - 1
            Dim NmFile As String = System.IO.Path.GetFileNameWithoutExtension(F(i))
            If Not NmFile.StartsWith("~") Then
                tsi = cms.Items.Add(NmFile, Nothing, HandlerRoutine)
                tsi.Tag = F(i)
            End If
        Next

        'Aggiunta modelli per utente
        BasePath = BasePath & "\" & IIf(CustomFolder <> "", CustomFolder & "\", "")
        If Not IO.Directory.Exists(BasePath) Then Return
        F = System.IO.Directory.GetFiles(BasePath, "*.docx")
        If F.Length = 0 Then Return
        Dim tssep As New ToolStripSeparator
        cms.Items.Add(tssep)
        For i As Integer = 0 To F.Length - 1
            Dim NmFile As String = System.IO.Path.GetFileNameWithoutExtension(F(i))
            tsi = cms.Items.Add(NmFile, Nothing, HandlerRoutine)
            tsi.Tag = F(i)
        Next

    End Sub

    Public Shared Sub CreatePrintMenu(ByVal tsddb As ToolStripDropDownButton, ByVal BasePath As String, CustomFolder As String, ByVal HandlerRoutine As System.EventHandler)
        tsddb.DropDownItems.Clear()
        Dim F() As String = System.IO.Directory.GetFiles(BasePath, "*.docx")
        Dim tsi As ToolStripItem
        For i As Integer = 0 To F.Length - 1
            Dim NmFile As String = System.IO.Path.GetFileNameWithoutExtension(F(i))
            tsi = tsddb.DropDownItems.Add(NmFile, Nothing, HandlerRoutine)
            tsi.Tag = F(i)
        Next

        'Aggiunta modelli per utente
        BasePath = BasePath & "\" & IIf(CustomFolder <> "", CustomFolder & "\", "")
        If Not IO.Directory.Exists(BasePath) Then Return
        F = System.IO.Directory.GetFiles(BasePath, "*.docx")
        If F.Length = 0 Then Return
        Dim tssep As New ToolStripSeparator
        tsddb.DropDownItems.Add(tssep)
        For i As Integer = 0 To F.Length - 1
            Dim NmFile As String = System.IO.Path.GetFileNameWithoutExtension(F(i))
            tsi = tsddb.DropDownItems.Add(NmFile, Nothing, HandlerRoutine)
            tsi.Tag = F(i)
        Next
    End Sub

End Class
