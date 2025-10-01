Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgSede
    Private _Sede As SedeEntity
    Private _CanEdit As Boolean

    Public Sub Apri(Sede As SedeEntity)
        _Sede = Sede
        _Sede.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova(Az As AziendaEntity) As SedeEntity
        _Sede = Az.Sedi.AddNew
        _Sede.CodTipoSede = Enums.CodTipoSede.SECONDARIA
        Inizializza()
        Me.ShowDialog()
        Return _Sede
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _Sede.Azienda.Id, _Sede.Azienda.RagioneSociale)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTipo, Lookups.TipiSede)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbProv, Lookups.Province, False, "Codice", "Codice")



        bsData.DataSource = _Sede
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
            _Sede.ValidateEntity()
            Dim asp As SedeEntity = _Sede.Azienda.GetAltraSedePrimaria(_Sede)

            If asp IsNot Nothing Then
                If MsgBox("Attenzione!!! Esiste già un'altra sede principale per l'azienda. Impostando quella corrente come principale l'altra sarà impostata come secondaria." & vbCr _
                          & "Proseguire ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
                asp.CodTipoSede = Enums.CodTipoSede.SECONDARIA
                DA.SaveEntity(asp, True)
            End If
            DA.SaveEntity(_Sede, True)

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Sede.IsNew Then
            _Sede.Azienda.Sedi.Remove(_Sede)
        Else
            bsData.CancelEdit()
            _Sede.RollbackFields("Edit")
            _Sede = Nothing
        End If
        Me.Close()
    End Sub

End Class