Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses

Namespace DAL.EntityClasses
    Partial Public Class DichiarazioneOnLineEntity

        Public Sub SetDatiCompilati(ds As Datasets.dsDichiarazione2019)
            Dim sw As New System.IO.StringWriter
            ds.WriteXml(sw)
            Me.Dati = sw.GetStringBuilder.ToString
        End Sub

        Private _DatiCompilati As Datasets.dsDichiarazione2019
        Public ReadOnly Property DatiCompilati As Datasets.dsDichiarazione2019
            Get
                If _DatiCompilati Is Nothing Then
                    _DatiCompilati = New Datasets.dsDichiarazione2019
                    Dim Buff As String = Me.Dati
                    Dim sr As New IO.StringReader(Buff)
                    _DatiCompilati.ReadXml(sr)
                End If
                Return _DatiCompilati
            End Get
        End Property

        Public ReadOnly Property HasAzienda As Boolean
            Get
                Return Me.IdAzienda.HasValue
            End Get
        End Property

        Public ReadOnly Property HasDichiarazione As Boolean
            Get
                Return Me.IdDichiarazione.HasValue
            End Get
        End Property

        Public ReadOnly Property StatoAllegatiValidati As Enums.StateCompleteEnum
            Get

                If Me.DatiCompilati.Voce.Count = 0 Then Return StateCompleteEnum.COMPLETE

                Dim N As Integer = Me.DatiCompilati.Voce.Compute("Count(IdVoce)", "IdAziendaCollegata is Null")
                If N = Me.DatiCompilati.Voce.Rows.Count Then
                    Return StateCompleteEnum.UNCOMPLETE
                ElseIf N > 0 Then
                    Return StateCompleteEnum.PARTIAL
                Else
                    Return StateCompleteEnum.COMPLETE
                End If
            End Get
        End Property

        Public ReadOnly Property DichiarazioneRagioneSociale As String
            Get
                Return GetDatasetProperty("RagioneSociale")
            End Get
        End Property

        Public ReadOnly Property DichiarazioneSedeLegale As String
            Get
                Return GetDatasetProperty("SedeLegale")
            End Get
        End Property

        Public ReadOnly Property DichiarazionePartitaIVA As String
            Get
                Return GetDatasetProperty("PartitaIVA")
            End Get
        End Property

        Private Function GetDatasetProperty(PropName As String) As String
            If DatiCompilati Is Nothing Then Return "?"
            If DatiCompilati.Dichiarazione.Count = 0 Then Return "?"
            If Not DatiCompilati.Dichiarazione.Columns.Contains(PropName) Then Return "?"
            Return DatiCompilati.Dichiarazione(0)(PropName) & ""
        End Function

        Public Sub RimuoviAssociazioneAzienda()
            If Me.Stato = Enums.StatoDOL.ASSOCIATA OrElse Me.HasDichiarazione Then Throw New Exception("E' associata una dichiarazione: impossibile disassociare l'azienda")
            Me.IdAzienda = Nothing
            Me.Stato = Enums.StatoDOL.INSERITA
        End Sub

        Public Sub AssociaAzienda(Az As AziendaEntity)
            If Me.HasAzienda Then Throw New Exception("E' già associata un'azienda")
            Me.Azienda = Az
            UpdateStato()
        End Sub

        Public ReadOnly Property HasRateizzazione As Boolean
            Get
                'If Me.Anno <> "2020" Then Return False
                'If Me.Periodo <> "S1" Then Return False
                Return (Me.GetDatasetProperty("Rateizzazione").ToUpper = "S")
            End Get
        End Property

        Public Sub AddRateizzazioni(dic As DichiarazioneEntity)

            If Not Me.HasRateizzazione Then Return

            Dim d(2) As Date
            If Me.Periodo = "S1" Then
                d(0) = DateSerial(Me.Anno, 7, 31)
                d(1) = DateSerial(Me.Anno, 9, 30)
                d(2) = DateSerial(Me.Anno, 11, 30)
            Else
                d(0) = DateSerial(Me.Anno + 1, 1, 31)
                d(1) = DateSerial(Me.Anno + 1, 3, 31)
                d(2) = DateSerial(Me.Anno + 1, 5, 31)
            End If

            Dim Tot As Decimal = dic.RigheDettaglio.Sum(Function(x) x.ImportoLordo)
            Dim ImpRata As Decimal = Math.Round(Tot / 3, 2)
            Dim i1 As IncassoEntity = dic.Incassi.AddNew
            i1.DataInserimento = Date.Today
            i1.CodTipo = Enums.TipiIncasso.RATA
            i1.Importo = ImpRata
            i1.Note = "Rata generata automaticamente da procedura di acquisizione Dichiarazioni Online"
            i1.DataScadenza = d(0)
            i1.NumeroRata = 1
            i1.CodModalitaPagamento = 2

            Dim i2 As IncassoEntity = dic.Incassi.AddNew
            i2.DataInserimento = Date.Today
            i2.CodTipo = Enums.TipiIncasso.RATA
            i2.Importo = ImpRata
            i2.Note = "Rata generata automaticamente da procedura di acquisizione Dichiarazioni Online"
            i2.DataScadenza = d(1)
            i2.NumeroRata = 2
            i2.CodModalitaPagamento = 2

            Dim i3 As IncassoEntity = dic.Incassi.AddNew
            i3.DataInserimento = Date.Today
            i3.CodTipo = Enums.TipiIncasso.RATA
            i3.Importo = Tot - ImpRata * 2
            i3.Note = "Rata generata automaticamente da procedura di acquisizione Dichiarazioni Online"
            i3.DataScadenza = d(2)
            i3.NumeroRata = 3
            i3.CodModalitaPagamento = 2
        End Sub



        Public Sub UpdateStato()
            If Me.Stato = Enums.StatoDOL.ANNULLATA Then Return
            If Me.HasDichiarazione Then
                Me.Stato = Enums.StatoDOL.ASSOCIATA
            ElseIf Me.HasAzienda AndAlso Me.StatoAllegatiValidati = StateCompleteEnum.COMPLETE Then
                Me.Stato = Enums.StatoDOL.VALIDATA
            Else
                Me.Stato = Enums.StatoDOL.INSERITA
            End If
        End Sub

    End Class
End Namespace

