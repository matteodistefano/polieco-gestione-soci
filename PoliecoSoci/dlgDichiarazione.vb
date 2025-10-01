Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Imports ARXWCF = ArxivarWCFWrapper

Public Class dlgDichiarazione
    Private _Dichiarazione As DichiarazioneEntity
    Private _CanEdit As Boolean

    Public Sub Apri(IdDic As Integer)
        _Dichiarazione = New DichiarazioneEntity(IdDic)
        Apri(_Dichiarazione)
    End Sub

    Public Sub Apri(Dic As DichiarazioneEntity)

        _Dichiarazione = Dic
        _Dichiarazione.RigheDettaglio.Clear()
        _Dichiarazione.Incassi.Clear()

        Dim PP As New PrefetchPath2(CInt(EntityType.DichiarazioneEntity))
        PP.Add(DichiarazioneEntity.PrefetchPathRigheDettaglio)
        PP.Add(DichiarazioneEntity.PrefetchPathIncassi)
        PP.Add(DichiarazioneEntity.PrefetchPathScadenza)
        PP.Add(DichiarazioneEntity.PrefetchPathAzienda)

        DA.FetchEntity(_Dichiarazione, PP)

        Inizializza()
        bsDettaglio.ResumeBinding()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _Dichiarazione.Azienda.Id, _Dichiarazione.Azienda.RagioneSociale)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbCategoria, Lookups.Categorie)
        cbCategoria.Enabled = False

        bsData.DataSource = _Dichiarazione

        bsDettaglio.DataSource = _Dichiarazione.RigheDettaglio
        dgvDettaglio.AutoGenerateColumns = False
        dgvDettaglio.DataSource = bsDettaglio

        bsIncassi.DataSource = _Dichiarazione.Incassi
        dgvIncassi.AutoGenerateColumns = False
        dgvIncassi.DataSource = bsIncassi



        'Aggiunta menu quadri

        tsbDettAdd.DropDownItems.Add("Semplificato", Nothing, AddressOf AddRigaDettaglio).Tag = Nothing
        tsbDettAdd.DropDownItems.Add(New ToolStripSeparator())

        For Each q In _Dichiarazione.QuadriConsentiti 'NB C'è il Fetc anche dei materiali
            tsbDettAdd.DropDownItems.Add(q.Codice, Nothing, AddressOf AddRigaDettaglio).Tag = q
        Next


        UpdateLayout()

    End Sub

    Private Sub UpdateLayout()

        If _Dichiarazione Is Nothing Then Return

        _Dichiarazione.UpdateStato()

        btnStatoDoc.Image = ImagesHelper.GetOkNoIcon(_Dichiarazione.CodStatoDichiarazione)
        lStatoIncasso.Image = ImagesHelper.GetOkNoIcon(_Dichiarazione.CodStatoPagamento)

        lTotDichiarazione.Text = String.Format("{0:c2}", _Dichiarazione.ImportoRuolo.GetValueOrDefault())
        lTotIncassi.Text = String.Format("{0:c2}", _Dichiarazione.ImportoPagato.GetValueOrDefault())

        Dim V As Decimal = _Dichiarazione.Saldo.GetValueOrDefault()
        If V > 0 Then
            lDescrSaldo.Text = "Saldo AVERE"
            lSaldo.BackColor = Color.FromArgb(255, 192, 192)
        Else
            lDescrSaldo.Text = "Saldo"
            lSaldo.BackColor = Color.FromArgb(192, 255, 192)
        End If

        lSaldo.Text = String.Format("{0:c2}", V)

        If _Dichiarazione.ContributoMinimoAnnuale > _Dichiarazione.ImportoRuolo Then
            lContrMin.BackColor = Color.FromArgb(255, 255, 192)
        Else
            lContrMin.BackColor = lTotDichiarazione.BackColor
        End If

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
            dgvDettaglio.EndEdit()
            bsData.EndEdit()
            _Dichiarazione.ValidateEntity()
            DA.SaveEntity(_Dichiarazione, True)
            dgvDettaglio.DataSource = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        bsData.CancelEdit()
        _Dichiarazione = Nothing
        Me.Close()
    End Sub


    Private Sub AddRigaDettaglio(sender As Object, e As EventArgs)
        Try
            Dim tsmi As ToolStripMenuItem = sender
            bsData.EndEdit()
            If Not _Dichiarazione.DataRicezione.HasValue Then
                Dim Fdt As New mdsUIControls.dlgGetInfo()
                Dim itDt As New mdsUIControls.dlgGetInfo.InfoType("Data ricezione", GetType(System.DateTime), False, Date.Today)
                If Not Fdt.Apri(itDt, "Richiesta data") Then Return
                Dim Dt As Date? = itDt.Value
                _Dichiarazione.DataRicezione = Dt
            End If


            If tsmi.Tag Is Nothing Then
                'Inserimento smart

                Dim Iva As Decimal = DAL.Generale.GetAliquotaIVA(_Dichiarazione.DataRicezione)

                Dim Data As String = ""
                Dim Ftxt As New mdsUIControls.dlgStringEdit()
                If Not Ftxt.Apri(Data, "Dati dichiarazione", True) Then Return
                If Data = "" Then Return
                Data = Data.ToUpper
                Dim DataQuadri() As String = Data.Split(New Char() {vbCr}, StringSplitOptions.RemoveEmptyEntries)
                For Each DQ In DataQuadri
                    Try
                        DQ = DQ.Trim
                        If DQ <> "" Then
                            Dim el() As String = DQ.Split(" ")
                            If el.Count <> 3 Then Throw New Exception("Numero elementi non valido")
                            Dim CodQuadro As String = el(0)
                            Dim PosMateriale As String = el(1)
                            Dim Valore As String = el(2)
                            Valore = Valore.Replace(".", ",")
                            If Not IsNumeric(PosMateriale) Then Throw New Exception("Definizione materiale non valida")
                            If Not IsNumeric(Valore) Then Throw New Exception("Valore non valido")

                            Dim rd As RigaDichiarazioneEntity = _Dichiarazione.AddDettaglio(CodQuadro, PosMateriale, Iva, CDec(Valore.Replace(",", ".")))
                            DA.SaveEntity(rd, True)
                        End If

                    Catch ex As Exception
                        MsgBox("Errore. Riga: " & DQ & vbCr & ex.Message, MsgBoxStyle.Information)
                    End Try
                Next



            Else
                
                Dim F As New dlgDichiarazioneDettaglio
                Dim rd As RigaDichiarazioneEntity = F.Nuova(_Dichiarazione, tsmi.Tag)
                If rd Is Nothing Then Return
                bsDettaglio.Position = bsDettaglio.IndexOf(rd)
            End If

            UpdateLayout()




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbDettEdit_Click(sender As Object, e As EventArgs) Handles tsbDettEdit.Click, dgvDettaglio.DoubleClick
        Try
            If bsDettaglio.Current Is Nothing Then Return
            Dim rd As RigaDichiarazioneEntity = bsDettaglio.Current
            Dim F As New dlgDichiarazioneDettaglio
            F.Apri(rd)
            UpdateLayout()
            dgvDettaglio.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbDettDel_Click(sender As Object, e As EventArgs) Handles tsbDettDel.Click
        Try
            If bsDettaglio.Current Is Nothing Then Return
            Dim rd As RigaDichiarazioneEntity = bsDettaglio.Current
            If MsgBox("Eliminare la riga selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(rd)
            bsDettaglio.RemoveCurrent()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnStatoDoc_Click(sender As Object, e As EventArgs) Handles btnStatoDoc.Click
        If _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.FORCED Then
            _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.NO
        ElseIf _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.NO Then
            _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.FORCED
        ElseIf _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.OK Then
            _Dichiarazione.CodStatoDichiarazione = Enums.StatoDocumento.FORCED
        End If
        UpdateLayout()
    End Sub


#Region "Gestione Incassi"

    Private Sub tsbIncadd_Click(sender As Object, e As EventArgs) Handles tsbIncAdd.Click
        Try
            Dim F As New dlgIncasso
            Dim inc As IncassoEntity = F.Nuovo(_Dichiarazione)
            If inc Is Nothing Then Return
            bsIncassi.Position = bsIncassi.IndexOf(inc)
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgvIncassi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvIncassi.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As IncassoEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcIncDataPagamento Then
            If rw.DataPagamento.HasValue AndAlso rw.DataPagamento.Value > _Dichiarazione.DataScadenzaPagamento Then
                e.CellStyle.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Sub tsbIncEdit_Click(sender As Object, e As EventArgs) Handles tsbIncEdit.Click, dgvIncassi.DoubleClick
        Try
            If bsIncassi.Current Is Nothing Then Return
            Dim inc As IncassoEntity = bsIncassi.Current
            Dim F As New dlgIncasso
            F.Apri(inc)
            UpdateLayout()
            dgvIncassi.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbIncDel_Click(sender As Object, e As EventArgs) Handles tsbIncDel.Click
        Try
            If bsIncassi.Current Is Nothing Then Return
            Dim inc As IncassoEntity = bsIncassi.Current
            If MsgBox("Eliminare l'incasso selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            DA.DeleteEntity(inc)
            bsIncassi.RemoveCurrent()
            UpdateLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
#End Region

    Private Sub rifArxivar_ProfileClick(sender As Object, e As ArxivarWCFWrapper.ucProtocolloArxivar.ProfileClickEventArgs) Handles rifArxivar.ProfileClick
        Try

            Dim MaskId As String
            Dim FilePath As String

            If e.ProfileType = ARXWCF.ProfilemodeEnum.FILE Then
                'Recupero file
                Dim ofd As New OpenFileDialog
                ofd.Filter = "Tutti i file|*.*"
                If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Return
                FilePath = ofd.FileName

                MaskId = CommonConfig.MascheraProfilazioneDichiarazioni
            Else

                MaskId = CommonConfig.MascheraProfilazioneDichiarazioni & "_BC"
            End If

            'Recupero data documento
            Dim F As New mdsUIControls.dlgGetInfo
            Dim dt As New mdsUIControls.dlgGetInfo.InfoType("Data documento", GetType(Date), False, _Dichiarazione.DataRicezione)
            If Not F.Apri(dt, "Profilazione", "Profilazione dichiarazione") Then Return

            Dim PProf As New Dictionary(Of String, String)
            PProf.Add("DataDoc", dt.Value)
            PProf.Add("DocName", "DICHIARAZIONE PERIODICA " & _Dichiarazione.GetCompetenzaDescription)
            PProf.Add("CodMittente", CommonConfig.ArxivarIdRubricaSoci & "," & _Dichiarazione.IdAzienda)
            PProf.Add("#-COMPETENZA_DICHIARAZIONE", _Dichiarazione.GetCompetenzaDescription)
            Dim docId As Integer = ARXWCF.Profiling.ProfileWithMask(MaskId, FilePath, PProf)
            If docId > 0 Then
                _Dichiarazione.RifArxivar = docId
                MsgBox("Barcode correttamente generato.(Id:" & docId & ")", MsgBoxStyle.Information)
            End If
            DA.SaveEntity(_Dichiarazione, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtDataRicezione_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles txtDataRicezione.PropertyChanged
        UpdateLayout()
    End Sub


End Class