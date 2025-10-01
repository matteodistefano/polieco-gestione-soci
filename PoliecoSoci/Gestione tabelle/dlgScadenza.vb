Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgScadenza
    Private _Scadenza As ScadenzaEntity
    Private retValue As Boolean

    Public Function Apri(ByVal Scad As ScadenzaEntity) As Boolean
        Me._Scadenza = Scad
        Scad.AuditorToUse = New EntityAuditor
        Inizializza()
        Me.ShowDialog()
        Scad.AuditorToUse = Nothing
        Return retValue
    End Function

    Private Sub Inizializza()

        DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)

        _Scadenza.SaveFields("Edit")

        cbCategoria.DataSource = Lookups.Categorie
        cbCategoria.DisplayMember = "Descrizione"
        cbCategoria.ValueMember = "Codice"
        cbCategoria.DataBindings.Add("SelectedValue", bsEntity, "CodCategoria")

        Me.bsEntity.DataSource = _Scadenza

    End Sub


    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        Me.bsEntity.CancelEdit()
        If Not _Scadenza.IsNew Then
            _Scadenza.RollbackFields("Edit")
        End If
        retValue = False
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            Me.bsEntity.EndEdit()
            Me._Scadenza.ValidateEntity()
            DA.SaveEntity(_Scadenza, True, True)
            retValue = True

            Me.Close()
        Catch ex As Exception
            DA.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class