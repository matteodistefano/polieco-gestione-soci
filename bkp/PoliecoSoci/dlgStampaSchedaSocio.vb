Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgStampaSchedaSocio
    Private _Azienda As AziendaEntity

    Public Sub Apri(Azienda As AziendaEntity)
        _Azienda = Azienda
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        lAzienda.Text = String.Format("{0} - {1}", _Azienda.Id, _Azienda.RagioneSociale)
        If _Azienda.Sedi.Count = 0 Then chkSedi.Checked = False
        If _Azienda.Contatti.Count = 0 Then chkContatti.Checked = False



    End Sub


    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim F As New mdsReport.FReport
            Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Rpt = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\schedasocio.rpt")

            F.ApplyLogonData(Rpt, Generale.ConnectionString)

            Rpt.RecordSelectionFormula = "{Azienda.Id}=" & _Azienda.Id
            Rpt.SetParameterValue("Sottotitolo", txtSottotitolo.Text)
            Rpt.SetParameterValue("MostraRecapiti", chkRecapiti.Checked)
            Rpt.SetParameterValue("MostraSedi", chkSedi.Checked)
            Rpt.SetParameterValue("MostraContatti", chkContatti.Checked)
            Rpt.SetParameterValue("MostraDichiarazioni", chkDichiarazioni.Checked)
            Rpt.SetParameterValue("MostraEventi", chkEventi.Checked)
            Rpt.SetParameterValue("MostraProdotti", chkProdotti.Checked)

            F.Apri(Rpt)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

End Class