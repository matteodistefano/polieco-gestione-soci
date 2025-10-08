Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Drawing

Public Class FDichiarazione

    Private _tpQuadri As New System.Collections.Generic.Dictionary(Of String, TabPage)
    Private _Coefficienti As System.Collections.Generic.Dictionary(Of String, Single)
    Private _IsReady As Boolean
    Private _dol As DichiarazioneOnLineEntity



    Public Sub Apri(dol As DichiarazioneOnLineEntity)

        Dim ds As Datasets.dsDichiarazione2019 = dol.DatiCompilati
        'DAL.EntityClasses.DichiarazioneOnLineEntity.CompleteDataset(ds)
        _dol = dol
        If _dol.HasAzienda Then
            _dol.Azienda = New AziendaEntity(_dol.IdAzienda)
            DA.FetchEntity(_dol.Azienda)
        End If
        data = ds
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Sub Apri(ds As Datasets.dsDichiarazione2019)
        data = ds
        Inizializza()
        Me.ShowDialog()
    End Sub



    Private Sub Inizializza()
        bsData.DataSource = data

        _Coefficienti = Manager.GetCoefficienti(data.Dichiarazione(0).Periodo.Substring(0, 4))


        InizializzaLabel()

        _tpQuadri.Add("A", tpQA)
        _tpQuadri.Add("B", tpQB)
        _tpQuadri.Add("C", tpQC)
        _tpQuadri.Add("D", tpQD)
        _tpQuadri.Add("E", tpQE)
        Me.tcQuadri.TabPages.Clear()

        Dim BSel As String = data.Dichiarazione(0).V_B_SEL
        If BSel = "B1" Then
            rbB1.Checked = True
        ElseIf BSel = "B1_1" Then
            rbB2_1.Checked = True
        Else
            rbB2_2.Checked = True
        End If

        If tcQuadri.TabPages.Count > 0 Then
            tcQuadri.SelectedIndex = 0
        End If

        lRateizzazione.Visible = (CStr(data.Dichiarazione(0).Rateizzazione & "").ToUpper = "S")
        'lRateizzazione.Visible = _dol.HasRateizzazione

        _IsReady = True

        If _dol Is Nothing Then
            Stato = ""
        Else
            Stato = _dol.Stato
        End If

        bsData.ResumeBinding()

        AggiornaLayoutAzienda()
        AggiornaConteggio()



    End Sub

    Private _Stato As String
    Private Property Stato As String
        Get
            Return _Stato
        End Get
        Set(value As String)
            _Stato = value
            ImpostaLabelStato()
            If value = "" Or _dol Is Nothing Then
                btnAzAss.Visible = False
                btnAzDel.Visible = False
                tsbImporta.Available = True
                tsbOpenDic.Available = False
                tsbAssociaDichiarazione.Available = False
                tsbAnnulla.Available = False
                tsbRipristina.Available = False
                Return
            End If

            Select Case value
                Case Enums.StatoDOL.ANNULLATA
                    btnAzAss.Visible = False
                    btnAzDel.Visible = False
                    tsbImporta.Available = False
                    tsbOpenDic.Available = False
                    tsbAssociaDichiarazione.Available = False
                    tsbAnnulla.Available = False
                    tsbRipristina.Available = True
                Case Enums.StatoDOL.INSERITA
                    btnAzAss.Visible = True
                    btnAzDel.Visible = _dol.HasAzienda
                    tsbImporta.Available = False
                    tsbOpenDic.Available = False
                    tsbAssociaDichiarazione.Available = True
                    tsbAnnulla.Available = True
                    tsbRipristina.Available = False
                Case Enums.StatoDOL.VALIDATA
                    btnAzAss.Visible = True
                    btnAzDel.Visible = _dol.HasAzienda
                    tsbImporta.Available = False
                    tsbOpenDic.Available = False
                    tsbAssociaDichiarazione.Available = True
                    tsbAnnulla.Available = True
                    tsbRipristina.Available = False
                Case Enums.StatoDOL.ASSOCIATA
                    btnAzAss.Visible = True
                    btnAzDel.Visible = False
                    tsbImporta.Available = False
                    tsbOpenDic.Available = True
                    tsbAssociaDichiarazione.Available = False
                    tsbAnnulla.Available = False
                    tsbRipristina.Available = False
            End Select
        End Set
    End Property


#Region "Gestione label stato"
    Private Enum StatoLabelEnum
        DISABLED
        [PARTIAL]
        COMPLETE
        RED
    End Enum

    Private Sub SetStatoLabel(lbl As Label, Stato As StatoLabelEnum, Text As String)
        lbl.Text = Text
        If Stato = StatoLabelEnum.DISABLED Then
            lbl.BackColor = Color.FromArgb(224, 224, 224)
            lbl.ForeColor = Color.Gray
        ElseIf Stato = StatoLabelEnum.PARTIAL Then
            lbl.BackColor = Color.FromArgb(255, 224, 192)
            lbl.ForeColor = Color.Black
        ElseIf Stato = StatoLabelEnum.COMPLETE Then
            lbl.BackColor = Color.FromArgb(192, 255, 192)
            lbl.ForeColor = Color.FromArgb(0, 30, 0)
        ElseIf Stato = StatoLabelEnum.RED Then
            lbl.BackColor = Color.FromArgb(255, 192, 192)
            lbl.ForeColor = Color.FromArgb(192, 0, 0)
        End If
    End Sub

    Private Sub ImpostaLabelStato()
        SetStatoLabel(lStatoDOL, StatoLabelEnum.DISABLED, "")
        SetStatoLabel(lStatoAzienda, StatoLabelEnum.DISABLED, "")
        SetStatoLabel(lStatoAllegati, StatoLabelEnum.DISABLED, "")
        SetStatoLabel(lStatoDichiarazione, StatoLabelEnum.DISABLED, "")

        If _dol Is Nothing Then
            SetStatoLabel(lStatoDOL, StatoLabelEnum.DISABLED, "Non importata")
            Return
        End If

        If _dol.Stato = Enums.StatoDOL.ANNULLATA Then
            SetStatoLabel(lStatoDOL, StatoLabelEnum.RED, "ANNULLATA")
            SetStatoLabel(lStatoAzienda, StatoLabelEnum.RED, "")
            SetStatoLabel(lStatoAllegati, StatoLabelEnum.RED, "")
            SetStatoLabel(lStatoDichiarazione, StatoLabelEnum.RED, "")
            Return
        End If

        If _dol.Stato = Enums.StatoDOL.INSERITA Then
            SetStatoLabel(lStatoDOL, StatoLabelEnum.PARTIAL, "INSERITA")
        ElseIf _dol.Stato = Enums.StatoDOL.VALIDATA Then
            SetStatoLabel(lStatoDOL, StatoLabelEnum.COMPLETE, "VALIDATA")
        ElseIf _dol.Stato = Enums.StatoDOL.ASSOCIATA Then
            SetStatoLabel(lStatoDOL, StatoLabelEnum.COMPLETE, "ASSOCIATA")
        End If

        If _dol.HasAzienda Then
            SetStatoLabel(lStatoAzienda, StatoLabelEnum.COMPLETE, "AZIENDA ASSOCIATA")
        Else
            SetStatoLabel(lStatoAzienda, StatoLabelEnum.DISABLED, "AZIENDA NON ASSOCIATA")
        End If


        If data.Voce.Count = 0 Then
            SetStatoLabel(lStatoAllegati, StatoLabelEnum.DISABLED, "NESSUN ALLEGATO DA VALIDARE")
        ElseIf _dol.StatoAllegatiValidati = StateCompleteEnum.UNCOMPLETE Then
            SetStatoLabel(lStatoAllegati, StatoLabelEnum.DISABLED, "ALLEGATI NON VALIDATI")
        ElseIf _dol.StatoAllegatiValidati = StateCompleteEnum.PARTIAL Then
            SetStatoLabel(lStatoAllegati, StatoLabelEnum.PARTIAL, "ALLEGATI PARZIALMENTE VALIDATI")
        ElseIf _dol.StatoAllegatiValidati = StateCompleteEnum.COMPLETE Then
            SetStatoLabel(lStatoAllegati, StatoLabelEnum.COMPLETE, "ALLEGATI VALIDATI")
        End If

        If _dol.HasDichiarazione Then
            SetStatoLabel(lStatoDichiarazione, StatoLabelEnum.COMPLETE, "DICHIARAZIONE ASSOCIATA")
        Else
            SetStatoLabel(lStatoDichiarazione, StatoLabelEnum.DISABLED, "DICHIARAZIONE  NON ASSOCIATA")
        End If
    End Sub





#End Region

    Private Sub InizializzaLabel()
        lFattA1_1.Text = "x " & _Coefficienti("A.1.1")
        lFattA1_2.Text = "x " & _Coefficienti("A.1.2")
        lFattA1_3_1.Text = "x " & _Coefficienti("A.1.3.1")
        lFattA1_3_2.Text = "x " & _Coefficienti("A.1.3.2")
        lFattA2.Text = "x " & _Coefficienti("A.2")

        lFattB1.Text = _Coefficienti("B.1").ToString("c2")
        lFattB1_1.Text = "x " & _Coefficienti("B.1.1")
        lFattB1_2.Text = "x " & _Coefficienti("B.1.2")
        lFattB1_3_1.Text = "x " & _Coefficienti("B.1.3.1")
        lFattB1_3_2.Text = "x " & _Coefficienti("B.1.3.2")
        lFattB2.Text = "x " & _Coefficienti("B.2")

        lFattC1.Text = "x " & _Coefficienti("C.1")
        lFattD1.Text = "x " & _Coefficienti("D.1")
        lFattE1.Text = "x " & _Coefficienti("E.1")
    End Sub

    Private Sub AggiornaConteggio()

        If Not _IsReady Then Return

        bsData.EndEdit()

        Dim d As Datasets.dsDichiarazione2019.DichiarazioneRow = data.Dichiarazione(0)
        Dim v, tA, tB, tC, tD, tE, tIVA, tNetto, Tot As Single

        tA = 0
        If chkCatA.Checked Then
            v = d.V_A1_1 * _Coefficienti("A.1.1")
            lTotA1_1.Text = v.ToString("n2")
            tA += v

            v = d.V_A1_2 * _Coefficienti("A.1.2")
            lTotA1_2.Text = v.ToString("n2")
            tA += v

            v = d.V_A1_3_1 * _Coefficienti("A.1.3.1")
            lTotA1_3_1.Text = v.ToString("n2") ' d.V_A2_1 * _Coefficienti("A.2").ToString("n2")
            tA += v

            v = d.V_A1_3_2 * _Coefficienti("A.1.3.2")
            lTotA1_3_2.Text = v.ToString("n2")
            tA += v

            v = d.V_A2_1 * _Coefficienti("A.2")
            lTotA2.Text = v.ToString("n2")
            tA += v
        End If

        tB = 0
        If chkCatB.Checked Then
            If d.V_B_SEL = "B1" Then
                tB = _Coefficienti("B.1")
            ElseIf d.V_B_SEL = "B2_1" Then
                tB = 0
            Else
                v = d.V_B1_1 * _Coefficienti("B.1.1")
                lTotB1_1.Text = v.ToString("n2")
                tB += v

                v = d.V_B1_2 * _Coefficienti("B.1.2")
                lTotB1_2.Text = v.ToString("n2")
                tB += v

                v = d.v_B1_3_1 * _Coefficienti("B.1.3.1")
                lTotB1_3_1.Text = v.ToString("n2") ' d.V_B2_1 * _Coefficienti("B.2").ToString("n2")
                tB += v

                v = d.V_B1_3_2 * _Coefficienti("B.1.3.2")
                lTotB1_3_2.Text = v.ToString("n2")
                tB += v

                v = d.V_B2_1 * _Coefficienti("B.2")
                lTotB2.Text = v.ToString("n2")
                tB += v
            End If
        End If

        tC = 0
        If chkCatC.Checked Then
            tC = d.VC1 * _Coefficienti("C.1")
            lTotC1.Text = tC.ToString("n2")
        End If

        tD = 0
        If chkCatD.Checked Then
            tD = d.VD1 * _Coefficienti("D.1")
            lTotD1.Text = tD.ToString("n2")
        End If


        tE = 0
        If chkCatE.Checked Then
            tE = d.VE1 * _Coefficienti("E.1")
            lTotE1.Text = tE.ToString("n2")
        End If


        Dim IVA As Single = d.Iva / 100

        v = tA * IVA
        tNetto += tA
        tIVA += v
        Tot += v + tA
        lRiepNettoA.Text = tA.ToString("n2")
        lRiepIVAA.Text = v.ToString("n2")
        lRiepTotA.Text = (v + tA).ToString("n2")

        v = tB * IVA
        tNetto += tB
        tIVA += v
        Tot += v + tB
        lRiepNettoB.Text = tB.ToString("n2")
        lRiepIVAB.Text = v.ToString("n2")
        lRiepTotB.Text = (v + tB).ToString("n2")

        v = tC * IVA
        tNetto += tC
        tIVA += v
        Tot += v + tC
        lRiepNettoC.Text = tC.ToString("n2")
        lRiepIVAC.Text = v.ToString("n2")
        lRiepTotC.Text = (v + tC).ToString("n2")

        v = tD * IVA
        tNetto += tD
        tIVA += v
        Tot += v + tD
        lRiepNettoD.Text = tD.ToString("n2")
        lRiepIVAD.Text = v.ToString("n2")
        lRiepTotD.Text = (v + tD).ToString("n2")

        v = tE * IVA
        tNetto += tE
        tIVA += v
        Tot += v + tE
        lRiepNettoE.Text = tE.ToString("n2")
        lRiepIVAE.Text = v.ToString("n2")
        lRiepTotE.Text = (v + tE).ToString("n2")

        lRiepNetto.Text = tNetto.ToString("n2")
        lRiepIVA.Text = tIVA.ToString("n2")
        lRiepTot.Text = Tot.ToString("n2")

        If Math.Abs(Tot - d.V_TOTALE) > 0.05 Then
            lRiepTot.BackColor = Drawing.Color.FromArgb(240, 200, 200)
        Else
            lRiepTot.BackColor = Drawing.Color.FromArgb(200, 240, 200)
        End If


    End Sub



    Private Sub chkCat_CheckedChanged(sender As Object, e As EventArgs) Handles chkCatA.CheckedChanged _
                                                                                , chkCatB.CheckedChanged _
                                                                                , chkCatC.CheckedChanged _
                                                                                , chkCatD.CheckedChanged _
                                                                                , chkCatE.CheckedChanged

        If Not _IsReady Then Return
        Dim chk As CheckBox = sender

        If chk.Checked = False Then
            If Not (chkCatA.Checked Or chkCatB.Checked Or chkCatC.Checked Or chkCatD.Checked Or chkCatE.Checked) Then
                chk.Checked = True
                Return
            End If
        End If


        Dim Cat As String = chk.Name.Replace("chkCat", "")
        Dim tp As TabPage = _tpQuadri(Cat)
        If chk.Checked Then
            If tcQuadri.TabPages.Contains(tp) Then Return

            Dim i As Integer
            For i = 0 To tcQuadri.TabPages.Count - 1
                If tcQuadri.TabPages(i).Name > tp.Name Then
                    Exit For
                End If
            Next

            tcQuadri.TabPages.Insert(i, tp)
            tcQuadri.SelectedTab = tp
        Else
            tcQuadri.TabPages.Remove(tp)
        End If

        AggiornaConteggio()

    End Sub



    Private Sub rbB_CheckedChanged(sender As Object, e As EventArgs) Handles rbB1.CheckedChanged, rbB2.CheckedChanged, rbB2_1.CheckedChanged, rbB2_2.CheckedChanged

        If Not _IsReady Then Return

        lFattB1.Visible = Not (rbB2.Checked And rbB2_2.Checked)
        lFattB1.Text = IIf(rbB1.Checked, _Coefficienti("B.1").ToString("c2"), "0,00 €")
        pnlRB2.Enabled = rbB2.Checked
        pnlB_B22.Visible = rbB2.Checked And rbB2_2.Checked


        'If Not _IsReady Then Return

        If rbB1.Checked Then
            data.Dichiarazione(0).V_B_SEL = "B1"
        ElseIf rbB2_1.Checked Then
            data.Dichiarazione(0).V_B_SEL = "B2_1"
        Else
            data.Dichiarazione(0).V_B_SEL = "B2_2"
        End If


        AggiornaConteggio()

    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbAllegati_Click(sender As Object, e As EventArgs) Handles tsbAllegati.Click
        Try
            If data.Voce.Count = 0 Then Throw New Exception("Nessun allegato comunicato")
            Dim F As New dlgElencoAllegato
            F.Apri(data)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbImporta_Click(sender As Object, e As EventArgs) Handles tsbImporta.Click
        Try
            If _dol IsNot Nothing Then Throw New Exception("Dichiarazione online già definita")
            If DA Is Nothing Then Throw New Exception("Accesso al sistema gestione soci non eseguito")

            If MsgBox("Importare la dichiarazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            _dol = Manager.ImportaDichiarazione(data)
            MsgBox("Dichiarazione correttamente importata", MsgBoxStyle.Information)
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If _dol IsNot Nothing Then Stato = _dol.Stato
        End Try
    End Sub

    Private Sub btnAzDel_Click(sender As Object, e As EventArgs) Handles btnAzDel.Click
        Try
            If MsgBox("Rimuovere l'associazione con l'azienda ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            _dol.RimuoviAssociazioneAzienda()
            DA.SaveEntity(_dol, True)
            Stato = _dol.Stato
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            AggiornaLayoutAzienda()
        End Try
    End Sub

    Private Sub btnAzAss_Click(sender As Object, e As EventArgs) Handles btnAzAss.Click
        Try
            CheckDelegate(Manager.RicercaAzienda)
            If _dol Is Nothing Then Throw New Exception("Dichiarazione non importata")

            If _dol.HasAzienda Then
                CheckDelegate(Manager.ApriAzienda)
                Manager.ApriAzienda(_dol.Azienda)
                Return
            End If

            Dim PIVA As String = _dol.DichiarazionePartitaIVA
            If PIVA = "" Then Throw New Exception("Partita IVA non definita")
            Dim Az As AziendaEntity = Nothing
            Dim srcAz As New EntityCollection(Of AziendaEntity)
            DA.FetchEntityCollection(srcAz, New RelationPredicateBucket(AziendaFields.PartitaIva = PIVA), 2)
            If srcAz.Count = 1 Then
                Az = srcAz(0)
                If MsgBox("Trovata la seguente azienda:" & vbCr & vbCr _
                          & vbTab & Az.RagioneSociale & vbCr _
                          & vbTab & Az.Indirizzo & vbCr _
                          & vbTab & Az.Localita & " " & Az.Provincia & vbCr & vbCr _
                          & "Associare alla dichiarazione on-line ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Az = Nothing
                End If
            ElseIf srcAz.Count = 2 Then
                MsgBox("Trovata corrispondenza multipla per partita IVA", MsgBoxStyle.Information)
            ElseIf srcAz.Count = 0 Then
                MsgBox("Partita IVA non trovata", MsgBoxStyle.Information)
            End If

            If Az Is Nothing Then
                CheckDelegate(Manager.RicercaAzienda)
                Az = Manager.RicercaAzienda.Invoke(_dol)
            End If
            If Az Is Nothing Then Return
            _dol.AssociaAzienda(Az)
            DA.SaveEntity(_dol, True)
            Stato = _dol.Stato
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            AggiornaLayoutAzienda()
        End Try
    End Sub

    Private Sub CheckDelegate(v As Object)
        If v Is Nothing Then Throw New Exception("Funzione non richiamabile in questo contesto. Accedere con l'applicazione principale")
    End Sub


#Region "Gestione azienda"

    Private Sub AggiornaLayoutAzienda()
        If _dol Is Nothing OrElse Not _dol.HasAzienda Then
            lcmpAzRagioneSociale.Image = Nothing
            lcmpAzSedeLegale.Image = Nothing
            lcmpAzPIVA.Image = Nothing
            lcmpAzTelefono.Image = Nothing
            lcmpAzFax.Image = Nothing
            lcmpAzEmail.Image = Nothing

            txtAzRagioneSociale.Text = ""
            txtAzSedeLegale.Text = ""
            txtAzPIva.Text = ""
            txtAzTelefono.Text = ""
            txtAzFax.Text = ""
            txtAzEmail.Text = ""

            Return
        End If

        Dim Az As AziendaEntity = _dol.Azienda

        txtAzRagioneSociale.Text = Az.RagioneSociale
        txtAzSedeLegale.Text = Az.Indirizzo & " " & Az.Cap & " " & Az.Localita & " " & Az.Provincia
        txtAzPIva.Text = Az.PartitaIva
        txtAzTelefono.Text = Az.Telefono1
        txtAzFax.Text = Az.Fax
        txtAzEmail.Text = Az.Email

        Dim dic As Datasets.dsDichiarazione2019.DichiarazioneRow = data.Dichiarazione(0)

        CompareAziendaField(lcmpAzRagioneSociale, mdsUtility.TextUtils.GetSearchableRagioneSociale(dic.RagioneSociale), mdsUtility.TextUtils.GetSearchableRagioneSociale(txtAzRagioneSociale.Text))
        CompareAziendaField(lcmpAzSedeLegale, dic.SedeLegale, txtAzSedeLegale.Text)
        CompareAziendaField(lcmpAzPIVA, dic.PartitaIVA, txtAzPIva.Text)
        CompareAziendaField(lcmpAzTelefono, dic.Telefono, txtAzTelefono.Text)
        CompareAziendaField(lcmpAzFax, dic.Fax, txtFax.Text)
        CompareAziendaField(lcmpAzEmail, dic.Email, txtAzEmail.Text)

    End Sub

    Private Sub CompareAziendaField(Lbl As Label, txt1 As String, txt2 As String)
        txt1 = txt1.Trim.ToUpper.Replace(" ", "")
        txt2 = txt2.Trim.ToUpper.Replace(" ", "")
        If txt1 = "" Or txt2 = "" Then
            Lbl.Image = Nothing
        Else
            If txt1 = txt2 Then
                Lbl.Image = My.Resources.Green_Checkmark_16_n_g
            Else
                Lbl.Image = My.Resources.Alert_or_Warning_2_16_n_g
            End If
        End If
    End Sub

#End Region



    Private Sub tsbAssociaDichiarazione_Click(sender As Object, e As EventArgs) Handles tsbAssociaDichiarazione.Click
        Try
            Dim d As DichiarazioneEntity = Manager.AssociaDichiarazione(_dol, False)
            If d IsNot Nothing Then MsgBox("Dichiarazione correttamente associata", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Stato = _dol.Stato
        End Try

    End Sub

    Private Sub tsbOpenDic_Click(sender As Object, e As EventArgs) Handles tsbOpenDic.Click
        Try
            If _dol Is Nothing Then Return
            If Not _dol.HasDichiarazione Then Return
            CheckDelegate(Manager.ApriDichiarazione)
            Manager.ApriDichiarazione.Invoke(_dol.IdDichiarazione)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtRiepIVA_Validated(sender As Object, e As EventArgs) Handles txtRiepIVA.Validated _
                                                                        , txtA1_1.Validated, txtA1_2.Validated, txtA1_3_1.Validated, txtA1_3_2.Validated, txtA2.Validated _
                                                                        , txtB1_1.Validated, txtB1_2.Validated, txtB1_3_1.Validated, txtB1_3_2.Validated, txtB2.Validated _
                                                                        , txtC1.Validated, txtD1.Validated, txtE1.Validated


        AggiornaConteggio()
    End Sub

    Private Sub tsbAnnulla_Click(sender As Object, e As EventArgs) Handles tsbAnnulla.Click
        Try
            If MsgBox("Annullare la dichiarazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            Manager.Annulla(_dol)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbRipristina_Click(sender As Object, e As EventArgs) Handles tsbRipristina.Click
        Try
            If MsgBox("Ripristinare la dichiarazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            Manager.Ripristina(_dol)
            Me.Stato = _dol.Stato
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub bsData_CurrentChanged(sender As Object, e As EventArgs) Handles bsData.CurrentChanged

    End Sub
End Class