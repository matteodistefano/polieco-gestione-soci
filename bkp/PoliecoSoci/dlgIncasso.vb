Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgIncasso
    Private _Dichiarazione As DichiarazioneEntity
    Private _Incasso As IncassoEntity
    Private _CanEdit As Boolean

    Public Sub Apri(Incasso As IncassoEntity)
        _Incasso = Incasso
        _Incasso.SaveFields("Edit")
        _Dichiarazione = _Incasso.Dichiarazione
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuovo(Dic As DichiarazioneEntity) As IncassoEntity
        'If Not Dic.DataRicezione.HasValue Then Throw New Exception("Data ricezione non definita")
        _Dichiarazione = Dic
        _Incasso = _Dichiarazione.Incassi.AddNew
        _Incasso.DataInserimento = Date.Today
        _Incasso.DataPagamento = Date.Today
        _Incasso.DataValuta = Date.Today
        _Incasso.CodTipo = Enums.TipiIncasso.VERSAMENTO
        _Incasso.CodModalitaPagamento = 2
        _Incasso.Importo = _Dichiarazione.Saldo

        Inizializza()
        Me.ShowDialog()
        Return _Incasso
    End Function

    Private Sub Inizializza()
        InitUiSecurity()

        cbTipo.DataSource = Lookups.TipiIncasso.DefaultView
        cbTipo.ValueMember = "Codice"
        cbTipo.DisplayMember = "Descrizione"

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbModPag, Lookups.ModalitaPagamento.CreateView)
        bsData.DataSource = _Incasso

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
            _Incasso.ValidateEntity()
            DA.SaveEntity(_Incasso, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Incasso.IsNew Then
            _Incasso.Dichiarazione.Incassi.Remove(_Incasso)
        Else
            bsData.CancelEdit()
            _Incasso.RollbackFields("Edit")
            _Incasso = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub cbTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        If cbTipo.SelectedValue = Enums.TipiIncasso.VERSAMENTO Then
            pnlRata.Visible = False
            chkAcconto.Visible = True
        Else
            pnlRata.Visible = True
            chkAcconto.Visible = False
        End If
    End Sub
End Class