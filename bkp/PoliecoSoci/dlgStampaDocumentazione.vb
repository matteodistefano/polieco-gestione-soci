Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports System.IO

Public Class dlgStampaDocumentazione
    Private _Azienda As AziendaEntity
    
    Public Sub Apri(Azienda As AziendaEntity)
        _Azienda = Azienda
        Inizializza()
        Me.ShowDialog()
    End Sub
    
    Private Sub Inizializza()
        lAzienda.Text = String.Format("{0} - {1}", _Azienda.Id, _Azienda.RagioneSociale)

        CaricaModelli()


    End Sub

    Private Sub CaricaModelli()
        Try
            Dim BaseFld As String = Generale.GetCartellaModelli
            BaseFld &= "\DocumentiSoci"
            If Not System.IO.Directory.Exists(BaseFld) Then Throw New Exception("Cartella documenti non trovata")
            Dim D As New System.IO.DirectoryInfo(BaseFld)
            Dim fi() As FileInfo = D.GetFiles("*.docx")
            tvwModelli.Nodes.Clear()
            tvwModelli.ItemHeight = 20

            For Each f In fi
                Dim Nd As TreeNode = tvwModelli.Nodes.Add(System.IO.Path.GetFileNameWithoutExtension(f.Name))
                Nd.ImageIndex = 1
                Nd.Tag = f.FullName
                Nd.Checked = True
            Next

            Dim NdCat As TreeNode
            Dim Cat As String = _Azienda.CodCategoria
            NdCat = tvwModelli.Nodes.Add("Documenti Categoria [" & Cat & "]")
            NdCat.ImageIndex = 0
            NdCat.SelectedImageIndex = 0
            NdCat.Checked = True


            Dim DCat As DirectoryInfo = D.GetDirectories("CAT_*" & Cat).FirstOrDefault
            If DCat IsNot Nothing Then
                fi = DCat.GetFiles("*.docx")
                For Each f In fi
                    Dim Nd As TreeNode = NdCat.Nodes.Add(System.IO.Path.GetFileNameWithoutExtension(f.Name))
                    Nd.Tag = f.FullName
                    Nd.ImageIndex = 1
                    Nd.Checked = True
                Next
                NdCat.Expand()
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    
    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            AvviaStampa()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

    Private Sub tvwModelli_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvwModelli.AfterCheck
        Dim Nd As TreeNode = e.Node
        If Nd.Nodes.Count = 0 Then Return
        For Each n As TreeNode In Nd.Nodes
            n.Checked = Nd.Checked
        Next
    End Sub

    Private Sub AvviaStampa()
        Try
            Dim sel As New List(Of String)
            For Each nd As TreeNode In tvwModelli.Nodes
                If nd.Tag <> "" Then
                    If nd.Checked Then
                        sel.Add(nd.Tag)
                    End If
                Else
                    For Each nf As TreeNode In nd.Nodes
                        If nf.Checked AndAlso nf.Tag <> "" Then
                            sel.Add(nf.Tag)
                        End If
                    Next
                End If
            Next

            If sel.Count = 0 Then Throw New Exception("Nessun documento selezionato")

            Dim wrm As New WordReportManager()
            For Each f In sel
                Try
                    wrm.GetReport(f, _Azienda.GetXMLData, "/azienda/")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try

            Next

            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class