Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FManagerUtenti
    Private _PP As PrefetchPath2
    Private _Utenti As EntityCollection(Of UtenteEntity)
    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()

        _PP = New PrefetchPath2(CInt(EntityType.UtenteEntity))
        _PP.Add(UtenteEntity.PrefetchPathRuoli)
        _Utenti = New EntityCollection(Of UtenteEntity)
        DA.FetchEntityCollection(_Utenti, Nothing, _PP)
        Me.bsUtenti.DataSource = _Utenti.CreateView()
    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    Private Sub tsbNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuovo.Click
        Dim Ut As New UtenteEntity
        Ut.IsAttivo = True
        Ut.AddRuolo(Enums.Ruolo.SEMPLICE)
        Ut.NumeroAccessi = 0
        Dim F As New dlgUtente
        If F.Apri(Ut) Then
            Me._Utenti.Add(Ut)
            bsUtenti.Position = bsUtenti.IndexOf(Ut)
        End If
    End Sub

    Private Sub dgUtenti_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvUtenti.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim ut As UtenteEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcStato Then
            If Not ut.IsAttivo Then
                e.Value = My.Resources.Light_Red_Round_16_n_g
            ElseIf ut.HasPasswordProvvisoria Then
                e.Value = My.Resources.Light_Blue_Round_16_n_g
            Else
                e.Value = My.Resources.Light_Green_Round_16_n_g
            End If
        End If
    End Sub



    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvUtenti.DoubleClick
        ApriUtente()
    End Sub

    Private Sub ApriUtente()
        If Me.bsUtenti.Current Is Nothing Then Return
        Dim F As New dlgUtente
        F.Apri(Me.bsUtenti.Current)
        dgvUtenti.Invalidate()
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim Ut As UtenteEntity = bsUtenti.Current
        If Ut Is Nothing Then Return
        If MsgBox("Eliminare l'utente selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Utente", Managers.AuditManager.OperazioneEnum.DEL, Ut.Descrizione)
            Managers.UtentiManager.DeleteUtente(Ut)
            Me.bsUtenti.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'Private Sub tsbRuoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim F As New mdsDbLib.FGest_Tabella
    '    F.Apri("Ruoli", "Ruoli", DAL.Lookups.Ruoli)
    '    Dim V As Object = DAL.Lookups.Ruoli(True)
    'End Sub



End Class