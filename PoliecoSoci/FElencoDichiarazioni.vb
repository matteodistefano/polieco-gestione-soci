Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL.TypedViewClasses
Imports DAL
Imports DAL.Managers
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient


Public Class FElencoDichiarazioni
    Private _ElencoDichiarazioni As VwRicercaDichiarazioniTypedView
    Private _IsReady As Boolean

    Private _SortColumnDic As DataGridViewColumn
    Private _SortOrderDic As System.Windows.Forms.SortOrder = Windows.Forms.SortOrder.Descending

    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub


    Private Sub Inizializza()
        InitUISecurity()

        'Grid
        dgvDic.AutoGenerateColumns = False
        dgvDic.DataSource = bsDic
        For Each Col As DataGridViewColumn In dgvDic.Columns
            Col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        pagerMov.PageSize = Config.clsCommonConfig.Instance.ElementiPerPagina

        For aa As Integer = Today.Year To Today.Year - 10 Step -1
            cbAnno.Items.Add(aa)
        Next


        mcCategoria.Initialize(New CheckBox() {chkCatA, chkCatB, chkCatC, chkCatD, chkCatE})
        mcStAz.Initialize(New CheckBox() {chkStAz0, chkStAz1, chkStAz2})
        mcStDic.Initialize(New CheckBox() {chkStDic0, chkStDic1, chkStDic2})
        mcStPag.Initialize(New CheckBox() {chkStPag0, chkStPag1, chkStPag2})

        mcCategoria.CheckAll()
        mcStAz.CheckAll()
        chkStAz2.Checked = False
        mcStDic.CheckAll()
        mcStPag.CheckAll()



        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcDicAnno, lAnno, False, Ttip)
        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcDicDataRic, lDataRicezione, True, Ttip)
        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcDicScadDic, lScadDic, False, Ttip)
        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcDicScadPag, lScadPag, True, Ttip)
        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcDicDataPag, lDataPag, True, Ttip)
        mdsUtility.WindowsForms.LinkDataGridviewColumnVisibility(dgvcRagioneSociale, lRagioneSociale, True, Ttip)


        ResetFilters()

        CaricaDati()

    End Sub




    Private Sub InitUISecurity()
        Dim Test As Boolean = Managers.UtentiManager.IsLoggedUserSegreteria

    End Sub


    Private Function GetFilter() As PredicateExpression
        Dim pr As New PredicateExpression
        Dim prFltDic As New PredicateExpression 'Filtri Azienda

        Dim txt As String = ""


        txt = cbAnno.Text
        If txt <> "" Then
            prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.Anno = txt)
        End If

        If cdiDataRic.DataIniziale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataRicezione >= cdiDataRic.DataIniziale)
        If cdiDataRic.DataFinale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataRicezione <= cdiDataRic.DataFinale)

        If cdiDataScadDic.DataIniziale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataScadenzaDichiarazione >= cdiDataScadDic.DataIniziale)
        If cdiDataScadDic.DataFinale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataScadenzaDichiarazione <= cdiDataScadDic.DataFinale)

        If cdiDataScadPag.DataIniziale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataScadenzaPagamento >= cdiDataScadPag.DataIniziale)
        If cdiDataScadPag.DataFinale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataScadenzaPagamento <= cdiDataScadPag.DataFinale)

        If cdiDataPag.DataIniziale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataPagamento >= cdiDataPag.DataIniziale)
        If cdiDataPag.DataFinale.HasValue Then prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.DataPagamento <= cdiDataPag.DataFinale)

        txt = txtCodice.Text.Trim
        If txt <> "" Then
            prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.IdAzienda = CInt(txt))
        End If

        txt = txtRagSoc.Text.Trim
        If txt <> "" Then
            txt = mdsUtility.TextUtils.GetSearchableRagioneSociale(txt)
            'prFltDic.AddWithAnd(VwRicercaDichiarazioniFields.RagioneSociale Mod ("%" & txt & "%"))

            Dim Fld As New EntityField2("rs", New DbFunctionCall("dbo.GetSearchableRagioneSociale", New Object() {VwRicercaDichiarazioniFields.RagioneSociale}))
            prFltDic.Add(Fld Mod ("%" & txt & "%"))


        End If




        If mcCategoria.HasUnCheck Then
            Dim prCat As New PredicateExpression
            If chkCatA.Checked Then prCat.AddWithOr(VwRicercaDichiarazioniFields.CategoriaAzienda = "A")
            If chkCatB.Checked Then prCat.AddWithOr(VwRicercaDichiarazioniFields.CategoriaAzienda = "B")
            If chkCatC.Checked Then prCat.AddWithOr(VwRicercaDichiarazioniFields.CategoriaAzienda = "C")
            If chkCatD.Checked Then prCat.AddWithOr(VwRicercaDichiarazioniFields.CategoriaAzienda = "D")
            If chkCatE.Checked Then prCat.AddWithOr(VwRicercaDichiarazioniFields.CategoriaAzienda = "E")
            prFltDic.AddWithAnd(prCat)
        End If

        If mcStAz.HasUnCheck Then
            Dim prAz As New PredicateExpression
            If chkStAz0.Checked Then prAz.AddWithOr(VwRicercaDichiarazioniFields.StatoAzienda = Enums.StatoSocio.ATTIVO)
            If chkStAz1.Checked Then prAz.AddWithOr(VwRicercaDichiarazioniFields.StatoAzienda = Enums.StatoSocio.NUOVO)
            If chkStAz2.Checked Then prAz.AddWithOr(VwRicercaDichiarazioniFields.StatoAzienda = Enums.StatoSocio.USCITO)
            prFltDic.AddWithAnd(prAz)
        End If

        If mcStDic.HasUnCheck Then
            Dim prDic As New PredicateExpression
            If chkStDic0.Checked Then
                prDic.AddWithOr(VwRicercaDichiarazioniFields.CodStatoDichiarazione = Enums.StatoDocumento.OK)
                prDic.AddWithOr(VwRicercaDichiarazioniFields.CodStatoDichiarazione = Enums.StatoDocumento.FORCED)
            End If
            If chkStDic1.Checked Then prDic.AddWithOr(VwRicercaDichiarazioniFields.CodStatoDichiarazione = Enums.StatoDocumento.PARTIAL)
            If chkStDic2.Checked Then prDic.AddWithOr(VwRicercaDichiarazioniFields.CodStatoDichiarazione = Enums.StatoDocumento.NO)
            prFltDic.AddWithAnd(prDic)
        End If

        If mcStPag.HasUnCheck Then
            Dim prPag As New PredicateExpression
            If chkStPag0.Checked Then
                prPag.AddWithOr(VwRicercaDichiarazioniFields.CodStatoPagamento = Enums.StatoDocumento.OK)
                prPag.AddWithOr(VwRicercaDichiarazioniFields.CodStatoPagamento = Enums.StatoDocumento.FORCED)
            End If
            If chkStPag1.Checked Then prPag.AddWithOr(VwRicercaDichiarazioniFields.CodStatoPagamento = Enums.StatoDocumento.PARTIAL)
            If chkStPag2.Checked Then prPag.AddWithOr(VwRicercaDichiarazioniFields.CodStatoPagamento = Enums.StatoDocumento.NO)
            prFltDic.AddWithAnd(prPag)
        End If



        Return prFltDic


    End Function


    Private Sub CaricaDati()
        Try
            If Not _IsReady Then Return

            Cursor.Current = Cursors.WaitCursor

            Dim pr As PredicateExpression = GetFilter()

            'Recupero conteggi
            Dim NN As Integer
            Dim frs As ResultsetFields

            frs = New ResultsetFields(3)
            frs.DefineField(VwRicercaDichiarazioniFields.Id, 0, "NN", AggregateFunction.Count)
            frs.DefineField(VwRicercaDichiarazioniFields.ImportoRuolo, 1, "TotRuolo", AggregateFunction.Sum)
            frs.DefineField(VwRicercaDichiarazioniFields.ImportoPagato, 2, "TotPagato", AggregateFunction.Sum)

            Dim tbRes As New DataTable

            Dim rpb As New RelationPredicateBucket
            rpb.PredicateExpression.Add(pr)
            DA.FetchTypedList(frs, tbRes, rpb)
            NN = tbRes(0)("NN")
            pagerMov.ItemsCount = NN

            If NN = 0 Then
                txtTotRuolo.Text = "0,00"
                txtTotPagato.Text = "0,00"

            Else
                txtTotRuolo.Text = CDbl(mdsUtility.Dataset.IsNull(tbRes(0)("TotRuolo"), 0)).ToString("n2")
                txtTotPagato.Text = CDbl(mdsUtility.Dataset.IsNull(tbRes(0)("TotPagato"), 0)).ToString("n2")
            End If


            _ElencoDichiarazioni = New VwRicercaDichiarazioniTypedView
            Dim flds As IEntityFields2 = _ElencoDichiarazioni.GetFieldsInfo

            Dim se As SortExpression = GetSortExpression()

            Generale.DA.FetchTypedList(flds, CType(_ElencoDichiarazioni, DataTable), rpb, 0, se, False, Nothing, pagerMov.CurrentPage, pagerMov.PageSize)
            bsDic.DataSource = _ElencoDichiarazioni

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub


    Private Function GetSortExpression() As SortExpression
        Dim Sc As DataGridViewColumn = _SortColumnDic
        Dim fld As EntityField2
        Dim EmitAlias As Boolean = True

        If Sc Is Nothing Then
            fld = VwRicercaDichiarazioniFields.Id
            'ElseIf Sc Is dgvcMovHasFlusso Then
            '    fld = New EntityField2("HasFlusso", New DbFunctionCall("CASE WHEN {0} Is NULL THEN 0 ELSE 1 END", New Object() {MovimentoFields.IdFlusso}))
            '    EmitAlias = False
        Else
            Dim cmp As String = Sc.DataPropertyName
            fld = _ElencoDichiarazioni.GetFieldsInfo(cmp)
        End If

        If fld Is Nothing Then
            fld = VwRicercaDichiarazioniFields.Id
        End If

        Dim so As SortOperator
        If _SortOrderDic = Windows.Forms.SortOrder.Descending Then
            so = SortOperator.Descending
        Else
            so = SortOperator.Ascending
        End If
        Dim scls As New SortClause(fld, Nothing, so)
        scls.EmitAliasForExpressionAggregateField = EmitAlias
        Dim ret As New SortExpression(scls)
        Return ret

    End Function

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        ResetFilters()
        CaricaDati()
    End Sub


    Private Sub ResetFilters()
        _IsReady = False

        cbAnno.SelectedIndex = 1

        pagerMov.CurrentPage = 1

        cdiDataRic.ResetDate()
        cdiDataScadDic.ResetDate()
        cdiDataScadPag.ResetDate()
        cdiDataPag.ResetDate()

        txtCodice.Text = ""
        txtRagSoc.Text = ""

        mcCategoria.CheckAll()

        mcStAz.UncheckAll()
        chkStAz0.Checked = True
        chkStAz1.Checked = False

        mcStDic.CheckAll()
        mcStPag.CheckAll()

        _IsReady = True

    End Sub


    Private Sub ME_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub tsbChiudi_Click(sender As System.Object, e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    Private Sub btnCerca_Click(sender As System.Object, e As System.EventArgs) Handles btnCerca.Click
        pagerMov.CurrentPage = 1
        CaricaDati()
    End Sub

    Private Sub pagerMov_PageChanged(sender As System.Object, e As System.EventArgs) Handles pagerMov.PageChanged
        CaricaDati()
    End Sub

    Private Sub ApriDichiarazione()
        Try
            If bsDic.Current Is Nothing Then Return
            Dim Id As Integer = bsDic.Current("Id")
            Dim F As New FDichiarazione
            F.Apri(Id)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvSoci_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDic.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As VwRicercaDichiarazioniRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row

        If col Is dgvcStAz Then
            e.Value = ImagesHelper.GetStatoIcon(rw.StatoAzienda)
        ElseIf col Is dgvcDicRegDic Then
            e.Value = ImagesHelper.GetStatoDicPagIcon(rw.CodStatoDichiarazione)
        ElseIf col Is dgvcDicRegPag Then
            e.Value = ImagesHelper.GetStatoDicPagIcon(rw.CodStatoPagamento)
        ElseIf col Is dgvcDicDocs Then
            e.Value = IIf(rw.RifArxivar = "", mdsUtility.GraphicsHelper.EmptyImage, My.Resources.Arxivar16)
        End If
    End Sub


    Private Sub dgvSoci_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDic.ColumnHeaderMouseClick

        If e.ColumnIndex = -1 Then Return
        Dim ClickedColumn As DataGridViewColumn = dgvDic.Columns(e.ColumnIndex)

        If _SortColumnDic Is Nothing Then
            _SortOrderDic = Windows.Forms.SortOrder.Ascending
        ElseIf ClickedColumn Is _SortColumnDic Then
            If _SortOrderDic = Windows.Forms.SortOrder.Ascending Then
                _SortOrderDic = Windows.Forms.SortOrder.Descending
            Else
                _SortOrderDic = Windows.Forms.SortOrder.Ascending
            End If
        End If
        _SortColumnDic = ClickedColumn
        CaricaDati()
    End Sub

    Private Sub dgvDic_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDic.CellDoubleClick

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As Object = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        Dim ColName As String = col.Name

        tsbModifica.PerformClick()

    End Sub

    Private Sub tsbModifica_Click(sender As Object, e As EventArgs) Handles tsbModifica.Click
        ApriDichiarazione()
    End Sub


    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try

            'If bsDic.Count = 0 Then Return
            'Dim pr As PredicateExpression
            'Dim sel As DataRow() = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DataRow)(dgvDic, False)
            'If sel.Count > 1 Or (Control.ModifierKeys And Keys.Control) = 1 Then
            '    'Selezione
            '    pr = New PredicateExpression(New FieldCompareRangePredicate(VwRicercaDichiarazioniFields.Id, Nothing, sel.Select(Function(x) x("Id")).ToArray))
            'Else
            '    'Tutto
            '    pr = GetFilter()
            'End If

            'Dim dati As New VwRicercaAziendeTypedView
            'Dim flds As IEntityFields2 = dati.GetFieldsInfo

            ''Inclusione opzionale colonna mtivazioni eventi
            'ToogleExtraColumns(flds, dati, False)


            'Dim se As SortExpression = GetSortExpression()
            'Generale.DA.FetchTypedList(flds, CType(dati, DataTable), New RelationPredicateBucket(pr), 0, se, False)

            'Dim F As New dlgStampaEsportaSoci
            'F.Apri(dati, Nothing)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub mc_CheckedChanged(sender As Object, e As EventArgs) Handles mcStAz.CheckedChanged, mcCategoria.CheckedChanged, mcStDic.CheckedChanged, mcStPag.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub cbAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnno.SelectedIndexChanged
        CaricaDati()
    End Sub

    Private Function GetDichiarazione(Id As Integer) As DichiarazioneEntity
        Dim dic As New DichiarazioneEntity(Id)
        Dim pp As New PrefetchPath2(CInt(EntityType.DichiarazioneEntity))
        pp.Add(DichiarazioneEntity.PrefetchPathAllegato)
        pp.Add(DichiarazioneEntity.PrefetchPathAzienda)
        DA.FetchEntity(dic, pp)
        Return dic
    End Function


    Private Sub tsArxivar_Click(sender As Object, e As EventArgs) Handles tsArxivar.Click
        Try
            If bsDic.Current Is Nothing Then Return
            Dim rw As VwRicercaDichiarazioniRow = bsDic.Current.row

            Dim dic As DichiarazioneEntity = GetDichiarazione(rw.Id)
            If dic.HasDocument Then
                ArxivarWCFWrapper.OpenDocumentById(dic.RifArxivar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbAltreAziende_Click(sender As Object, e As EventArgs) Handles tsbAltreAziende.Click
        Try
            If bsDic.Current Is Nothing Then Return
            Dim rw As VwRicercaDichiarazioniRow = bsDic.Current.row

            If rw Is Nothing Then Return

            Dim dic As DichiarazioneEntity = GetDichiarazione(rw.Id)

            Dim F As New dlgAllegato
            If rw.HasAllegato Then
                F.Apri(dic.Allegato)
            Else
                If Not DichiarazioneEntity.CanHaveAllegato(dic.CodCategoria) Then Throw New Exception("Per la dichiarazione non sono previsti allegati")
                If Not dic.DataRicezione.HasValue Then dic.DataRicezione = Date.Today
                F.Nuovo(dic)
            End If

            dgvDic.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsAcquisisci_Click(sender As Object, e As EventArgs) Handles tsAcquisisci.Click
        Try
            Dim F As New DichiarazioneOnLine.dlgAcquisisciAllegato
            F.OpenAziendaAction = Sub(x As AziendaEntity)
                                      Dim Faz As New FAzienda
                                      Faz.Apri(x)
                                  End Sub
            F.Apri()
            dgvDic.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbAzienda_Click(sender As Object, e As EventArgs) Handles tsbAzienda.Click
        Try
            If bsDic.Current Is Nothing Then Return
            Dim rw As VwRicercaDichiarazioniRow = bsDic.Current.row
            If rw Is Nothing Then Return
            Dim F As New FAzienda
            F.Apri(rw.IdAzienda)
            dgvDic.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub lScadPag_Click(sender As Object, e As EventArgs) Handles lScadPag.Click

    End Sub
End Class