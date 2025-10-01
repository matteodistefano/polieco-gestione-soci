Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.TypedViewClasses
Imports System.IO

Public Class dlgStampaEsportaSoci


    Private _Dati As DAL.TypedViewClasses.VwRicercaAziendeTypedView
    Private _SelEv() As dlgSelFiltroEvento.SelEvento
    Private _CartellaModelli As String

    Public Sub Apri(Dati As DAL.TypedViewClasses.VwRicercaAziendeTypedView, SelEv() As dlgSelFiltroEvento.SelEvento)

        _Dati = Dati
        _SelEv = SelEv
        Inizializza()
        Me.ShowDialog()

    End Sub


    Private Sub Inizializza()

        Me.Text = "Stampa / Esporta "
        If Me._Dati.Count = 1 Then
            Me.Text &= "[1 socio]"
        Else
            Me.Text &= "[" & _Dati.Count & " soci]"
        End If

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)

        _CartellaModelli = Generale.GetCartellaModelli & "\ElencoSoci"

        If Not System.IO.Directory.Exists(_CartellaModelli) Then
            MsgBox("Cartella modelli non trovata", MsgBoxStyle.Information)
            rbSt2.Enabled = False
        Else
            Dim fi() As String = mdsUtility.FileSystem.GetFiles(_CartellaModelli, "*.docx")
            cbModelloWord.Items.AddRange(fi)
            cbModelloWord.Enabled = False
        End If

    End Sub

    Private Sub rbSt1_CheckedChanged(sender As Object, e As EventArgs) Handles rbSt1.CheckedChanged, rbSt1.CheckedChanged, rbSt2.CheckedChanged
        cbModelloWord.Enabled = rbSt2.Checked
        chkGeneraEvento.Visible = rbSt2.Checked
    End Sub

    Private Sub tsbOk_Click(sender As Object, e As EventArgs) Handles tsbOk.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If rbSt0.Checked Then
                StampaReport()
            ElseIf rbSt1.Checked Then
                EsportaExcel()
            ElseIf rbSt2.Checked Then
                EsportaWord()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub tsbAnnulla_Click(sender As Object, e As EventArgs) Handles tsbAnnulla.Click
        Me.Close()
    End Sub

    Private Sub StampaReport()
        Dim F As New mdsReport.FReport
        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\elencosoci.rpt")
        '_Dati.WriteXmlSchema(My.Application.Info.DirectoryPath & "\..\..\datasets\elencosoci.xml")
        'MsgBox("Schema scritto")
        F.ApplyLogonData(Rpt, DA.ConnectionString, _Dati)
        F.Apri(Rpt)
    End Sub

    Private _Working As Boolean

    Private Sub EsportaWord()
        If cbModelloWord.SelectedItem Is Nothing Then Return

        Try

            pnlLog.Visible = True
            lblLog.Text = "Inizializzazione"
            tsbStop.Available = True
            tsbOk.Enabled = False
            tsbAnnulla.Enabled = False
            pBar.Value = 0
            pBar.Maximum = _Dati.Count
            _Working = True

            Dim wrm As New WordReportManager()
            wrm.GetReport(_CartellaModelli & "\" & cbModelloWord.Text, _Dati, AddressOf Logger)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            pnlLog.Visible = False
            tsbStop.Available = False
            tsbOk.Enabled = True
            tsbAnnulla.Enabled = True
        End Try


    End Sub

    Private Function Logger(x As Integer, rw As DataRow) As Boolean
        pBar.Value = x
        Dim st As String = String.Format("Documento {0} di {1}", x + 1, _Dati.Count)
        lblLog.Text = st
        If chkGeneraEvento.Checked Then
            Dim ev As EventoAziendaEntity = Managers.SociManager.AggiungiEvento(rw("Id"), Enums.TipoEvento.CERTIFICATE_DECLARATION, Nothing, Nothing, Nothing, "Stampa del certificato per socio aderente")
            DA.SaveEntity(ev)
        End If


        My.Application.DoEvents()
        Return _Working
    End Function


    Private Sub tsbStop_Click(sender As Object, e As EventArgs) Handles tsbStop.Click
        If _Working Then
            If MsgBox("Interrompere ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = vbYes Then
                _Working = False
            End If
        End If
    End Sub


    Private Sub EsportaExcel()
        Try
            Dim F As New mdsUIControls.dlgExpExcel
            F.Esporta(_Dati.DefaultView, Generale.UserApplicationFolder & "\ExpAziende.cfg")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class