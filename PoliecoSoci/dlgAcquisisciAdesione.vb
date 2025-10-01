
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Public Class dlgAcquisisciAdesione

    Private dsIsc As dsIscrizione
    Private tbData As DataTable

    Private _isReady As Boolean
    Private _FLog As mdsUIControls.Logging.dlgLogRtf = mdsUIControls.Logging.dlgLogRtf.GetInstance


    Public Sub Apri(Optional Path As String = "")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        tbData = New DataTable
        tbData.Columns.Add("Proprieta")
        tbData.Columns.Add("Valore")

        dgvDati.AutoGenerateColumns = False
        dgvDati.DataSource = bsData

    End Sub

    Private Sub ucFile_SceltaFile(sender As Object, e As EventArgs) Handles ucFile.SceltaFile
        tsbAnalizza.PerformClick()
    End Sub

    Private Sub ApriFile(Path As String)

        Try

            Trace.TraceInformation("Apertura file [" & Path & "]")
            dsIsc = New dsIscrizione
            dsIsc.ReadXml(Path)

            tbData.Clear()

            Trace.TraceInformation("****************************")


            Dim Isc As dsIscrizione.IscrizioneRow = dsIsc.Iscrizione(0)

            AddProprieta("Protocollo", Isc.Protocollo)

            AddProprieta("Ragione sociale", Isc.AzRagioneSociale)
            AddProprieta("Indirizzo", Isc.AzIndirizzo)
            AddProprieta("Localita", Isc.AzLocalita)
            AddProprieta("Cap", Isc.AzCap)
            AddProprieta("Provincia", Isc.AzProvincia)
            AddProprieta("Telefono", Isc.AzTelefono)
            AddProprieta("Url", Isc.AzUrl)
            AddProprieta("Email", Isc.AzEmail)
            AddProprieta("Pec", Isc.AzPec)
            AddProprieta("Partita IVA", Isc.AzPartitaIva)
            AddProprieta("Codice fiscale", Isc.AzCodiceFiscale)

            AddProprieta("Cognome firmatario", Isc.Cognome)
            AddProprieta("Nome firmatario", Isc.Nome)
            AddProprieta("Codice fiscale", Isc.CodiceFiscale)

            AddProprieta("Categoria A", IIf(Isc.CatA, "SI", ""))
            AddProprieta("Categoria B", IIf(Isc.CatB, "SI", ""))
            AddProprieta("Categoria C", IIf(Isc.CatC, "SI", ""))
            AddProprieta("Categoria D", IIf(Isc.CatD, "SI", ""))
            AddProprieta("Categoria E", IIf(Isc.CatE, "SI", ""))

            AddProprieta("Categoria Secondaria", Isc.CatSec)

            AddProprieta("Fascia fatturato", Isc.FasciaFatturato)


            bsData.DataSource = tbData

            Trace.TraceInformation("")
            Trace.TraceInformation("**********************************")
            Trace.TraceInformation("IMPORTAZIONE TERMINATA")

        Catch ex As Exception
            Trace.TraceError(ex.Message)
            Throw
        End Try



    End Sub

    Private Sub AddProprieta(PropDescription As String, PropValue As String)
        tbData.Rows.Add(New Object() {PropDescription, PropValue})
    End Sub


    Private Sub tsbAcquisisci_Click(sender As Object, e As EventArgs) Handles tsbAnalizza.Click
        Try
            ApriFile(ucFile.Text)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbCrea_Click(sender As Object, e As EventArgs) Handles tsbCrea.Click
        Try
            If dsIsc Is Nothing OrElse dsIsc.Iscrizione.Count = 0 Then Throw New Exception("Nessun dato acquisito")
            Dim isc As dsIscrizione.IscrizioneRow = dsIsc.Iscrizione(0)

            Dim pi As String = isc.AzPartitaIva
            If DbLib.GetDbValue("Select count(*) from Azienda where PartitaIVA='" & pi.Trim.Replace("'", "''") & "'", 0) > 0 Then Throw New Exception("Partita iva già esistente")

            If MsgBox("Aggiungere il socio ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            Dim Az As New AziendaEntity
            Az.RagioneSociale = isc.AzRagioneSociale
            Az.Indirizzo = isc.AzIndirizzo
            Az.Localita = isc.AzLocalita
            Az.Cap = isc.AzCap
            Az.Provincia = isc.AzProvincia
            Az.Telefono1 = isc.AzTelefono
            Az.SitoWeb = isc.AzUrl
            Az.Email = isc.AzEmail
            Az.Pec = isc.AzPec
            Az.PartitaIva = isc.AzPartitaIva
            Az.CodiceFiscale = isc.AzCodiceFiscale
            Az.FormaGiuridica = Lookups.FormeGiuridiche.Item(0)
            Az.CodTipoIscrizione = Enums.TipoSocio.SOC_ORD

            Az.LegaleRappresentante = isc.Cognome & " " & isc.Nome

            Az.CodStato = Enums.StatoSocio.NUOVO

            DA.SaveEntity(Az, True)

            Dim F As New FAzienda

            F.Apri(Az)

            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class