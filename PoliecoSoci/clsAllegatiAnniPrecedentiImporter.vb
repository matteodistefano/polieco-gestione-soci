Imports Syncfusion.XlsIO
Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses


Public Class clsAllegatiAnniPrecedentiImporter


    Private _wb As IWorkbook
    Private _ws As IWorksheet
    Private _xlsApp As IApplication
    Private _AllAdd As Integer = 0
    Private _AllMod As Integer = 0
    Private _AzAdd As Integer = 0
    Private _AzMod As Integer = 0
    Private _DettAdd As Integer = 0
    Private _DettMod As Integer = 0
    Private _NNErr As Integer = 0

    Private Class rifAzienda
        Public Property Codice As String
        Public Property RagSoc As String
        Public Property RigaStart As Integer
        Public Property RigaEnd As Integer
        Public Property IsValid As Boolean
        Public Property ErrMsg As String
        Public Property Dichiarazioni As New List(Of rifDichiarazione)
    End Class

    Private Class rifDichiarazione
        Public Property Azienda As rifAzienda
        Public Property Anno As Integer
        Public Property RigaStart As Integer
        Public Property RigaEnd As Integer
        Public Property S1 As Boolean
        Public Property S2 As Boolean
    End Class


    Public Sub New()
        _xlsApp = New ExcelEngine().Excel
    End Sub


    Public Sub AcquisisciFileAllegati(File As String, Categoria As String)
        Try
            LogView.ClearLog()
            LogView.LogTitle = "Acquisizione file"
            LogView.ShowLog()


            Trace.TraceInformation("Apertura file [" & File & "]")
            _wb = _xlsApp.Workbooks.Open(File, ExcelParseOptions.Default, False, "")
            'Test 

            _ws = _wb.Worksheets(0)
            If _ws(1, 1).Value <> "Esito" Or _ws(1, 2).Value <> "Codice" Then Throw New Exception("File non valido")

            Dim currRow As Integer = 2
            Dim lastAzienda As String = _ws(2, 2).Value
            If lastAzienda = "" Then Throw New Exception("Codice prima azienda non definito")

            Dim xxAziende As New List(Of rifAzienda)

            Do
                Try
                    If _ws(currRow, 1).Value = "FINE" Then Exit Do
                    'Ricava range righe azienda
                    Dim Az As rifAzienda = GetAzienda(currRow)
                    AddDichiarazioni(Az, currRow, Az.RigaEnd)
                    xxAziende.Add(Az)
                    currRow = Az.RigaEnd + 1
                Catch ex As Exception
                    Trace.TraceError(ex.Message)
                    _ws(currRow, 1).CellStyle.Color = Color.Red
                    _ws(currRow, 1).Value = "ERR"
                    _ws(currRow, 16).CellStyle.Color = Color.Red
                    _ws(currRow, 16).Value = ex.Message
                    currRow += 1
                End Try


            Loop

            Trace.TraceInformation("")
            Trace.TraceInformation("**************************")
            Trace.TraceInformation("")
            Trace.TraceInformation("Totale aziende riconosciute" & xxAziende.Count)

            For Each xAz In xxAziende
                AcquisisciDati(xAz, Categoria)
            Next


            Trace.TraceInformation("")
            Trace.TraceInformation("")
            Trace.TraceInformation("Acquisizione terminata")
            Trace.TraceInformation("Riepilogo")
            Trace.TraceInformation("Allegati        Aggiunti: " & _AllAdd & vbTab & "Modificati: " & _AllMod)
            Trace.TraceInformation("Aziende         Aggiunte: " & _AzAdd & vbTab & "Modificate: " & _AzMod)
            Trace.TraceInformation("Dettaglio       Aggiunti: " & _DettAdd & vbTab & "Modificate: " & _DettMod)
            Trace.TraceInformation("ERRORI: " & _NNErr)
            Trace.TraceInformation("")
            _wb.Save()


        Catch ex As Exception
            Trace.TraceError(ex.Message)
        End Try



    End Sub

    Private Function GetAzienda(StartRow As Integer) As rifAzienda
        Dim ret As New rifAzienda
        Dim r As Integer = StartRow

        Do While _ws(r, 2).Value = ""
            r += 1
        Loop
        StartRow = r


        ret.RigaStart = StartRow
        ret.Codice = _ws(r, 2).Value
        ret.RagSoc = _ws(r, 3).Value



        If ret.Codice = "" Then Throw New Exception("Codice azienda non definito")
        Do
            r += 1
        Loop Until _ws(r, 2).Value <> ""
        Dim EndRow As Integer = r - 1
        ret.RigaEnd = EndRow

        'Try
        '    Dim az As New AziendaEntity(CInt(ret.Codice))
        '    DA.FetchEntity(az)
        '    If az.IsNew Then Throw New Exception("Azienda non trovata")
        Trace.TraceInformation(String.Format("Analisi azienda {0}-{1} |||| Righe da {2} a {3}", ret.Codice, ret.RagSoc, StartRow, EndRow))
        '    ret.IsValid = True
        'Catch ex As Exception
        '    ret.IsValid = False
        '    ret.ErrMsg = ex.Message
        '    Trace.TraceError(ex.Message)
        'End Try
        Return ret


    End Function


    Private Sub AddDichiarazioni(Az As rifAzienda, rwStart As Integer, rwEnd As Integer)
        Dim r As Integer = rwStart
        Dim Anno As String = _ws(r, 4).Value
        Do While Anno = "" And r < rwEnd
            r += 1
            Anno = _ws(r, 4).Value
        Loop

        Dim dic As New rifDichiarazione
        dic.Anno = Anno
        dic.Azienda = Az
        dic.RigaStart = r
        dic.S1 = _ws(r, 5).Value <> ""
        dic.S2 = _ws(r, 6).Value <> ""
        Az.Dichiarazioni.Add(dic)

        r += 1
        Do While r < rwEnd
            If _ws(r, 4).Value <> "" Then
                dic.RigaEnd = r - 1
                Anno = _ws(r, 4).Value
                dic = New rifDichiarazione
                dic.Anno = Anno
                dic.Azienda = Az
                dic.RigaStart = r
                Az.Dichiarazioni.Add(dic)
            End If
            r += 1
        Loop
        dic.RigaEnd = r - 1

    End Sub


    Private Sub AcquisisciDati(xAz As rifAzienda, Cat As String)
        Try
            Trace.TraceInformation(String.Format("Analisi azienda {0} - {1} ||| Righe da {2} a {3}", xAz.Codice, xAz.RagSoc, xAz.RigaStart, xAz.RigaEnd))

            Dim PP As New PrefetchPath2(CInt(EntityType.AziendaEntity))
            PP.Add(AziendaEntity.PrefetchPathDichiarazioni).SubPath.Add(DichiarazioneEntity.PrefetchPathAllegato).SubPath.Add(AllegatoEntity.PrefetchPathDettaglio).SubPath.Add(DettaglioAllegatoEntity.PrefetchPathAziendaAllegato)
            Dim Az As New AziendaEntity(CInt(xAz.Codice))
            DA.FetchEntity(Az, PP)
            If Az.IsNew Then Throw New Exception(vbTab & "Azienda non trovata")
            Trace.TraceInformation(vbTab & "Trovata azienda:" & Az.RagioneSociale)

            For Each XDic In xAz.Dichiarazioni
                Try
                    Trace.TraceInformation(vbTab & "Dichiarazione anno" & XDic.Anno)
                    If _ws(XDic.RigaStart, 8).Value = "mancante" Then
                        Trace.TraceWarning(vbTab & vbTab & "Dichiarazione mancante")
                    Else
                        Dim dic As DichiarazioneEntity = Az.Dichiarazioni.FirstOrDefault(Function(x) x.Anno = XDic.Anno)
                        If dic Is Nothing Then Throw New Exception("Dichiarazione non trovata")
                        Dim all As AllegatoEntity = dic.Allegato
                        If all IsNot Nothing Then
                            Trace.TraceWarning(vbTab & vbTab & "Allegato già inserito")
                            _AllMod += 1
                        Else
                            all = New AllegatoEntity
                            all.Dichiarazione = dic
                            all.Azienda = Az
                            DA.SaveEntity(all, True)
                            _AllAdd += 1
                        End If
                        all.Anno = XDic.Anno
                        all.CategoriaAzienda = Cat
                        Dim per As String
                        If XDic.S1 And Not XDic.S2 Then
                            per = String.Format("01/01/{0}-30/06/{0}", all.Anno)
                        ElseIf Not XDic.S1 And XDic.S2 Then
                            per = String.Format("01/07/{0}-31/12/{0}", all.Anno)
                        Else
                            per = String.Format("01/01/{0}-31/12/{0}", all.Anno)
                        End If
                        all.Periodo = per



                        For riga As Integer = XDic.RigaStart To XDic.RigaEnd
                            Try
                                Dim Piva As String = _ws(riga, 10).Value
                                Piva = Piva.Replace("IT", "")
                                If Piva <> "" Then
                                    Piva = Piva.PadLeft(11, "0")
                                End If

                                Dim Azienda As String = _ws(riga, 9).Value
                                Dim Cer As String = _ws(riga, 15).Value
                                Dim Ruolo As String = _ws(riga, 7).Value
                                If Cer <> "" Then
                                    Dim azAll As New AziendaAllegatoEntity
                                    Dim find As Boolean = False
                                    If Piva <> "" Then
                                        find = DA.FetchEntityUsingUniqueConstraint(azAll, New PredicateExpression(AziendaAllegatoFields.PartitaIva Mod ("%" & Piva & "%")))
                                    End If

                                    If Not find Then
                                        Dim Fld As New EntityField2("rs", New DbFunctionCall("dbo.GetSearchableRagioneSociale", New Object() {AziendaAllegatoFields.RagioneSociale}))
                                        Dim txt As String = mdsUtility.TextUtils.GetSearchableRagioneSociale(Azienda)
                                        find = DA.FetchEntityUsingUniqueConstraint(azAll, New PredicateExpression(Fld Mod ("%" & txt & "%")))
                                    End If

                                    If Not find Then
                                        azAll = New AziendaAllegatoEntity
                                        If Piva = "" Then
                                            Piva = "#id-" & CInt(DAL.DbLib.GetDbValue("select ident_current('allegati.aziendaallegato')", 0)) + 1
                                        End If
                                        azAll.PartitaIva = Piva

                                        azAll.RagioneSociale = Azienda
                                        azAll.Localita = _ws(riga, 11).Value
                                        azAll.Nazione = _ws(riga, 12).Value
                                        DA.SaveEntity(azAll, True)
                                        _AzAdd += 1
                                    Else
                                        _AzMod += 1
                                    End If

                                    Dim ruoloAll As String
                                    If Ruolo = "ric" Then
                                        ruoloAll = Enums.RuoloAziendaAllegato.FORNITORE
                                    Else
                                        ruoloAll = Enums.RuoloAziendaAllegato.RICEVITORE
                                    End If

                                    If Lookups.CodiciCER.FirstOrDefault(Function(x) x.Codice = Cer) Is Nothing Then Throw New Exception("Cer non valido")

                                    Dim dett As DettaglioAllegatoEntity = all.Dettaglio.FirstOrDefault(Function(x) x.IdAziendaAllegato = azAll.Id And x.CodiceCer = Cer And x.RuoloAziendaAllegato = ruoloAll)
                                    Dim wasNew As Boolean = False
                                    If dett Is Nothing Then
                                        dett = all.Dettaglio.AddNew
                                        dett.IdAllegato = all.Id
                                        dett.AziendaAllegato = azAll
                                        dett.CodiceCer = Cer
                                        dett.RuoloAziendaAllegato = ruoloAll
                                        wasNew = True
                                    End If
                                    dett.Quantita = _ws(riga, 13).Value
                                    If _ws(riga, 14).Value = "t" Then
                                        dett.UnitaMisura = "tn"
                                    Else
                                        dett.UnitaMisura = _ws(riga, 14).Value
                                    End If

                                    dett.Note = "Imp.annuale"

                                    DA.SaveEntity(dett, True)
                                    If wasNew Then
                                        _DettAdd += 1
                                    Else
                                        _DettMod += 1
                                    End If

                                End If
                                _ws(riga, 1).CellStyle.Color = Color.LightGreen
                                _ws(riga, 1).Value = "OK"
                                _ws(riga, 16).Value = ""
                            Catch ex As Exception
                                Trace.TraceError(ex.Message)
                                _ws(riga, 1).CellStyle.Color = Color.Red
                                _ws(riga, 1).Value = "ERR"
                                _ws(riga, 16).CellStyle.Color = Color.Red
                                _ws(riga, 16).Value = ex.Message
                                _NNErr += 1
                            End Try



                        Next


                    End If
                Catch ex As Exception
                    Trace.TraceError(vbTab & vbTab & ex.Message)
                End Try




            Next




        Catch ex As Exception
            Trace.TraceError(ex.Message)
        End Try


    End Sub


End Class

