Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Namespace DAL.Managers
    Public Class SociManager
        Public Shared Sub NuovoSocio(Az As AziendaEntity)
            If Not Az.IsNew Then Throw New Exception("Azienda già esistente")
            Az.CodStato = Enums.StatoSocio.ATTIVO
            Az.CodInfoStato = Enums.StatoSocio.ATTIVO
        End Sub




        Public Shared Sub SaveAzienda(Az As AziendaEntity)

            'Check categoria / attivita

            Dim cc As AttivitaEntity() = (From x In Az.Attivita Where x.CodTipoAttivita = Enums.CodTipoAttivita.PRINCIPALE Select x).ToArray
            If cc.Length = 1 Then
                Az.CodCategoria = cc(0).CodCategoria
            Else
                Az.CodCategoria = ""
            End If

            Az.ValidateEntity()
            If Az.IsNew Then
                'Crea evento ingresso
                EventoAziendaEntity.GetNew(Az, Enums.TipoEvento.COMPANY_IN)

                'Crea contatto con nome rappresentante legale
                Dim ca As ContattoEntity = Az.Contatti.AddNew
                ca.CodRuolo = Enums.RuoliContatto.LEGALE_RAPPRESENTANTE
                ca.Nominativo = Az.LegaleRappresentante

            Else
                'Aggiornamento Ragioni Sociali precedenti
                Dim rrp As EntityCollection(Of EventoAziendaEntity) = GetLastEventsOfType(Az.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE, Nothing)
                If rrp Is Nothing Then
                    Az.RagSocPrecedenti = ""
                Else
                    Dim rr() As String = rrp.Select(Function(x) x.Note.Replace("Nome precedente:", "").Trim).ToArray
                    Az.RagSocPrecedenti = String.Join(" | ", rr)
                End If


            End If


            '#TODO: SISTEMARE AGGIORNAMENTO REGIONE
            Dim pe As ProvinciaEntity = Lookups.Province.FirstOrDefault(Function(x) x.Codice = Az.Provincia)
            If pe IsNot Nothing Then
                Dim re As RegioneEntity = Lookups.Regioni.FirstOrDefault(Function(x) x.Codice = pe.CodRegione)
                If re IsNot Nothing Then
                    Az.Regione = re.Descrizione
                End If
            End If

            DA.SaveEntity(Az, True, True)

        End Sub

        Public Shared Function AggiungiEvento(Az As AziendaEntity, CodEvento As String, Causale As String, Segnalazione As String, Valore As Decimal?, Note As String) As EventoAziendaEntity
            Dim ev As EventoAziendaEntity = EventoAziendaEntity.GetNew(Az, CodEvento)
            ev.Causale = Causale
            ev.Segnalazione = Segnalazione
            ev.Valore = Valore
            ev.Note = Note
            Return ev
        End Function

        Public Shared Function AggiungiEvento(IdAzienda As Integer, CodEvento As String, Causale As String, Segnalazione As String, Valore As Decimal?, Note As String) As EventoAziendaEntity
            Dim ev As EventoAziendaEntity = EventoAziendaEntity.GetNew(IdAzienda, CodEvento)
            ev.Causale = Causale
            ev.Segnalazione = Segnalazione
            ev.Valore = Valore
            ev.Note = Note
            Return ev
        End Function

        Public Shared Function UpdateStatoEventi(az As AziendaEntity) As Boolean
            Dim vv As EntityView2(Of EventoAziendaEntity) = az.Eventi.CreateView(New EntityProperty("HasPrecedente") = True Or New EntityProperty("HasSuccessivo") = True, New SortExpression(EventoAziendaFields.Data Or SortOperator.Ascending))
            For i As Integer = 0 To vv.Count - 1
                Dim ev As EventoAziendaEntity = vv(i)
                If ev.HasSuccessivo Then
                    'Cerco evento di chiusura
                    Dim find As Boolean = False
                    For j = i + 1 To vv.Count - 1
                        Dim et As EventoAziendaEntity = vv(j)
                        If et.CodEvento = ev.CodEvento Then
                            'Evento apertura ripetuto
                            'ev.Stato = Enums.StatoEvento.OPEN
                            ev.Stato = Enums.StatoEvento.DONE
                            find = True
                            Exit For
                        ElseIf et.CodEvento = ev.Evento.EventiFigli(0).Codice Then
                            ev.Stato = Enums.StatoEvento.DONE
                            find = True
                            Exit For
                        End If
                    Next
                    If Not find Then
                        ev.Stato = Enums.StatoEvento.OPEN
                    End If
                End If
            Next
            Return vv.RelatedCollection.DirtyEntities.Count > 0
        End Function

        Public Shared Function GetLastEventsOfType(IdAzienda As Integer, CodEvento As String, Condition As IPredicate) As EntityCollection(Of EventoAziendaEntity)
            Dim ret As New EntityCollection(Of EventoAziendaEntity)
            Dim pr As New PredicateExpression(EventoAziendaFields.IdAzienda = IdAzienda)
            pr.AddWithAnd(EventoAziendaFields.CodEvento = CodEvento)
            If Condition IsNot Nothing Then pr.AddWithAnd(Condition)
            DA.FetchEntityCollection(ret, New RelationPredicateBucket(pr), 0, New SortExpression(EventoAziendaFields.Data Or SortOperator.Descending))
            If ret.Count = 0 Then Return Nothing
            Return ret
        End Function

        Public Shared Sub SetDataCDA(DataCDA As DateTime, selRows() As TypedViewClasses.VwPassaggioCdaRow)
            For Each rw In selRows
                Try
                    DA.StartTransaction(IsolationLevel.ReadCommitted, "CDA")

                    Dim ev As EventoAziendaEntity
                    Dim ee As EntityCollection(Of EventoAziendaEntity)

                    If rw.Motivo = Enums.MotivoPassaggio.NUOVO Then

                        ev = AggiungiEvento(rw.Id, Enums.TipoEvento.BOARD_OF_DIR_PASSAGE, "", "", 0, String.Format("{0:d} Socio passato in CDA", DataCDA))
                        DA.SaveEntity(ev)

                        Dim az As New AziendaEntity(rw.Id)
                        az.DataPassaggioCda = DataCDA
                        DA.UpdateEntitiesDirectly(az, New RelationPredicateBucket(AziendaFields.Id = rw.Id))

                    ElseIf rw.Motivo = Enums.MotivoPassaggio.RAGIONE_SOCIALE Then
                        ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE, EventoAziendaFields.Scadenza = DBNull.Value)
                        If ee Is Nothing OrElse ee.Count = 0 Then Throw New Exception("Evento modifica ragione sociale non trovato")
                        For Each ev In ee
                            ev.Scadenza = String.Format("{0:d} Ragione sociale passata in CDA", DataCDA)
                            DA.SaveEntity(ev)
                        Next
                    ElseIf rw.Motivo = Enums.MotivoPassaggio.USCITA Then
                        'Aggiorno eventi
                        ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.EXIT_FROM_POLIECO_M, EventoAziendaFields.Scadenza = DBNull.Value)
                        If ee Is Nothing OrElse ee.Count = 0 Then Throw New Exception("Evento uscita non trovato")
                        For Each ev In ee
                            ev.Scadenza = String.Format("{0:d} Uscita passata in CDA", DataCDA)
                            DA.SaveEntity(ev)

                            'Aggiungo evento uscita
                            ev = AggiungiEvento(rw.Id, Enums.TipoEvento.EXIT_CDA, "", "", 0, String.Format("{0:d} Uscita passata in CDA", DataCDA))
                            ev.Data = DataCDA 'Nel caso di uscita la data dell'evento è quella del CDA
                            DA.SaveEntity(ev)

                        Next

                    End If

                    DA.Commit()
                Catch ex As Exception
                    DA.Rollback()
                End Try

            Next
        End Sub

        Public Shared Sub SetDataAssemblea(DataAssemblea As DateTime, selRows() As TypedViewClasses.VwPassaggioAssembleaRow)
            For Each rw In selRows
                Try
                    DA.StartTransaction(IsolationLevel.ReadCommitted, "ASSEMBLEA")

                    Dim ev As EventoAziendaEntity
                    Dim ee As EntityCollection(Of EventoAziendaEntity)

                    If rw.Motivo = Enums.MotivoPassaggio.NUOVO Then

                        Dim az As New AziendaEntity(rw.Id)
                        DA.FetchEntity(az)
                        If Not az.DataPassaggioCda.HasValue Then az.DataPassaggioCda = DataAssemblea
                        az.DataAssemblea = DataAssemblea
                        DA.SaveEntity(az)

                        ev = AggiungiEvento(rw.Id, Enums.TipoEvento.PLENUM_PASSAGE, "", "", 0, String.Format("{0:d} Socio passato in assemblea", DataAssemblea))
                        DA.SaveEntity(ev)


                    ElseIf rw.Motivo = Enums.MotivoPassaggio.RAGIONE_SOCIALE Then
                        'ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE, EventoAziendaFields.Scadenza = DBNull.Value)
                        Dim pr As New PredicateExpression
                        ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE_PASSED, Nothing)
                        If ee IsNot Nothing Then
                            pr.AddWithAnd(EventoAziendaFields.Data > ee(0).Data)
                        End If
                        ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE, pr)
                        If ee Is Nothing OrElse ee.Count = 0 Then Throw New Exception("Evento modifica ragione sociale non trovato")

                        For Each ev In ee

                            Dim prevScad As String = ev.Scadenza & ""
                            ev.Scadenza = String.Format("{0:d} Ragione sociale passata in assemblea", DataAssemblea) '!!!! Importante deve sparire CDA altrimnti la view che recupera l'elenco per assemblea non funziona
                            Dim Np As String = ev.Note
                            If prevScad <> "" Then
                                ev.Note &= vbCrLf & prevScad
                            End If

                            DA.SaveEntity(ev)

                            ev = AggiungiEvento(rw.Id, Enums.TipoEvento.COMPANY_NAME_CHANGE_PASSED, "", "", 0, Np)
                            ev.Data = DataAssemblea
                            DA.SaveEntity(ev)
                        Next

                    ElseIf rw.Motivo = Enums.MotivoPassaggio.USCITA Then
                        'Aggiorno eventi
                        ee = GetLastEventsOfType(rw.Id, Enums.TipoEvento.EXIT_FROM_POLIECO_M, Nothing)
                        If ee Is Nothing OrElse ee.Count = 0 Then Throw New Exception("Evento uscita non trovato")
                        For Each ev In ee
                            If ev.Scadenza <> "" Then ev.Scadenza &= vbCrLf
                            ev.Scadenza &= String.Format("{0:d} Uscita passata in assemblea", DataAssemblea)
                            DA.SaveEntity(ev)

                            Dim az As New AziendaEntity(rw.Id)
                            'If Not az.DataPassaggioCda.HasValue Then az.DataPassaggioCda = DataAssemblea
                            'az.DataAssemblea = DataAssemblea
                            az.CodTipoIscrizione = Enums.TipoSocio.ARC_STO
                            az.CodStato = Enums.StatoSocio.USCITO
                            az.CodInfoStato = Enums.InfoStatoSocio.USCITO
                            DA.UpdateEntitiesDirectly(az, New RelationPredicateBucket(AziendaFields.Id = rw.Id))

                            ev = AggiungiEvento(rw.Id, Enums.TipoEvento.EXIT_PLENUM, "", "", 0, String.Format("{0:d} Uscita passata in assemblea", DataAssemblea))
                            ev.Data = DataAssemblea
                            DA.SaveEntity(ev)

                            ev = AggiungiEvento(rw.Id, Enums.TipoEvento.EXIT, "", "", 0, String.Format("{0:d} Uscita passata", DataAssemblea))
                            ev.Data = DataAssemblea
                            DA.SaveEntity(ev)
                        Next

                    End If

                    DA.Commit()
                Catch ex As Exception
                    DA.Rollback()
                    Throw
                End Try

            Next
        End Sub

        'Public Shared Sub UpdateStato(Az As AziendaEntity)
        '    Dim St As String
        '    If Az.Attivita.Count = 0 Then
        '        Az.CodStato = Enums.StatoSocio.NUOVO
        '        Az.CodInfoStato = Enums.InfoStatoSocio.ISCNC_NO_ATT_PRINC
        '        Return
        '    End If

        '    If (Az.CodCategoria = "B" OrElse Az.CodCategoria = "D") AndAlso Az.Prodotti.Count = 0 Then
        '        Az.CodStato = Enums.StatoSocio.NUOVO
        '        Az.CodInfoStato = Enums.InfoStatoSocio.ISCNC_NO_PROD
        '        Return
        '    End If

        '    Az.CodStato = Enums.StatoSocio.ATTIVO
        '    Az.CodInfoStato = Enums.InfoStatoSocio.OK
        'End Sub
        Public Shared Function GetSocioByPiva(Piva As String) As AziendaEntity
            If Piva = "" Then Return Nothing
            Dim ret As New AziendaEntity
            Dim pr As New PredicateExpression(AziendaFields.PartitaIva = Piva)
            Dim se As New SortExpression(AziendaFields.CodStato Or SortOperator.Ascending) ' ATTIVO - NUOVO - USCITO
            Dim aa As New EntityCollection(Of AziendaEntity)
            DA.FetchEntityCollection(aa, New RelationPredicateBucket(pr), 2)
            If aa.Count = 0 Then Return Nothing
            Return aa(0)
        End Function


        Public Shared Function GetNuoviSociInScadenza(GG As Integer) As DataTable

            Dim Dt As Date = Date.Today
            Dt = Dt.AddDays(-GG)
            Dim sql As String
            sql = "WITH T AS " _
                & "(SELECT id" _
                & ",RagioneSociale" _
                & ",CodInfoStato" _
                & ",CodCategoria " _
                & ",(Select top 1 Data from EventoAzienda ea " _
                & "     where IdAzienda=az.id " _
                & "     and CodEvento='" & Enums.TipoEvento.LETTER_GENERATION & "' " _
                & "     order by data desc) DataLettera " _
                & "from Azienda az " _
                & "where CodStato='" & Enums.StatoSocio.NUOVO & "' " _
                & ") " _
                & "Select * from t " _
                & "where DataLettera is Null " _
                & "or DataLettera<'" & Dt.ToString("yyyyMMdd") & "' " _
                & "order by DataLettera"

            Return Generale.DbLib.GetDbTable(sql)
        End Function

        Public Shared Sub SyncronizeProdotti(Az As AziendaEntity)


            Dim pp As New PrefetchPath2(CInt(EntityType.AziendaProdottoEntity))
            pp.Add(AziendaProdottoEntity.PrefetchPathProdotto)
            DA.FetchEntityCollection(Az.AziendaProdotti, Az.GetRelationInfoAziendaProdotti, pp)

            Trace.TraceInformation("Avvio sincronizzazione prodotti")
            Dim Piva As String = Az.PartitaIva.Trim.Replace("'", "''")
            If Piva = "" Then Throw New Exception("Partita IVA non definita")

            Trace.TraceInformation("Connessione Polietile.NET")
            Dim tbAz As DataTable = SSPoliNet.GetDbTable("Select Id,RagioneSociale from azienda where PartitaIva='" & Piva & "'")
            Trace.TraceInformation("Verifica azienda")
            If tbAz.Rows.Count = 0 Then Throw New Exception("Azienda non trovata sul portale Polietile.Net")
            If tbAz.Rows.Count > 1 Then Trace.TraceWarning("Attenzione esistono più aziende con la partita iva [" & Piva & "]")

            Trace.TraceInformation(String.Format("Azienda identificata: {0}-{1}", tbAz(0)!Id, tbAz(0)!RagioneSociale))

            Trace.TraceInformation("Recupero prodotti")
            Dim tbProd As DataTable = SSPoliNet.GetDbTable("select 
                    acb.IdCategoria IdProdotto
                    ,acb.TipoUtilizzo
                    , cb.descrizione DescrizioneProdotto
                    , cb.livello LivelloProdotto  
                    , cb.Id_Riferimento IdRifProdotto    
	           from AziendaCategoriaBene acb 
                inner join CategoriaBene cb on acb.Idcategoria=cb.Id
                where acb.IdAzienda=" & tbAz(0)!Id)
            If tbProd.Rows.Count = 0 Then Throw New Exception("Nessun prodotto trovato")

            Dim p As Integer = 0
            Do While p < Az.AziendaProdotti.Count
                Dim ap As AziendaProdottoEntity = Az.AziendaProdotti(p)
                Dim rrProd() As DataRow = tbProd.Select("IdProdotto=" & ap.IdProdotto, "")
                If rrProd.Count = 0 Then
                    'Prodotto non esistente --> Cancellare
                    Trace.TraceWarning("Cancellazione prodotto " & ap.DescrProdotto)
                    Az.AziendaProdotti.RemoveAt(p)
                    DA.DeleteEntity(ap)
                Else
                    'Prodotto esistente --> Aggiornare
                    Trace.TraceInformation("Aggiornamento prodotto " & ap.DescrProdotto)
                    ap.TipoUtilizzo = rrProd(0)!TipoUtilizzo
                    DA.SaveEntity(ap, True)
                    p += 1
                End If
            Loop

            For Each rwProd In tbProd.Rows

                'Verifica se esiste il padre
                If Not IsDBNull(rwProd!IdRifProdotto) AndAlso Lookups.CategorieProdotto.FirstOrDefault(Function(x) x.Id = rwProd!IdRifProdotto) Is Nothing Then
                    Dim rwPadre As DataRow = SSPoliNet.GetDbRow($"select * from CategoriaBene where Id={rwProd!IdRifProdotto}")
                    Trace.TraceInformation($"Aggiunta macro categoria [{rwPadre!Descrizione}]")

                    Dim Sql As String = "set identity_insert prodotto on "
                    Sql &= $"insert into prodotto(Id,Descrizione,Livello,IdRiferimento) values({rwPadre!Id},'{CStr(rwPadre!Descrizione).Replace("'", "''")}',0,null)"
                    Sql &= "set identity_insert prodotto off"
                    DbLib.ExecuteSqlScript(Sql)

                    Dim newPB As New ProdottoEntity(CInt(rwProd!IdRifProdotto))
                    DA.FetchEntity(newPB)
                    Lookups.CategorieProdotto.Add(newPB)

                End If


                If Az.AziendaProdotti.FirstOrDefault(Function(x) x.IdProdotto = rwProd!IdProdotto) Is Nothing Then
                    'Prodotto non esistente --> Aggiungere
                    Dim ppp As New PrefetchPath2(CInt(EntityType.ProdottoEntity))
                    ppp.Add(ProdottoEntity.PrefetchPathProdottoPadre)

                    Dim pe As New ProdottoEntity(CInt(rwProd!IdProdotto))
                    DA.FetchEntity(pe, ppp)

                    If pe.IsNew Then
                        Trace.TraceInformation("Aggiunta prodotto " & rwProd!DescrizioneProdotto)
                        Dim Sql As String = "set identity_insert prodotto on "
                        Sql &= String.Format("insert into prodotto(Id,Descrizione,Livello,IdRiferimento) values({0},'{1}',{2},{3}) " _
                            , rwProd!IdProdotto _
                            , CStr(rwProd!DescrizioneProdotto).Replace("'", "''") _
                            , rwProd!LivelloProdotto _
                            , mdsUtility.Dataset.IsNull(rwProd!IdRifProdotto, "NULL"))
                        Sql &= "set identity_insert prodotto off"
                        DbLib.ExecuteSqlScript(Sql)
                        DA.FetchEntity(pe, ppp)
                    End If

                    Trace.TraceInformation("Aggiunta prodotto " & rwProd!DescrizioneProdotto & " ad azienda")
                    Dim azpe As AziendaProdottoEntity = Az.AziendaProdotti.AddNew
                    azpe.Prodotto = pe
                    azpe.TipoUtilizzo = rwProd!TipoUtilizzo
                    DA.SaveEntity(azpe, True)
                End If





            Next

            Trace.TraceInformation("********************************************")
            Trace.TraceInformation("Sincronizzazione completata")
        End Sub


    End Class
End Namespace
