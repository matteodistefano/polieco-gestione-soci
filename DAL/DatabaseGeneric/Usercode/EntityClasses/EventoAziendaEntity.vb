Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class EventoAziendaEntity

        Public Shared Function GetNew(Az As AziendaEntity, CodEvento As String) As EventoAziendaEntity
            Dim ret As EventoAziendaEntity = Az.Eventi.AddNew
            ret.CodEvento = CodEvento
            ret.Data = Date.Now
            ret.CodUtente = Managers.UtentiManager.UtenteCorrente.UserName
            Return ret
        End Function

        Public Shared Function GetNew(IdAzienda As Integer, CodEvento As String) As EventoAziendaEntity
            Dim ret As New EventoAziendaEntity
            ret.IdAzienda = IdAzienda
            ret.CodEvento = CodEvento
            ret.Data = Date.Now
            ret.CodUtente = Managers.UtentiManager.UtenteCorrente.UserName
            Return ret
        End Function

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Data = Date.MinValue Then Throw New ORMEntityValidationException("Data non definita", Me)
            If Me.CodEvento = "" Then Throw New ORMEntityValidationException("Tipo evento non definito", Me)
        End Sub

        Public ReadOnly Property DescrUtente As String
            Get
                Return Me.CodUtente
            End Get
        End Property

        Public ReadOnly Property DescrTipo As String
            Get
                Return DAL.Lookups.GetLookupDescription(Lookups.Eventi, Me.CodEvento, "Codice", "Nome")
            End Get
        End Property

        Public ReadOnly Property Evento As EventoEntity
            Get
                Return DAL.Lookups.Eventi.FirstOrDefault(Function(x) x.Codice = Me.CodEvento)
            End Get
        End Property

        Public ReadOnly Property HasPrecedente() As Boolean
            Get
                If Evento IsNot Nothing Then Return Evento.HasPrecedente
                Return False
            End Get
        End Property

        Public ReadOnly Property HasSuccessivo() As Boolean
            Get
                If Evento IsNot Nothing Then Return Evento.HasSuccessivo
                Return False
            End Get
        End Property

        Public ReadOnly Property IsManuale() As Boolean
            Get
                If Evento IsNot Nothing Then Return Evento.IsManuale
                Return False
            End Get
        End Property

        Public ReadOnly Property HasDocument() As Boolean
            Get
                Return Me.RifArxivar <> ""
            End Get
        End Property



    End Class
End Namespace

