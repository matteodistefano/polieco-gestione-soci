Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class AziendaEntity

        Public Shared Function GetNew() As AziendaEntity
            Dim ret As New AziendaEntity

            ret.CodStato = Enums.StatoSocio.NUOVO
            ret.CodInfoStato = Enums.InfoStatoSocio.NOINFO
            ret.CodTipoIscrizione = Enums.TipoSocio.SOC_ORD
            ret.UsatoPerSpedizione = True
            ret.DataAdesione = Date.Today

            Return ret
        End Function

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.RagioneSociale = "" Then Throw New ORMEntityValidationException("Ragione sociale non definita", Me)
            If Me.CodFormaGiuridica = "" Then Throw New ORMEntityValidationException("Forma giuridica non definita", Me)
            If Me.CodTipoIscrizione = "" Then Throw New ORMEntityValidationException("Tipo iscrizione non definita", Me)
            If Me.Indirizzo = "" Then Throw New ORMEntityValidationException("Indirizzo non definito", Me)
            If Me.Cap = "" Then Throw New ORMEntityValidationException("Cap non definito", Me)
            If Me.Localita = "" Then Throw New ORMEntityValidationException("Località non definita", Me)
            If Me.Provincia = "" Then Throw New ORMEntityValidationException("Provincia non definita", Me)
            If (Me.Telefono1 = "" And Me.Email = "" And Me.Pec = "") Then Throw New ORMEntityValidationException("Bisogna definire almeno un recapito tra telefono, email o pec.", Me)
            If Me.LegaleRappresentante = "" Then Throw New ORMEntityValidationException("Legale rappresentante non definito", Me)
            If Not Me.QuotaAdesione.HasValue Then Throw New ORMEntityValidationException("Quota adesione non definita", Me)
            If Not Me.DataAdesione.HasValue Then Throw New ORMEntityValidationException("Data adesione non definita", Me)
            If Not Me.DataInizioAttivita.HasValue Then Throw New ORMEntityValidationException("Data inizio attività non definita", Me)
            If Me.PartitaIva.Length <> 11 Then Throw New ORMEntityValidationException("Partita IVA non valida", Me)
            If Me.CodCategoria = "" Then
                Dim ex As New ORMEntityValidationException("Categoria principale non definita", Me)
                ex.Data.Add("Info", "NoCategoria")
                Throw ex
            End If

        End Sub

        Public ReadOnly Property RagioneSocialeChanged() As Boolean
            Get
                Return Me.Fields("RagioneSociale").IsChanged OrElse Me.Fields("CodFormaGiuridica").IsChanged
            End Get
        End Property

        Public Function GetCodCategoria(Tipo) As String
            Dim ret As AttivitaEntity = Me.Attivita.FirstOrDefault(Function(x) x.CodTipoAttivita = Tipo)
            If ret Is Nothing Then Return ""
            Return ret.CodCategoria
        End Function

        Public Function GetCategoria(Tipo) As CategoriaEntity
            Dim Cod As String = GetCodCategoria(Tipo)
            Return Lookups.Categorie.FirstOrDefault(Function(x) x.Codice = Cod)
        End Function


        Public Function GetAltraSedePrimaria(Sd As SedeEntity) As SedeEntity
            Dim asp As SedeEntity = Me.Sedi.FirstOrDefault(Function(x) x.CodTipoSede = Enums.CodTipoSede.PRINCIPALE And Not x Is Sd)
            Return asp
        End Function

        Public Sub UpdateStato()
            '1) Stato dichiarazioni
            Dim DD As IEnumerable(Of DichiarazioneEntity) = From x In Me.Dichiarazioni Where x.DataScadenzaDichiarazione < Date.Today

            Me.StatoDichiarazione = Enums.StatoDocumento.OK
            Dim ND As Integer = DD.Where(Function(x) x.CodStatoDichiarazione = Enums.StatoDocumento.NO).Count
            If ND > 0 Then
                Me.StatoDichiarazione = Enums.StatoDocumento.NO
            Else
                ND = DD.Where(Function(x) x.CodStatoDichiarazione = Enums.StatoDocumento.PARTIAL).Count
                If ND > 0 Then
                    Me.StatoDichiarazione = Enums.StatoDocumento.PARTIAL
                End If
            End If

            '2) Stato pagamenti
            If Me.StatoDichiarazione = Enums.StatoDocumento.NO Then
                Me.StatoPagamenti = Enums.StatoDocumento.NO
            Else
                Dim NP As Integer = (From x In Me.Dichiarazioni Where x.DataScadenzaDichiarazione < Date.Today And x.CodStatoPagamento = Enums.StatoDocumento.NO Select x).Count
                If NP > 0 Then
                    Me.StatoPagamenti = Enums.StatoDocumento.NO
                Else
                    NP = (From x In Me.Dichiarazioni Where x.DataScadenzaDichiarazione < Date.Today And x.CodStatoPagamento = Enums.StatoDocumento.PARTIAL Select x).Count
                    If NP > 0 Then
                        Me.StatoPagamenti = Enums.StatoDocumento.PARTIAL
                    Else
                        Me.StatoPagamenti = Enums.StatoDocumento.OK
                    End If

                End If
            End If
        End Sub

        Public Sub GeneraDichiarazioni(MaxAnni As Integer)
            If Not Me.DataInizioAttivita.HasValue Then Throw New Exception("Data inizio attività non definita")
            If Me.CodCategoria = "" Then Throw New Exception("Categoria non definita")
            Dim AnnoIni As Integer = Math.Max(DataInizioAttivita.Value.Year, Date.Today.Year - MaxAnni)
            'Dim ss As New List(Of ScadenzaEntity)
            Dim Err As String = ""
            'For i As Integer = AnnoIni To Date.Today.Year
            'Dim CurrAnno As Integer = i
            Dim scad As IEnumerable(Of ScadenzaEntity) = From s In Lookups.Scadenze
                   Where s.CodCategoria = Me.CodCategoria _
                   And s.CreaAutomatico = True _
                   And s.Anno >= AnnoIni _
                   And (s.DataInizio >= Me.DataInizioAttivita Or (Me.DataInizioAttivita > s.DataInizio And Me.DataInizioAttivita <= s.DataFine))

            If scad.Count = 0 Then Throw New Exception("Impossibile trovare scadenza valide")
            GeneraDichiarazioni(scad)

        End Sub

        Public Sub GeneraDichiarazioni(SS As IEnumerable(Of ScadenzaEntity))
            If SS.Count = 0 Then Throw New Exception("Nessuna scadenza trovata")
            For Each s In ss
                GeneraDichiarazione(s)
            Next
            UpdateStato()
        End Sub

        Public Function GeneraDichiarazione(S As ScadenzaEntity) As DichiarazioneEntity
            Dim d As DichiarazioneEntity = Me.Dichiarazioni.AddNew()
            d.Anno = S.Anno
            d.DataInizio = S.DataInizio
            d.DataFine = S.DataFine
            d.CodCategoria = S.CodCategoria
            d.Scadenza = S
            d.DataScadenzaDichiarazione = S.DataScadenzaDichiarazione
            d.DataScadenzaPagamento = S.DataScadenzaPagamento
            d.CodStatoDichiarazione = Enums.StatoDocumento.NO
            d.CodStatoPagamento = Enums.StatoDocumento.NO
            d.ImportoPagato = 0
            d.ImportoRuolo = 0
            Return d
        End Function

        Public Function GetXMLData(ByVal ParamArray Options() As Xml.Linq.XElement) As String
            Dim ret = <azienda>
                          <RagioneSociale><%= Me.RagioneSociale %></RagioneSociale>
                          <Indirizzo><%= Me.Indirizzo %></Indirizzo>
                          <Localita><%= Me.Localita %></Localita>
                          <Cap><%= Me.Cap %></Cap>
                          <Provincia><%= Me.Provincia %></Provincia>
                          <LegaleRappresentante><%= Me.LegaleRappresentante %></LegaleRappresentante>
                          <Telefono><%= Me.Telefono1 %></Telefono>
                          <QuotaAdesione><%= Me.QuotaAdesione.GetValueOrDefault.ToString("c2") %></QuotaAdesione>
                          <DataAccettazione><%= Me.DataAdesione.Value.ToShortDateString %></DataAccettazione>
                          <NumeroSocio><%= Me.Id %></NumeroSocio>
                          <DichiarazioniRichieste><%= Me.GetElencoDichiarazioniRichieste %></DichiarazioniRichieste>
                          <PartitaIva><%= Me.PartitaIva %></PartitaIva>
                      </azienda>

            For Each opt In Options
                ret.Add(opt)
            Next

            Return ret.ToString
        End Function

        'Private _ElencoDichiarazioniRichieste As String = Nothing
        Public Function GetElencoDichiarazioniRichieste() As String

            'If _ElencoDichiarazioniRichieste IsNot Nothing Then Return _ElencoDichiarazioniRichieste

            Dim ret As New System.Text.StringBuilder
            Dim dm() As DichiarazioneEntity = (From x In Me.Dichiarazioni Where x.CodStatoDichiarazione = Enums.StatoDocumento.NO Select x).ToArray
            Dim aa() As Integer = (From d In dm Select d.Anno Distinct).ToArray

            For Each a In aa
                ret.Append(a & "    [ ")
                Dim da() As DichiarazioneEntity = (From d In dm Where d.Anno = a Order By d.DataInizio).ToArray
                For i As Integer = 0 To da.Count - 1
                    If i > 0 Then ret.Append("  |  ")
                    ret.AppendFormat("{0} - {1}", da(i).DataInizio.ToString("dd/MMM"), da(i).DataFine.ToString("dd/MMM"))
                Next
                ret.Append(" ]" & vbCrLf)
            Next
            Return ret.ToString
        End Function


    End Class
End Namespace

