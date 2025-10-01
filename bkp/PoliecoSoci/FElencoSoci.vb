Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL.TypedViewClasses
Imports DAL
Imports DAL.Managers
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient


Public Class FElencoSoci
    Private _ElencoSoci As VwRicercaAziendeTypedView
    Private _IsReady As Boolean
    Private Shared _Instance As FElencoSoci

    Private _SortColumnSoci As DataGridViewColumn
    Private _SortOrderSoci As System.Windows.Forms.SortOrder = Windows.Forms.SortOrder.Descending

    Private _SelSoci() As VwRicercaAziendeRow

    Private WithEvents _ChkMgrStato, _ChkMgrStDic, _ChkMgrStPag As New mdsUIControls.MultiCheck

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shared Sub Apri(F As Form)
        GetInstance()
        _Instance.Visible = False
        _Instance.SelectionMode = False
        If F IsNot Nothing Then
            _Instance.Show(F)
        Else
            _Instance.Show()
        End If
    End Sub

    Public Shared Function GetInstance() As FElencoSoci
        If _Instance Is Nothing OrElse _Instance.IsDisposed Then
            _Instance = New FElencoSoci
            _Instance.Inizializza()
        End If
        Return _Instance
    End Function

    Public Shared Function GetSoci() As VwRicercaAziendeRow()
        GetInstance()
        _Instance.Visible = False
        _Instance.SelectionMode = True
        _Instance.ShowDialog()
        Return _Instance._SelSoci
    End Function

    Private _SelectionMode As Boolean
    Public Property SelectionMode As Boolean
        Get
            Return _SelectionMode
        End Get
        Set(value As Boolean)
            _SelectionMode = value
            tsbSeleziona.Available = value
            tsSepSel.Available = value
        End Set
    End Property



    Private Sub Inizializza()
        InitUISecurity()

        'Grid
        dgvSoci.AutoGenerateColumns = False
        dgvSoci.DataSource = bsSoci

        For Each Col As DataGridViewColumn In dgvSoci.Columns
            Col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        pagerMov.PageSize = Config.clsCommonConfig.Instance.ElementiPerPagina

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbRegione, Lookups.Regioni, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbProvincia, Lookups.Province, True)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTipo, Lookups.TipiSocio, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbStato, Lookups.StatiSocio, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbInfoStato, Lookups.InfoStati, True)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbAttivitaPrincipale, Lookups.Categorie.CreateView, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbAttivitaSecondaria, Lookups.Categorie.CreateView, True)

        _ChkMgrStato.Initialize(New CheckBox() {chkSt0, chkSt1, chkSt2})
        _ChkMgrStato.AllowAllUnchecked = False

        _ChkMgrStDic.Initialize(New CheckBox() {chkStDic0, chkStDic1})
        _ChkMgrStDic.AllowAllUnchecked = False

        _ChkMgrStPag.Initialize(New CheckBox() {chkStPag0, chkStPag1, chkStPag2})
        _ChkMgrStPag.AllowAllUnchecked = False


        lvwFltEventi.Columns.Add("Evento")
        lvwFltEventi.Columns(0).Width = 300
        lvwFltEventi.Columns.Add("Periodo")
        lvwFltEventi.Columns(1).Width = 300
        lvwFltEventi.Columns.Add("Opzioni")



        ucSelEvento.Enabled = False


        For Each attr In Lookups.TipiAttrezzatura
            chkLstAtt.Items.Add(attr, False)
        Next


        cdiDataCDA.AddMenuVoice("Seleziona CDA", AddressOf SelezioneCDA)
        cdiDataAssemblea.AddMenuVoice("Seleziona Assemblea", AddressOf SelezioneAssemblea)



        UpdateColumnVisibility()

        ResetFilters(True)

        CaricaDati()

    End Sub




    Private Sub InitUISecurity()
        Dim Test As Boolean = Managers.UtentiManager.IsLoggedUserSegreteria
        tsbNuovo.Enabled = Test
        tsbElimina.Enabled = Test
    End Sub

    Private Sub UpdateColumnVisibility()


        tcFiltri.Refresh()

        Dim tp As TabPage = tcFiltri.SelectedTab

        'dgvcMovCRO.Visible = (tp Is tpMovimento)
        'dgvcMovNumBonifico.Visible = (tp Is tpMovimento)

        'dgvcContoProv.Visible = (tp Is tpConto)
        'dgvcContoRegione.Visible = (tp Is tpConto)
        'dgvcContoIban.Visible = (tp Is tpConto)

        'dgvcFlussoDescr.Visible = (tp Is tpFlusso)
        'dgvcFlussoComp.Visible = (tp Is tpFlusso)
        'dgvcFlussoStato.Visible = (tp Is tpFlusso)

        'dgvcAziendaRagSoc.Visible = (tp Is tpAzienda)
        'dgvcAziendaRegione.Visible = (tp Is tpAzienda)
        'dgvcAziendaProv.Visible = (tp Is tpAzienda)
        'dgvcAziendaLocalita.Visible = (tp Is tpAzienda)
        'dgvcAziendaCat.Visible = (tp Is tpAzienda)
        'dgvcAziendaTipo.Visible = (tp Is tpAzienda)
        'dgvcAziendaIsAngem.Visible = (tp Is tpAzienda)


    End Sub

    Private Function GetFilter() As PredicateExpression
        Dim pr As New PredicateExpression
        Dim prFltAzienda As New PredicateExpression 'Filtri Azienda

        Dim txt As String = ""


        '----- FILTRI AZIENDA ----
        txt = txtRagSoc.Text.Trim
        If txt <> "" Then

            txt = mdsUtility.TextUtils.GetSearchableRagioneSociale(txt)

            Dim prRS As New PredicateExpression
            'prFltAzienda.AddWithAnd( VwRicercaAziendeFields.RagioneSociale.SetExpression(New DbFunctionCall("dbo.GetSearchableRagioneSociale", Nothing)) Mod ("%" & txt & "%"))
            Dim Fld As New EntityField2("rs", New DbFunctionCall("dbo.GetSearchableRagioneSociale", New Object() {VwRicercaAziendeFields.RagioneSociale}))
            prRS.Add(Fld Mod ("%" & txt & "%"))

            Fld = New EntityField2("rsp", New DbFunctionCall("dbo.GetSearchableRagioneSociale", New Object() {VwRicercaAziendeFields.RagSocPrecedenti}))
            prRS.AddWithOr(Fld Mod ("%" & txt & "%"))


            prFltAzienda.AddWithAnd(prRS)
        End If

        txt = txtCodice.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.Id = CInt(txt))
        End If

        txt = txtAssociazione.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.Associazione Mod ("%" & txt & "%"))
        End If

        txt = txtReferente.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.LegaleRappresentante Mod ("%" & txt & "%"))
        End If

        txt = IIf(cbRegione.Text <> "", cbRegione.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CodRegione = txt)
        End If

        txt = IIf(cbProvincia.Text <> "", cbProvincia.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.Provincia = txt)
        End If

        txt = txtLocalita.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.Localita Mod ("%" & txt & "%"))
        End If

        txt = txtIndirizzo.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.Indirizzo Mod ("%" & txt & "%"))
        End If

        txt = IIf(cbTipo.Text <> "", cbTipo.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CodTipoIscrizione = txt)
        End If



        If rbStato0.Checked Then
            If _ChkMgrStato.HasUnChecked Then
                Dim prStato As New PredicateExpression
                If chkSt0.Checked Then
                    prStato.AddWithOr(VwRicercaAziendeFields.CodStato = Enums.StatoSocio.ATTIVO)
                End If
                If chkSt1.Checked Then
                    prStato.AddWithOr(VwRicercaAziendeFields.CodStato = Enums.StatoSocio.NUOVO)
                End If
                If chkSt2.Checked Then
                    prStato.AddWithOr(VwRicercaAziendeFields.CodStato = Enums.StatoSocio.USCITO)
                End If


                prFltAzienda.AddWithAnd(prStato)
            End If

        ElseIf rbStato1.Checked Then
            txt = IIf(cbStato.Text <> "", cbStato.SelectedValue, "")
            If txt <> "" Then
                prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CodStato = txt)
            End If
        End If


        txt = IIf(cbInfoStato.Text <> "", cbInfoStato.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CodInfoStato = txt)
        End If

        If chkStDichiarazioni.Checked Then
            If _ChkMgrStDic.HasUnChecked Then
                If chkStDic0.Checked Then
                    prFltAzienda.AddWithAnd(VwRicercaAziendeFields.StatoDichiarazione = Enums.StatoDocumento.OK)
                ElseIf chkStDic1.Checked Then
                    prFltAzienda.AddWithAnd(VwRicercaAziendeFields.StatoDichiarazione = Enums.StatoDocumento.NO)
                End If
            End If
        End If

        If chkStPagamenti.Checked Then
            If _ChkMgrStPag.HasUnChecked Then

                Dim prStPag As New PredicateExpression
                If chkStPag0.Checked Then
                    prStPag.AddWithOr(VwRicercaAziendeFields.StatoPagamenti = Enums.StatoDocumento.OK)
                End If
                If chkStPag1.Checked Then
                    prStPag.AddWithOr(VwRicercaAziendeFields.StatoPagamenti = Enums.StatoDocumento.PARTIAL)
                End If
                If chkStPag2.Checked Then
                    prStPag.AddWithOr(VwRicercaAziendeFields.StatoPagamenti = Enums.StatoDocumento.NO)
                End If
                prFltAzienda.AddWithAnd(prStPag)
            End If
        End If


        '-- FILTRI DATI AMMINISTRATIVI --

        txt = txtPartitaIVA.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.PartitaIva Mod ("%" & txt & "%"))
        End If

        txt = txtCodiceFiscale.Text.Trim
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CodiceFiscale Mod ("%" & txt & "%"))
        End If

        txt = IIf(cbAttivitaPrincipale.Text <> "", cbAttivitaPrincipale.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CatAttivitaPrincipale = txt)
        End If

        txt = IIf(cbAttivitaSecondaria.Text <> "", cbAttivitaSecondaria.SelectedValue, "")
        If txt <> "" Then
            prFltAzienda.AddWithAnd(VwRicercaAziendeFields.CatAttivitaSecondaria = txt)
        End If

        'Datacda
        If cdiDataCDA.DataIniziale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataPassaggioCda >= cdiDataCDA.DataIniziale)
        If cdiDataCDA.DataFinale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataPassaggioCda <= cdiDataCDA.DataFinale)

        'DataAssemblea
        If cdiDataAssemblea.DataIniziale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataAssemblea >= cdiDataAssemblea.DataIniziale)
        If cdiDataAssemblea.DataFinale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataAssemblea <= cdiDataAssemblea.DataFinale)

        'DataAdesione
        If cdiDataAdesione.DataIniziale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataAdesione >= cdiDataAdesione.DataIniziale)
        If cdiDataAdesione.DataFinale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataAdesione <= cdiDataAdesione.DataFinale)

        'Inizio attivita
        If cdiDataInizioAtt.DataIniziale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataInizioAttivita >= cdiDataInizioAtt.DataIniziale)
        If cdiDataInizioAtt.DataFinale.HasValue Then prFltAzienda.AddWithAnd(VwRicercaAziendeFields.DataInizioAttivita <= cdiDataInizioAtt.DataFinale)

        '----- FILTRI EVENTI ----
        If lvwFltEventi.Items.Count > 0 Then
            Dim prEventi As New PredicateExpression
            For Each li As ListViewItem In lvwFltEventi.Items
                Dim se As dlgSelFiltroEvento.SelEvento = li.Tag
                Dim ev As EventoEntity = se.Evento

                Dim pp As New PredicateExpression(EventoAziendaFields.CodEvento = ev.Codice)
                pp.AddWithAnd(EventoAziendaFields.IsChiuso = False)
                If se.SoloAperti Then pp.AddWithAnd(New FieldCompareNullPredicate(EventoAziendaFields.Stato, Nothing) Or EventoAziendaFields.Stato <> Enums.StatoEvento.DONE)
                If se.DataIniziale.HasValue Then pp.AddWithAnd(EventoAziendaFields.Data >= se.DataIniziale)
                If se.DataFinale.HasValue Then pp.AddWithAnd(EventoAziendaFields.Data <= se.DataFinale)

                If se.DataNotificaIniziale.HasValue Or se.DataNotificaFinale.HasValue Then
                    If se.DataNotificaIniziale.HasValue Then pp.AddWithAnd(EventoAziendaFields.DataAvviso >= se.DataNotificaIniziale)
                    If se.DataNotificaFinale.HasValue Then pp.AddWithAnd(EventoAziendaFields.DataAvviso <= se.DataNotificaFinale)
                End If



                If se.SoloUrgenti Then pp.AddWithAnd(EventoAziendaFields.IsUrgente = True)

                If se.Utente.Trim <> "" Then pp.AddWithAnd(EventoAziendaFields.CodUtente = se.Utente.Trim)


                txt = se.MotivazioniNote.Trim
                If txt <> "" Then pp.AddWithAnd(EventoAziendaFields.Causale Mod ("%" & txt & "%") Or EventoAziendaFields.Note Mod ("%" & txt & "%"))

                Dim pe As New FieldCompareSetPredicate(VwRicercaAziendeFields.Id, Nothing, EventoAziendaFields.IdAzienda, Nothing, SetOperator.In, pp)
                prEventi.AddWithAnd(pe)
            Next

            prFltAzienda.AddWithAnd(prEventi)
        End If

        txt = txtTestoEvento.Text.Trim
        If txt <> "" Then
            Dim prNoteEventi As New PredicateExpression
            prNoteEventi.Add(EventoAziendaFields.Scadenza Mod ("%" & txt & "%"))
            prNoteEventi.AddWithOr(EventoAziendaFields.Note Mod ("%" & txt & "%"))
            prNoteEventi.AddWithOr(EventoAziendaFields.Causale Mod ("%" & txt & "%"))
            Dim pe As New FieldCompareSetPredicate(VwRicercaAziendeFields.Id, Nothing, EventoAziendaFields.IdAzienda, Nothing, SetOperator.In, prNoteEventi)
            prFltAzienda.AddWithAnd(pe)
        End If

        '----- FILTRI Attrezzature ----
        Dim prAtt As PredicateExpression = GetAttivitaPredicate()
        If prAtt IsNot Nothing Then
            prFltAzienda.AddWithAnd(New FieldCompareSetPredicate(VwRicercaAziendeFields.Id, Nothing, AttivitaFields.IdAzienda, Nothing, SetOperator.In, prAtt))

        End If


        '----- FILTRI Prodotti ----
        Dim prProd As PredicateExpression = GetProdottiPredicate()
        If prProd IsNot Nothing Then
            prFltAzienda.AddWithAnd(prProd)
        End If

        'If cdiMovData.HasCondition Then
        '    If cdiMovData.DataIniziale.HasValue Then
        '        prFltMovimento.AddWithAnd(MovimentoFields.DataMovimento >= cdiMovData.DataIniziale.Value)
        '    End If
        '    If cdiMovData.DataFinale.HasValue Then
        '        prFltMovimento.AddWithAnd(MovimentoFields.DataMovimento <= cdiMovData.DataFinale.Value)
        '    End If
        'End If

        'txt = txtMovDescrizione.Text.Trim
        'If txt <> "" Then
        '    prFltMovimento.AddWithAnd(MovimentoFields.Descrizione Mod ("%" & txt & "%"))
        'End If

        'txt = txtMovImporto.Text.Trim
        'If txt <> "" Then
        '    Dim ImpCond As Predicate = mdsLLBLGenUtility.Common.ParseNumericCondition(txt, MovimentoFields.Importo)
        '    If ImpCond IsNot Nothing Then
        '        prFltMovimento.AddWithAnd(ImpCond)
        '    Else
        '        MsgBox("Attenzione !!! Condizione su importo non riconosciuta.", MsgBoxStyle.Information)
        '    End If
        'End If



        'txt = txtMovCRO.Text.Trim
        'If txt <> "" Then
        '    prFltMovimento.AddWithAnd(MovimentoFields.Cro Mod ("%" & txt & "%"))
        'End If

        'txt = txtMovNumBon.Text.Trim
        'If txt <> "" Then
        '    prFltMovimento.AddWithAnd(MovimentoFields.NumBonifico Mod ("%" & txt & "%"))
        'End If

        'txt = txtMovNote.Text.Trim
        'If txt <> "" Then
        '    prFltMovimento.AddWithAnd(MovimentoFields.Note Mod ("%" & txt & "%"))
        'End If

        'If mcStatoMovimento.HasUnCheck Then
        '    Dim prStatoMov As New PredicateExpression
        '    For Each chk In mcStatoMovimento.GetAllChecked
        '        prStatoMov.AddWithOr(MovimentoFields.Stato = chk.Tag)
        '    Next
        '    prFltMovimento.AddWithAnd(prStatoMov)
        'End If


        '**********************************************************

        '-- Predicato finale 
        If prFltAzienda.Count > 0 Then pr.AddWithAnd(prFltAzienda)


        Return pr


    End Function


    Private Sub CaricaDati()
        Try
            If Not _IsReady Then Return

            Cursor.Current = Cursors.WaitCursor

            Dim pr As PredicateExpression = GetFilter()

            'Recupero conteggi
            Dim NN As Integer
            Dim frs As ResultsetFields

            frs = New ResultsetFields(1)
            frs.DefineField(VwRicercaAziendeFields.Id, 0, "NN", AggregateFunction.Count)

            Dim tbRes As New DataTable

            Dim rpb As New RelationPredicateBucket
            rpb.PredicateExpression.Add(pr)
            DA.FetchTypedList(frs, tbRes, rpb)
            NN = tbRes(0)("NN")

            pagerMov.ItemsCount = NN
            _ElencoSoci = New VwRicercaAziendeTypedView
            Dim flds As IEntityFields2 = _ElencoSoci.GetFieldsInfo

            'Inclusione opzionale colonna mtivazioni eventi
            If chkIncludiDatiEvento.Checked AndAlso ucSelEvento.SelectedEvent IsNot Nothing Then

                Dim CodEvento As String = ucSelEvento.SelectedEvent.Codice
                'rpb.SelectListAlias = "Az"
                flds.Expand(1)
                flds.DefineField(New EntityField2("DatiEvento", New DbFunctionCall("(Select top 1 Causale+' - '+Note from EventoAzienda " _
                                                         & "where IdAzienda=VwRicercaAziende.Id and CodEvento={0} order by Data desc)", New Object() {CodEvento})), flds.Count - 1)

                Dim col As New DataColumn("DatiEvento", GetType(String), Nothing, MappingType.Element)
                _ElencoSoci.Columns.Add(col)


                If Not dgvSoci.Columns.Contains("dgvcDatiEvento") Then
                    Dim dgvc As New DataGridViewTextBoxColumn()
                    dgvc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    dgvc.FillWeight = 100
                    dgvc.HeaderText = "Motivazioni / Note"
                    dgvc.DataPropertyName = "DatiEvento"
                    dgvc.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    dgvc.Name = "dgvcDatiEvento"
                    dgvSoci.Columns.Insert(dgvcStato.Index, dgvc)

                End If
                dgvSoci.Columns("dgvcDatiEvento").Visible = True

            Else
                If dgvSoci.Columns.Contains("dgvcDatiEvento") Then dgvSoci.Columns("dgvcDatiEvento").Visible = False
            End If



            Dim se As SortExpression = GetSortExpression()

            'Dim V As New DataTable
            Generale.DA.FetchTypedList(flds, CType(_ElencoSoci, DataTable), rpb, 0, se, False, Nothing, pagerMov.CurrentPage, pagerMov.PageSize)
            'Generale.DA.FetchTypedView(flds, CType(_ElencoSoci, DataTable), rpb, 0, se, False, Nothing, pagerMov.CurrentPage, pagerMov.PageSize)
            'Generale.DA.FetchTypedView(flds, V, rpb, 0, se, False, Nothing, pagerMov.CurrentPage, pagerMov.PageSize)
            bsSoci.DataSource = _ElencoSoci



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Function GetSortExpression() As SortExpression
        Dim Sc As DataGridViewColumn = _SortColumnSoci
        Dim fld As EntityField2
        Dim EmitAlias As Boolean = True

        If Sc Is Nothing Then
            fld = VwRicercaAziendeFields.Id
            'ElseIf Sc Is dgvcMovHasFlusso Then
            '    fld = New EntityField2("HasFlusso", New DbFunctionCall("CASE WHEN {0} IS NULL THEN 0 ELSE 1 END", New Object() {MovimentoFields.IdFlusso}))
            '    EmitAlias = False
        Else
            Dim cmp As String = Sc.DataPropertyName
            fld = _ElencoSoci.GetFieldsInfo(cmp)
        End If

        Dim so As SortOperator
        If _SortOrderSoci = Windows.Forms.SortOrder.Descending Then
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
        cmReset.Show(btnReset, New Point(0, 0), ToolStripDropDownDirection.Left)
    End Sub


    Private Sub ResetFilters(All As Boolean)
        _IsReady = False

        pagerMov.CurrentPage = 1

        'Filtri anagrafica
        If All Or tcFiltri.SelectedTab Is tpAnagrafici Then
            txtRagSoc.Text = ""
            txtCodice.Text = ""
            txtAssociazione.Text = ""
            txtReferente.Text = ""
            cbRegione.SelectedValue = ""
            cbProvincia.SelectedValue = ""
            txtLocalita.Text = ""
            txtIndirizzo.Text = ""
            cbTipo.SelectedValue = ""

            rbStato0.Checked = True
            _ChkMgrStato.CheckAll()
            chkSt2.Checked = False
            cbStato.SelectedValue = ""
            cbInfoStato.SelectedValue = ""

            chkStDichiarazioni.Checked = False
            chkStPagamenti.Checked = False

        End If

        'Filtri amministrativi
        If All Or tcFiltri.SelectedTab Is tpAmministrativi Then
            txtPartitaIVA.Text = ""
            txtCodiceFiscale.Text = ""
            cbAttivitaPrincipale.SelectedValue = ""
            cbAttivitaSecondaria.SelectedValue = ""

            cdiDataCDA.ResetDate()
            cdiDataAssemblea.ResetDate()
            cdiDataAdesione.ResetDate()
            cdiDataInizioAtt.ResetDate()

        End If

        If All Or tcFiltri.SelectedTab Is tpEventi Then
            lvwFltEventi.Items.Clear()
            txtTestoEvento.Text = ""
        End If

        If All Or tcFiltri.SelectedTab Is tpAtt Then
            cdiAttPeriodo.ResetDate()
            txtAttDescrizione.Text = ""
            txtAttAteco.Text = ""
            For i As Integer = 0 To chkLstAtt.Items.Count - 1
                chkLstAtt.SetItemChecked(i, False)
            Next
        End If

        'Prodotti
        If All Or tcFiltri.SelectedTab Is tpProd Then
            lvwProdotti.Items.Clear()
        End If

        _IsReady = True

    End Sub

    Private Sub tsmiResetCurrent_Click(sender As System.Object, e As System.EventArgs) Handles tsmiResetCurrent.Click
        ResetFilters(False)
        CaricaDati()
    End Sub

    Private Sub tsmiResetAll_Click(sender As System.Object, e As System.EventArgs) Handles tsmiResetAll.Click
        ResetFilters(True)
        CaricaDati()
    End Sub


    'Private Sub MultiCheck_CheckChange(sender As Object, e As System.EventArgs) Handles mcStatoMovimento.CheckedChanged, mcTipoConto.CheckedChanged, mcStatoFlusso.CheckedChanged
    '    CaricaDati()
    'End Sub

    Private Sub FElencoMovimenti_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.Owner IsNot Nothing Then
            Me.Owner.BringToFront()
        End If
    End Sub

    Private Sub ME_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub tsbChiudi_Click(sender As System.Object, e As System.EventArgs) Handles tsbChiudi.Click
        If SelectionMode Then
            _SelSoci = Nothing
        End If
        Me.Hide()
    End Sub

    Private Sub btnCerca_Click(sender As System.Object, e As System.EventArgs) Handles btnCerca.Click
        pagerMov.CurrentPage = 1
        CaricaDati()
    End Sub

    Private Sub pagerMov_PageChanged(sender As System.Object, e As System.EventArgs) Handles pagerMov.PageChanged
        CaricaDati()
    End Sub

    Private Sub ApriAzienda()
        Try
            If bsSoci.Current Is Nothing Then Return
            Dim IdSocio As Integer = bsSoci.Current("Id")
            Dim F As New FAzienda
            F.Apri(IdSocio)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvSoci_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvSoci.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As VwRicercaAziendeRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row

        If col Is dgvcStato Then
            e.Value = ImagesHelper.GetStatoIcon(rw.CodStato)
        ElseIf col Is dgvcStatoDic Then
            e.Value = ImagesHelper.GetStatoDicPagIcon(rw.StatoDichiarazione)
        ElseIf col Is dgvcStatoPag Then
            e.Value = ImagesHelper.GetStatoDicPagIcon(rw.StatoPagamenti)
        End If
    End Sub

    Private Sub dgvSoci_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvSoci.CellToolTipTextNeeded

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As VwRicercaAziendeRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row
        If col Is dgvcStato Then
            e.ToolTipText = Lookups.GetLookupDescription(Lookups.InfoStati, rw.CodInfoStato)
        End If
    End Sub

    Private Sub dgvSoci_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSoci.ColumnHeaderMouseClick

        If e.ColumnIndex = -1 Then Return
        Dim ClickedColumn As DataGridViewColumn = dgvSoci.Columns(e.ColumnIndex)

        If _SortColumnSoci Is Nothing Then
            _SortOrderSoci = Windows.Forms.SortOrder.Ascending
        ElseIf ClickedColumn Is _SortColumnSoci Then
            If _SortOrderSoci = Windows.Forms.SortOrder.Ascending Then
                _SortOrderSoci = Windows.Forms.SortOrder.Descending
            Else
                _SortOrderSoci = Windows.Forms.SortOrder.Ascending
            End If
        End If
        _SortColumnSoci = ClickedColumn
        CaricaDati()
    End Sub

    Private Sub dgvSoci_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSoci.CellDoubleClick

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As Object = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        Dim ColName As String = col.Name

        If SelectionMode Then
            tsbSeleziona.PerformClick()
        Else
            tsbModifica.PerformClick()
        End If
    End Sub

    Private Sub tcFiltri_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcFiltri.SelectedIndexChanged
        UpdateColumnVisibility()
    End Sub


    Private Sub tsbNuovo_Click(sender As Object, e As EventArgs) Handles tsbNuovo.Click
        Try
            Dim az As AziendaEntity
            Dim F As New FAzienda
            az = F.Nuova
            If az IsNot Nothing Then

                Dim pr As New PredicateExpression(VwRicercaAziendeFields.Id = az.Id)
                DA.FetchTypedView(_ElencoSoci, New RelationPredicateBucket(pr), True)
                bsSoci.Position = bsSoci.Find("Id", az.Id)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbModifica_Click(sender As Object, e As EventArgs) Handles tsbModifica.Click
        ApriAzienda()
    End Sub


    Private Sub rbStato_CheckedChanged(sender As Object, e As EventArgs) Handles rbStato0.CheckedChanged, rbStato1.CheckedChanged
        chkSt0.Enabled = rbStato0.Checked
        chkSt1.Enabled = rbStato0.Checked
        chkSt2.Enabled = rbStato0.Checked

        cbStato.Enabled = rbStato1.Checked
        CaricaDati()

    End Sub

    Private Sub _ChkMgrStato_CheckedChanged(sender As Object, e As EventArgs) Handles _ChkMgrStato.CheckedChanged, _ChkMgrStDic.CheckedChanged, _ChkMgrStPag.CheckedChanged _
                                                                             , chkStDichiarazioni.CheckedChanged, chkStPagamenti.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub tsbElimina_Click(sender As Object, e As EventArgs) Handles tsbElimina.Click
        Try
            If bsSoci.Current Is Nothing Then Return
            If MsgBox("Eliminare il socio selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntitiesDirectly("AziendaEntity", New RelationPredicateBucket(AziendaFields.Id = bsSoci.Current("Id")))
            bsSoci.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub chkStDoc_CheckedStateChanged(sender As Object, e As EventArgs)
        Dim chk As CheckBox = sender
        If chk.CheckState = CheckState.Checked Then
            chk.Image = My.Resources.Light_Green_Round_16_n_g
            Ttip.SetToolTip(chk, "In regola")
        ElseIf chk.CheckState = CheckState.Unchecked Then
            chk.Image = My.Resources.Light_Red_Round_16_n_g
            Ttip.SetToolTip(chk, "Non in regola")
        Else
            chk.Image = My.Resources.Light_White_Round_16_n_g
            Ttip.SetToolTip(chk, "Tutti")
        End If
        CaricaDati()
    End Sub

    Private Sub tsbFltAdd_Click(sender As Object, e As EventArgs) Handles tsbFltAdd.Click
        Try
            Dim F As New dlgSelFiltroEvento
            Dim se As dlgSelFiltroEvento.SelEvento = F.GetEvento
            If se Is Nothing Then Return

            Dim li As ListViewItem = lvwFltEventi.Items.Add(se.Evento.Nome)
            li.Tag = se
            li.SubItems.Add(se.DescrizionePeriodo)
            li.SubItems.Add(se.DescrizioneOpzioni)

            CaricaDati()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbFltDel_Click(sender As Object, e As EventArgs) Handles tsbFltDel.Click
        Try
            If lvwFltEventi.SelectedIndices.Count > 0 Then
                lvwFltEventi.Items.RemoveAt(lvwFltEventi.SelectedIndices(0))
                CaricaDati()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub lvwFltEventi_DoubleClick(sender As Object, e As EventArgs) Handles lvwFltEventi.DoubleClick
        Try
            If lvwFltEventi.SelectedItems.Count = 0 Then Return
            Dim li As ListViewItem = lvwFltEventi.SelectedItems(0)
            Dim F As New dlgSelFiltroEvento
            Dim se As dlgSelFiltroEvento.SelEvento = F.Apri(li)
            If se Is Nothing Then Return
            li.Text = se.Evento.Nome
            li.Tag = se
            li.SubItems(1).Text = se.DescrizionePeriodo
            li.SubItems(2).Text = se.DescrizioneOpzioni

            CaricaDati()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub




    Private Sub SelezioneCDA(sender As Object, e As mdsUIControls.ctlDateInterval.MenuVoiceClickEventArgs)
        SelezionaRiunione(Enums.TipoRiunione.CDA, e)
    End Sub

    Private Sub SelezioneAssemblea(sender As Object, e As mdsUIControls.ctlDateInterval.MenuVoiceClickEventArgs)
        SelezionaRiunione(Enums.TipoRiunione.ASSEMBLEA, e)
    End Sub

    Private Sub SelezionaRiunione(Tipo As String, e As mdsUIControls.ctlDateInterval.MenuVoiceClickEventArgs)
        Try

            Dim F As New mdsUIControls.FSelTabella
            F.HideFilterBox = True
            F.Width = 300

            Dim Sql As String = String.Format("Select Id,Data from Riunione Where Tipo='{0}' Order By Data Desc", Tipo)
            Dim tb As DataTable = DAL.DatabaseSpecific.Generale.SSHelp.GetDbTable(Sql)
            Dim rwData As DataRow = F.GetSelectedRow("Selezione " & Tipo, tb, "Data")
            If rwData Is Nothing Then
                e.Cancel = True
                Return
            End If

            Dim Dt As Date = CDate(rwData("Data"))
            e.DataIniziale = Dt
            e.DataFinale = Dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Function GetAttivitaPredicate() As PredicateExpression
        Dim pr As New PredicateExpression
        If cdiAttPeriodo.DataIniziale.HasValue Then pr.AddWithAnd(AttivitaFields.DataIniziale >= cdiAttPeriodo.DataIniziale)
        If cdiAttPeriodo.DataFinale.HasValue Then pr.AddWithAnd(AttivitaFields.DataFinale <= cdiAttPeriodo.DataFinale)
        Dim txt As String
        txt = txtAttDescrizione.Text.Trim
        If txt <> "" Then pr.AddWithAnd(AttivitaFields.Descrizione Mod ("%" & txt & "%"))

        txt = txtAttAteco.Text.Trim
        If txt <> "" Then pr.AddWithAnd(AttivitaFields.CodiceAteco Mod ("%" & txt & "%"))

        Dim aa As Windows.Forms.CheckedListBox.CheckedItemCollection = chkLstAtt.CheckedItems
        If aa.Count > 0 Then

            Dim prSel As New FieldCompareRangePredicate(AttrezzaturaAttivitaFields.CodAttrezzatura, Nothing, (From x In aa Select x.codice).ToArray)

            If rbAtt0.Checked And aa.Count > 1 Then


                Dim hpr As New FieldCompareValuePredicate(AttrezzaturaAttivitaFields.Id, Nothing, ComparisonOperator.Equal, aa.Count)
                hpr.FieldCore.AggregateFunctionToApply = AggregateFunction.Count

                Dim gb As New GroupByCollection
                gb.Add(AttrezzaturaAttivitaFields.IdAttivita)
                gb.HavingClause = New PredicateExpression
                gb.HavingClause.Add(hpr)
                pr.AddWithAnd(New FieldCompareSetPredicate(AttivitaFields.Id, Nothing, AttrezzaturaAttivitaFields.IdAttivita, Nothing, SetOperator.In, prSel, Nothing, Nothing, 0, Nothing, False, gb))


            Else

                pr.AddWithAnd(New FieldCompareSetPredicate(AttivitaFields.Id, Nothing, AttrezzaturaAttivitaFields.IdAttivita, Nothing, SetOperator.In, prSel))
            End If
        End If
        If pr.Count = 0 Then Return Nothing
        Return pr
    End Function

    Private Function GetProdottiPredicate() As PredicateExpression
        If lvwProdotti.Items.Count = 0 Then Return Nothing

        Dim pr As New PredicateExpression
        
        Dim pp As Windows.Forms.ListView.ListViewItemCollection = lvwProdotti.Items

        Dim prSel As New FieldCompareRangePredicate(AziendaProdottoFields.IdProdotto, Nothing, (From x In pp Select x.name).ToArray)

        If rbProdTutti.Checked And pp.Count > 1 Then

            Dim hpr As New FieldCompareValuePredicate(AziendaProdottoFields.Id, Nothing, ComparisonOperator.GreaterEqual, pp.Count)
            hpr.FieldCore.AggregateFunctionToApply = AggregateFunction.Count

            Dim gb As New GroupByCollection
            gb.Add(AziendaProdottoFields.IdAzienda)
            gb.HavingClause = New PredicateExpression
            gb.HavingClause.Add(hpr)
            pr.AddWithAnd(New FieldCompareSetPredicate(VwRicercaAziendeFields.Id, Nothing, AziendaProdottoFields.IdAzienda, Nothing, SetOperator.In, prSel, Nothing, Nothing, 0, Nothing, False, gb))
        Else
            pr.AddWithAnd(New FieldCompareSetPredicate(VwRicercaAziendeFields.Id, Nothing, AziendaProdottoFields.IdAzienda, Nothing, SetOperator.In, prSel))
        End If

        Return pr
    End Function


    Private Sub chkLstAtt_SizeChanged(sender As Object, e As EventArgs) Handles chkLstAtt.SizeChanged
        chkLstAtt.ColumnWidth = chkLstAtt.Width / 2 - 4
    End Sub

    Private Sub tsbSeleziona_Click(sender As Object, e As EventArgs) Handles tsbSeleziona.Click
        Try
            If dgvSoci.SelectedRows.Count = 0 Then Return
            _SelSoci = (From rwsel As DataGridViewRow In dgvSoci.SelectedRows Select CType(rwsel.DataBoundItem.row, VwRicercaAziendeRow)).ToArray
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try

            If bsSoci.Count = 0 Then Return
            Dim pr As PredicateExpression
            Dim sel As DataRow() = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DataRow)(dgvSoci, False)
            If sel.Count > 1 Or (Control.ModifierKeys And Keys.Control) = 1 Then
                'Selezione
                pr = New PredicateExpression(New FieldCompareRangePredicate(VwRicercaAziendeFields.Id, Nothing, sel.Select(Function(x) x("Id")).ToArray))
            Else
                'Tutto
                pr = GetFilter()
            End If

            Dim dati As New VwRicercaAziendeTypedView
            Dim flds As IEntityFields2 = dati.GetFieldsInfo

            'Inclusione opzionale colonna mtivazioni eventi
            If chkIncludiDatiEvento.Checked AndAlso ucSelEvento.SelectedEvent IsNot Nothing Then

                Dim CodEvento As String = ucSelEvento.SelectedEvent.Codice
                'rpb.SelectListAlias = "Az"
                flds.Expand(1)
                flds.DefineField(New EntityField2("DatiEvento", New DbFunctionCall("(Select top 1 isnull(Causale,'')+' - '+isnull(Note,'') from EventoAzienda " _
                                                         & "where IdAzienda=VwRicercaAziende.Id and CodEvento={0} order by Data desc)", New Object() {CodEvento})), flds.Count - 1)

                Dim col As New DataColumn("DatiEvento", GetType(String), Nothing, MappingType.Element)
                dati.Columns.Add(col)
            End If


            Dim se As SortExpression = GetSortExpression()
            Generale.DA.FetchTypedList(flds, CType(dati, DataTable), New RelationPredicateBucket(pr), 0, se, False)

            Dim F As New dlgStampaEsportaSoci
            F.Apri(dati, Nothing)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub chkIncludiDatiEvento_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludiDatiEvento.CheckedChanged
        ucSelEvento.Enabled = chkIncludiDatiEvento.Checked
    End Sub

    Private Sub chkStDichiarazioni_CheckedChanged(sender As Object, e As EventArgs) Handles chkStDichiarazioni.CheckedChanged
        Dim test As Boolean = chkStDichiarazioni.Checked
        chkStDic0.Enabled = test
        chkStDic1.Enabled = test
    End Sub

    Private Sub chkStPagamenti_CheckedChanged(sender As Object, e As EventArgs) Handles chkStPagamenti.CheckedChanged
        Dim test As Boolean = chkStPagamenti.Checked
        chkStPag0.Enabled = test
        chkStPag1.Enabled = test
        chkStPag2.Enabled = test
    End Sub

    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnProdAdd.Click
        Try
            Dim F As New FElencoProdotti
            Dim pp() As ProdottoEntity = F.GetProdotti
            If pp Is Nothing OrElse pp.Count = 0 Then Return

            For Each p In pp
                If Not lvwProdotti.Items.ContainsKey(p.Id) Then
                    Dim li As ListViewItem = lvwProdotti.Items.Add(p.Descrizione)
                    li.Name = p.Id
                End If
                If lvwProdotti.Items.Count >= 30 Then
                    Throw New Exception("Sono consentiti al massimo 30 prodotti nella selezione")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbAltreAziende_Click(sender As Object, e As EventArgs) Handles tsbAltreAziende.Click
        Try
            Dim F As New FElencoAziendeAllegato
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnProdDel_Click(sender As Object, e As EventArgs) Handles btnProdDel.Click
        Try
            Do While lvwProdotti.SelectedItems.Count > 0
                lvwProdotti.Items.Remove(lvwProdotti.SelectedItems(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub lvwFltEventi_Resize(sender As Object, e As EventArgs) Handles lvwFltEventi.Resize
        If lvwFltEventi.Columns.Count < 3 Then Return
        lvwFltEventi.Columns(2).Width = lvwFltEventi.Width - 600 - 20
    End Sub
End Class