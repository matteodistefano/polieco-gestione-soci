Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FAzienda
    Private _Azienda As AziendaEntity
    Private _Context As Context
    Private _CanEdit As Boolean

    Public Sub Apri(Id As Integer)
        _Azienda = New AziendaEntity(Id)
        FetchAzienda()
        If _Azienda.IsNew Then Throw New Exception("Azienda non trovata")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub FetchAzienda()
        _Context = New Context
        _Context.Add(_Azienda)

        Dim PP As New PrefetchPath2(CInt(EntityType.AziendaEntity))
        PP.Add(AziendaEntity.PrefetchPathSedi)
        PP.Add(AziendaEntity.PrefetchPathContatti).SubPath.Add(ContattoEntity.PrefetchPathRuoloContatto)
        PP.Add(AziendaEntity.PrefetchPathAttivita).SubPath.Add(AttivitaEntity.PrefetchPathAttrezzature)
        PP.Add(AziendaEntity.PrefetchPathLicenze).SubPath.Add(LicenzaAziendaEntity.PrefetchPathTipoLicenza)
        Dim ppDic As IPrefetchPathElement2 = PP.Add(AziendaEntity.PrefetchPathDichiarazioni, 0, Nothing, Nothing, New SortExpression(DichiarazioneFields.Anno Or SortOperator.Descending))
        ppDic.SubPath.Add(DichiarazioneEntity.PrefetchPathAllegato)
        ppDic.SubPath.Add(DichiarazioneEntity.PrefetchPathElencoProdottiDichiarati)

        PP.Add(AziendaEntity.PrefetchPathEventi, 0, Nothing, Nothing, New SortExpression(EventoAziendaFields.Data Or SortOperator.Descending))
        PP.Add(AziendaEntity.PrefetchPathAziendaProdotti).SubPath.Add(AziendaProdottoEntity.PrefetchPathProdotto, 0, New PredicateExpression(ProdottoFields.Livello = 1)).SubPath.Add(ProdottoEntity.PrefetchPathProdottoPadre)
        DA.FetchEntity(_Azienda, PP, _Context)

    End Sub

    Public Sub Apri(az As AziendaEntity)
        _Azienda = az
        FetchAzienda()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova() As AziendaEntity
        _Azienda = AziendaEntity.GetNew()
        Inizializza()
        Me.ShowDialog()
        Return _Azienda
    End Function


    Private Sub Inizializza()
        bsAzienda.DataSource = _Azienda

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTipo, Lookups.TipiSocio)
        cbTipo.DataBindings.Add("SelectedValue", bsAzienda, "CodTipoIscrizione")


        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbFormaGiuridica, Lookups.FormeGiuridiche)
        cbFormaGiuridica.DataBindings.Add("SelectedValue", bsAzienda, "CodFormaGiuridica")

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbSLProv, Lookups.Province, False, "Codice", "Codice")
        cbSLProv.DataBindings.Add("SelectedValue", bsAzienda, "Provincia")

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbQuotaAdesione, Lookups.QuoteAdesione, False, "Codice", "Descrizione")
        cbQuotaAdesione.DataBindings.Add("SelectedValue", bsAzienda, "QuotaAdesione", True)
        'Dim B As Binding = cbQuotaAdesione.DataBindings.Add("SelectedValue", bsAzienda, "QuotaAdesione", True)
        'AddHandler B.Format, AddressOf QuotaAdesioneBinding_Format
        'AddHandler B.Parse, AddressOf QuotaAdesioneBinding_Parse

        dgvSedi.AutoGenerateColumns = False
        bsSedi.DataSource = _Azienda.Sedi
        bsSedi.Sort = "CodTipoSede"

        dgvContatti.AutoGenerateColumns = False
        bsContatti.DataSource = _Azienda.Contatti

        dgvAttivita.AutoGenerateColumns = False
        bsAttivita.DataSource = _Azienda.Attivita

        dgvLicenze.AutoGenerateColumns = False
        bsLicenze.DataSource = _Azienda.Licenze

        dgvProdotti.AutoGenerateColumns = False
        bsProdotti.DataSource = _Azienda.AziendaProdotti

        dgvDichiarazioni.AutoGenerateColumns = False
        Dim se As New SortExpression(DichiarazioneFields.Anno Or SortOperator.Descending)
        se.Add(DichiarazioneFields.DataInizio Or SortOperator.Descending)
        _Azienda.Dichiarazioni.DefaultView.Sorter = se
        bsDichiarazioni.DataSource = _Azienda.Dichiarazioni

        dgvNotePNet.AutoGenerateColumns = False
        dgvNotePNet.DataSource = bsNotePNet



        Dim sl As mdsUIControls.DataGridSummaryLabel
        sl = New mdsUIControls.DataGridSummaryLabel(dgvcDicImporto, mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM, True)
        pnlDicFooter.Controls.Add(sl)
        sl.Visible = True
        sl.Top = 4

        sl = New mdsUIControls.DataGridSummaryLabel(dgvcDicPagato, mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM, True)
        pnlDicFooter.Controls.Add(sl)
        sl.Visible = True
        sl.Top = 4

        dgvEventi.AutoGenerateColumns = False
        bsEventi.DataSource = _Azienda.Eventi
        dgvEventi.Sort(dgvcEvData, System.ComponentModel.ListSortDirection.Descending)

        pnlHeader.IsReadOnly = Not _Azienda.IsNew

        'Dim tsmi As ToolStripMenuItem
        'For Each eu In Lookups.EventiUtente
        ' If eu.Codice <> Enums.TipoEvento.GENERIC_EVENT_M Then
        ' tsmi = tsbEvAdd.DropDownItems.Add(eu.Nome, Nothing, AddressOf AddEvento)
        ' tsmi.Tag = eu.Codice
        ' End If
        ' Next

        'tsbEvAdd.DropDownItems.Add(New ToolStripSeparator)
        'tsmi = tsbEvAdd.DropDownItems.Add("Generico", Nothing, AddressOf AddEvento)
        'tsmi.Tag = Enums.TipoEvento.GENERIC_EVENT_M
        'tsbEvAdd.DropDownItems.Add(tsmi)

        btnTest.Visible = _Azienda.IsNew AndAlso ((Control.ModifierKeys And Keys.Control) <> 0)

        UpdateLayout()

        InitUISecurity()

    End Sub


    Private Sub InitUISecurity()
        _CanEdit = DAL.Managers.UtentiManager.IsLoggedUserInRole(Enums.Ruolo.DIREZIONE, Enums.Ruolo.SEGRETERIA)

        tsmiArxProfila.Enabled = _CanEdit
        tsbStampa.Available = _CanEdit

        If Not _CanEdit Then
            tsbAttivaSocio.Available = False
            tsbOk.Available = False
            tsbChiudi.Text = "Chiudi"
            tsbChiudi.Image = My.Resources.SE_Arrow_32_n_g
            tsSedi.Visible = False
            tsContatti.Visible = False
            tsAttivita.Visible = False
            tsLicenze.Visible = False
            tsDichiarazioni.Visible = False
            tsEventi.Visible = False
        End If

        tsbProdAdd.Available = False
        tsbProdDel.Available = False
        tsbProdEdit.Available = False


    End Sub

    Private Sub UpdateLayout()
        _Azienda.UpdateStato()
        lStato.Text = Lookups.GetLookupDescription(Lookups.StatiSocio, _Azienda.CodStato)
        lInfoStato.Text = Lookups.GetLookupDescription(Lookups.InfoStati, _Azienda.CodInfoStato)
        lStatoSocio.Image = ImagesHelper.GetStatoIcon(_Azienda.CodStato)
        lStatoPagamenti.Image = ImagesHelper.GetStatoDicPagIcon(_Azienda.StatoPagamenti)
        lStatoDichiarazioni.Image = ImagesHelper.GetStatoDicPagIcon(_Azienda.StatoDichiarazione)
        tsbAttivaSocio.Available = _Azienda.CodStato = Enums.StatoSocio.NUOVO ' (_Azienda.CodStato = Enums.StatoSocio.NUOVO Or _Azienda.CodStato = Enums.StatoSocio.USCITO)


        Dim Cat As CategoriaEntity = _Azienda.GetCategoria(Enums.CodTipoAttivita.PRINCIPALE)
        If Cat Is Nothing Then
            lDescrCatPrincipale.Text = ""
        Else
            lDescrCatPrincipale.Text = Cat.Descrizione
        End If

        Cat = _Azienda.GetCategoria(Enums.CodTipoAttivita.SECONDARIA)
        If Cat Is Nothing Then
            lDescrCatSecondaria.Text = ""
        Else
            lDescrCatSecondaria.Text = Cat.Descrizione
        End If


    End Sub

    'Private Sub QuotaAdesioneBinding_Format(sender As Object, e As ConvertEventArgs)
    '    'e.Value = CStr(e.Value)
    'End Sub

    'Private Sub QuotaAdesioneBinding_Parse(sender As Object, e As ConvertEventArgs)
    '    'Throw New NotImplementedException
    'End Sub


    Private Sub SaveAzienda()

        bsAzienda.EndEdit()
        Managers.SociManager.SaveAzienda(_Azienda)
        pnlHeader.IsReadOnly = True

        Try
            If UserConfig.ArxivarSincronizzaRubrica Then
                UpdateRubricaArxivar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub UpdateRubricaArxivar()
        Try


            Dim r As New Abletech.Arxivar.Entities.Dm_Rubrica
            r.AOO = CommonConfig.ArxivarAreaOrganizzativa
            r.AOORUBRICA = r.AOO
            r.CAP = _Azienda.Cap
            r.CODFIS = _Azienda.CodiceFiscale
            r.FAX = _Azienda.Fax
            r.INDIRIZZO = _Azienda.Indirizzo
            r.LOCALITA = _Azienda.Localita
            r.MAIL = _Azienda.Email
            r.PARTIVA = _Azienda.PartitaIva
            r.PROVINCIA = _Azienda.Provincia
            r.RAGIONE_SOCIALE = _Azienda.RagioneSociale
            r.STATO = Abletech.Arxivar.Entities.Enums.Dm_Rubrica_Stato.Active
            r.TEL = _Azienda.Telefono1
            r.TIPO = Abletech.Arxivar.Entities.Enums.Dm_Rubrica_Tipo.Ditta
            ArxivarWCFWrapper.UpdateRubrica(CommonConfig.ArxivarIdRubricaSoci, CommonConfig.PrefissoCodiceRubrica & _Azienda.Id, r.AOO, r)

            Dim c As New Abletech.Arxivar.Entities.Dm_Contatti
            c.CONTATTO = "PEC"
            c.EMAIL = _Azienda.Pec
            ArxivarWCFWrapper.UpdateContatto(r, c)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        
    End Sub


    Private Sub tsbOk_Click(sender As Object, e As EventArgs) Handles tsbOk.Click
        Dim wasNew As Boolean = _Azienda.IsNew
        Try
            CheckRagSocChanges(False)


            SaveAzienda()
            Me.Close()
        Catch ex As ORMEntityValidationException When ex.Data("Info") = "NoCategoria"
            If wasNew Then
                tsbAttAdd.PerformClick()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbChiudi_Click(sender As Object, e As EventArgs) Handles tsbChiudi.Click
        bsAzienda.CancelEdit()
        _Azienda = Nothing
        Me.Close()
    End Sub



#Region "Gestione sedi"

    Private Sub tsbSediAdd_Click(sender As Object, e As EventArgs) Handles tsbSediAdd.Click
        Try
            Dim F As New dlgSede
            Dim sd As SedeEntity = F.Nuova(_Azienda)
            If sd IsNot Nothing Then
                bsSedi.Position = bsSedi.IndexOf(sd)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbSediDel_Click(sender As Object, e As EventArgs) Handles tsbSediDel.Click
        Try
            Dim sd As SedeEntity = bsSedi.Current
            If sd Is Nothing Then Return
            If MsgBox("Eliminare la sede selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(sd)
            bsSedi.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbSediEdit_Click(sender As Object, e As EventArgs) Handles tsbSediEdit.Click
        Try
            Dim sd As SedeEntity = bsSedi.Current
            If sd Is Nothing Then Return
            Dim F As New dlgSede
            F.Apri(sd)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvSedi_DoubleClick(sender As Object, e As EventArgs) Handles dgvSedi.DoubleClick
        tsbSediEdit.PerformClick()
    End Sub

#End Region

#Region "Gestione Contatti"

    Private Sub tsbContattiAdd_Click(sender As Object, e As EventArgs) Handles tsbContattiAdd.Click
        Try
            Dim F As New dlgContatto
            Dim cnt As ContattoEntity = F.Nuova(_Azienda)
            If cnt IsNot Nothing Then
                bsContatti.Position = bsContatti.IndexOf(cnt)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbContattiDel_Click(sender As Object, e As EventArgs) Handles tsbContattiDel.Click
        Try
            Dim cnt As ContattoEntity = bsContatti.Current
            If cnt Is Nothing Then Return
            If MsgBox("Eliminare il contatto selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(cnt)
            bsContatti.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbContattiEdit_Click(sender As Object, e As EventArgs) Handles tsbContattiEdit.Click
        Try
            Dim cnt As ContattoEntity = bsContatti.Current
            If cnt Is Nothing Then Return
            Dim F As New dlgContatto
            F.Apri(cnt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvContatti_DoubleClick(sender As Object, e As EventArgs) Handles dgvContatti.DoubleClick
        tsbContattiEdit.PerformClick()
    End Sub

#End Region

#Region "Gestione Attivita"

    Private Sub tsbAttAdd_Click(sender As Object, e As EventArgs) Handles tsbAttAdd.Click
        Try
            Dim F As New dlgAttivita
            Dim att As AttivitaEntity = F.Nuova(_Azienda)
            If att IsNot Nothing Then
                bsAttivita.Position = bsAttivita.IndexOf(att)
            End If
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbAttivitaDel_Click(sender As Object, e As EventArgs) Handles tsbAttDel.Click
        Try
            Dim att As AttivitaEntity = bsAttivita.Current
            If att Is Nothing Then Return
            If MsgBox("Eliminare l'attività selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(att)
            bsAttivita.RemoveCurrent()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbAttivitaEdit_Click(sender As Object, e As EventArgs) Handles tsbAttEdit.Click
        Try
            Dim att As AttivitaEntity = bsAttivita.Current
            If att Is Nothing Then Return
            Dim F As New dlgAttivita
            F.Apri(att)
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvAttivita_DoubleClick(sender As Object, e As EventArgs) Handles dgvAttivita.DoubleClick
        tsbAttEdit.PerformClick()
    End Sub

#End Region

#Region "Gestione Licenze"

    Private Sub tsbLicenzeAdd_Click(sender As Object, e As EventArgs) Handles tsbLicAdd.Click
        Try
            Dim F As New dlgLicenza
            Dim lic As LicenzaAziendaEntity = F.Nuova(_Azienda)
            If lic IsNot Nothing Then
                bsLicenze.Position = bsLicenze.IndexOf(lic)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbLicenzeDel_Click(sender As Object, e As EventArgs) Handles tsbLicDel.Click
        Try
            Dim lic As LicenzaAziendaEntity = bsLicenze.Current
            If lic Is Nothing Then Return
            If MsgBox("Eliminare la licenza selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(lic)
            bsLicenze.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbLicenzeEdit_Click(sender As Object, e As EventArgs) Handles tsbLicEdit.Click
        Try
            Dim lic As LicenzaAziendaEntity = bsLicenze.Current
            If lic Is Nothing Then Return
            Dim F As New dlgLicenza
            F.Apri(lic)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvLicenze_DoubleClick(sender As Object, e As EventArgs) Handles dgvLicenze.DoubleClick
        tsbLicEdit.PerformClick()
    End Sub

#End Region

#Region "Dichiarazioni"
    Private Sub dgvDichiarazioni_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDichiarazioni.CellFormatting
        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DichiarazioneEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If (rw.Anno Mod 2) = 0 Then
            e.CellStyle.BackColor = Color.FromArgb(230, 230, 230)
        End If

        If col Is dgvcDicRegDic Then
            e.Value = GetStatoDicPagIcon(rw.CodStatoDichiarazione)
        ElseIf col Is dgvcDicRegPag Then
            e.Value = GetStatoDicPagIcon(rw.CodStatoPagamento)
        ElseIf col Is dgvcDicDocs Then
            If rw.HasDocument Then
                e.Value = My.Resources.Arxivar16
            Else
                e.Value = mdsUtility.GraphicsHelper.EmptyImage
            End If
        End If

    End Sub


    Private Sub tsmDicGenAuto_Click(sender As Object, e As EventArgs) Handles tsmDicGenAuto.Click
        If MsgBox("Generare le dichiarazioni ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            SaveAzienda()
            _Azienda.GeneraDichiarazioni(Generale.CommonConfig.MaxAnniDichiarazioni)
            SaveAzienda()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmDicGenSel_Click(sender As Object, e As EventArgs) Handles tsmDicGenSel.Click
        Try
            Dim F As New FElencoScadenze
            Dim ss As IEnumerable(Of ScadenzaEntity) = F.GetScadenze()
            If ss Is Nothing OrElse ss.Count = 0 Then Return
            If MsgBox("Generare le dichiarazioni dalle scadenze selezionate ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            _Azienda.GeneraDichiarazioni(ss)
            SaveAzienda()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub tsbDicEdit_Click(sender As Object, e As EventArgs) Handles tsbDicEdit.Click
        Try
            If bsDichiarazioni.Current Is Nothing Then Return
            Dim F As New FDichiarazione
            F.Apri(bsDichiarazioni.Current)
            dgvDichiarazioni.Invalidate()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbDicDel_Click(sender As Object, e As EventArgs) Handles tsbDicDel.Click
        Try
            Dim dd() As DichiarazioneEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DichiarazioneEntity)(dgvDichiarazioni, False)
            If dd Is Nothing OrElse dd.Length = 0 Then Return
            If MsgBox("Eliminare le dichiarazioni selezionate ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            For Each d In dd
                DA.DeleteEntity(d)
                bsDichiarazioni.Remove(d)
            Next
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub tsbDicForza_Click(sender As Object, e As EventArgs) Handles tsbDicForza.Click
        Try
            Dim dd() As DichiarazioneEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DichiarazioneEntity)(dgvDichiarazioni, False)
            If dd.Count = 0 Then Return
            If MsgBox("Forzare lo stato delle dichiarazioni selezionate  ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            For Each d In dd
                d.CodStatoDichiarazione = Enums.StatoDocumento.FORCED
                d.CodStatoPagamento = Enums.StatoDocumento.FORCED
                DA.SaveEntity(d, True)
            Next

            UpdateLayout()
            dgvDichiarazioni.Invalidate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbDicDocArxivar_Click(sender As Object, e As EventArgs) Handles tsbDicDocArxivar.Click
        Try
            If bsDichiarazioni.Current Is Nothing Then Return
            Dim dic As DichiarazioneEntity = bsDichiarazioni.Current
            If dic.HasDocument Then
                ArxivarWCFWrapper.OpenDocumentById(dic.RifArxivar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbDicScadenze_Click(sender As Object, e As EventArgs) Handles tsbDicScadenze.Click
        Try
            Dim F As New FElencoScadenze
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvDichiarazioni_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDichiarazioni.CellDoubleClick

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DichiarazioneEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcDicDocs Then
            tsbDicDocArxivar.PerformClick()
        ElseIf col Is dgvcDicAllegato Then
            ApriAllegato()
        Else
            tsbDicEdit.PerformClick()
        End If
    End Sub

    Private Sub ApriAllegato()
        Try
            Dim dic As DichiarazioneEntity = bsDichiarazioni.Current
            If dic Is Nothing Then Return

            Dim F As New dlgAllegato
            If dic.HasAllegato Then
                F.Apri(dic.Allegato)
            Else
                If Not DichiarazioneEntity.CanHaveAllegato(dic.CodCategoria) Then Throw New Exception("Per la dichiarazione non sono previsti allegati")
                If Not dic.DataRicezione.HasValue Then dic.DataRicezione = Date.Today
                F.Nuovo(dic)
            End If
            dgvDichiarazioni.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Eventi"
    Private Sub tsbEvVisAll_Click(sender As Object, e As EventArgs) Handles tsbEvVisAll.Click
        If tsbEvVisAll.Checked Then
            dgvcEvNote.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvcEvMotivazione.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Else
            dgvcEvNote.DefaultCellStyle.WrapMode = DataGridViewTriState.False
            dgvcEvMotivazione.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        End If
        dgvEventi.AutoResizeRows()
    End Sub

    Private Sub tsbEvAdd_Click(sender As Object, e As EventArgs) Handles tsbEvAdd.Click
        Try

            Dim FSelEv As New dlgSelEvento
            Dim Pos As Point = tsEventi.PointToScreen(New Point(tsbEvAdd.ContentRectangle.Location.X - 730, tsbEvAdd.ContentRectangle.Location.Y))
            Dim SelEv As EventoEntity = FSelEv.GetEvent(Nothing, Pos, True)
            If SelEv Is Nothing Then Return

            Dim F As New dlgEventoAzienda
            Dim ev As EventoAziendaEntity = F.Nuovo(_Azienda, SelEv.Codice)
            If ev Is Nothing Then Return
            bsEventi.Position = bsEventi.IndexOf(ev)
            If DAL.Managers.SociManager.UpdateStatoEventi(_Azienda) Then
                DA.SaveEntityCollection(_Azienda.Eventi, True, False)
                dgvEventi.Invalidate()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbEvDel_Click(sender As Object, e As EventArgs) Handles tsbEvDel.Click
        Try
            Dim ev As EventoAziendaEntity = bsEventi.Current
            If ev Is Nothing Then Return
            If MsgBox("Eliminare l'evento selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(ev)
            bsEventi.RemoveCurrent()
            If DAL.Managers.SociManager.UpdateStatoEventi(_Azienda) Then
                DA.SaveEntityCollection(_Azienda.Eventi, True, False)
                dgvEventi.Invalidate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbEvEdit_Click(sender As Object, e As EventArgs) Handles tsbEvEdit.Click
        Try
            Dim ev As EventoAziendaEntity = bsEventi.Current
            If ev Is Nothing Then Return
            Dim F As New dlgEventoAzienda
            F.Apri(ev)
            If DAL.Managers.SociManager.UpdateStatoEventi(_Azienda) Then
                DA.SaveEntityCollection(_Azienda.Eventi, True, False)
                dgvEventi.Invalidate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbEvDocArxivar_Click(sender As Object, e As EventArgs) Handles tsbEvDocArxivar.Click
        Try
            If bsEventi.Current Is Nothing Then Return
            Dim ev As EventoAziendaEntity = bsEventi.Current
            If ev.HasDocument Then
                ArxivarWCFWrapper.OpenDocumentById(ev.RifArxivar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvEventi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEventi.CellDoubleClick

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As EventoAziendaEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcEvDocs Then
            tsbEvDocArxivar.PerformClick()
        Else
            tsbEvEdit.PerformClick()
        End If



    End Sub


    Private Sub dgvEventi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEventi.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As EventoAziendaEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem

        If col Is dgvcEvStato Then
            If rw.Stato = Enums.StatoEvento.DONE Then
                e.Value = My.Resources.Green_Checkmark_16_n_g
            ElseIf rw.Stato = Enums.StatoEvento.OPEN Then
                e.Value = My.Resources.Help_Blue_16_n_g
            Else
                e.Value = mdsUtility.GraphicsHelper.EmptyImage
            End If
        ElseIf col Is dgvcEvNotifica Or col Is dgvcEvRuoloNotifica Then
            If rw.IsChiuso Then
                e.CellStyle.Font = New Font(dgvEventi.Font, FontStyle.Strikeout)
            Else
                If rw.DataAvviso.HasValue Then
                    If rw.DataAvviso.Value < Date.Today Then
                        e.CellStyle.ForeColor = Color.Red
                        e.CellStyle.SelectionForeColor = Color.LightCoral
                    ElseIf rw.DataAvviso.Value.Subtract(Date.Today).Days < 3 Then
                        e.CellStyle.ForeColor = Color.DarkOrange
                        e.CellStyle.SelectionForeColor = Color.LightGoldenrodYellow
                    Else
                        e.CellStyle.ForeColor = Color.DarkGreen
                        e.CellStyle.SelectionForeColor = Color.LightGreen
                    End If
                End If
            End If


        End If

    End Sub

    'Private Sub dgvEventi_DoubleClick(sender As Object, e As EventArgs) Handles dgvEventi.DoubleClick
    '    tsbEvEdit.PerformClick()
    'End Sub

#End Region

#Region "Gestione Stampe"
    Private Sub tsmiPrintLA_Click(sender As Object, e As EventArgs) Handles tsmiPrintLA.Click
        Try
            SaveAzienda()

            Dim cc As New List(Of mdsUIControls.dlgGetInfo.InfoType)
            cc.Add(New mdsUIControls.dlgGetInfo.InfoType("Profila con barcode", GetType(Boolean), False, False))
            cc.Add(New mdsUIControls.dlgGetInfo.InfoType("Copia comforme", GetType(Boolean), False, False))
            Dim F As New mdsUIControls.dlgGetInfo()
            If Not F.Apri(cc, "Lettera accettazione", "") Then Return


            Dim BasePath As String = Generale.GetCartellaModelli
            Dim wrm As New WordReportManager()

            '           Dim Risp As MsgBoxResult = MsgBox("Profilare la lettera con barcode ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNoCancel)
            '          If Risp = MsgBoxResult.Cancel Then Return

            '            Dim ProfileBarcode As Boolean = (Risp = MsgBoxResult.Yes)
            Dim ProfileBarcode As Boolean = cc(0).Value
            Dim CopiaConforme As Boolean = cc(1).Value

            Dim Barcode As String = ""
            Dim DescrCopiaConforme As String = IIf(CopiaConforme, " - COPIA CONFORME -", "")
            Dim IdDoc As Integer?
            If ProfileBarcode Then

                IdDoc = ArxivarWCFWrapper.Profiling.ProfileWithIdProfile(CommonConfig.ArxivarIdProfiloLetteraAccettazione, _
                                                                 CommonConfig.ContattoPredefinito, _
                                                                 CommonConfig.ArxivarIdRubricaSoci & "," & CommonConfig.PrefissoCodiceRubrica & _Azienda.Id, _
                                                                 "Lettera accettazione", _
                                                                 Date.Today, _
                                                                  ArxivarWCFWrapper.Profiling.ProfilemodeEnum.BARCODE, _
                                                                 "", _
                                                                 False, _
                                                                 Nothing)
                Barcode = "*PON" & CStr(IdDoc.Value).PadLeft(8, "0") & "*"
            End If


            Dim Data As String = _Azienda.GetXMLData(<Barcode><%= Barcode %></Barcode> _
                                                   , <CopiaConforme><%= DescrCopiaConforme %></CopiaConforme>)

            If Not wrm.GetReport(BasePath & "\LetteraAccettazione.docx", Data, "/azienda/") Then Return
            Dim ev As EventoAziendaEntity = DAL.Managers.SociManager.AggiungiEvento(_Azienda, Enums.TipoEvento.LETTER_GENERATION, "", "", Nothing, "Lettera di accettazione stampata")
            If IdDoc.HasValue Then ev.RifArxivar = IdDoc.Value
            SaveAzienda()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub tsmiPrintDoc_Click(sender As Object, e As EventArgs) Handles tsmiPrintDoc.Click
        Try
            Dim F As New dlgStampaDocumentazione
            F.Apri(_Azienda)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
#End Region


    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        _Azienda.RagioneSociale = "Matteo Di Stefano"
        _Azienda.CodFormaGiuridica = "SRL"
        _Azienda.PartitaIva = "11111111111"
        _Azienda.Indirizzo = "via Milano, 11"
        _Azienda.Localita = "Roma"
        _Azienda.Cap = "00000"
        _Azienda.Provincia = "RM"
        _Azienda.LegaleRappresentante = "Matteo Di Stefano"
        _Azienda.QuotaAdesione = Lookups.QuoteAdesione.Item(3).Codice
        _Azienda.Telefono1 = "111223131"

    End Sub

    Private Sub tsbAttivaSocio_Click(sender As Object, e As EventArgs) Handles tsbAttivaSocio.Click
        _Azienda.CodStato = Enums.StatoSocio.ATTIVO
        UpdateLayout()
    End Sub


    Private Sub tsmiArxApri_Click(sender As Object, e As EventArgs) Handles tsmiArxApri.Click
        Try
            ArxivarWCFWrapper.RicercaDocsPerContatto(CommonConfig.ArxivarAreaOrganizzativa, CommonConfig.PrefissoCodiceRubrica & _Azienda.Id, "")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiArxProfila_Click(sender As Object, e As EventArgs) Handles tsmiArxProfila.Click
        Try

            Dim F As New ArxivarWCFWrapper.dlgProfilaDocumento
            Dim Id As Integer? = F.ProfileFor(CommonConfig.ArxivarIdRubricaSoci & "," & CommonConfig.PrefissoCodiceRubrica & _Azienda.Id, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtRagioneSociale_validating(sender As Object, e As EventArgs) Handles txtRagioneSociale.Validating
        CheckRagSocChanges(True)
    End Sub

    Private Sub CheckRagSocChanges(Save As Boolean)
        Try
            If _Azienda.IsNew Then Return
            Dim NewRs As String = txtRagioneSociale.Text.Trim
            Dim OldRs As String = _Azienda.RagioneSociale.Trim
            If NewRs = "" Then Return
            If OldRs = "" Then Return
            If NewRs <> OldRs Then
                If MsgBox("La ragione sociale è stata modificata da [" & OldRs & "] a [" & NewRs & "]." & vbCr _
                          & "Generare un evento specifico ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    _Azienda.RagioneSociale = NewRs
                    Managers.SociManager.AggiungiEvento(_Azienda, Enums.TipoEvento.COMPANY_NAME_CHANGE, "", "", 0, "Nome precedente:" & OldRs)
                    If Save Then SaveAzienda()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub bsDichiarazioni_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsDichiarazioni.ListChanged
        Dim x As Integer
        x = 1
    End Sub

    Private Sub tsmiSchedaSocio_Click(sender As Object, e As EventArgs) Handles tsmiSchedaSocio.Click
        Try
            SaveAzienda()
            Dim F As New dlgStampaSchedaSocio
            F.Apri(_Azienda)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtRagioneSociale_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRagioneSociale.Validating

    End Sub

    Private Sub pnlHeader_DoubleClick(sender As Object, e As EventArgs) Handles pnlHeader.DoubleClick
        Try
            If MsgBox("Sblocccare i dati di intestazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not DAL.Managers.UtentiManager.IsLoggedUserContabilita Then Throw New Exception("Operazione riservata solo ad utente con ruolo [contabilità]")
                pnlHeader.IsReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub dgvEventi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEventi.CellContentClick

    End Sub

    Private Sub tsbProdRefresh_Click(sender As Object, e As EventArgs) Handles tsbProdRefresh.Click
        Try
            Generale.LogView.ClearLog()
            Generale.LogView.LogTitle = "Sincronizzazione prodotti"
            Generale.LogView.ShowLog()
            DAL.Managers.SociManager.SyncronizeProdotti(_Azienda)
        Catch ex As Exception
            Trace.TraceError(ex.Message)
        End Try
    End Sub

    Private Sub tsbNPRefresh_Click(sender As Object, e As EventArgs) Handles tsbNPRefresh.Click
        Try
            Dim Sql As String = "Select n.* from Nota n 
                    inner join Azienda az on n.IdAzienda=az.id
                    where az.partitaiva='" & _Azienda.PartitaIva & "'
                    order by Data desc"
            Dim tb As DataTable = DAL.SSPoliNet.GetDbTable(Sql)
            If tb.Rows.Count = 0 Then
                MsgBox("Nessuna nota trovata", MsgBoxStyle.Information)
            End If
            bsNotePNet.DataSource = tb

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsLicenze_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsLicenze.ItemClicked

    End Sub
End Class