Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FElencoProdotti
    Private _PP As PrefetchPath2
    Private _Prodotti As New EntityCollection(Of ProdottoEntity)
    Private _SelProdotti() As ProdottoEntity

    Public Sub Apri()
        tsbSelect.Available = False
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function GetProdotti() As IEnumerable(Of ProdottoEntity)
        tsbSelect.Available = True
        Inizializza()
        Me.ShowDialog()
        Return _SelProdotti
    End Function

    Private Sub Inizializza()

        dgvProd.AutoGenerateColumns = False
        dgvProd.DataSource = bsProd
        CaricaDati()
    End Sub

    Private Sub CaricaDati()

        Dim rpb As New RelationPredicateBucket
        rpb.PredicateExpression.Add(ProdottoFields.Livello = 1)

        Dim txt As String = txtRic.Text.Trim
        If txt <> "" Then
            Dim prDescr As New PredicateExpression

            prDescr.Add(ProdottoFields.Descrizione Mod ("%" & txt & "%"))
            Dim fdescrCat = ProdottoFields.Descrizione
            fdescrCat.ObjectAlias = "tCat"
            prDescr.AddWithOr(fdescrCat Mod ("%" & txt & "%"))
            rpb.PredicateExpression.AddWithAnd(prDescr)

            Dim rel As EntityRelation = ProdottoEntity.Relations.ProdottoEntityUsingIdIdRiferimento
            rel.SetAliases("", "tCat")
            rpb.Relations.Add(rel)
        End If

        _Prodotti.Clear()
        Dim pp As New PrefetchPath2(CInt(EntityType.ProdottoEntity))
        pp.Add(ProdottoEntity.PrefetchPathProdottoPadre)

        DA.FetchEntityCollection(_Prodotti, rpb, pp)
        Me.bsProd.DataSource = _Prodotti

        'dgvProd.Invalidate()

        'dgvProd.Sort(dgvcCat, System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        _SelProdotti = Nothing
        Me.Close()
    End Sub

    'Private Sub tsbNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuovo.Click
    '    Dim M As New MaterialeEntity
    '    M.Utilizzato = True
    '    M.Prezzo = 0
    '    Dim F As New dlgMateriale
    '    If F.Apri(M) Then
    '        Me._Materiali.RelatedCollection.Add(M)
    '        CaricaDati()
    '        bsProd.Position = bsProd.IndexOf(M)
    '    End If
    'End Sub

    'Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
    '    ApriMateriale()
    'End Sub

    'Private Sub ApriMateriale()
    '    If Me.bsProd.Current Is Nothing Then Return
    '    Dim F As New dlgMateriale
    '    F.Apri(Me.bsProd.Current)
    '    CaricaDati()
    '    dgvElenco.Invalidate()
    'End Sub


    'Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
    '    Dim Mat As MaterialeEntity = bsProd.Current
    '    If Mat Is Nothing Then Return
    '    If MsgBox("Eliminare il materiale selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
    '    Try
    '        DAL.Managers.AuditManager.AddAudit("Materiale", Managers.AuditManager.OperazioneEnum.DEL, Mat.Codice)
    '        DA.DeleteEntity(Mat)
    '        Me.bsProd.RemoveCurrent()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

    Private Sub tsbSelect_Click(sender As Object, e As EventArgs) Handles tsbSelect.Click
        Dim ss() As ProdottoEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of ProdottoEntity)(dgvProd, False)
        If ss Is Nothing OrElse ss.Length = 0 Then Return
        _SelProdotti = ss
        Me.Close()
    End Sub

    
    Private Sub btnAzAss_Click(sender As Object, e As EventArgs) Handles btnRic.Click
        CaricaDati()
    End Sub

    Private Sub txtRic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRic.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

End Class