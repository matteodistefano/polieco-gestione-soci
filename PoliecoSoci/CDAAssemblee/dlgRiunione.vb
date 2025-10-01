Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgRiunione
    Private _Riunione As RiunioneEntity
    Private retValue As Boolean

    Public Function Apri(ByVal R As RiunioneEntity) As Boolean
        Me._Riunione = R
        R.AuditorToUse = New EntityAuditor
        Inizializza()
        Me.ShowDialog()
        R.AuditorToUse = Nothing
        Return retValue
    End Function

    Private Sub Inizializza()

        _Riunione.SaveFields("Edit")

        cbTipo.DataSource = Lookups.TipiRiunione
        cbTipo.DisplayMember = "Descrizione"
        cbTipo.ValueMember = "Codice"
        cbTipo.DataBindings.Add("SelectedValue", bsEntity, "Tipo")

        Me.bsEntity.DataSource = _Riunione

    End Sub


    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        Me.bsEntity.CancelEdit()
        If Not _Riunione.IsNew Then
            _Riunione.RollbackFields("Edit")
        End If
        retValue = False
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            Me.bsEntity.EndEdit()
            Me._Riunione.ValidateEntity()
            DA.SaveEntity(_Riunione, True, True)
            retValue = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class