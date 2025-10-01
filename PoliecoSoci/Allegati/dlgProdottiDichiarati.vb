Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgProdottiDichiarati

    Private _Dic As DichiarazioneEntity
    Private _ElencoProdotti As EntityCollection(Of ProdottoDichiaratoEntity)
    Private _CanEdit As Boolean

    Public Sub Apri(IdDichiarazione As Integer)
        _Dic = New DichiarazioneEntity(IdDichiarazione)
        Apri(_Dic)
    End Sub

    Public Sub Apri(Dic As DichiarazioneEntity)
        _Dic = Dic
        If _Dic Is Nothing Then Throw New Exception("Dichiarazione non definita")

        _Dic.ElencoProdottiDichiarati.Clear()

        Dim pp As New PrefetchPath2(CInt(EntityType.DichiarazioneEntity))
        pp.Add(DichiarazioneEntity.PrefetchPathAzienda)
        pp.Add(DichiarazioneEntity.PrefetchPathElencoProdottiDichiarati)
        DA.FetchEntity(_Dic, pp)
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        InitUiSecurity()

        _ElencoProdotti = _Dic.ElencoProdottiDichiarati

        lAzienda.Text = String.Format("{0} - {1} - {2}", _Dic.IdAzienda, _Dic.Azienda.RagioneSociale, _Dic.Azienda.Localita)

        bsDichiarazione.DataSource = _Dic
        bsProdotti.DataSource = _Dic.ElencoProdottiDichiarati
        dgvProdotti.AutoGenerateColumns = False
        dgvProdotti.DataSource = bsProdotti

        dgslQV.Initialize(dgvcQtaVer, mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM, True)
        dgslQR.Initialize(dgvcQtaRic, mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM, True)


    End Sub

    Private Sub InitUiSecurity()


        _CanEdit = UtentiManager.IsLoggedUserSegreteria
        _CanEdit = False '#todo : eliminare

        tsbOk.Available = _CanEdit
        If Not _CanEdit Then
            tsbExit.Text = "Chiudi"
        End If
    End Sub

    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            bsDichiarazione.EndEdit()
            DA.SaveEntityCollection(_ElencoProdotti)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

    Private Sub tsbProdAdd_Click(sender As Object, e As EventArgs) Handles tsbProdAdd.Click
        'Try
        '    Dim f As New dlgAllegatoDettaglio
        '    f.Nuovo(_Allegato)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        'End Try
    End Sub

    Private Sub tsbProdEdit_Click(sender As Object, e As EventArgs) Handles tsbProdEdit.Click
        'Try
        '    Dim d As DettaglioAllegatoEntity = bsProdotti.Current
        '    If d Is Nothing Then Return
        '    Dim f As New dlgAllegatoDettaglio
        '    f.Apri(d)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        'End Try
    End Sub

    Private Sub tsbProdDel_Click(sender As Object, e As EventArgs) Handles tsbProdDel.Click
        'Try
        '    Dim d As DettaglioAllegatoEntity = bsProdotti.Current
        '    If d Is Nothing Then Return
        '    DA.DeleteEntity(d)
        '    bsProdotti.RemoveCurrent()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        'End Try
    End Sub

    Private Sub dgvDettaglio_DoubleClick(sender As Object, e As EventArgs) Handles dgvProdotti.DoubleClick
        tsbProdEdit.PerformClick()
    End Sub

    Private Sub tsbAzienda_Click(sender As Object, e As EventArgs) Handles tsbAzienda.Click
        Try
            Dim F As New FAzienda
            F.Apri(_Dic.IdAzienda)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class