Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgLicenza
    Private _Licenza As LicenzaAziendaEntity
    Private _CanEdit As Boolean

    Public Sub Apri(Licenza As LicenzaAziendaEntity)
        _Licenza = Licenza
        _Licenza.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova(Az As AziendaEntity) As LicenzaAziendaEntity
        _Licenza = Az.Licenze.AddNew
        Inizializza()
        Me.ShowDialog()
        Return _Licenza
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _Licenza.Azienda.Id, _Licenza.Azienda.RagioneSociale)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTipo, Lookups.TipiLicenza)
        bsData.DataSource = _Licenza
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
            _Licenza.TipoLicenza = cbTipo.SelectedItem
            _Licenza.ValidateEntity()
            DA.SaveEntity(_Licenza, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Licenza.IsNew Then
            _Licenza.Azienda.Licenze.Remove(_Licenza)
        Else
            bsData.CancelEdit()
            _Licenza.RollbackFields("Edit")
            _Licenza = Nothing
        End If
        Me.Close()
    End Sub

End Class