Imports System.Text
Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestSocio

    Public Sub New()
        DAL.Generale.InitDataAccess(New DAL.DatabaseSpecific.DataAccessAdapter("server=.\ss2008;Initial Catalog=SociPolieco;User Id=intuser;password=intuser"))
        DAL.Managers.UtentiManager.Login("admin", "polieco")

    End Sub


    <TestMethod()> Public Sub IscrizioneSocioCatA()
        Dim Az As DAL.EntityClasses.AziendaEntity = AziendaEntity.GetNew
        Az.RagioneSociale = "Socio Test 1"
        Az.CodFormaGiuridica = DAL.Lookups.FormeGiuridiche.Item(0).Codice
        Az.CodTipoIscrizione = DAL.Enums.TipoSocio.SOC_ORD
        Az.CodCategoria = "A"
        Az.Indirizzo = "Via Tibaldi 1"
        Az.Cap = "60125"
        Az.Localita = "Ancona"
        Az.Provincia = "AN"
        Az.Telefono1 = "1223131313"
        Az.LegaleRappresentante = "Matteo Di Stefano"
        Az.QuotaAdesione = Lookups.QuoteAdesione.Item(0).Codice
        Az.PartitaIva = "01561240704"
        Managers.SociManager.SaveAzienda(Az)

    End Sub

    <TestMethod()> Public Sub IscrizioneSocioCatB()
        Dim Az As DAL.EntityClasses.AziendaEntity = AziendaEntity.GetNew
        Az.RagioneSociale = "Socio Test B"
        Az.CodFormaGiuridica = DAL.Lookups.FormeGiuridiche.Item(0).Codice
        Az.CodTipoIscrizione = DAL.Enums.TipoSocio.SOC_ORD
        Az.CodCategoria = "B"
        Az.Indirizzo = "Via Roma 1"
        Az.Cap = "60125"
        Az.Localita = "Ancona"
        Az.Provincia = "AN"
        Az.Telefono1 = "1223131313"
        Az.LegaleRappresentante = "BBBBBBBBB BBBBBBBBBBB"
        Az.QuotaAdesione = Lookups.QuoteAdesione.Item(0).Codice
        Az.PartitaIva = "22222222222"
        Managers.SociManager.SaveAzienda(Az)

    End Sub


End Class