Imports DAL

Public Class FAggiornaDB
    Inherits mdsDBLib.FVersioneDB

#Region "Old update"
    
#End Region


    Protected Overrides Sub OnInizializza()
        Me.InitConnection(Generale.ConnectionString)

        Dim Az As New tagAzione

        Az.Versione = "000000.01"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.0.2.0"
        Controlli.Add(Az)

        Az.Versione = "000000.02"
        Az.Descrizione = "Aggiunta Tabella IVA"
        Az.Routine = AddressOf RT00002_AggiuntaTabellaIVA
        Az.RequiredAppVersion = "0.0.7.0"
        Controlli.Add(Az)

        Az.Versione = "000000.03"
        Az.Descrizione = "Campo stato evento "
        Az.Routine = AddressOf RT00003_AggiuntaChiusuraEvento
        Az.RequiredAppVersion = "0.0.7.0"
        Controlli.Add(Az)

        Az.Versione = "000000.04"
        Az.Descrizione = "Modifica view CDA"
        Az.Routine = AddressOf RT00004_ModViewCDA
        Az.RequiredAppVersion = "0.0.7.0"
        Controlli.Add(Az)

        Az.Versione = "000000.05"
        Az.Descrizione = "Aggiunta stored procedure Libro Soci"
        Az.Routine = AddressOf RT00005_AddSpLibroSoci
        Az.RequiredAppVersion = "0.0.7.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.0.8.0 *******************

        Az.Versione = "000000.06"
        Az.Descrizione = "Aggiunta rif Arxivar "
        Az.Routine = AddressOf RT00006_AddRifArxivar
        Az.RequiredAppVersion = "0.0.8.0"
        Controlli.Add(Az)

        Az.Versione = "000000.07"
        Az.Descrizione = "Aggiunta rif periodo scadenze "
        Az.Routine = AddressOf RT00007_AddRifPerScad
        Az.RequiredAppVersion = "0.0.8.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.0.9.0 *******************

        Az.Versione = "000000.08"
        Az.Descrizione = "Aggiunta gestione dichiarazione ON Line "
        Az.Routine = AddressOf RT00008_AddDOL
        Az.RequiredAppVersion = "0.0.9.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.0.0 *******************

        Az.Versione = "000000.09"
        Az.Descrizione = "Modifica gestione DOL "
        Az.Routine = AddressOf RT00009_ModGestioneDol
        Az.RequiredAppVersion = "0.1.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.1.0 *******************

        Az.Versione = "000000.10"
        Az.Descrizione = "Gestione estrazione quote"
        Az.Routine = AddressOf RT00010_EstrazioneQuote
        Az.RequiredAppVersion = "0.1.1.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.2.0 *******************

        Az.Versione = "000000.11"
        Az.Descrizione = "Sp Ragione sociale"
        Az.Routine = AddressOf RT00011_ModSpRagSoc
        Az.RequiredAppVersion = "0.1.2.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.3.0 *******************

        Az.Versione = "000000.12"
        Az.Descrizione = "Add ricerca quantitativi"
        Az.Routine = AddressOf RT00012_AddRicercaQuantitativi
        Az.RequiredAppVersion = "0.1.3.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.4.0 *******************

        Az.Versione = "000000.13"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.1.4.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.5.0 *******************

        Az.Versione = "000000.14"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.1.5.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.6.0 *******************

        Az.Versione = "000000.15"
        Az.Descrizione = "Aggiunta PEC"
        Az.Routine = AddressOf RT00013_AddPec
        Az.RequiredAppVersion = "0.1.6.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.7.0 *******************

        Az.Versione = "000000.16"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.1.7.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.8.0 *******************

        Az.Versione = "000000.17"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.1.8.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.1.9.0 *******************

        Az.Versione = "000000.18"
        Az.Descrizione = "Modifica stato dichiarazioni/Pagamenti azienda"
        Az.Routine = AddressOf RT00018_ModStaoDicPag
        Az.RequiredAppVersion = "0.1.9.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.2.0.0 *******************

        Az.Versione = "000000.19"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.2.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.0.0 *******************

        Az.Versione = "000000.20"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.3.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.1.0 *******************

        Az.Versione = "000000.21"
        Az.Descrizione = "Aggiunta ordinamento materiali"
        Az.Routine = AddressOf RT00021_AddSortMaterial
        Az.RequiredAppVersion = "0.3.1.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.2.0 *******************

        Az.Versione = "000000.22"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.3.2.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.3.0 *******************

        Az.Versione = "000000.23"
        Az.Descrizione = "Gestione Prodotti"
        Az.Routine = AddressOf RT00023_AddProdotti
        Az.RequiredAppVersion = "0.3.3.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.4.0 *******************

        Az.Versione = "000000.24"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.3.4.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.5.0 *******************

        Az.Versione = "000000.25"
        Az.Descrizione = "Gestione importazione DOL"
        Az.Routine = AddressOf RT00025_ModImpDOL
        Az.RequiredAppVersion = "0.3.5.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.6.0 *******************

        Az.Versione = "000000.26"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.3.6.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.7.0 *******************

        Az.Versione = "000000.27"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.3.7.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.8.0 *******************

        Az.Versione = "000000.28"
        Az.Descrizione = "Aggiunta campo RS precedenti"
        Az.Routine = AddressOf RT00028_AddRsPrec
        Az.RequiredAppVersion = "0.3.8.0"
        Controlli.Add(Az)

        Az.Versione = "000000.29"
        Az.Descrizione = "Aggiunta campi mail/url"
        Az.Routine = AddressOf RT00029_AddMailUrl
        Az.RequiredAppVersion = "0.3.8.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.3.9.0 *******************

        Az.Versione = "000000.30"
        Az.Descrizione = "Modifica view ricerca"
        Az.Routine = AddressOf RT00030_ModViewRIc
        Az.RequiredAppVersion = "0.3.9.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.0.0 *******************

        Az.Versione = "000000.31"
        Az.Descrizione = "Mod eventi"
        Az.Routine = AddressOf RT00031_ModEventi
        Az.RequiredAppVersion = "0.4.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.1.0 *******************

        Az.Versione = "000000.32"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.4.1.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.2.0 *******************

        Az.Versione = "000000.33"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.4.2.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.3.0 *******************

        Az.Versione = "000000.34"
        Az.Descrizione = "Generazione prosperro quote"
        Az.Routine = AddressOf RT00033_ModProspettoQuote
        Az.RequiredAppVersion = "0.4.3.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.4.0 *******************

        Az.Versione = "000000.35"
        Az.Descrizione = "Generazione prospettoo quote"
        Az.Routine = AddressOf RT00034_ModProspettoQuote
        Az.RequiredAppVersion = "0.4.4.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.5.0 *******************

        Az.Versione = "000000.36"
        Az.Descrizione = "Cambio versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.4.5.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.6.0 *******************

        Az.Versione = "000000.37"
        Az.Descrizione = "Aggiunta evento"
        Az.Routine = AddressOf RT00037_AggiuntaEventoRichiestaRecesso
        Az.RequiredAppVersion = "0.4.6.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.7.0 *******************

        Az.Versione = "000000.38"
        Az.Descrizione = "Gestione dichiarazioni"
        Az.Routine = AddressOf RT00038_ModDichiarazioni
        Az.RequiredAppVersion = "0.4.7.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.8.0 *******************

        Az.Versione = "000000.39"
        Az.Descrizione = "Modifica versione - Agg. .NET + DAL"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.4.8.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.4.9.0 *******************

        Az.Versione = "000000.40"
        Az.Descrizione = "Modifica dichiarazioni"
        Az.Routine = AddressOf RT00040_ModificaDichiarazioni
        Az.RequiredAppVersion = "0.4.9.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.0.0 *******************

        Az.Versione = "000000.41"
        Az.Descrizione = "Aggiornamento versione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.5.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.1.0 *******************

        Az.Versione = "000000.42"
        Az.Descrizione = "Importazione allegati"
        Az.Routine = AddressOf RT00042_ImpAllegati
        Az.RequiredAppVersion = "0.5.1.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.2.0 *******************

        Az.Versione = "000000.43"
        Az.Descrizione = "Aggiunta pec su esportazione"
        Az.Routine = AddressOf RT00043_AddPecExp
        Az.RequiredAppVersion = "0.5.2.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.3.0 *******************

        Az.Versione = "000000.44"
        Az.Descrizione = "Aggiunta prodotti dichiarati"
        Az.Routine = AddressOf RT00044_AddProdottiDichiarati
        Az.RequiredAppVersion = "0.5.3.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.4.0 *******************

        Az.Versione = "000000.45"
        Az.Descrizione = "Aggiornamento versione - Controllo stati"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.5.4.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.5.0 *******************

        Az.Versione = "000000.46"
        Az.Descrizione = "Aggiornamento versione - Gestione rateizzazione"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.5.5.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.6.0 *******************

        Az.Versione = "000000.47"
        Az.Descrizione = "Aggiornamento versione - Gestione rateizzazione seconda scadenza 2020"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.5.6.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.7.0 *******************

        Az.Versione = "000000.48"
        Az.Descrizione = "Aggiornamento versione - Evento aziende notifica ruolo"
        Az.Routine = AddressOf RT00048_EANotificaRuolo
        Az.RequiredAppVersion = "0.5.7.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.8.0 *******************

        Az.Versione = "000000.49"
        Az.Descrizione = "Aggiunta evento Recesso per Ecopolietilene "
        Az.Routine = AddressOf RT00049_AddEvRevEc
        Az.RequiredAppVersion = "0.5.8.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.5.9.0 *******************

        Az.Versione = "000000.50"
        Az.Descrizione = "Gestione modifiche Scheda Adesione - Dichiarazioni 2021"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.5.9.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.6.0.0 *******************

        Az.Versione = "000000.51"
        Az.Descrizione = "Aggiunta evento Autorizzazioni"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.6.0.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.6.1.0 *******************

        Az.Versione = "000000.52"
        Az.Descrizione = "Modifica stato dichiarazioni / Aggiornamento CR"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.6.1.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.6.2.0 *******************

        Az.Versione = "000000.53"
        Az.Descrizione = "Correzione acquisizione prodotti"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.6.2.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.6.3.0 *******************

        Az.Versione = "000000.54"
        Az.Descrizione = "Chiamate via Asterisk"
        Az.Routine = AddressOf CambioVersione
        Az.RequiredAppVersion = "0.6.3.0"
        Controlli.Add(Az)

        '********** VERSIONE 0.6.4.0 *******************

        Az.Versione = "000000.55"
        Az.Descrizione = "Adegumento risoluzione font"
        Az.Routine = AddressOf RT00055_AddKeyProdotti
        Az.RequiredAppVersion = "0.6.4.0"
        Controlli.Add(Az)


    End Sub

    Protected Overrides Sub OnLeggiVersione(ByRef V As String)
        V = CommonConfig.VersioneDB
    End Sub

    Protected Overrides Sub OnScriviVersione(ByVal V As String)
        CommonConfig.VersioneDB = V
        CommonConfig.SalvaDati()
    End Sub

    Protected Overrides Sub OnScriviRequiredAppversion(ByVal V As String)
        CommonConfig.VersioneApplicazione = V
        CommonConfig.SalvaDati()
    End Sub




#Region "Routine aggiornamento"

    Private Function RT00002_AggiuntaTabellaIVA(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteTabella("lookup.AliquotaIVA") Then
                Sql = "Create Table lookup.AliquotaIVA(" _
                    & "Valore real not null primary key" _
                    & ",DataIniziale smalldatetime" _
                    & ",DataFinale smalldatetime)"
                SSHelper.ExecDbQuery(Sql)
            End If
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


    Private Function RT00003_AggiuntaChiusuraEvento(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("EventoAzienda", "Stato") Then
                Sql = "Alter Table EventoAzienda " _
                    & "Add Stato varchar(20)" 
                SSHelper.ExecDbQuery(Sql)
            End If
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00004_ModViewCDA(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            Me.RemoveDbView("vwPassaggioCDA")
            Sql = "Create view [dbo].[vwPassaggioCDA]  " & vbCr _
            & "as " & vbCr _
            & "with taz as  " & vbCr _
            & "(Select * from Azienda where CodTipoIscrizione not in('ARC_STO','ASS_CAT','MOD_SCH')) " & vbCr _
            & "select  " & vbCr _
            & "	Id " & vbCr _
            & "	,RagioneSociale " & vbCr _
            & "	,Localita  " & vbCr _
            & "	,provincia  " & vbCr _
            & "	,CodCategoria  " & vbCr _
            & "	,CodiceFiscale  " & vbCr _
            & "	,PartitaIVA " & vbCr _
            & "	,'NUOVO' Motivo  " & vbCr _
            & "	from taz where  " & vbCr _
            & "	(DataPassaggioCDA is null) " & vbCr _
            & "union " & vbCr _
            & "select  " & vbCr _
            & "	taz.Id " & vbCr _
            & "	,(taz.RagioneSociale+char(13)+e.Note) RagioneSociale " & vbCr _
            & "	,taz.Localita  " & vbCr _
            & "	,taz.Provincia  " & vbCr _
            & "	,taz.CodCategoria  " & vbCr _
            & "	,taz.CodiceFiscale  " & vbCr _
            & "	,taz.PartitaIVA " & vbCr _
            & "	,'RAGSOC' Motivo  " & vbCr _
            & "	from taz inner join EventoAzienda E " & vbCr _
            & "	on taz.Id=e.IdAzienda  " & vbCr _
            & "	and e.CodEvento='COMPANY_NAME_CHANGE'  " & vbCr _
            & "	and e.data is not null " & vbCr _
            & "	and isnull(E.Scadenza,'')='' " & vbCr _
            & "	and taz.DataPassaggioCDA is not null " & vbCr _
            & "union  " & vbCr _
            & "select  " & vbCr _
            & "	taz.Id " & vbCr _
            & "	,taz.RagioneSociale " & vbCr _
            & "	,taz.Localita  " & vbCr _
            & "	,taz.Provincia  " & vbCr _
            & "	,taz.CodCategoria  " & vbCr _
            & "	,taz.CodiceFiscale  " & vbCr _
            & "	,taz.PartitaIVA " & vbCr _
            & "	,'USCITA' Motivo  " & vbCr _
            & "	from taz  " & vbCr _
            & "	Where Id in (select IdAzienda from EventoAzienda where CodEvento='EXIT_FROM_POLIECO_M') " & vbCr _
            & "	and Id not in (select IdAzienda from EventoAzienda where CodEvento in ('EXIT_CDA','EXIT_PLENUM')) "
            SSHelper.ExecDbQuery(Sql)
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00005_AddSpLibroSoci(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            Me.RemoveDbStoredProcedure("getLibroSoci")
            Sql = "Create procedure getLibroSoci(@DataAssemblea smalldatetime) " & vbCr _
            & "as  " & vbCr _
            & "	with taz as  " & vbCr _
            & "	(Select * from Azienda ) " & vbCr _
            & "	select  " & vbCr _
            & "		Id " & vbCr _
            & "		,RagioneSociale " & vbCr _
            & "		,Indirizzo " & vbCr _
            & "		,Localita  " & vbCr _
            & "		,Cap " & vbCr _
            & "		,Provincia  " & vbCr _
            & "		,CodCategoria  " & vbCr _
            & "		,CodiceFiscale  " & vbCr _
            & "		,PartitaIVA " & vbCr _
            & "		,DataPassaggioCDA  " & vbCr _
            & "		,'NUOVO' Motivo  " & vbCr _
            & "		from taz where  " & vbCr _
            & "		(DataAssemblea = @DataAssemblea) " & vbCr _
            & "	union " & vbCr _
            & "	select  " & vbCr _
            & "		taz.Id " & vbCr _
            & "		,taz.RagioneSociale " & vbCr _
            & "		,taz.Indirizzo " & vbCr _
            & "		,taz.Localita  " & vbCr _
            & "		,taz.Cap " & vbCr _
            & "		,taz.Provincia  " & vbCr _
            & "		,taz.CodCategoria  " & vbCr _
            & "		,taz.CodiceFiscale  " & vbCr _
            & "		,taz.PartitaIVA " & vbCr _
            & "		,taz.DataPassaggioCDA  " & vbCr _
            & "		,'NUOVO_CRS' Motivo  " & vbCr _
            & "		from taz inner join EventoAzienda E " & vbCr _
            & "		on taz.Id=e.IdAzienda  " & vbCr _
            & "		and e.CodEvento='COMPANY_NAME_CHANGE_PASSED'  " & vbCr _
            & "		and e.data =@DataAssemblea " & vbCr _
            & "		and taz.DataAssemblea is not null " & vbCr _
            & "	union  " & vbCr _
            & "	select  " & vbCr _
            & "		taz.Id " & vbCr _
            & "		,taz.RagioneSociale " & vbCr _
            & "		,taz.Indirizzo " & vbCr _
            & "		,taz.Localita  " & vbCr _
            & "		,taz.Cap " & vbCr _
            & "		,taz.Provincia  " & vbCr _
            & "		,taz.CodCategoria  " & vbCr _
            & "		,taz.CodiceFiscale  " & vbCr _
            & "		,taz.PartitaIVA " & vbCr _
            & "		,taz.DataPassaggioCDA  " & vbCr _
            & "		,'USCITA' Motivo  " & vbCr _
            & "		from taz  " & vbCr _
            & "		Where Id in (select IdAzienda from EventoAzienda where CodEvento='EXIT_PLENUM' and Data=@DataAssemblea) and DataAssemblea is not null " & vbCr _
            & "	union " & vbCr _
            & "	select  " & vbCr _
            & "		taz.Id " & vbCr _
            & "		,(case  " & vbCr _
            & "			when CHARINDEX('Nome precedente:',e.note)=0 then e.note " & vbCr _
            & "			else " & vbCr _
            & "				ltrim(rtrim(SUBSTRING(e.note,charindex('Nome precedente:',e.note)+16,len(e.note)-charindex('Nome precedente:',e.note)+16))) " & vbCr _
            & "			end)  RagioneSociale " & vbCr _
            & "		,taz.Indirizzo " & vbCr _
            & "		,taz.Localita  " & vbCr _
            & "		,taz.Cap " & vbCr _
            & "		,taz.Provincia  " & vbCr _
            & "		,taz.CodCategoria  " & vbCr _
            & "		,taz.CodiceFiscale  " & vbCr _
            & "		,taz.PartitaIVA " & vbCr _
            & "		,taz.DataPassaggioCDA  " & vbCr _
            & "		,'USCITA_CRS' Motivo  " & vbCr _
            & "		from taz inner join EventoAzienda E " & vbCr _
            & "		on taz.Id=e.IdAzienda  " & vbCr _
            & "		and e.CodEvento='COMPANY_NAME_CHANGE_PASSED'  " & vbCr _
            & "		and e.data =@DataAssemblea " & vbCr _
            & "		and taz.DataAssemblea is not null " & vbCr _
            & "	order by Motivo,RagioneSociale  "
            SSHelper.ExecDbQuery(Sql)
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00006_AddRifArxivar(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("EventoAzienda", "RifArxivar") Then
                Sql = "Alter Table EventoAzienda " _
                    & "Add RifArxivar varchar(50)"
                SSHelper.ExecDbQuery(Sql)
            End If

            If Not EsisteCampo("Utente", "ArxivarUserId") Then
                Sql = "Alter Table Utente " _
                    & "Add ArxivarUserId varchar(150)"
                SSHelper.ExecDbQuery(Sql)
            End If

            If Not EsisteCampo("Utente", "ArxivarPassword") Then
                Sql = "Alter Table Utente " _
                    & "Add ArxivarPassword varchar(150)"
                SSHelper.ExecDbQuery(Sql)
            End If

            If Not EsisteCampo("Dichiarazione", "RifArxivar") Then
                Sql = "Alter Table Dichiarazione " _
                    & "Add RifArxivar varchar(50)"
                SSHelper.ExecDbQuery(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00007_AddRifPerScad(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("Scadenza", "RifPeriodo") Then
                Sql = "Alter Table Scadenza " _
                    & "Add RifPeriodo varchar(20)"
                SSHelper.ExecDbQuery(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00008_AddDOL(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteTabella("DichiarazioneOnLine") Then
                Sql = "create table DichiarazioneOnLine( " _
                & "	Id int not null identity(1,1) primary key " _
                & " ,Protocollo varchar(50) not null " _
                & "	,DataRicevimento smalldatetime not null " _
                & "	,Dati varchar(max) " _
                & "	,Stato varchar(20) " _
                & "	,Utente varchar(20) " _
                & "	,Anno varchar(20) " _
                & "	,Periodo varchar(20) " _
                & "	,IdAzienda int constraint fk_dol_azienda " _
                & "		foreign key references Azienda(Id) " _
                & "		on update cascade on delete set null " _
                & "	,IdDichiarazione int constraint fl_dol_dic " _
                & "		foreign key references Dichiarazione(Id) " _
                & "		on update no action on delete no action " _
                & "	,Note varchar(2000) " _
                & "	);" _
                & "create unique index ix_dol on DichiarazioneOnLine(Protocollo)"
                SSHelper.ExecDbQuery(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00009_ModGestioneDol(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            If GetColumnDataType("DichiarazioneOnLine", "Dati") <> "xml" Then
                Sql = "alter table DichiarazioneOnLine alter column Dati xml"
                SSHelper.ExecDbQuery(Sql)
            End If

            Sql = "alter table DichiarazioneOnLine alter column DataRicevimento smalldatetime null"
            SSHelper.ExecDbQuery(Sql)

            If Not EsisteCampo("DichiarazioneOnLine", "DataCompilazione") Then
                Sql = "alter table DichiarazioneOnLine add DataCompilazione smalldatetime"
                SSHelper.ExecDbQuery(Sql)
            End If


            Return True

            'Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00010_EstrazioneQuote(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            Me.RemoveDbView("vwQuoteCatA")
            Sql = "create view vwQuoteCatA as " & vbCr _
            & "select  " & vbCr _
            & "	d.IdAzienda " & vbCr _
            & "	,rd.CodQuadro  " & vbCr _
            & "	,d.Anno  " & vbCr _
            & "	,(case when rd.codUnitaMisura='KG' then 0.001 else 1 end) * rd.valore * (case when m.Codice='Rese Prodotti Nuovo' then -1 else 1 end) Valore " & vbCr _
            & "	from RigaDichiarazione rd  " & vbCr _
            & "	inner join Dichiarazione d on rd.IdDichiarazione=d.id  " & vbCr _
            & "	inner join Materiale m on rd.IdMateriale=m.id  " & vbCr _
            & "	where m.Codice in ('Contributo base','PRODOTTI cont.Nuovo','PRODOTTI cont.Vecchio','Rese Prodotti Nuovo','D3 Prodotto nuovo contributo') "
            SSHelper.ExecDbQuery(Sql)

            Me.RemoveDbView("vwQuoteCatB")
            Sql = "create view vwQuoteCatB as " & vbCr _
            & "select  " & vbCr _
            & "	d.IdAzienda " & vbCr _
            & "	,rd.CodQuadro  " & vbCr _
            & "	,d.Anno  " & vbCr _
            & "	,rd.Valore " & vbCr _
            & "	from RigaDichiarazione rd  " & vbCr _
            & "	inner join Dichiarazione d on rd.IdDichiarazione=d.id  " & vbCr _
            & "	where rd.CodQuadro='B' "
            SSHelper.ExecDbQuery(Sql)

            Me.RemoveDbView("vwQuoteCatC")
            Sql = "create view vwQuoteCatC as " & vbCr _
            & "select  " & vbCr _
            & "	d.IdAzienda " & vbCr _
            & "	,rd.CodQuadro  " & vbCr _
            & "	,d.Anno  " & vbCr _
            & "	,(case when rd.codUnitaMisura='KG' then 0.001 else 1 end) * rd.valore Valore " & vbCr _
            & "	from RigaDichiarazione rd  " & vbCr _
            & "	inner join Dichiarazione d on rd.IdDichiarazione=d.id  " & vbCr _
            & "	inner join Materiale m on rd.IdMateriale=m.id  " & vbCr _
            & "	where m.Codice in ('Rifiuti') "
            SSHelper.ExecDbQuery(Sql)

            Me.RemoveDbView("vwQuoteCatD")
            Sql = "create view vwQuoteCatD as " & vbCr _
            & "select  " & vbCr _
            & "	d.IdAzienda " & vbCr _
            & "	,rd.CodQuadro  " & vbCr _
            & "	,d.Anno  " & vbCr _
            & "	,(case when rd.codUnitaMisura='KG' then 0.001 else 1 end) * rd.valore * (case when m.Codice='Rimborso MP Nuovo' then -1 else 1 end) Valore " & vbCr _
            & "	from RigaDichiarazione rd  " & vbCr _
            & "	inner join Dichiarazione d on rd.IdDichiarazione=d.id  " & vbCr _
            & "	inner join Materiale m on rd.IdMateriale=m.id  " & vbCr _
            & "	where m.Codice in ('MP cont. Nuovo','Rimborso MP Nuovo') "
            SSHelper.ExecDbQuery(Sql)

            Me.RemoveDbView("vwQuoteCatE")
            Sql = "create view vwQuoteCatE as " & vbCr _
            & "select  " & vbCr _
            & "	d.IdAzienda " & vbCr _
            & "	,rd.CodQuadro  " & vbCr _
            & "	,d.Anno  " & vbCr _
            & "	,(case when rd.codUnitaMisura='KG' then 0.001 else 1 end) * rd.valore  Valore " & vbCr _
            & "	from RigaDichiarazione rd  " & vbCr _
            & "	inner join Dichiarazione d on rd.IdDichiarazione=d.id  " & vbCr _
            & "	inner join Materiale m on rd.IdMateriale=m.id  " & vbCr _
            & "	where m.Codice in ('Rifiuti') "
            SSHelper.ExecDbQuery(Sql)

            Me.RemoveDbStoredProcedure("getAnalisiQuote")
            Sql = "Create procedure getAnalisiQuote(@Anno int)  " & vbCr _
               & "as  " & vbCr _
               & "begin  " & vbCr _
               & "	set nocount on  " & vbCr _
               & "	set concat_null_yields_null off  " & vbCr _
               & "	declare @tq as table(CatQuota varchar(10),IdAzienda int,tot money)  " & vbCr _
               & "  " & vbCr _
               & "	insert into @tq(CatQuota,IdAzienda,tot)  " & vbCr _
               & "	select * from   " & vbCr _
               & "	(select 'A' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatA where Anno=@Anno group by IdAzienda  " & vbCr _
               & "	union select 'B' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatB where Anno=@Anno group by IdAzienda  " & vbCr _
               & "	union select 'C' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatC where Anno=@Anno group by IdAzienda  " & vbCr _
               & "	union select 'D' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatD where Anno=@Anno group by IdAzienda  " & vbCr _
               & "	union select 'E' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatE where Anno=@Anno group by IdAzienda) t  " & vbCr _
               & "	;with tcat as   " & vbCr _
               & "	(  " & vbCr _
               & "	SELECT	a1.IdAzienda  " & vbCr _
               & "			, a1.CodCategoria CAT1  " & vbCr _
               & "			,CASE  " & vbCr _
               & "				WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'A' and tq.CatQuota='A') > 0 THEN ' A'  " & vbCr _
               & "				ELSE '' END +   " & vbCr _
               & "			CASE  " & vbCr _
               & "				WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'B' and tq.CatQuota='B') > 0 THEN ' B'  " & vbCr _
               & "				ELSE '' END +   " & vbCr _
               & "			CASE  " & vbCr _
               & "				WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'C' and tq.CatQuota='C') > 0 THEN ' C'  " & vbCr _
               & "				ELSE '' END +   " & vbCr _
               & "			CASE  " & vbCr _
               & "				WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'D' and tq.CatQuota='D') > 0 THEN ' D'  " & vbCr _
               & "				ELSE '' END  AS CAT2  " & vbCr _
               & "	   FROM Attivita a1  " & vbCr _
               & "			WHERE a1.CodTipoAttivita  = 'PRI'  " & vbCr _
               & "			GROUP BY a1.IdAzienda, a1.CodCategoria  " & vbCr _
               & "	)  " & vbCr _
               & "	,taz as   " & vbCr _
               & "	(select   " & vbCr _
               & "		az.id  " & vbCr _
               & "		,az.RagioneSociale  " & vbCr _
               & "		,az.CodStato   " & vbCr _
               & "		,az.CodTipoIscrizione  " & vbCr _
               & "		,tcat.CAT1  " & vbCr _
               & "		,tcat.CAT2  " & vbCr _
               & "		,(case when StatoPagamenti ='OK' and StatoDichiarazione='OK' then 1 else 0 end) Adempimento " & vbCr _
               & "		from Azienda az left join tcat on az.Id=tcat.IdAzienda    " & vbCr _
               & "	)  " & vbCr _
               & "	,tquote as   " & vbCr _
               & "	(  " & vbCr _
               & "		select   " & vbCr _
               & "		'A' as CatQuota,taz.*,isnull(tot,0) as tot  " & vbCr _
               & "		from taz left join @tq on CatQuota='A' and taz.id=IdAzienda   " & vbCr _
               & "		where IdAzienda is not null or (taz.CAT1  ='A' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  " & vbCr _
               & "	union  " & vbCr _
               & "		select 'B',taz.*,isnull(tot,0) tot  " & vbCr _
               & "		from taz left join @tq on CatQuota='B' and taz.id=IdAzienda   " & vbCr _
               & "		where IdAzienda is not null or (taz.CAT1  ='B' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  " & vbCr _
               & "	union  " & vbCr _
               & "		select 'C',taz.*,isnull(tot,0) tot  " & vbCr _
               & "		from taz left join @tq on CatQuota='C' and taz.id=IdAzienda   " & vbCr _
               & "		where IdAzienda is not null or (taz.CAT1  ='C' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  " & vbCr _
               & "	union  " & vbCr _
               & "		select 'D',taz.*,isnull(tot,0) tot  " & vbCr _
               & "		from taz left join @tq on CatQuota='D' and taz.id=IdAzienda   " & vbCr _
               & "		where IdAzienda is not null or (taz.CAT1  ='D' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  " & vbCr _
               & "	union  " & vbCr _
               & "		select 'E',taz.*,isnull(tot,0) tot  " & vbCr _
               & "		from taz left join @tq on CatQuota='E' and taz.id=IdAzienda   " & vbCr _
               & "		where taz.CAT1='E' and (IdAzienda is not null or (taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH')))  " & vbCr _
               & "	)  " & vbCr _
               & "	select   " & vbCr _
               & "		CatQuota  " & vbCr _
               & "		,RagioneSociale  " & vbCr _
               & "      ,Cat1 " & vbCr _
               & "      ,Cat2 " & vbCr _
               & "		,((case when (Cat1<>'B' and Cat1<>CatQuota) then '['+Cat1+']' else '' end) + ltrim(rtrim(REPLACE(Cat2,CatQuota,'')))) AltreCat  " & vbCr _
               & "		,tot as Peso  " & vbCr _
               & "		,Adempimento " & vbCr _
               & "	from tquote  " & vbCr _
               & "	order by CatQuota,tot desc,ragionesociale	  " & vbCr _
               & "end   "
            SSHelper.ExecDbQuery(Sql)

            Return True


        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00011_ModSpRagSoc(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            Me.RemoveDbFunction("GetSearchableRagioneSociale")

            Sql = "CREATE FUNCTION [dbo].[GetSearchableRagioneSociale](@RS VARCHAR(2000))  " & vbCr _
            & "RETURNS VARCHAR(2000)  " & vbCr _
            & "AS  " & vbCr _
            & "BEGIN  " & vbCr _
            & "	DECLARE @RET VARCHAR(2000)  " & vbCr _
            & "	SET @RET=REPLACE(@RS,'.','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' E ','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' & ','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,'-','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,'''','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' SRL','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' SNC','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' SPA','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' SAS','')  " & vbCr _
            & "	SET @RET=REPLACE(@RET,' ','')  " & vbCr _
            & "	RETURN @RET  " & vbCr _
            & "END  "
            SSHelper.ExecDbQuery(Sql)

            Return True

            'Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00012_AddRicercaQuantitativi(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            Me.RemoveDbView("vwRicercaQuantitativi")
            Sql = "create view vwRicercaQuantitativi " & vbCr _
                & "as " & vbCr _
                & "with t1 as  " & vbCr _
                & "( " & vbCr _
                & "select  " & vbCr _
                & "	--* " & vbCr _
                & "	--codtipo,count(*),min(d.DataRicezione),max(d.dataricezione)  " & vbCr _
                & "	d.anno " & vbCr _
                & "	,d.IdAzienda  " & vbCr _
                & "	,d.Id IdDichiarazione " & vbCr _
                & "	,(case  " & vbCr _
                & "		when m.CodTipo='RESEPRODOTTI' THEN 'PRODOTTI' " & vbCr _
                & "		WHEN m.CodTipo='RIMBORSOMP' THEN 'MATERIAPRIMA' " & vbCr _
                & "		else m.CodTipo  " & vbCr _
                & "	 end) CodTipo " & vbCr _
                & "	,rd.CodQuadro  " & vbCr _
                & "	,rd.CodUnitaMisura  " & vbCr _
                & "	,rd.IdMateriale  " & vbCr _
                & "	,rd.Valore  " & vbCr _
                & "	,(case when rd.CodUnitaMisura='TN' then valore*1000 else valore end)  " & vbCr _
                & "	* (case when m.CodTipo in ('RESEPRODOTTI','RIMBORSOMP') then -1 else 1 end ) valorekg " & vbCr _
                & " from Dichiarazione d " & vbCr _
                & "	left join RigaDichiarazione rd on d.id=rd.IdDichiarazione  " & vbCr _
                & "	left join Materiale m on rd.IdMateriale =m.id " & vbCr _
                & ") " & vbCr _
                & "--select * from t1 where IdAzienda=2005 " & vbCr _
                & ",t2 as  " & vbCr _
                & "(select  " & vbCr _
                & "	anno " & vbCr _
                & "	,idAzienda " & vbCr _
                & "	,idDichiarazione " & vbCr _
                & "	,CodTipo " & vbCr _
                & "	,valorekg " & vbCr _
                & "	,row_number() over (partition by idAzienda,idDichiarazione,CodTipo,ValoreKg order by iddichiarazione) rn " & vbCr _
                & "from t1 " & vbCr _
                & ") " & vbCr _
                & "--select * from t2 where IdAzienda=2005 " & vbCr _
                & ",t3 as " & vbCr _
                & "(select	 " & vbCr _
                & "	anno " & vbCr _
                & "	,idAzienda " & vbCr _
                & "	,CodTipo " & vbCr _
                & "	,sum(valoreKg) valorekg " & vbCr _
                & "	from t2  " & vbCr _
                & "where rn=1 " & vbCr _
                & "	--and anno=2013 " & vbCr _
                & "group by anno,idAzienda,CodTipo ) " & vbCr _
                & ",t4 as " & vbCr _
                & "(select az.id " & vbCr _
                & "	,az.RagioneSociale " & vbCr _
                & "	,az.codCategoria " & vbCr _
                & "	,az.provincia " & vbCr _
                & "	,az.Regione  " & vbCr _
                & "	,t3.* " & vbCr _
                & "from azienda az  " & vbCr _
                & "	inner join t3 on az.id=t3.idAzienda " & vbCr _
                & "	--where az.codstato<>'0019' and az.CodTipoIscrizione not in ('ARC_STO','MOD_SCH') " & vbCr _
                & ") " & vbCr _
                & "select * from t4 "
            SSHelper.ExecDbQuery(Sql)

            Return True

            'Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00013_AddPec(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("Azienda", "Pec") Then
                Sql = "Alter Table Azienda Add Pec varchar(100)" 
                SSHelper.ExecDbQuery(Sql)
            End If
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00018_ModStaoDicPag(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            Sql = "alter table azienda alter column StatoDichiarazione varchar(10)"
            SSHelper.ExecDbQuery(Sql)

            Sql = "alter table azienda alter column StatoPagamenti varchar(10)"
            SSHelper.ExecDbQuery(Sql)

            Sql = " sp_refreshview 'vwRicercaAziende'"
            SSHelper.ExecDbQuery(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00021_AddSortMaterial(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            If Not EsisteCampo("MaterialeQuadro", "Posizione") Then
                Sql = "alter table MaterialeQuadro add Posizione varchar(10)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00023_AddProdotti(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteTabella("Prodotto") Then
                Sql = "Create table Prodotto (" _
                    & "Id int not null identity(1,1) primary key " _
                    & ",Descrizione varchar(100) " _
                    & ",Livello int " _
                    & ",IdRiferimento int " _
                    & "constraint fk_prod_prod foreign key references Prodotto(Id) " _
                    & "on update no action on delete no action)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            If Not EsisteTabella("AziendaProdotto") Then
                Sql = "Create table AziendaProdotto (" _
                    & "Id int not null identity(1,1) primary key " _
                    & ",IdAzienda int " _
                    & "constraint fk_ap_az foreign key references Azienda(Id) " _
                    & "on update no action on delete no action " _
                    & ",IdProdotto int " _
                    & "constraint fk_ap_prod foreign key references Prodotto(Id) " _
                    & "on update no action on delete no action " _
                    & ",TipoUtilizzo char(1)" _
                    & ",Note varchar(2000)" _
                    & ")"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            If EsisteTabella("ProdottoAzienda") Then
                SSHelper.ExecDbQuery("Drop Table ProdottoAzienda")
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00025_ModImpDOL(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("DichiarazioneOnline", "EsitoAnalisi") Then
                Sql = "Alter table DichiarazioneOnline Add EsitoAnalisi varchar(4000)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00028_AddRsPrec(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("Azienda", "RagSocPrecedenti") Then
                Sql = "Alter table Azienda Add RagSocPrecedenti varchar(4000)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            RemoveDbView("vwRicercaAziende")
            Sql = "CREATE VIEW [dbo].[vwRicercaAziende] as " & vbCr _
            & "SELECT [Id] " & vbCr _
            & "      ,[RagioneSociale] " & vbCr _
            & "      ,[CodFormaGiuridica] " & vbCr _
            & "      ,[CodStato] " & vbCr _
            & "      ,[CodInfoStato] " & vbCr _
            & "      ,[CodTipoIscrizione] " & vbCr _
            & "      ,[Associazione] " & vbCr _
            & "      ,[Indirizzo] " & vbCr _
            & "      ,[Cap] " & vbCr _
            & "      ,[Localita] " & vbCr _
            & "      ,[Provincia] " & vbCr _
            & "      ,[Regione] " & vbCr _
            & "      ,[Telefono1] " & vbCr _
            & "      ,[Telefono2] " & vbCr _
            & "      ,[Fax] " & vbCr _
            & "      ,[UsatoPerSpedizione] " & vbCr _
            & "      ,[PartitaIVA] " & vbCr _
            & "      ,[CodiceFiscale] " & vbCr _
            & "      ,[Email] " & vbCr _
            & "      ,[LegaleRappresentante] " & vbCr _
            & "      ,[CodCategoria] " & vbCr _
            & "      ,[DataInizioAttivita] " & vbCr _
            & "      ,[DataAdesione] " & vbCr _
            & "      ,[DataVersamentoUnaTantum] " & vbCr _
            & "      ,[DataPassaggioCDA] " & vbCr _
            & "      ,[DataAssemblea] " & vbCr _
            & "      ,[AllegaBilancio] " & vbCr _
            & "      ,[DocumentazioneCCIAA] " & vbCr _
            & "      ,[StatoDichiarazione] " & vbCr _
            & "      ,[StatoPagamenti] " & vbCr _
            & "      ,[QuotaAdesione] " & vbCr _
            & "	     ,[RagSocPrecedenti] " & vbCr _
            & "      ,(Telefono1+ (CASE WHEN LTRIM(RTRIM(Telefono2))<>'' THEN CHAR(13)+Telefono2 ELSE '' END )) DescrTelefoni  " & vbCr _
            & "      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='PRI') CatAttivitaPrincipale " & vbCr _
            & "      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='SEC') CatAttivitaSecondaria " & vbCr _
            & "        " & vbCr _
            & "  FROM [SociPolieco].[dbo].[Azienda] az "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00029_AddMailUrl(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("Azienda", "SitoWeb") Then
                Sql = "Alter table Azienda Add SitoWeb varchar(500)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            If Not EsisteCampo("Sede", "Email") Then
                Sql = "Alter table Sede Add Email varchar(100)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            If Not EsisteCampo("Contatto", "Email") Then
                Sql = "Alter table Contatto Add Email varchar(100)"
                SSHelper.ExecuteSqlScript(Sql)
            End If
            
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00030_ModViewRIc(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            RemoveDbView("vwRicercaAziende")
            Sql = "CREATE VIEW [dbo].[vwRicercaAziende] as " & vbCr _
            & "SELECT [Id] " & vbCr _
            & "      ,[RagioneSociale] " & vbCr _
            & "      ,[CodFormaGiuridica] " & vbCr _
            & "      ,[CodStato] " & vbCr _
            & "      ,[CodInfoStato] " & vbCr _
            & "      ,[CodTipoIscrizione] " & vbCr _
            & "      ,[Associazione] " & vbCr _
            & "      ,[Indirizzo] " & vbCr _
            & "      ,[Cap] " & vbCr _
            & "      ,[Localita] " & vbCr _
            & "      ,[Provincia] " & vbCr _
            & "      ,[Regione] " & vbCr _
            & "      ,p.cod_regione as [CodRegione] " & vbCr _
            & "      ,[Telefono1] " & vbCr _
            & "      ,[Telefono2] " & vbCr _
            & "      ,[Fax] " & vbCr _
            & "      ,[UsatoPerSpedizione] " & vbCr _
            & "      ,[PartitaIVA] " & vbCr _
            & "      ,[CodiceFiscale] " & vbCr _
            & "      ,[Email] " & vbCr _
            & "      ,[LegaleRappresentante] " & vbCr _
            & "      ,[CodCategoria] " & vbCr _
            & "      ,[DataInizioAttivita] " & vbCr _
            & "      ,[DataAdesione] " & vbCr _
            & "      ,[DataVersamentoUnaTantum] " & vbCr _
            & "      ,[DataPassaggioCDA] " & vbCr _
            & "      ,[DataAssemblea] " & vbCr _
            & "      ,[AllegaBilancio] " & vbCr _
            & "      ,[DocumentazioneCCIAA] " & vbCr _
            & "      ,[StatoDichiarazione] " & vbCr _
            & "      ,[StatoPagamenti] " & vbCr _
            & "      ,[QuotaAdesione] " & vbCr _
            & "	     ,[RagSocPrecedenti] " & vbCr _
            & "      ,(Telefono1+ (CASE WHEN LTRIM(RTRIM(Telefono2))<>'' THEN CHAR(13)+Telefono2 ELSE '' END )) DescrTelefoni  " & vbCr _
            & "      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='PRI') CatAttivitaPrincipale " & vbCr _
            & "      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='SEC') CatAttivitaSecondaria " & vbCr _
            & "        " & vbCr _
            & "  FROM [SociPolieco].[dbo].[Azienda] az " _
            & "  LEFT JOIN PROVINCIA P on az.provincia=p.codice "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00031_ModEventi(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("EventoAzienda", "IsUrgente") Then
                Sql = "Alter Table EventoAzienda " _
                    & "Add IsUrgente bit not null default 0"
                SSHelper.ExecDbQuery(Sql)
            End If

            If Not EsisteCampo("EventoAzienda", "IsChiuso") Then
                Sql = "Alter Table EventoAzienda " _
                    & "Add IsChiuso bit not null default 0"
                SSHelper.ExecDbQuery(Sql)
            End If

            If Not EsisteCampo("EventoAzienda", "DataAvviso") Then
                Sql = "Alter Table EventoAzienda " _
                    & "Add DataAvviso smalldatetime"
                SSHelper.ExecDbQuery(Sql)
            End If

            Sql = "SELECT COUNT(*) FROM Lookup.Evento where Codice='" & DAL.Enums.TipoEvento.REMINDER_M & "'"
            Dim n As Integer = SSHelper.GetDbValue(Sql, 0)
            If n = 0 Then
                Sql = "INSERT INTO Lookup.Evento(Codice,Nome,Descrizione) " _
                    & "values ('" & DAL.Enums.TipoEvento.REMINDER_M & "','Notifica','Notifica attivita su azienda')"
                SSHelper.ExecDbQuery(Sql)
            End If



            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


    Private Function RT00033_ModProspettoQuote(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            RemoveDbStoredProcedure("getAnalisiQuote")
            Sql = "CREATE procedure [dbo].[getAnalisiQuote](@Anno int)  
                    as  
                    begin  
	                    set nocount on  
	                    set concat_null_yields_null off  
	                    declare @tq as table(CatQuota varchar(10),IdAzienda int,tot money)  
  
	                    insert into @tq(CatQuota,IdAzienda,tot)  
	                    select * from   
	                    (select 'A' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatA where Anno=@Anno group by IdAzienda  
	                    union select 'B' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatB where Anno=@Anno group by IdAzienda  
	                    union select 'C' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatC where Anno=@Anno group by IdAzienda  
	                    union select 'D' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatD where Anno=@Anno group by IdAzienda  
	                    union select 'E' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatE where Anno=@Anno group by IdAzienda) t  
	                    ;with tcat as   
	                    (  
	                    SELECT	a1.IdAzienda  
			                    , a1.CodCategoria CAT1  
			                    ,CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'A' and tq.CatQuota='A') > 0 THEN ' A'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'B' and tq.CatQuota='B') > 0 THEN ' B'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'C' and tq.CatQuota='C') > 0 THEN ' C'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'D' and tq.CatQuota='D') > 0 THEN ' D'  
				                    ELSE '' END  AS CAT2  
	                       FROM Attivita a1  
			                    WHERE a1.CodTipoAttivita  = 'PRI'  
			                    GROUP BY a1.IdAzienda, a1.CodCategoria  
	                    )  
	                    ,taz as   
	                    (select   
		                    az.id  
		                    ,az.RagioneSociale  
		                    ,az.CodStato   
		                    ,az.CodTipoIscrizione  
		                    ,tcat.CAT1  
		                    ,tcat.CAT2  
		                    ,(case when StatoPagamenti ='OK' and StatoDichiarazione='OK' then 1 else 0 end) Adempimento 
		                    from Azienda az left join tcat on az.Id=tcat.IdAzienda    
	                    )  
	                    ,tquote as   
	                    (  
		                    select   
		                    'A' as CatQuota,taz.*,isnull(tot,0) as tot  
		                    from taz left join @tq on CatQuota='A' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='A' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'B',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='B' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='B' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'C',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='C' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='C' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'D',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='D' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='D' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'E',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='E' and taz.id=IdAzienda   
		                    where taz.CAT1='E' and (IdAzienda is not null or (taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH')))  
	                    )  
	                    select   
		                    Id
		                    ,CatQuota  
		                    ,RagioneSociale  
                          ,Cat1 
                          ,Cat2 
		                    ,((case when (Cat1<>'B' and Cat1<>CatQuota) then '['+Cat1+']' else '' end) + ltrim(rtrim(REPLACE(Cat2,CatQuota,'')))) AltreCat  
		                    ,tot as Peso  
		                    ,Adempimento 
	                    from tquote  
	                    order by CatQuota,tot desc,ragionesociale	  
                    end"
            SSHelper.ExecDbQuery(Sql)
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00034_ModProspettoQuote(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            RemoveDbStoredProcedure("getAnalisiQuote")
            Sql = "CREATE 
                    procedure [dbo].[getAnalisiQuote](@Anno int)  
                    as  
                    begin  
						declare @aa int
						set @aa=@Anno
	                    set nocount on  
	                    set concat_null_yields_null off  
	                    declare @tq as table(CatQuota varchar(10),IdAzienda int,tot money)  
	                    insert into @tq(CatQuota,IdAzienda,tot)  
	                    select * from   
	                    (select 'A' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatA where Anno=@aa group by IdAzienda  
	                    union select 'B' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatB where Anno=@aa group by IdAzienda  
	                    union select 'C' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatC where Anno=@aa group by IdAzienda  
	                    union select 'D' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatD where Anno=@aa group by IdAzienda  
	                    union select 'E' as CatQuota,IdAzienda,isnull(sum (valore),0) tot from vwQuoteCatE where Anno=@aa group by IdAzienda) t  
	                    
						;with tcat as   
	                    (  
	                    SELECT	a1.IdAzienda  
			                    , a1.CodCategoria CAT1  
			                    ,CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'A' and tq.CatQuota='A') > 0 THEN ' A'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'B' and tq.CatQuota='B') > 0 THEN ' B'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'C' and tq.CatQuota='C') > 0 THEN ' C'  
				                    ELSE '' END +   
			                    CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'D' and tq.CatQuota='D') > 0 THEN ' D'  
				                    ELSE '' END +
								CASE  
				                    WHEN ( SELECT count(*) AS cnt FROM @tq tq WHERE IdAzienda = a1.IdAzienda AND a1.CodCategoria <> 'E' and tq.CatQuota='E') > 0 THEN ' E'  
				                    ELSE '' END   
									AS CAT2  
	                       FROM Attivita a1  
			                    WHERE a1.CodTipoAttivita  = 'PRI'  
			                    GROUP BY a1.IdAzienda, a1.CodCategoria  
	                    )  
	                    ,taz as   
	                    (select   
		                    az.id  
		                    ,az.RagioneSociale  
		                    ,az.CodStato   
		                    ,az.CodTipoIscrizione  
		                    ,tcat.CAT1  
		                    ,tcat.CAT2  
		                    ,(case when StatoPagamenti ='OK' and StatoDichiarazione='OK' then 1 else 0 end) Adempimento 
		                    from Azienda az left join tcat on az.Id=tcat.IdAzienda    
	                    )  
	                    ,tquote as   
	                    (  
		                    select   
		                    'A' as CatQuota,taz.*,isnull(tot,0) as tot  
		                    from taz left join @tq on CatQuota='A' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='A' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'B',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='B' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='B' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'C',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='C' and taz.id=IdAzienda   
		                    where (IdAzienda is not null and taz.cat1<>'E') or (taz.CAT1  ='C' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'D',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='D' and taz.id=IdAzienda   
		                    where IdAzienda is not null or (taz.CAT1  ='D' and taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH'))  
	                    union  
		                    select 'E',taz.*,isnull(tot,0) tot  
		                    from taz left join @tq on CatQuota='E' and taz.id=IdAzienda   
		                    where taz.CAT1='E' and (IdAzienda is not null or (taz.codstato<>'0019' and taz.CodTipoIscrizione not in ('ARC_STO','MOD_SCH')))  
	                    )  
	                    select   
		                    Id
		                    ,CatQuota  
		                    ,RagioneSociale  
                          ,Cat1 
                          ,Cat2 
		                    ,((case when (Cat1<>'B' and Cat1<>CatQuota) then '['+Cat1+']' else '' end) + ltrim(rtrim(REPLACE(Cat2,CatQuota,'')))) AltreCat  
		                    ,tot as Peso  
		                    ,Adempimento 
	                    from tquote  
	                    order by CatQuota,tot desc,ragionesociale	  
                    end"
            SSHelper.ExecDbQuery(Sql)
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function



    Private Function RT00037_AggiuntaEventoRichiestaRecesso(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try

            Sql = "if not exists(SELECT * from Lookup.Evento where codice='RIC_RECESSO_M') 
                insert into Lookup.Evento(Codice,Nome) values('RIC_RECESSO_M','Ricevuta richiesta recesso')"
            SSHelper.ExecuteSqlScript(Sql)

            Sql = "if not exists(SELECT * from Lookup.Evento where codice='RIC_RECESSO_CLOSE_M') 
                insert into Lookup.Evento(Codice,Nome,CodEventoPrecedente) values('RIC_RECESSO_CLOSE_M','Chiusa richiesta recesso','RIC_RECESSO_M')"
            SSHelper.ExecuteSqlScript(Sql)

            If Not EsisteIndice("ix_AllPiva") Then
                Sql = "create unique nonclustered index ix_AllPiva on Allegati.AziendaAllegato(PartitaIva)"
                SSHelper.ExecuteSqlScript(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


    Private Function RT00038_ModDichiarazioni(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            RemoveDbView("vwRicercaDichiarazioni")
            Sql = "CREATE VIEW [dbo].[vwRicercaDichiarazioni] as
            select 	d.* 
	            ,az.RagioneSociale 
	            ,az.CodCategoria CategoriaAzienda
	            ,az.CodStato StatoAzienda
	            ,(case when exists(select * from Allegati.Allegato where IdDichiarazione=d.id) then 1 else 0 end) HasAllegato 
	            from Dichiarazione d
	            inner join Azienda az on d.IdAzienda=az.id
	            "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


    Private Function RT00040_ModificaDichiarazioni(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            RemoveDbView("vwRicercaDichiarazioni")
            Sql = "CREATE VIEW [dbo].[vwRicercaDichiarazioni] as
            select 	d.* 
			  ,CONVERT(VARCHAR(20),DataInizio,103)+' - '+CONVERT(VARCHAR(20),DataFIne,103) Periodo
	            ,az.RagioneSociale 
	            ,az.CodCategoria CategoriaAzienda
	            ,az.CodStato StatoAzienda
	            ,(case when exists(select * from Allegati.Allegato where IdDichiarazione=d.id) then 1 else 0 end) HasAllegato 
	            from Dichiarazione d
	            inner join Azienda az on d.IdAzienda=az.id
	            "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00042_ImpAllegati(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            RemoveDbFunction("GetSearchableRagioneSociale")
            Sql = "CREATE FUNCTION [dbo].[GetSearchableRagioneSociale](@RS VARCHAR(2000))  
                RETURNS VARCHAR(2000)  
                AS  
                BEGIN  
	                DECLARE @RET VARCHAR(2000)  
	                SET @RET=REPLACE(@RS,'.','')  
	                SET @RET=REPLACE(@RET,' E ','')  
	                SET @RET=REPLACE(@RET,'&','')  
	                SET @RET=REPLACE(@RET,'-','')  
	                SET @RET=REPLACE(@RET,'''','')  
	                SET @RET=REPLACE(@RET,' SRL','')  
	                SET @RET=REPLACE(@RET,' SNC','')  
	                SET @RET=REPLACE(@RET,' SPA','')  
	                SET @RET=REPLACE(@RET,' SAS','')  
	                SET @RET=REPLACE(@RET,' ','')  
	                RETURN @RET  
                END "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00043_AddPecExp(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            RemoveDbView("vwRicercaAziende")
            Sql = "CREATE VIEW [dbo].[vwRicercaAziende] as 
                SELECT [Id] 
                      ,[RagioneSociale] 
                      ,[CodFormaGiuridica] 
                      ,[CodStato] 
                      ,[CodInfoStato] 
                      ,[CodTipoIscrizione] 
                      ,[Associazione] 
                      ,[Indirizzo] 
                      ,[Cap] 
                      ,[Localita] 
                      ,[Provincia] 
                      ,[Regione] 
                      ,p.cod_regione as [CodRegione] 
                      ,[Telefono1] 
                      ,[Telefono2] 
                      ,[Fax] 
                      ,[UsatoPerSpedizione] 
                      ,[PartitaIVA] 
                      ,[CodiceFiscale] 
                      ,[Email] 
	                  ,[Pec]
                      ,[LegaleRappresentante] 
                      ,[CodCategoria] 
                      ,[DataInizioAttivita] 
                      ,[DataAdesione] 
                      ,[DataVersamentoUnaTantum] 
                      ,[DataPassaggioCDA] 
                      ,[DataAssemblea] 
                      ,[AllegaBilancio] 
                      ,[DocumentazioneCCIAA] 
                      ,[StatoDichiarazione] 
                      ,[StatoPagamenti] 
                      ,[QuotaAdesione] 
	                  ,[RagSocPrecedenti] 
                      ,(Telefono1+ (CASE WHEN LTRIM(RTRIM(Telefono2))<>'' THEN CHAR(13)+Telefono2 ELSE '' END )) DescrTelefoni  
                      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='PRI') CatAttivitaPrincipale 
                      ,(Select top 1 CodCategoria from Attivita att where IdAzienda=az.id and CodTipoAttivita='SEC') CatAttivitaSecondaria 
        
                  FROM [SociPolieco].[dbo].[Azienda] az   LEFT JOIN PROVINCIA P on az.provincia=p.codice 
	                            "
            SSHelper.ExecuteSqlScript(Sql)

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00044_AddProdottiDichiarati(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteTabella("ProdottoDichiarato") Then
                Sql = "create table ProdottoDichiarato(
	                    Id int not null identity(1,1) primary key
	                    ,IdDichiarazione int not null constraint fk_pd_dic foreign key references Dichiarazione(Id)
	                    ,Descrizione varchar(500) not null
	                    ,QtaVergine decimal
	                    ,QtaRiciclato decimal
	                    )"
                SSHelper.ExecuteSqlScript(Sql)
            End If



            Me.RemoveDbView("vwRicercaDichiarazioni")
            Sql = "create View [dbo].[vwRicercaDichiarazioni] as
            select d.*
			  ,convert(varchar(20),datainizio,103)+' - '+convert(varchar(20),datafine,103) Periodo
	            ,az.RagioneSociale 
	            ,az.CodCategoria CategoriaAzienda
	            ,az.CodStato StatoAzienda
	            ,(case when exists(select * from Allegati.Allegato where IdDichiarazione=d.id) then 1 else 0 end) HasAllegato 
				,(select count(*) from ProdottoDichiarato where IdDichiarazione=d.Id) NumProdotti
	            From Dichiarazione d
	            inner Join Azienda az on d.IdAzienda=az.id"
            SSHelper.ExecuteSqlScript(Sql)


            Return True

        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00048_EANotificaRuolo(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("EventoAzienda", "RuoloNotifica") Then
                Sql = "alter table EventoAzienda add RuoloNotifica varchar(20)"
                SSHelper.ExecuteSqlScript(Sql)
            End If
            Return True

        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


    Private Function RT00049_AddEvRevEc(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            Sql = "SELECT COUNT(*) FROM Lookup.Evento where Codice='" & DAL.Enums.TipoEvento.RECESSO_ECOPLT_M & "'"
            Dim n As Integer = SSHelper.GetDbValue(Sql, 0)
            If n = 0 Then
                Sql = "INSERT INTO Lookup.Evento(Codice,Nome,Descrizione) " _
                    & "values ('" & DAL.Enums.TipoEvento.RECESSO_ECOPLT_M & "','Recesso Ecopolietilene','Ricevuta richiesta recesso per ecopolietilene')"
                SSHelper.ExecDbQuery(Sql)
            End If
            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function

    Private Function RT00055_AddKeyProdotti(ByRef Msg As String) As Boolean
        Dim Sql As String
        Try
            If Not EsisteCampo("ProdottoDichiarato", "IdCategoria") Then

                Sql = "ALTER TABLE ProdottoDichiarato ADD IdCategoria INT"

                SSHelper.ExecDbQuery(Sql)
            End If

            Return True
        Catch ex As Exception
            Msg = ex.Message
            Return False
        End Try
    End Function


#End Region


End Class