Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgAllegatoDettaglio

    Private _Dettaglio As DettaglioAllegatoEntity
    Private _Allegato As AllegatoEntity
    Private _AziendaAllegato As AziendaAllegatoEntity

    Private _CanEdit As Boolean

    Public Sub Apri(DettaglioAllegato As DettaglioAllegatoEntity)

        _Dettaglio = DettaglioAllegato
        _Dettaglio.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuovo(All As AllegatoEntity) As DettaglioAllegatoEntity

        _Dettaglio = All.Dettaglio.AddNew
        If All.CategoriaAzienda <> "E" Then
            _Dettaglio.RuoloAziendaAllegato = Enums.RuoloAziendaAllegato.FORNITORE
        End If

        Inizializza()
        Me.ShowDialog()
        Return _Dettaglio
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        _Allegato = _Dettaglio.Allegato
        _AziendaAllegato = _Dettaglio.AziendaAllegato

        lAzienda.Text = String.Format("{0} - {1} - {2}", _Allegato.Dichiarazione.IdAzienda, _Allegato.Dichiarazione.Azienda.RagioneSociale, _Allegato.Dichiarazione.Azienda.Localita)
        lDichiarazione.Text = String.Format("{0} - Anno: {1} - Periodo: {2}", _Allegato.IdDichiarazione, _Allegato.Dichiarazione.Anno, _Allegato.Dichiarazione.Periodo)

        bsDettaglio.DataSource = _Dettaglio
        mdsUtility.Dataset.InitLookupCombo(cbRuolo, Lookups.RuoliAziendeAllegato.DefaultView)
        cbRuolo.DataBindings.Add("SelectedValue", _Dettaglio, "RuoloAziendaAllegato")

        UpdateAzienda()
        UpdateLayout()
        UpdateMateriale()

    End Sub

    Private Sub UpdateAzienda()
        If _Dettaglio.AziendaAllegato Is Nothing Then
            lAzRagioneSociale.Text = ""
            lAzPartitaIva.Text = ""
            lAzIndirizzo.Text = ""
            lAzLocalita.Text = ""
            lAzCap.Text = ""
            lAzProvincia.Text = ""
            lAzNazione.Text = ""
        Else
            lAzRagioneSociale.Text = _Dettaglio.AziendaAllegato.RagioneSociale
            lAzPartitaIva.Text = _Dettaglio.AziendaAllegato.PartitaIva
            lAzIndirizzo.Text = _Dettaglio.AziendaAllegato.Indirizzo
            lAzLocalita.Text = _Dettaglio.AziendaAllegato.Localita
            lAzCap.Text = _Dettaglio.AziendaAllegato.Cap
            lAzProvincia.Text = _Dettaglio.AziendaAllegato.Provincia
            lAzNazione.Text = _Dettaglio.AziendaAllegato.Nazione
        End If
    End Sub



    Private Sub UpdateMateriale()
        If _Dettaglio.MaterialeCer Is Nothing Then
            lCerCodice.Text = ""
            lCerDescrizione.Text = ""
        Else
            lCerCodice.Text = _Dettaglio.CodiceCer
            lCerDescrizione.Text = _Dettaglio.MaterialeCer.Descrizione
        End If
    End Sub

    Private Sub UpdateLayout()
        Dim Cat As String = _Allegato.CategoriaAzienda
        Select Case Cat
            Case "B"
                ldescrQta.Text = "Quantità (Kg)"
                lDescrContributo.Visible = True
                txtContributo.Visible = True
                btnSetMateriale.Enabled = False
                lCerCodice.BackColor = Color.LightGray
                lCerDescrizione.BackColor = Color.LightGray
                cbRuolo.SelectedValue = Enums.RuoloAziendaAllegato.FORNITORE
                cbRuolo.Enabled = False
            Case "C"
                ldescrQta.Text = "Quantità (Tn)"
                lDescrContributo.Visible = False
                txtContributo.Visible = False
                btnSetMateriale.Enabled = True
                lCerCodice.BackColor = Color.White
                lCerDescrizione.BackColor = Color.White
                cbRuolo.SelectedValue = Enums.RuoloAziendaAllegato.FORNITORE
                cbRuolo.Enabled = False
            Case "E"
                ldescrQta.Text = "Quantità (Tn)"
                lDescrContributo.Visible = False
                txtContributo.Visible = False
                btnSetMateriale.Enabled = True
                lCerCodice.BackColor = Color.White
                lCerDescrizione.BackColor = Color.White
                cbRuolo.Enabled = True
            Case Else
                Throw New Exception("Categoria azienda non valida per un allegato")
        End Select

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
            bsDettaglio.EndEdit()
            _Dettaglio.ValidateEntity()
            DA.SaveEntity(_Dettaglio, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Dettaglio.IsNew Then
            _Dettaglio.Allegato.Dettaglio.Remove(_Dettaglio)
        Else
            bsDettaglio.CancelEdit()
            _Dettaglio.RollbackFields("Edit")
            _Dettaglio = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub btnSetMateriale_Click(sender As Object, e As EventArgs) Handles btnSetMateriale.Click
        Try
            Dim F As New mdsLLBLGenUtility.FSelTabella()
            Dim cc As CodiciCerEntity = F.GetSelectedRow("Materiale", Lookups.CodiciCER, "Codice|100px,Descrizione", Nothing, Nothing)
            If cc Is Nothing Then Return
            _Dettaglio.MaterialeCer = cc
            UpdateMateriale()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnSetAzienda_Click(sender As Object, e As EventArgs) Handles btnSetAzienda.Click
        Try
            Dim F As New FElencoAziendeAllegato
            Dim aa As AziendaAllegatoEntity = F.GetAzienda
            If aa Is Nothing Then Return
            _Dettaglio.AziendaAllegato = aa
            _AziendaAllegato = aa

            UpdateAzienda

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub cbRuolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRuolo.SelectedIndexChanged

    End Sub
End Class