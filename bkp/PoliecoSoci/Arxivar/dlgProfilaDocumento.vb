Imports Abletech.Arxivar.Client
Imports Abletech.Arxivar.Entities



Public Class dlgProfilaDocumento

    Private _ContactCode As String
    Private _TargetContact As Dm_Rubrica
    Private _Profili As Dm_AssociaFolder()
    Private _retValue As Integer?
    Private _Parametri As Dictionary(Of String, String)


    Private Enum RuoloContattoTargetEnum
        Mittente = 0
        Destinatario = 1
    End Enum

    Public Function ProfileFor(Codice As String, Optional ByVal Parametri As Dictionary(Of String, String) = Nothing) As Integer?
        _ContactCode = Codice
        _Parametri = Parametri
        Inizializza()
        Me.ShowDialog()
        Return _retValue
    End Function

    Private Sub Inizializza()
        LoadProfili()
        _TargetContact = ArxWCF.GetContattoRubrica(_ContactCode)


        If _TargetContact Is Nothing Then Throw New Exception("Contatto non trovato")
        lDescrContattoTarget.Text = _TargetContact.RAGIONE_SOCIALE
        cbRuoloContattoTarget.SelectedIndex = RuoloContattoTargetEnum.Mittente

        If ArxWCF.ContattoPredefinito Is Nothing Then Throw New Exception("Contatto predefinito non definito")
        lDescrContattoDefault.Text = ArxWCF.ContattoPredefinito.RAGIONE_SOCIALE


    End Sub

    Private Sub LoadProfili()
        _Profili = ArxWCF.Conn.ARX_DATI.Dm_AssociaFolder_GetData()
        If Not chkTutti.Checked Then
            _Profili = (From x In _Profili Where x.UTENTE = ArxWCF.Conn.userConnected.UTENTE).ToArray
        End If
        cbProfilo.DataSource = _Profili
        cbProfilo.DisplayMember = "DESCRIZIONE"
        cbProfilo.ValueMember = "ID"
    End Sub

  
    Private Sub chkTutti_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutti.CheckedChanged
        LoadProfili()
    End Sub

    Private Sub cbRuoloContattoTarget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRuoloContattoTarget.SelectedIndexChanged
        If cbRuoloContattoTarget.SelectedIndex = RuoloContattoTargetEnum.Mittente Then
            lRuoloContattoDefault.Text = "A"
            pbFreccia.Image = My.Resources.freccia_DA
        Else
            lRuoloContattoDefault.Text = "DA"
            pbFreccia.Image = My.Resources.freccia_A
        End If
    End Sub

    Private Sub cbProfilo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfilo.SelectedIndexChanged
        UpdateProfilo()
    End Sub

    Private Sub UpdateProfilo()
        Dim pd As Dm_AssociaFolder = cbProfilo.SelectedItem

        txtOggetto.Text = pd.DOCNAME
        Dim idp(2) As Integer

        idp(0) = pd.TIPODOC
        idp(1) = pd.TIPO2
        idp(2) = pd.TIPO3
        Dim aa() As Aggiuntivo_Base = ArxWCF.Conn.ARX_DATI.Dm_CampiSpecifici_GetData_AggiuntivoBase(pd.AOO, idp, True, "")
        If _Parametri IsNot Nothing Then
            For Each k As String In _Parametri.Keys
                Dim kl As String = k.ToLower
                If kl.StartsWith("#-") Then
                    Dim a As Aggiuntivo_Base = aa.FirstOrDefault(Function(x) x.ExternalId.ToLower = kl.Substring(2))
                    If a IsNot Nothing Then
                        a.Set_Property_Value_By_Name("Valore", _Parametri(k), False)
                    End If
                Else
                    Select Case kl
                        Case "docname"
                            txtOggetto.Text &= " " & _Parametri(k)
                        Case "datadoc"
                            If IsDate(_Parametri(k)) Then txtDataDoc.DateValue = CDate(_Parametri(k))
                        Case "numero"
                            txtNumero.Text = _Parametri(k)
                    End Select
                End If
            Next
        End If


        bsAggiuntivi.DataSource = aa

    End Sub


    Private Sub rbTaFile_CheckedChanged(sender As Object, e As EventArgs) Handles rbTaFile.CheckedChanged, rbTaBarcode.CheckedChanged
        ucFile.Enabled = rbTaFile.Checked
    End Sub

    Private Sub dgvAggiuntivi_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvAggiuntivi.DataBindingComplete
        For Each rw As DataGridViewRow In dgvAggiuntivi.Rows
            rw.Cells("dgvcAggValore").Value = rw.DataBoundItem.Valore
        Next
    End Sub


    Private Sub UpdateAggiuntivi()
        For Each rw As DataGridViewRow In dgvAggiuntivi.Rows
            rw.DataBoundItem.Valore = rw.Cells("dgvcAggValore").Value
        Next
    End Sub

    Private Sub tsbOk_Click(sender As Object, e As EventArgs) Handles tsbOk.Click
        Try
            dgvAggiuntivi.EndEdit()
            _retValue = ProfileDoc()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsbAnnulla_Click(sender As Object, e As EventArgs) Handles tsbAnnulla.Click
        _retValue = Nothing
        Me.Close()
    End Sub

    Private Function ProfileDoc() As Integer

        Dim af As Dm_AssociaFolder = cbProfilo.SelectedItem
        If af Is Nothing Then Throw New Exception("Profilo non selezionato")

        Dim pd As Libraries.Dm_Profile_Default = ArxWCF.Conn.ARX_DATI.Dm_Profile_Default_GetNewInstance_From_IdAssociaFolder(af.ID, True)
        Dim p As Libraries.Dm_Profile_ForInsert = pd.Dm_Profile_Insert_Base.To_Dm_Profile_ForInsert

        Dim mitt, dest As Dm_DatiProfilo
        If cbRuoloContattoTarget.SelectedIndex = RuoloContattoTargetEnum.Mittente Then
            mitt = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(_TargetContact.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.MI)
            dest = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(ArxWCF.ContattoPredefinito.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.DE)
        Else
            mitt = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(ArxWCF.ContattoPredefinito.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.MI)
            dest = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(_TargetContact.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.DE)
        End If
        If mitt Is Nothing Then Throw New Exception("Mittente non definito")
        If dest Is Nothing Then Throw New Exception("Destinatario non definito")

        p.From = mitt
        If p.To.FirstOrDefault(Function(x) x.IDRUBRICA = dest.IDRUBRICA) Is Nothing Then p.To.Add(dest)

        If txtOggetto.Text.Trim = "" Then Throw New Exception("Oggetto non definito")
        p.DocName = txtOggetto.Text

        If Not txtDataDoc.DateValue.HasValue Then Throw New Exception("Data non definita")
        p.DataDoc = txtDataDoc.DateValue



        p.ProtocolloInterno = txtNumero.Text
        'p.Set_Property_Value_By_Name("NUMERO", txtNumero.Text, True)


        UpdateAggiuntivi()
        For Each a As Aggiuntivo_Base In bsAggiuntivi.DataSource
            Dim ca As Aggiuntivo_Base = p.Aggiuntivi.FirstOrDefault(Function(x) x.Nome = a.Nome)
            If ca IsNot Nothing Then
                ca.Set_Property_Value_By_Name("Valore", a.Get_Property_Value_By_Name("Valore"), False)
            End If
        Next

        Dim res As Libraries.Dm_Profile_Result

        If rbTaFile.Checked Then
            If ucFile.Text = "" Then Throw New Exception("File non definito")
            If Not System.IO.File.Exists(ucFile.Text) Then Throw New Exception("File non trovato")
            p.File = New Arx_File(ucFile.Text)
            res = ArxWCF.Conn.ARX_DATI.Dm_Profile_Insert(p)
        Else
            res = ArxWCF.Conn.ARX_DATI.Dm_Profile_Insert_For_Barcode(p, "")
            ArxWCF.Conn.ARX_DATI.Dm_Barcode_Print(res.PROFILE.DOCNUMBER, Enums.Dm_Barcode_TipoImpronta.N, False)
        End If
        If res.MESSAGE <> "" Then Throw New Exception(res.MESSAGE)
        Return res.PROFILE.DOCNUMBER
    End Function


End Class