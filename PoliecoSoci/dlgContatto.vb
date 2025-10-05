Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgContatto
    Private _Contatto As ContattoEntity
    Private _CanEdit As Boolean

    Public Sub Apri(Contatto As ContattoEntity)
        _Contatto = Contatto
        _Contatto.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova(Az As AziendaEntity) As ContattoEntity
        _Contatto = Az.Contatti.AddNew
        Inizializza()
        Me.ShowDialog()
        Return _Contatto
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _Contatto.Azienda.Id, _Contatto.Azienda.RagioneSociale)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbRuolo, Lookups.RuoliContatto)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTitolo, Lookups.TitoliContatto)

        bsData.DataSource = _Contatto
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
            _Contatto.RuoloContatto = cbRuolo.SelectedItem
            _Contatto.ValidateEntity()
            DA.SaveEntity(_Contatto, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Contatto.IsNew Then
            _Contatto.Azienda.Contatti.Remove(_Contatto)
        Else
            bsData.CancelEdit()
            _Contatto.RollbackFields("Edit")
            _Contatto = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub dlgContatto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class