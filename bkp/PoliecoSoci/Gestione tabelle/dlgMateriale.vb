Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgMateriale
    Private _Materiale As MaterialeEntity
    Private retValue As Boolean

    Public Function Apri(ByVal Mat As MaterialeEntity) As Boolean
        Me._Materiale = Mat
        Mat.AuditorToUse = New EntityAuditor
        Inizializza()
        Me.ShowDialog()
        Mat.AuditorToUse = Nothing
        Return retValue
    End Function

    Private Sub Inizializza()

        DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)

        _Materiale.SaveFields("Edit")

        cbTipo.DataSource = Lookups.TipiMateriale
        cbTipo.DisplayMember = "Descrizione"
        cbTipo.ValueMember = "Codice"
        cbTipo.DataBindings.Add("SelectedValue", bsEntity, "CodTipo")

        cbUM.DataSource = Lookups.UnitaMisura
        cbUM.DisplayMember = "Descrizione"
        cbUM.ValueMember = "Codice"
        cbUM.DataBindings.Add("SelectedValue", bsEntity, "CodUnitaMisura")



        Me.bsEntity.DataSource = _Materiale

    End Sub


    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        Me.bsEntity.CancelEdit()
        If Not _Materiale.IsNew Then
            _Materiale.RollbackFields("Edit")
        End If
        retValue = False
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            Me.bsEntity.EndEdit()
            Me._Materiale.ValidateEntity()
            DA.SaveEntity(_Materiale, True, True)
            retValue = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class