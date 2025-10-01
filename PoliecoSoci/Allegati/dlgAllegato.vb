Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgAllegato

    Private _Allegato As AllegatoEntity
    Private _CanEdit As Boolean

    Public Sub Apri(Allegato As AllegatoEntity)
        _Allegato = Allegato
        Dim pp As New PrefetchPath2(CInt(EntityType.AllegatoEntity))
        Dim ppd As IPrefetchPathElement2 = pp.Add(AllegatoEntity.PrefetchPathDettaglio)
        ppd.SubPath.Add(DettaglioAllegatoEntity.PrefetchPathAziendaAllegato)
        ppd.SubPath.Add(DettaglioAllegatoEntity.PrefetchPathMaterialeCer)

        DA.FetchEntity(_Allegato, pp)

        _Allegato.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuovo(Dic As DichiarazioneEntity) As AllegatoEntity
        If Not Dic.DataRicezione.HasValue Then Throw New Exception("Data ricezione non definita")
        If Dic.Allegato IsNot Nothing Then Throw New Exception("Allegato già esistente")
        _Allegato = New AllegatoEntity
        _Allegato.Dichiarazione = Dic
        _Allegato.Azienda = Dic.Azienda
        _Allegato.Anno = Dic.Anno
        _Allegato.Periodo = Dic.Periodo
        _Allegato.CategoriaAzienda = Dic.CodCategoria

        Inizializza()
        Me.ShowDialog()
        Return _Allegato
    End Function

    Private Sub Inizializza()
        InitUiSecurity()

        lAzienda.Text = String.Format("{0} - {1} - {2}", _Allegato.Dichiarazione.IdAzienda, _Allegato.Dichiarazione.Azienda.RagioneSociale, _Allegato.Dichiarazione.Azienda.Localita)


        bsAllegato.DataSource = _Allegato
        bsDettaglio.DataSource = _Allegato.Dettaglio
        dgvDettaglio.AutoGenerateColumns = False
        dgvDettaglio.DataSource = bsDettaglio

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
            bsAllegato.EndEdit()
            _Allegato.ValidateEntity()
            DA.SaveEntity(_Allegato, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Allegato.IsNew Then
            _Allegato.Dichiarazione.Allegato = Nothing
        Else
            bsAllegato.CancelEdit()
            _Allegato.RollbackFields("Edit")
            _Allegato = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub tsbSediAdd_Click(sender As Object, e As EventArgs) Handles tsbSediAdd.Click
        Try
            Dim f As New dlgAllegatoDettaglio
            f.Nuovo(_Allegato)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbSediEdit_Click(sender As Object, e As EventArgs) Handles tsbSediEdit.Click
        Try
            Dim d As DettaglioAllegatoEntity = bsDettaglio.Current
            If d Is Nothing Then Return
            Dim f As New dlgAllegatoDettaglio
            f.Apri(d)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbSediDel_Click(sender As Object, e As EventArgs) Handles tsbSediDel.Click
        Try
            Dim d As DettaglioAllegatoEntity = bsDettaglio.Current
            If d Is Nothing Then Return
            DA.DeleteEntity(d)
            bsDettaglio.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        Try
            If MsgBox("Eliminare l'allegato e i dati collegati?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            _Allegato.Dichiarazione.DeleteAllegato()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub dgvDettaglio_DoubleClick(sender As Object, e As EventArgs) Handles dgvDettaglio.DoubleClick
        tsbSediEdit.PerformClick()
    End Sub

    Private Sub tsbAzienda_Click(sender As Object, e As EventArgs) Handles tsbAzienda.Click
        Try
            Dim d As DettaglioAllegatoEntity = bsDettaglio.Current
            If d Is Nothing Then Return
            Dim F As New dlgAziendaAllegato
            F.Apri(d.IdAziendaAllegato)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class