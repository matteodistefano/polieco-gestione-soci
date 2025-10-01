Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgEventoAzienda
    Private _EA As EventoAziendaEntity
    Private _CanEdit As Boolean

    Public Sub Apri(EA As EventoAziendaEntity)
        _EA = EA
        _EA.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuovo(Az As AziendaEntity, CodEvento As String) As EventoAziendaEntity
        If Not CodEvento.EndsWith("_M") Then Throw New Exception("Impossibile creare un evento di sistema")
        _EA = EventoAziendaEntity.GetNew(Az, CodEvento)
        Inizializza()
        Me.ShowDialog()
        Return _EA
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _EA.Azienda.Id, _EA.Azienda.RagioneSociale)

        bsData.DataSource = _ea
    End Sub

    Private Sub InitUiSecurity()
        _CanEdit = UtentiManager.IsLoggedUserSegreteria

        tsbOk.Available = _CanEdit
        If Not _CanEdit Then
            tsbExit.Text = "Chiudi"
        End If
    End Sub

    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            bsData.EndEdit()
            _EA.ValidateEntity()
            DA.SaveEntity(_ea, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _ea.IsNew Then
            _EA.Azienda.Eventi.Remove(_EA)
        Else
            bsData.CancelEdit()
            _ea.RollbackFields("Edit")
            _ea = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub ucArxivar_ProfileClick(sender As Object, e As ArxivarWCFWrapper.ucProtocolloArxivar.ProfileClickEventArgs) Handles ucArxivar.ProfileClick
        Try

            Dim Par As New Dictionary(Of String, String)
            Par.Add("DataDoc", _EA.Data)

            Dim F As New ArxivarWCFWrapper.dlgProfilaDocumento
            Dim Id As Integer? = F.ProfileFor(CommonConfig.ArxivarIdRubricaSoci & "," & CommonConfig.PrefissoCodiceRubrica & _EA.IdAzienda, Nothing, Par)
            If Id.HasValue Then
                ucArxivar.Protocollo = Id.Value
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class