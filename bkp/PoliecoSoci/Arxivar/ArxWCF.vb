Imports System.Collections.Generic
Imports Abletech.Arxivar
Imports Abletech.Arxivar.Entities

Public Class ArxWCF

    Public Enum ProfilemodeEnum
        FILE
        BARCODE
        UNDEFINED
    End Enum

    Private Shared _Conn As Abletech.Arxivar.Client.WCFConnectorManager
    Public Shared ReadOnly Property Conn As Client.WCFConnectorManager
        Get
            Return _Conn
        End Get
    End Property
    Public Shared Sub InitConnection(Url As String, UserId As String, Password As String, SW As String)
        If _Conn Is Nothing Then _Conn = New Client.WCFConnectorManager
        Dim risp As Entities.Enums.ArxLogOnErrorType
        _Conn.AutoReconnect = True
        _Conn.SoftwareName = SW
        risp = _Conn.Logon(UserId, Password, Url)
        If risp = Entities.Enums.ArxLogOnErrorType.None Then Return
        Throw New Exception("Errore accesso WCF - " & [Enum].GetName(risp.GetType, risp))
    End Sub


    Public Shared Function ProfileWithIdProfile(IdProfilo As Integer, _
                                          CodMittente As String, _
                                          CodDestinatario As String, _
                                          Oggetto As String, _
                                          Data As Date, _
                                          ProfileMode As ProfilemodeEnum, _
                                          FileNameOrBarcode As String, _
                                          PrintLabel As Boolean, _
                                          Parametri As Dictionary(Of String, String)) As Integer?

        Dim af As Dm_AssociaFolder = ArxWCF.Conn.ARX_DATI.Dm_AssociaFolder_GetData_By_Id(CommonConfig.ArxivarIdProfiloLetteraAccettazione)
        If af Is Nothing Then Throw New Exception("Profilo predefinito non valido")

        Dim pd As Libraries.Dm_Profile_Default = ArxWCF.Conn.ARX_DATI.Dm_Profile_Default_GetNewInstance_From_IdAssociaFolder(af.ID, True)
        Dim p As Libraries.Dm_Profile_ForInsert = pd.Dm_Profile_Insert_Base.To_Dm_Profile_ForInsert

        Dim rmitt As Dm_Rubrica = GetContattoRubrica(CodMittente)
        If rmitt Is Nothing Then Throw New Exception("Mittente non valido")
        Dim rdest As Dm_Rubrica = GetContattoRubrica(CodDestinatario)
        If rdest Is Nothing Then Throw New Exception("Destinatario non valido")

        Dim mitt, dest As Dm_DatiProfilo
        mitt = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(rmitt.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.MI)
        dest = ArxWCF.Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(rdest.SYSTEM_ID, Enums.Dm_DatiProfilo_Campo.DE)

        p.From = mitt
        If p.To.FirstOrDefault(Function(x) x.IDRUBRICA = dest.IDRUBRICA) Is Nothing Then p.To.Add(dest)

        If Oggetto = "" Then Throw New Exception("Oggetto non definito")
        p.DocName = Oggetto
        p.DataDoc = Data

        AssignParams(p, Parametri)
        Dim res As Libraries.Dm_Profile_Result

        If ProfileMode = ProfilemodeEnum.FILE Then
            If FileNameOrBarcode = "" Then Throw New Exception("File non definito")
            If Not System.IO.File.Exists(FileNameOrBarcode) Then Throw New Exception("File non trovato")
            p.File = New Arx_File(FileNameOrBarcode)
            res = ArxWCF.Conn.ARX_DATI.Dm_Profile_Insert(p)
        Else
            res = ArxWCF.Conn.ARX_DATI.Dm_Profile_Insert_For_Barcode(p, FileNameOrBarcode)
            If PrintLabel Then ArxWCF.Conn.ARX_DATI.Dm_Barcode_Print(res.PROFILE.DOCNUMBER, Enums.Dm_Barcode_TipoImpronta.N, False)
        End If
        If res.MESSAGE <> "" Then Throw New Exception(res.MESSAGE)
        Return res.PROFILE.DOCNUMBER
    End Function

    Public Shared Function ProfileWithMask(MaskId As String, _
                                           FilePath As String, _
                                           ByRef ProfileProp As Dictionary(Of String, String)) As Integer

        Try

            Cursor.Current = Cursors.WaitCursor
            Dim m As Entities.Dm_Mask = _Conn.ARX_DATI.Dm_Mask_GetData_By_ExternalId(MaskId)
            Dim p As Entities.Libraries.Dm_Profile_Insert_Base = _Conn.ARX_DATI.Dm_Profile_Default_GetNewInstance_From_DmMaskId(m.ID).Dm_Profile_Insert_Base
            Dim dt As New Entities.Libraries.Dm_Profile_Insert_For_Mask()
            dt.LoadFromDm_Profile_Insert_Base(p)
            dt.DmMaskId = m.ID

            If m.TYPE = Entities.Enums.Dm_Mask_Type.Archiviazione Then
                dt.File = New Entities.Arx_File(FilePath)
            End If

            AssignParams(dt, ProfileProp)

            'If ProfileProp IsNot Nothing Then
            '    For Each el In ProfileProp
            '        If el.Key = "CodMittente" OrElse el.Key = "CodDestinatario" Then

            '            Dim c As Entities.Dm_Rubrica = GetContattoRubrica(el.Value)
            '            If c Is Nothing Then Throw New Exception("Contatto non trovato")

            '            If el.Key = "CodMittente" Then
            '                Dim tc As Entities.Enums.Dm_DatiProfilo_Campo = Entities.Enums.Dm_DatiProfilo_Campo.MI
            '                Dim dp As Entities.Dm_DatiProfilo = _Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(c.SYSTEM_ID, tc)
            '                dt.From = dp
            '            Else
            '                Dim tc As Entities.Enums.Dm_DatiProfilo_Campo = Entities.Enums.Dm_DatiProfilo_Campo.DE
            '                Dim dp As Entities.Dm_DatiProfilo = _Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(c.SYSTEM_ID, tc)
            '                dt.To.Add(dp)
            '            End If

            '        ElseIf el.Key.StartsWith("#-") Then
            '            'Proprieta aggiuntivi
            '            Dim ab As Entities.Aggiuntivo_Base = dt.Aggiuntivi.FirstOrDefault(Function(x) x.ExternalId = el.Key.Substring(2))
            '            If ab IsNot Nothing Then
            '                ab.Set_Property_Value_By_Name("Valore", el.Value, False)
            '            End If
            '        Else
            '            'Proprieta profilo
            '            dt.Set_Property_Value_By_Name(el.Key, el.Value, False)
            '        End If
            '    Next
            'End If


            Dim res As Entities.Libraries.Dm_Profile_Result = _Conn.ARX_DATI.Dm_Profile_Insert_For_Mask(dt)
            If res.MESSAGE <> "" Then Throw New Exception(res.MESSAGE)

            If m.TYPE = Entities.Enums.Dm_Mask_Type.Barcode Then
                _Conn.ARX_DATI.Dm_Barcode_Print(res.PROFILE.DOCNUMBER, Entities.Enums.Dm_Barcode_TipoImpronta.N, False)
            End If

            Return res.PROFILE.DOCNUMBER
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Function

    Private Shared Sub AssignParams(pi As Libraries.Dm_Profile_Insert_Base, Par As Dictionary(Of String, String))
        If Par Is Nothing Then Return
        For Each el In Par
            If el.Key = "CodMittente" OrElse el.Key = "CodDestinatario" Then

                Dim c As Entities.Dm_Rubrica = GetContattoRubrica(el.Value)
                If c Is Nothing Then Throw New Exception("Contatto non trovato")

                If el.Key = "CodMittente" Then
                    Dim tc As Entities.Enums.Dm_DatiProfilo_Campo = Entities.Enums.Dm_DatiProfilo_Campo.MI
                    Dim dp As Entities.Dm_DatiProfilo = _Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(c.SYSTEM_ID, tc)
                    pi.From = dp
                Else
                    Dim tc As Entities.Enums.Dm_DatiProfilo_Campo = Entities.Enums.Dm_DatiProfilo_Campo.DE
                    Dim dp As Entities.Dm_DatiProfilo = _Conn.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdRubrica(c.SYSTEM_ID, tc)
                    pi.To.Add(dp)
                End If
            ElseIf el.Key = "Numero" Then
                pi.ProtocolloInterno = el.Value
            ElseIf el.Key.StartsWith("#-") Then
                'Proprieta aggiuntivi
                Dim ab As Entities.Aggiuntivo_Base = pi.Aggiuntivi.FirstOrDefault(Function(x) x.ExternalId = el.Key.Substring(2))
                If ab IsNot Nothing Then
                    ab.Set_Property_Value_By_Name("Valore", el.Value, False)
                End If
            Else
                'Proprieta profilo
                pi.Set_Property_Value_By_Name(el.Key, el.Value, False)
            End If
        Next
    End Sub

    Public Shared Sub OpenDocumentById(Id As Integer)
        Dim tmpPath As String = ""
        Dim tmpFile As String = ""
        Dim P As System.Diagnostics.Process = Nothing
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim f As Entities.Arx_File = _Conn.ARX_DOCUMENTI.Dm_Profile_GetDocument(Id)

            If f Is Nothing Then
                Throw New Exception("Documento non trovato. Se è stata effettuata un'archiviazione mediante BARCODE assicurarsi che il documento sia stato acquisito")
            End If

            tmpPath = System.IO.Path.GetTempPath & "SociPoliecoTemp\"
            If Not System.IO.Directory.Exists(tmpPath) Then
                System.IO.Directory.CreateDirectory(tmpPath)
            End If

            tmpFile = f.FileName

            f.SaveTo(tmpPath, tmpFile, True)
            tmpPath = tmpPath & tmpFile

            'P = System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo With {.FileName = tmpPath, .UseShellExecute = False})
            P = System.Diagnostics.Process.Start(tmpPath)
            If P IsNot Nothing Then P.WaitForExit()
        Finally
            Cursor.Current = Cursors.Default
            If P IsNot Nothing AndAlso System.IO.File.Exists(tmpPath) Then
                System.IO.File.Delete(tmpPath)
            End If
        End Try
    End Sub

    Public Shared Function GetContattoRubrica(Codice As String) As Dm_Rubrica
        If Codice = "" Then Return Nothing
        Dim vv() As String = Codice.Split(New Char() {","}, 2)
        If vv.Length > 1 Then
            Return GetContattoRubrica(vv(0), vv(1))
        Else
            Return GetContattoRubrica(Nothing, vv(0))
        End If
    End Function

    Public Shared Function GetContattoRubrica(ByVal IdRubrica As Integer?, Codice As String) As Dm_Rubrica
        Dim cc() As Entities.Dm_Rubrica = _Conn.ARX_DATI.Dm_Rubrica_Get_Data_By_Codice(Codice)
        If cc Is Nothing OrElse cc.Count = 0 Then Return Nothing
        If IdRubrica.HasValue Then
            Return cc.FirstOrDefault(Function(x) x.CATEGORIA = IdRubrica.Value)
        Else
            Return cc(0)
        End If
    End Function


    Private Shared _ContattoPredefinito As Dm_Rubrica
    Public Shared ReadOnly Property ContattoPredefinito As Dm_Rubrica
        Get
            Return _ContattoPredefinito
        End Get
    End Property

    Public Shared Sub SetContattoPredefinito(Codice As String)
        _ContattoPredefinito = GetContattoRubrica(Codice)
    End Sub

    Public Shared Sub UpdateRubrica(IdRubrica As Integer, az As DAL.EntityClasses.AziendaEntity)
        Dim ri As Libraries.Dm_Rubrica_Base
        Dim r As Dm_Rubrica = GetContattoRubrica(IdRubrica, az.Id)
        If r Is Nothing Then
            ri = ArxWCF.Conn.ARX_DATI.Dm_Rubrica_ForInsert_GetNewInstance_By_DmCatRubricheId(IdRubrica)
            ri.CODICE = az.Id
        Else
            ri = ArxWCF.Conn.ARX_DATI.Dm_Rubrica_ForUpdate_GetNewInstance_By_SystemId(r.SYSTEM_ID)
        End If
        ri.AOO = CommonConfig.ArxivarAreaOrganizzativa
        ri.AOORUBRICA = ri.AOO
        ri.CAP = az.Cap
        ri.CODFIS = az.CodiceFiscale
        ri.FAX = az.Fax
        ri.INDIRIZZO = az.Indirizzo
        ri.LOCALITA = az.Localita
        ri.MAIL = az.Email
        ri.PARTIVA = az.PartitaIva
        ri.PROVINCIA = az.Provincia
        ri.RAGIONE_SOCIALE = az.RagioneSociale
        ri.STATO = Enums.Dm_Rubrica_Stato.Active
        ri.TEL = az.Telefono1
        ri.TIPO = Enums.Dm_Rubrica_Tipo.Ditta
        If TypeOf ri Is Libraries.Dm_Rubrica_ForInsert Then
            ArxWCF.Conn.ARX_DATI.Dm_Rubrica_Insert(ri)
        Else
            ArxWCF.Conn.ARX_DATI.Dm_Rubrica_Update(ri)
        End If

    End Sub


End Class
