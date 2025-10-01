Public Module AFSDK
    
    Public Delegate Sub dlgLogRoutine(ByVal Testo As String)
    'Public ArxivarConn As Object

    Public Sub SetSqlDbConnection(ByVal Server As String, ByVal Db As String)
        Dim ArxivarConn As Object
        ArxivarConn = CreateObject("AFSDK.ManageConnections")
        ArxivarConn.Provider = "SQL SERVER"
        ArxivarConn.Server = Server
        ArxivarConn.Database = Db
    End Sub

    Public Function RicercaDocsClasse(ByVal AreaOrg As String, ByVal ClasseDoc As String, ParamArray CampiAgg() As String) As Boolean
        Dim AF_VIS As Object
        Dim Msg As String = ""
        AF_VIS = CreateObject("AFSDK.ARX_Search")

        AF_VIS.CampiStd.Aoo = AreaOrg
        AF_VIS.CampiStd.Classe = ClasseDoc

        For Each ca As String In CampiAgg
            Dim v() As String = ca.Split(New Char() {"="}, 2)
            AF_VIS.CampiAgg.Add(v(0).Trim, v(1))
        Next

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim Risp As Integer = AF_VIS.Run()
        If Risp Then Return True

        For i As Integer = 1 To AF_VIS.Errori.Count
            Msg &= AF_VIS.Errori(i) & vbCrLf
        Next
        Throw New Exception(Msg)
    End Function


    Public Function RicercaDocsPerContatto(AreaOrg As String, Codice As String, Classe As String) As Boolean
        Dim AF_VIS As Object
        Dim Msg As String = ""
        AF_VIS = CreateObject("AFSDK.ARX_Search")

        AF_VIS.CampiStd.Classe = Classe
        AF_VIS.CampiStd.Aoo = AreaOrg
        'If IdRubrica <> "" Then AF_VIS.DatiProfilo.IdRubrica = CInt(IdRubrica)
        AF_VIS.DatiProfilo.Codice = Codice

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim Risp As Integer = AF_VIS.Run()
        If Risp Then Return True


        For i As Integer = 1 To AF_VIS.Errori.Count
            Msg &= AF_VIS.Errori(i) & vbCrLf
        Next
        Throw New Exception(Msg)

    End Function

    Public Function RicercaDocsPerNumero(AreaOrg As String, Numero As String) As Boolean
        Dim AF_VIS As Object
        Dim Msg As String = ""
        AF_VIS = CreateObject("AFSDK.ARX_Search")

        AF_VIS.CampiStd.Aoo = AreaOrg
        AF_VIS.CampiStd.Numero = Numero

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim Risp As Integer = AF_VIS.Run()
        If Risp Then Return True

        For i As Integer = 1 To AF_VIS.Errori.Count
            Msg &= AF_VIS.Errori(i) & vbCrLf
        Next
        Throw New Exception(Msg)
    End Function
    
    Public Function ApriConfigClassiDocumentali() As Boolean
        Dim Result As String
        Dim AF_CD As Object = CreateObject("AFSDK.Configura")
        Result = AF_CD.AvviaConfig
        ElaboraErrore(Result)
        Return True
    End Function

    Public Function ArchiviaDocArxivar(ByVal PathFile As String, _
                                        ByVal ID_ESTERNO As String, _
                                        ByVal AZIENDA As String, _
                                        ByVal CLASSE_DOC As String, _
                                        ByVal AOO As String, _
                                        ByVal UTENTE As String, _
                                        Optional ByVal Par As System.Collections.SortedList = Nothing) As Boolean

        Dim ArchFlowSDK As Object
        Try
            Dim Result As String
            ArchFlowSDK = CreateObject("AFSDK.Importa")
            ArchFlowSDK.IDesterno = ID_ESTERNO
            ArchFlowSDK.Azienda = AZIENDA
            ArchFlowSDK.ClasseDoc = CLASSE_DOC
            ArchFlowSDK.Aoo = AOO
            ArchFlowSDK.Utente = UTENTE
            ArchFlowSDK.NomeFile = System.IO.Path.GetFileName(PathFile)
            ArchFlowSDK.PathFile = System.IO.Path.GetDirectoryName(PathFile)
            If Not Par Is Nothing Then
                For i As Integer = 0 To Par.Count - 1
                    'ArchFlowSDK.AggiungiCampo(Par.GetKey(i), Par.GetValueList.Item(i))
                    ArchFlowSDK.AggiungiCampo(Par.GetKey(i), Par.GetByIndex(i))
                Next
            End If
            Result = ArchFlowSDK.ImportaDoc
            ElaboraErrore(Result)
            Return True
        Finally
            ArchFlowSDK = Nothing
        End Try

    End Function

    Public Function EstraiDocArxivar(ByVal CartellaOut As String, _
                                     ByVal NomeFile As String, _
                                     ByVal ID_ARXIVAR As Integer, _
                                     Optional ByVal ID_ESTERNO As String = Nothing) As Boolean

        Dim ArchFlowSDK As Object
        Try
            Dim Result As String
            ArchFlowSDK = CreateObject("AFSDK.Esporta")
            If ID_ESTERNO Is Nothing Then
                ArchFlowSDK.SystemID = ID_ARXIVAR
            Else
                ArchFlowSDK.IDesterno = ID_ESTERNO
            End If
            ArchFlowSDK.EsportaPath = CartellaOut
            ArchFlowSDK.EsportaNome = NomeFile
            If ArchFlowSDK.Esiste <> "SI" Then
                Throw New Exception("Documento inesistente")
            Else
                Result = ArchFlowSDK.EsportaDoc
                ElaboraErrore(Result)
                Return True
            End If
        Finally
            ArchFlowSDK = Nothing
        End Try

    End Function


    Public Function ArchiviaBarcode(ByVal ID_ESTERNO As String, _
                                        ByVal AZIENDA As String, _
                                        ByVal CLASSE_DOC As String, _
                                        ByVal AOO As String, _
                                        ByVal UTENTE As String, _
                                        ByVal Barcode As String, _
                                        ByVal Tipo As String, _
                                        Optional ByVal Par As System.Collections.SortedList = Nothing) As String

        Dim ArchFlowSDK As Object
        Try
            Dim Result As String
            ArchFlowSDK = CreateObject("AFSDK.Importa")
            ArchFlowSDK.IDesterno = ID_ESTERNO
            ArchFlowSDK.Azienda = AZIENDA
            ArchFlowSDK.ClasseDoc = CLASSE_DOC
            ArchFlowSDK.Aoo = AOO
            ArchFlowSDK.Utente = UTENTE
            ArchFlowSDK.TipoImporta = 2
            ArchFlowSDK.CopieBarcode = 1
            ArchFlowSDK.TipoBarcode = "FILE"
            ArchFlowSDK.EsportaPath = My.Application.Info.DirectoryPath
            RemovePreviousBarcodeImage()
            ArchFlowSDK.EsportaNome = "Barcode.bmp"

            If Not Par Is Nothing Then
                For i As Integer = 0 To Par.Count - 1
                    ArchFlowSDK.AggiungiCampo(Par.GetKey(i), Par.GetByIndex(i))
                Next
            End If
            Result = ArchFlowSDK.ImportaDoc
            If Result.Length = 0 Then Throw New Exception("Profilazione non corretta")
            If Result.StartsWith("7#") Then
                Return GetProfileArchivedID(Result.Substring(2))
            End If

            ElaboraErrore(Result)

        Finally
            ArchFlowSDK = Nothing
        End Try

    End Function

    Private Sub RemovePreviousBarcodeImage()
        Dim F() As String = System.IO.Directory.GetFiles(My.Application.Info.DirectoryPath, "barcode*.bmp")
        For i As Integer = 0 To F.Length - 1
            Try
                System.IO.File.Delete(F(i))
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        Next
    End Sub

    Private Function GetProfileArchivedID(ByVal Result As String) As String

        Dim M As String = System.Text.RegularExpressions.Regex.Match(Result, "System ID: \d+", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value
        If M.Length > 11 Then
            Return M.Substring(11)
        Else
            Return ""
        End If
    End Function

    Private Sub ElaboraErrore(ByVal Risultato As String)
        Dim MatError() As String

        If Risultato & "" = "" Then Return

        If Risultato.IndexOf("#") = -1 Then Throw New Exception(Risultato)
        If Risultato.Length <> 0 Then
            MatError = Split(Risultato, "#")
            If Val(MatError(0)) = 7 Then Return
        End If
        Dim Descr As String = "?"
        Select Case Val(MatError(0))
            Case 0
                Descr = MatError(1)                 ' Errore generico di vb
            Case 1
                Descr = "Il campo " & MatError(1) & " è obbligatorio mentre il valore del campo " & MatError(2) & " è vuoto "
            Case 2
                Descr = "Il campo " & MatError(1) & " è un numero mentre il valore del campo " & MatError(2) & " è :" & MatError(3)
            Case 3
                Descr = "Il campo " & MatError(1) & " è una data mentre il valore del campo " & MatError(2) & " è :" & MatError(3)
            Case 4
                Descr = MatError(1) ' Errore nella compressione zip
            Case 5
                Descr = MatError(1) & " la stringa di connessione è :" & MatError(2)  ' Errore Connessione DB
            Case 6
                Descr = MatError(1)  ' Errore logico di ARCHflow (ex: documento sottoposto a processo di workflow, oppure documento aperto )
        End Select
        Throw New Exception(Descr)
    End Sub

    Public Function EsistonoDocumenti(ByVal ConnDb As String, ByVal AOO As String, ByVal Mat As String) As Boolean
        Dim Sql As String
        Mat = Mat.Replace("'", "''")
        Sql = "SELECT COUNT (*) FROM DM_DATIPROFILO DP INNER JOIN DM_PROFILE P " _
            & "ON DP.DOCNUMBER=P.DOCNUMBER " _
            & "WHERE P.AOO='" & AOO & "' AND DP.CODICE='" & Mat & "'"
        Dim Conn As SqlClient.SqlConnection = Nothing
        Try
            Conn = New SqlClient.SqlConnection(ConnDb)
            Dim Cmd As SqlClient.SqlCommand = Conn.CreateCommand
            Cmd.CommandText = Sql
            Conn.Open()
            Dim NR As Integer = Cmd.ExecuteScalar()
            Return NR > 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If Not Conn Is Nothing AndAlso Conn.State <> ConnectionState.Closed Then Conn.Close()
        End Try
    End Function

    Public Function EliminaAzienda(ByVal ConnDb As String, ByVal Mat As String, ByVal IdRubrica As Integer) As Boolean
        Dim Sql As String
        Mat = Mat.Replace("'", "''")
        Sql = "DELETE FROM DM_RUBRICA WHERE CODICE='" & Mat & "' AND CATEGORIA=" & IdRubrica '& "' " 'AND AOO='" & AOO & "'"
        Dim Conn As SqlClient.SqlConnection = Nothing
        Try
            Conn = New SqlClient.SqlConnection(ConnDb)
            Dim Cmd As SqlClient.SqlCommand = Conn.CreateCommand
            Cmd.CommandText = Sql
            Conn.Open()
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If Not Conn Is Nothing AndAlso Conn.State <> ConnectionState.Closed Then Conn.Close()
        End Try
    End Function

    'Public Function SincronizzaRubricaAnagrafe(ByVal Mat As String, _
    '                                    ByVal AOO As String, _
    '                                    ByVal ConnAnag As String, _
    '                                    ByVal ConnArxivar As String, _
    '                                    ByVal IdRubrica As String, _
    '                                    Optional ByVal Logger As dlgLogRoutine = Nothing) As Boolean

    '    'Sincronizza dati con ARXivar escludendo le aziende cancellate
    '    Dim MaxID As Long
    '    Dim NRec As Integer
    '    Dim EffettuaLog As Boolean = Not Logger Is Nothing

    '    If ConnArxivar = "" Then Exit Function
    '    If ConnAnag = "" Then Exit Function

    '    Dim NomeDbAnag As String = mdsUtility.Utility.GetDbNameFromConnstring(ConnAnag)
    '    Dim NomeDbArxivar As String = mdsUtility.Utility.GetDbNameFromConnstring(ConnArxivar)
    '    Dim NomeSrvArxivar As String = mdsUtility.Utility.GetServerNameFromConnstring(ConnArxivar)
    '    NomeDbArxivar = "[" & NomeSrvArxivar & "]." & NomeDbArxivar

    '    'IDRub = gAppConfig.RubricaArxivar ' Generale.Proprieta.Parametro("ID_RUBRICA_AF", "-1")
    '    If IdRubrica = -1 Then Throw (New Exception("Rubrica ARXivar non definita"))

    '    If EffettuaLog Then Logger("Connessione con db ARXivar")

    '    Dim ConnDb As New SqlClient.SqlConnection(ConnAnag)
    '    Dim Cmd As New SqlClient.SqlCommand

    '    Dim Sql As String

    '    Try
    '        'Aggiornamento nominativi esistenti (JOIN)

    '        Cmd.Connection = ConnDb
    '        Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"

    '        Sql &= "UPDATE TB_AF SET " & _
    '            "TB_AF.CONTATTI=LEFT(" & EspandiRagSoc("TB_EB.") & ",125)," & _
    '            "TB_AF.FAX=LEFT(TB_EB.FAX_OPE,20)," & _
    '            "TB_AF.INDIRIZZO=LEFT(" & EspandiQryPreferenzaIndirizzo("INDIRIZZO") & "+' '+" & EspandiQryPreferenzaIndirizzo("NCIVICO") & ",50)," & _
    '            "TB_AF.LOCALITA=LEFT(" & EspandiQryPreferenzaIndirizzo("LOCALITA") & ",50)," & _
    '            "TB_AF.CAP=LEFT(" & EspandiQryPreferenzaIndirizzo("CAP") & ",5)," & _
    '            "TB_AF.PROVINCIA=LEFT(" & EspandiQryPreferenzaIndirizzo("PROV") & ",2)," & _
    '            "TB_AF.MAIL=LEFT(TB_EB.EMAIL_OPE,65)," & _
    '            "TB_AF.TEL=LEFT(TB_EB.TELEFONO_OPE,20)," & _
    '            "TB_AF.CODFIS=LEFT(TB_EB.CODICE_FISCALE,16)," & _
    '            "TB_AF.PARTIVA=LEFT(TB_EB.PIVA,20), " & _
    '            "TB_AF.AOORUBRICA='" & AOO & "' " & _
    '            "FROM " & _
    '            NomeDbArxivar & ".DBO.DM_RUBRICA AS TB_AF " & _
    '            "JOIN "
    '        If Mat = "" Then
    '            Sql &= "(SELECT * FROM " & NomeDbAnag & ".DBO.AZIENDE WHERE ISNULL(CANCELLATA,'')<>'S') AS TB_EB "
    '        Else
    '            Sql &= "(SELECT * FROM " & NomeDbAnag & ".DBO.AZIENDE WHERE MATRICOLA='" & Mat & "' AND ISNULL(CANCELLATA,'')<>'S') AS TB_EB "
    '        End If
    '        Sql &= "ON TB_AF.CODICE=TB_EB.MATRICOLA AND TB_AF.CATEGORIA=" & IdRubrica

    '        ConnDb.Open()
    '        If EffettuaLog Then Logger("Aggiornamento nominativi già inseriti")
    '        Cmd.CommandText = Sql
    '        Cmd.CommandTimeout = 600
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiornati " & (NRec / 2) & " nominativi")
    '        If Mat <> "" And NRec > 0 Then
    '            'Se ha già trovato cosa aggiornare esce
    '            Return True
    '        End If

    '        If Mat = "" Then
    '            'Eliminazione Nominativi non corrispondenti (SOLO SU AGGIORNAMENTO COMPLETO)
    '            'Elimina nominativi in rubrica che non hanno una corrisopondenza in anagrafe
    '            Sql = "DELETE FROM TR " _
    '                & "FROM " _
    '                & NomeDbArxivar & ".DBO.DM_RUBRICA TR " _
    '                & "LEFT JOIN " _
    '                & "(SELECT MATRICOLA,RAGIONE_SOCIALE FROM AZIENDE WHERE ISNULL(CANCELLATA,'')<>'S') TA " _
    '                & "ON " _
    '                & "TR.CODICE= TA.MATRICOLA " _
    '                & "WHERE TR.CATEGORIA=" & IdRubrica & " " _
    '                & "AND ISNULL(TR.CODICE,'')<>'' " _
    '                & "AND TA.MATRICOLA IS NULL "

    '            If EffettuaLog Then Logger("Eliminazione voci.")
    '            Cmd.CommandText = Sql
    '            NRec = Cmd.ExecuteNonQuery
    '            If EffettuaLog Then Logger("Eliminate " & NRec & " voci.")
    '        End If

    '        'Aggiunta nominativi mancanti
    '        'Creazione tabella temporanea (valida per la sessione corrente)
    '        'Con progressivo numerico da usare per System_ID

    '        '1) Ricavo valore iniziale progressivo

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NomeDbArxivar & ".DBO.DM_RUBRICA"
    '        If IsDBNull(Cmd.ExecuteScalar()) Then
    '            MaxID = 0
    '        Else
    '            MaxID = Cmd.ExecuteScalar()
    '        End If
    '        MaxID += 1

    '        '2) Estrazione tabella temporanea da inserire in DM_RUBRICA
    '        '   PRENDE TUTTI 


    '        If EffettuaLog Then Logger("Inserimento nuovi nominativi")
    '        Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"
    '        Sql &= "SELECT IDENTITY(int," & MaxID & ",1) AS SYSTEM_ID," & _
    '                    "LEFT(" & EspandiRagSoc("") & ",125) AS CONTATTI," & _
    '                    "LEFT(TB_EB.FAX_OPE,20) AS FAX," & _
    '                    "LEFT(" & EspandiQryPreferenzaIndirizzo("INDIRIZZO") & " +' '+" & EspandiQryPreferenzaIndirizzo("NCIVICO") & ",50) AS INDIRIZZO," & _
    '                    "LEFT(" & EspandiQryPreferenzaIndirizzo("LOCALITA") & ",50) AS LOCALITA," & _
    '                    "LEFT(" & EspandiQryPreferenzaIndirizzo("CAP") & ",5) AS CAP," & _
    '                    "LEFT(" & EspandiQryPreferenzaIndirizzo("PROV") & ",2) AS PROVINCIA," & _
    '                    "LEFT(EMAIL_OPE,65) AS MAIL," & _
    '                    "MATRICOLA AS CODICE," & _
    '                    "LEFT(TELEFONO_OPE,20) AS TEL," & _
    '                    "LEFT(CODICE_FISCALE,16) AS CODFIS," & _
    '                    "LEFT(PIVA,20) AS PARTIVA," & _
    '                    IdRubrica & " AS CATEGORIA," & _
    '                    "'A' AS STATO," & _
    '                    "'D' AS TIPO, " & _
    '                    "'" & AOO & "' AS AOORUBRICA " & _
    '                    "INTO #TMP_TAB "
    '        Sql &= "FROM (SELECT * FROM AZIENDE WHERE ISNULL(CANCELLATA,'')<>'S' "
    '        If Mat <> "" Then
    '            Sql &= " AND MATRICOLA='" & Mat & "'"
    '        End If
    '        Sql &= ") AS TB_EB " & _
    '                    "LEFT JOIN " & _
    '                    NomeDbArxivar & ".DBO.DM_RUBRICA AS TB_AF " & _
    '                    "ON TB_AF.CODICE=TB_EB.MATRICOLA " & _
    '                    "AND TB_AF.CATEGORIA=" & IdRubrica & " " & _
    '                    "WHERE TB_AF.CODICE IS NULL;"

    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Estratti [" & NRec & "] nominativi")

    '        Dim strCampi As String = "SYSTEM_ID, CONTATTI, FAX, INDIRIZZO, LOCALITA, " & _
    '                                "CAP, PROVINCIA,MAIL, CODICE, TEL, CATEGORIA, " & _
    '                                "STATO, TIPO, AOORUBRICA "
    '        Cmd.CommandText = "INSERT INTO " & NomeDbArxivar & ".DBO.DM_RUBRICA" & _
    '                          "(" & strCampi & ")" & _
    '                          "SELECT " & strCampi & " FROM #TMP_TAB"
    '        If NRec > 3000 Then
    '            'Da quando hanno messo un trigger in update sulla tabella
    '            'DM_RUBRICA le operazioni di insert sono diventate lentissime
    '            MsgBox("Attenzione l'operazione potrebbe richiedere alcuni minuti ....")
    '            Cmd.CommandTimeout = 600
    '        End If

    '        NRec = Cmd.ExecuteNonQuery()

    '        If EffettuaLog Then Logger("Aggiunti [" & (NRec / 2) & "] nominativi")


    '        '************************************************************
    '        'A partire dalla versione 4.6.19 il progressivo di dm_rubrica deve essere salvato della tabella
    '        'DM_COUNTERS

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NomeDbArxivar & ".DBO.DM_RUBRICA"
    '        Dim NewId As Integer? = Cmd.ExecuteScalar()

    '        Sql = "IF EXISTS(SELECT * FROM " & NomeDbArxivar & ".DBO.DM_COUNTERS WHERE TABELLA='DM_RUBRICA') " _
    '            & "UPDATE " & NomeDbArxivar & ".DBO.DM_COUNTERS SET COUNTER=" & NewId.GetValueOrDefault & " WHERE TABELLA='DM_RUBRICA'"
    '        Cmd.CommandText = Sql
    '        Cmd.ExecuteNonQuery()
    '        '******************************************************************




    '        '******************************************************************************************
    '        '   Aggiunta sincronizzazione tabella DM_CONTATTI
    '        '   A partire dalla versione 3.2.1 Arxivar richiede che
    '        '   per ogni record della tabella DM_RUBRICA esista almeno 
    '        '   un record nella tabella DM_CONTATTI
    '        '
    '        '******************************************************************************************
    '        Sql = "INSERT INTO " & NomeDbArxivar & ".DBO.DM_CONTATTI(RUBRICA) " & _
    '            "SELECT TR.SYSTEM_ID AS RUBRICA " & _
    '            "FROM " & NomeDbArxivar & ".DBO.DM_CONTATTI TC " & _
    '            "RIGHT OUTER JOIN " & NomeDbArxivar & ".DBO.DM_RUBRICA TR " & _
    '            "ON TC.RUBRICA=TR.SYSTEM_ID " & _
    '            "WHERE (ISNULL(TC.RUBRICA,-1)=-1)"
    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiunti [" & NRec & "] alla tabella contatti.")

    '        Return True

    '    Catch ex As Exception
    '        If EffettuaLog Then Logger(ex.ToString)
    '    Finally
    '        If Not ConnDb Is Nothing AndAlso ConnDb.State <> ConnectionState.Closed Then ConnDb.Close()
    '    End Try
    'End Function

    'Public Function SincronizzaRubriche(ByVal Cod As String, _
    '                                    ByVal AOO As String, _
    '                                    ByVal ConnAnagrafica As String, _
    '                                    ByVal ConnArxivar As String, _
    '                                    ByVal IDRubrica As Integer, _
    '                                    ByVal TbSincr As String, _
    '                                    ByVal CmpContatto As String, _
    '                                    ByVal CmpCod As String, _
    '                                    Optional ByVal Logger As dlgLogRoutine = Nothing) As Boolean

    '    'Sincronizza dati con ARXivar
    '    Dim MaxID As Long
    '    Dim NRec As Integer
    '    Dim EffettuaLog As Boolean = Not Logger Is Nothing

    '    Dim C As New SqlClient.SqlConnectionStringBuilder(ConnArxivar)
    '    Dim NmDbAX As String = "[" & C.DataSource & "]." & C.InitialCatalog

    '    Dim CAnag As New SqlClient.SqlConnectionStringBuilder(ConnAnagrafica)
    '    Dim DbSincr As String = CAnag.InitialCatalog

    '    Try
    '        If NmDbAX = "" Then Throw (New Exception("Database Arxivar non valido."))
    '        If IDRubrica = -1 Then Throw (New Exception("Rubrica ARXivar non definita"))
    '    Catch ex As Exception
    '        If EffettuaLog Then
    '            Logger("Errore:" & ex.Message)
    '        Else
    '            MsgBox(ex.Message)
    '        End If
    '        Return False
    '    End Try

    '    If EffettuaLog Then Logger("Connessione con db ARXivar")

    '    Dim ConnDb As New SqlClient.SqlConnection(ConnAnagrafica)
    '    Dim Cmd As New SqlClient.SqlCommand


    '    Dim Sql As String
    '    Cmd.Connection = ConnDb
    '    Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"

    '    Sql &= "UPDATE TB_AX SET " & _
    '        "TB_AX.CONTATTI=LEFT(" & CmpContatto & ",125)," & _
    '        "TB_AX.FAX=LEFT(TB_EB.FAX,20)," & _
    '        "TB_AX.INDIRIZZO=LEFT(TB_EB.INDIRIZZO +' '+TB_EB.NCIVICO,50)," & _
    '        "TB_AX.LOCALITA=LEFT(TB_EB.LOCALITA,50)," & _
    '        "TB_AX.CAP=LEFT(TB_EB.CAP,5)," & _
    '        "TB_AX.PROVINCIA=LEFT(TB_EB.PROV,2)," & _
    '        "TB_AX.MAIL=LEFT(TB_EB.EMAIL,65)," & _
    '        "TB_AX.TEL=LEFT(TB_EB.TELEFONO,20)," & _
    '        "TB_AX.AOORUBRICA='" & AOO & "' " & _
    '        "FROM " & _
    '        NmDbAX & ".DBO.DM_RUBRICA AS TB_AX " & _
    '        "JOIN "
    '    If Cod = "" Then
    '        Sql &= "" & DbSincr & ".DBO." & TbSincr & " AS TB_EB "
    '    Else
    '        Sql &= "(SELECT * FROM " & DbSincr & ".DBO." & TbSincr & " WHERE " & CmpCod & "='" & Cod & "') AS TB_EB "
    '    End If
    '    Sql &= "ON TB_AX.CODICE=TB_EB." & CmpCod & " AND TB_AX.CATEGORIA=" & IDRubrica

    '    ConnDb.Open()
    '    'Aggiornamento nominativi esistenti (JOIN)
    '    Try
    '        If EffettuaLog Then Logger("Aggiornamento nominativi già inseriti")
    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiornati " & NRec & " nominativi")
    '        If Cod <> "" And NRec > 0 Then
    '            'Se ha già trovato cosa aggiornare esce
    '            ConnDb.Close()
    '            Return True
    '        End If

    '        'Aggiunta nominativi mancanti+
    '        'Creazione tabella temporanea (valida per la sessione corrente)
    '        'Con progressivo numerico da usare per System_ID

    '        '1) Ricavo valore iniziale progressivo

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NmDbAX & ".DBO.DM_RUBRICA"
    '        If IsDBNull(Cmd.ExecuteScalar()) Then
    '            MaxID = 0
    '        Else
    '            MaxID = Cmd.ExecuteScalar()
    '        End If
    '        MaxID += 1

    '        '2) Estrazione tabella temporanea da inserire in DBO
    '        '   PRENDE TUTTI 

    '        If EffettuaLog Then Logger("Inserimento nuovi nominativi")
    '        Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"
    '        Sql &= "SELECT IDENTITY(int," & MaxID & ",1) AS SYSTEM_ID," & _
    '                    "LEFT(" & CmpContatto & ",125) AS CONTATTI," & _
    '                    "LEFT(TB_EB.FAX,20) AS FAX," & _
    '                    "LEFT(TB_EB.INDIRIZZO +' '+TB_EB.NCIVICO,50) AS INDIRIZZO," & _
    '                    "LEFT(TB_EB.LOCALITA,50) AS LOCALITA," & _
    '                    "LEFT(TB_EB.CAP,5) AS CAP," & _
    '                    "LEFT(TB_EB.PROV,2) AS PROVINCIA," & _
    '                    "LEFT(TB_EB.EMAIL,65) AS MAIL," & _
    '                    "TB_EB." & CmpCod & " AS CODICE," & _
    '                    "LEFT(TB_EB.TELEFONO,20) AS TEL," & _
    '                    IDRubrica & " AS CATEGORIA," & _
    '                    "'A' AS STATO," & _
    '                    "'D' AS TIPO, " & _
    '                    "'" & AOO & "' AS AOORUBRICA " & _
    '                    "INTO #TMP_TAB "
    '        Sql &= "FROM (SELECT * FROM " & TbSincr & " "
    '        If Cod <> "" Then
    '            Sql &= " WHERE " & CmpCod & "='" & Cod & "'"
    '        End If
    '        Sql &= ") AS TB_EB " & _
    '                    "LEFT JOIN " & _
    '                    NmDbAX & ".DBO.DM_RUBRICA AS TB_AX " & _
    '                    "ON TB_AX.CODICE=TB_EB." & CmpCod & " " & _
    '                    "AND TB_AX.CATEGORIA=" & IDRubrica & " " & _
    '                    "WHERE TB_AX.CODICE IS NULL;"

    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Estratti [" & NRec & "] nominativi")

    '        Dim strCampi As String = "SYSTEM_ID, CONTATTI, FAX, INDIRIZZO, LOCALITA, " & _
    '                                "CAP, PROVINCIA,MAIL, CODICE, TEL, CATEGORIA, " & _
    '                                "STATO, TIPO, AOORUBRICA "
    '        Cmd.CommandText = "INSERT INTO " & NmDbAX & ".DBO.DM_RUBRICA" & _
    '                          "(" & strCampi & ")" & _
    '                          "SELECT " & strCampi & " FROM #TMP_TAB"
    '        If NRec > 3000 Then
    '            'Da quando hanno messo un trigger in update sulla tabella
    '            'DM_RUBRICA le operazioni di insert sono diventate lentissime
    '            MsgBox("Attenzione l'operazione potrebbe richiedere alcuni minuti ....")
    '            Cmd.CommandTimeout = 600
    '        End If

    '        NRec = Cmd.ExecuteNonQuery()

    '        If EffettuaLog Then Logger("Aggiunti [" & NRec & "] nominativi")

    '        '************************************************************
    '        'A partire dalla versione 4.6.19 il progressivo di dm_rubrica deve essere salvato della tabella
    '        'DM_COUNTERS

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NmDbAX & ".DBO.DM_RUBRICA"
    '        Dim NewId As Integer? = Cmd.ExecuteScalar()

    '        Sql = "IF EXISTS(SELECT * FROM " & NmDbAX & ".DBO.DM_COUNTERS WHERE TABELLA='DM_RUBRICA') " _
    '            & "UPDATE " & NmDbAX & ".DBO.DM_COUNTERS SET COUNTER=" & NewId.GetValueOrDefault & " WHERE TABELLA='DM_RUBRICA'"
    '        Cmd.CommandText = Sql
    '        Cmd.ExecuteNonQuery()
    '        '******************************************************************


    '        '******************************************************************************************
    '        '   Aggiunta sincronizzazione tabella DM_CONTATTI
    '        '   A partire dalla versione 3.2.1 Arxivar richiede che
    '        '   per ogni record della tabella DM_RUBRICA esista almeno 
    '        '   un record nella tabella DM_CONTATTI
    '        '
    '        '******************************************************************************************
    '        Sql = "INSERT INTO " & NmDbAX & ".DBO.DM_CONTATTI(RUBRICA) " & _
    '            "SELECT TR.SYSTEM_ID AS RUBRICA " & _
    '            "FROM " & NmDbAX & ".DBO.DM_CONTATTI TC " & _
    '            "RIGHT OUTER JOIN " & NmDbAX & ".DBO.DM_RUBRICA TR " & _
    '            "ON TC.RUBRICA=TR.SYSTEM_ID " & _
    '            "WHERE (ISNULL(TC.RUBRICA,-1)=-1)"
    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiunti [" & NRec & "] alla tabella contatti.")

    '    Catch ex As Exception
    '        If EffettuaLog Then Logger(ex.ToString)
    '    Finally
    '        If Not ConnDb Is Nothing AndAlso ConnDb.State <> ConnectionState.Closed Then ConnDb.Close()
    '    End Try


    'End Function

    'Public Function SincronizzaRubriche(ByVal Cod As String, _
    '                                   ByVal AOO As String, _
    '                                   ByVal ConnAnagrafica As String, _
    '                                   ByVal ConnArxivar As String, _
    '                                   ByVal IDRubrica As Integer, _
    '                                   ByVal TbSincr As String, _
    '                                   FieldsMapping As Collections.Generic.Dictionary(Of String, String), _
    '                                   Optional ByVal Logger As dlgLogRoutine = Nothing) As Boolean

    '    'Sincronizza dati con ARXivar
    '    Dim MaxID As Long
    '    Dim NRec As Integer
    '    Dim EffettuaLog As Boolean = Not Logger Is Nothing

    '    Dim C As New SqlClient.SqlConnectionStringBuilder(ConnArxivar)
    '    Dim NmDbAX As String = "[" & C.DataSource & "]." & C.InitialCatalog

    '    Dim CAnag As New SqlClient.SqlConnectionStringBuilder(ConnAnagrafica)
    '    Dim DbSincr As String = CAnag.InitialCatalog

    '    Try
    '        If NmDbAX = "" Then Throw (New Exception("Database Arxivar non valido."))
    '        If IDRubrica = -1 Then Throw (New Exception("Rubrica ARXivar non definita"))
    '    Catch ex As Exception
    '        If EffettuaLog Then
    '            Logger("Errore:" & ex.Message)
    '        Else
    '            MsgBox(ex.Message)
    '        End If
    '        Return False
    '    End Try

    '    If EffettuaLog Then Logger("Connessione con db ARXivar")

    '    Dim ConnDb As New SqlClient.SqlConnection(ConnAnagrafica)
    '    Dim Cmd As New SqlClient.SqlCommand

    '    Dim cmpNameCodice As String = "CODICE"
    '    Dim cmpNameDescrizione As String = "DESCRIZIONE"
    '    Dim cmpNameFax As String = "FAX"
    '    Dim cmpNameIndirizzo As String = "INDIRIZZO"
    '    Dim cmpNameLocalita As String = "LOCALITA"
    '    Dim cmpNameCap As String = "CAP"
    '    Dim cmpNameProvincia As String = "PROVINCIA"
    '    Dim cmpNameMail As String = "EMAIL"
    '    Dim cmpNameTelefono As String = "TELEFONO"

    '    If FieldsMapping IsNot Nothing Then
    '        cmpNameCodice = GetDictionaryValue(FieldsMapping, cmpNameCodice)
    '        cmpNameDescrizione = GetDictionaryValue(FieldsMapping, cmpNameDescrizione)
    '        cmpNameFax = GetDictionaryValue(FieldsMapping, cmpNameFax)
    '        cmpNameIndirizzo = GetDictionaryValue(FieldsMapping, cmpNameIndirizzo)
    '        cmpNameLocalita = GetDictionaryValue(FieldsMapping, cmpNameLocalita)
    '        cmpNameCap = GetDictionaryValue(FieldsMapping, cmpNameCap)
    '        cmpNameProvincia = GetDictionaryValue(FieldsMapping, cmpNameProvincia)
    '        cmpNameMail = GetDictionaryValue(FieldsMapping, cmpNameMail)
    '        cmpNameTelefono = GetDictionaryValue(FieldsMapping, cmpNameTelefono)
    '    End If

    '    Dim IntCodice As String 'Espressione codice nelle query interne (subquery)
    '    Dim OutCodice As String 'Espressione codice nelle query esterne (condition su join)

    '    If cmpNameCodice.Contains("{0}") Then
    '        IntCodice = String.Format(cmpNameCodice, "")
    '        OutCodice = String.Format(cmpNameCodice, "TB_EB.")
    '    Else
    '        IntCodice = cmpNameCodice
    '        OutCodice = "TB_EB." & cmpNameCodice
    '    End If

    '    Dim Sql As String
    '    Cmd.Connection = ConnDb
    '    Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"

    '    Sql &= "UPDATE TB_AX SET " & _
    '        "TB_AX.CONTATTI=LEFT(" & cmpNameDescrizione & ",125)," & _
    '        "TB_AX.FAX=LEFT(TB_EB." & cmpNameFax & ",20)," & _
    '        "TB_AX.INDIRIZZO=LEFT(TB_EB." & cmpNameIndirizzo & ",50)," & _
    '        "TB_AX.LOCALITA=LEFT(TB_EB." & cmpNameLocalita & ",50)," & _
    '        "TB_AX.CAP=LEFT(TB_EB." & cmpNameCap & ",5)," & _
    '        "TB_AX.PROVINCIA=LEFT(TB_EB." & cmpNameProvincia & ",2)," & _
    '        "TB_AX.MAIL=LEFT(TB_EB." & cmpNameMail & ",65)," & _
    '        "TB_AX.TEL=LEFT(TB_EB." & cmpNameTelefono & ",20)," & _
    '        "TB_AX.AOORUBRICA='" & AOO & "' " & _
    '        "FROM " & _
    '        NmDbAX & ".DBO.DM_RUBRICA AS TB_AX " & _
    '        "JOIN "
    '    If Cod = "" Then
    '        Sql &= "" & DbSincr & ".DBO." & TbSincr & " AS TB_EB "
    '    Else
    '        Sql &= "(SELECT * FROM " & DbSincr & ".DBO." & TbSincr & " WHERE " & IntCodice & "='" & Cod & "') AS TB_EB "
    '    End If
    '    'Sql &= "ON TB_AX.CODICE=TB_EB." & cmpNameCodice & " AND TB_AX.CATEGORIA=" & IDRubrica
    '    Sql &= "ON TB_AX.CODICE=" & OutCodice & " AND TB_AX.CATEGORIA=" & IDRubrica

    '    ConnDb.Open()
    '    'Aggiornamento nominativi esistenti (JOIN)
    '    Try
    '        If EffettuaLog Then Logger("Aggiornamento nominativi già inseriti")
    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiornati " & NRec & " nominativi")
    '        If Cod <> "" And NRec > 0 Then
    '            'Se ha già trovato cosa aggiornare esce
    '            ConnDb.Close()
    '            Return True
    '        End If

    '        'Aggiunta nominativi mancanti+
    '        'Creazione tabella temporanea (valida per la sessione corrente)
    '        'Con progressivo numerico da usare per System_ID

    '        '1) Ricavo valore iniziale progressivo

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NmDbAX & ".DBO.DM_RUBRICA"
    '        If IsDBNull(Cmd.ExecuteScalar()) Then
    '            MaxID = 0
    '        Else
    '            MaxID = Cmd.ExecuteScalar()
    '        End If
    '        MaxID += 1

    '        '2) Estrazione tabella temporanea da inserire in DBO
    '        '   PRENDE TUTTI 

    '        If EffettuaLog Then Logger("Inserimento nuovi nominativi")
    '        Sql = "SET CONCAT_NULL_YIELDS_NULL OFF;"
    '        Sql &= "SELECT IDENTITY(int," & MaxID & ",1) AS SYSTEM_ID," & _
    '                    "LEFT(" & cmpNameDescrizione & ",125) AS CONTATTI," & _
    '                    "LEFT(TB_EB." & cmpNameFax & ",20) AS FAX," & _
    '                    "LEFT(TB_EB." & cmpNameIndirizzo & ",50) AS INDIRIZZO," & _
    '                    "LEFT(TB_EB." & cmpNameLocalita & ",50) AS LOCALITA," & _
    '                    "LEFT(TB_EB." & cmpNameCap & ",5) AS CAP," & _
    '                    "LEFT(TB_EB." & cmpNameProvincia & ",2) AS PROVINCIA," & _
    '                    "LEFT(TB_EB." & cmpNameMail & ",65) AS MAIL,"
    '        '"TB_EB." & cmpNameCodice & " AS CODICE," & _
    '        Sql &= OutCodice & " AS CODICE," & _
    '                    "LEFT(TB_EB." & cmpNameTelefono & ",20) AS TEL," & _
    '                    IDRubrica & " AS CATEGORIA," & _
    '                    "'A' AS STATO," & _
    '                    "'D' AS TIPO, " & _
    '                    "'" & AOO & "' AS AOORUBRICA " & _
    '                    "INTO #TMP_TAB "
    '        Sql &= "FROM (SELECT * FROM " & TbSincr & " "
    '        If Cod <> "" Then
    '            Sql &= " WHERE " & IntCodice & "='" & Cod & "'"
    '        End If
    '        Sql &= ") AS TB_EB " & _
    '                    "LEFT JOIN " & _
    '                    NmDbAX & ".DBO.DM_RUBRICA AS TB_AX " & _
    '                    "ON TB_AX.CODICE=" & OutCodice & " " & _
    '                    "AND TB_AX.CATEGORIA=" & IDRubrica & " " & _
    '                    "WHERE TB_AX.CODICE IS NULL;"

    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Estratti [" & NRec & "] nominativi")

    '        Dim strCampi As String = "SYSTEM_ID, CONTATTI, FAX, INDIRIZZO, LOCALITA, " & _
    '                                "CAP, PROVINCIA,MAIL, CODICE, TEL, CATEGORIA, " & _
    '                                "STATO, TIPO, AOORUBRICA "
    '        Cmd.CommandText = "INSERT INTO " & NmDbAX & ".DBO.DM_RUBRICA" & _
    '                          "(" & strCampi & ")" & _
    '                          "SELECT " & strCampi & " FROM #TMP_TAB"
    '        If NRec > 3000 Then
    '            'Da quando hanno messo un trigger in update sulla tabella
    '            'DM_RUBRICA le operazioni di insert sono diventate lentissime
    '            MsgBox("Attenzione l'operazione potrebbe richiedere alcuni minuti ....")
    '            Cmd.CommandTimeout = 600
    '        End If

    '        NRec = Cmd.ExecuteNonQuery()

    '        If EffettuaLog Then Logger("Aggiunti [" & NRec & "] nominativi")

    '        '************************************************************
    '        'A partire dalla versione 4.6.19 il progressivo di dm_rubrica deve essere salvato della tabella
    '        'DM_COUNTERS

    '        Cmd.CommandText = "SELECT MAX(SYSTEM_ID) FROM " & NmDbAX & ".DBO.DM_RUBRICA"
    '        Dim NewId As Integer? = Cmd.ExecuteScalar()

    '        Sql = "IF EXISTS(SELECT * FROM " & NmDbAX & ".DBO.DM_COUNTERS WHERE TABELLA='DM_RUBRICA') " _
    '            & "UPDATE " & NmDbAX & ".DBO.DM_COUNTERS SET COUNTER=" & NewId.GetValueOrDefault & " WHERE TABELLA='DM_RUBRICA'"
    '        Cmd.CommandText = Sql
    '        Cmd.ExecuteNonQuery()
    '        '******************************************************************


    '        '******************************************************************************************
    '        '   Aggiunta sincronizzazione tabella DM_CONTATTI
    '        '   A partire dalla versione 3.2.1 Arxivar richiede che
    '        '   per ogni record della tabella DM_RUBRICA esista almeno 
    '        '   un record nella tabella DM_CONTATTI
    '        '
    '        '******************************************************************************************
    '        Sql = "INSERT INTO " & NmDbAX & ".DBO.DM_CONTATTI(RUBRICA) " & _
    '            "SELECT TR.SYSTEM_ID AS RUBRICA " & _
    '            "FROM " & NmDbAX & ".DBO.DM_CONTATTI TC " & _
    '            "RIGHT OUTER JOIN " & NmDbAX & ".DBO.DM_RUBRICA TR " & _
    '            "ON TC.RUBRICA=TR.SYSTEM_ID " & _
    '            "WHERE (ISNULL(TC.RUBRICA,-1)=-1)"
    '        Cmd.CommandText = Sql
    '        NRec = Cmd.ExecuteNonQuery()
    '        If EffettuaLog Then Logger("Aggiunti [" & NRec & "] alla tabella contatti.")

    '    Catch ex As Exception
    '        If EffettuaLog Then Logger(ex.ToString)
    '    Finally
    '        If Not ConnDb Is Nothing AndAlso ConnDb.State <> ConnectionState.Closed Then ConnDb.Close()
    '    End Try


    'End Function

    Private Function GetDictionaryValue(Dic As System.Collections.Generic.IDictionary(Of String, String), Key As String) As String
        Dim V As String = ""
        If Dic.TryGetValue(Key, V) Then
            Return V
        Else
            Return Key
        End If
    End Function

    Private Function EspandiQryPreferenzaIndirizzo(ByVal Campo As String) As String
        Return "(CASE INDIRIZZO_PREDEFINITO " & _
                "WHEN 'L' THEN " & Campo & "_LEG " & _
                "WHEN 'O' THEN " & Campo & "_OPE " & _
                "ELSE " & Campo & "_RES " & _
                "END)"
    End Function

    Private Function EspandiRagSoc(ByVal Tab As String) As String
        Return "(CASE ISNULL(" & Tab & "AZIENDA_PRINCIPALE,'') " _
            & "WHEN '' THEN " & Tab & "RAGIONE_SOCIALE " _
            & "ELSE " & Tab & "RAGIONE_SOCIALE + '-' + " & Tab & "LOCALITA_OPE + '-' + " & Tab & "INDIRIZZO_OPE " _
            & "END)"
    End Function

    Public Function GetArxivarFieldNameFromSpecificName(ByVal ConnString As String, ByVal Classe As String, ByVal ERPName As String) As String
        Classe = Classe.Replace("'", "''")
        ERPName = ERPName.Replace("'", "''")
        Dim Sql As String = "SELECT AFNAME FROM DM_SDK_SEARCH_FIELDSPEC WHERE CLASSE='" & Classe & "' AND ERPNAME='" & ERPName & "'"
        Dim ret As String
        Using Conn As New SqlClient.SqlConnection(ConnString)
            Dim cmd As SqlClient.SqlCommand = Conn.CreateCommand
            cmd.CommandText = Sql
            Conn.Open()
            ret = cmd.ExecuteScalar() & ""
        End Using
        Return ret
    End Function

    Public Sub DeleteDocuments(ByVal ConnStr As String, ByVal Ids() As Integer)

        'La funzione DeleteDoc della classe Cancella richiede di spcificare 
        'oltre l'id del documento anche l'id erp x cui se non esiste lo creo al volo

        'Uso deletedoc perche si occupa della pulizia completa delle tabelle

        'Purtroppo funziona in maniera strana: cerca nella tabella SD_ASSOCDOC il primo 
        'record che ha IDERP uguale a quello passato e ricava da questo l'IdDoc 
        'x cui l'IdDoc passato viene ignorato

        'X evitare cio' creo nella tabella SD_ASSOC un entry con un IDERP Univoco apposito



        Dim ArchFlowSDK As Object
        Try
            Dim IdErp As String

            Using Conn As New SqlClient.SqlConnection(ConnStr)

                Dim Result As String
                ArchFlowSDK = CreateObject("AFSDK.Cancella")

                Dim CmdIns As SqlClient.SqlCommand = Conn.CreateCommand
                'Dim CmdCheck As SqlClient.SqlCommand = Conn.CreateCommand
                'CmdCheck.CommandText = "SELECT TOP(1) IDERP FROM SD_ASSOCDOC WHERE DOCNUMBER=@DOCNUMBER"
                'CmdCheck.Parameters.Add("@DOCNUMBER", SqlDbType.Int)

                CmdIns.CommandText = "INSERT INTO SD_ASSOCDOC(DOCNUMBER,IDERP) VALUES(@DOCNUMBER,@IDERP)"
                CmdIns.Parameters.Add("@DOCNUMBER", SqlDbType.Int)
                CmdIns.Parameters.Add("@IDERP", SqlDbType.VarChar, 50)

                Conn.Open()

                For Each x As Integer In Ids
                    'CmdCheck.Parameters("@DOCNUMBER").Value = x
                    'IdErp = CmdCheck.ExecuteScalar() & ""
                    'If IdErp = "" Then
                    IdErp = "_DEL_" & x & "_" & DateTime.Now.Ticks
                    CmdIns.Parameters("@DOCNUMBER").Value = x
                    CmdIns.Parameters("@IDERP").Value = IdErp
                    CmdIns.ExecuteNonQuery()
                    'End If

                    ArchFlowSDK.SytemId = x
                    ArchFlowSDK.SytemIdErp = IdErp
                    Result = ArchFlowSDK.DeleteDoc() & ""
                    ElaboraErrore(Result)
                Next
                Conn.Close()
            End Using
        Finally
            ArchFlowSDK = Nothing
        End Try
    End Sub

End Module
