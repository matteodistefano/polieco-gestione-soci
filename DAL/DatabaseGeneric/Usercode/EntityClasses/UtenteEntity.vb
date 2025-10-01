Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class UtenteEntity
        Public ReadOnly Property IsInRole(Ruolo As String) As Boolean
            Get
                Return Me.Ruoli.FirstOrDefault(Function(x) x.CodRuolo = Ruolo) IsNot Nothing
            End Get
        End Property

        Public Sub AddRuolo(Ruolo As String)
            If Me.IsInRole(Ruolo) Then Return
            Me.Ruoli.Add(New RuoloUtenteEntity(Ruolo, Me.UserName))
        End Sub

        Public ReadOnly Property DescrRuoli As String
            Get
                If Me.Ruoli.Count = 0 Then Return "?"
                Dim Buff As String = ""
                For Each r As RuoloUtenteEntity In Me.Ruoli
                    Buff &= Lookups.GetLookupDescription(Lookups.Ruoli, r.CodRuolo, "DESCRIZIONE") & vbCrLf
                Next
                Return Buff.Trim
            End Get
        End Property


        Public ReadOnly Property Descrizione As String
            Get
                Return String.Format("{0} - [ {1} ]", Me.Nome, Me.UserName)
            End Get
        End Property


        Public ReadOnly Property HasPasswordProvvisoria
            Get
                Return Me.PasswordProvvisoria <> ""
            End Get
        End Property

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.UserName.Trim = "" Then Throw New ORMEntityValidationException("User name non definito", Me)
            If Me.Nome.Trim = "" Then Throw New ORMEntityValidationException("Nome non definito", Me)
            If Me.Ruoli.Count = 0 Then Throw New ORMEntityValidationException("Ruolo non definito", Me)
            If Me.Password.Length = 0 AndAlso Not Me.HasPasswordProvvisoria Then
                Throw New ORMEntityValidationException("Inserire la password provvisoria", Me)
            End If

            If Me.UserName = Managers.UtentiManager.UtenteCorrente.UserName Then
                If Me.IsAttivo = False Then
                    Throw New Exception("Impossibile disattivare l'utente corrente")
                End If
                If Not Me.IsInRole(Enums.Ruolo.AMMINISTRATORE) Then
                    Throw New Exception("Impossibile rimuovere l'utente corrente dal ruolo di amministratore ")
                End If
            End If

            'Regole validazione key
            If Me.IsNew Then Me.DataRegistrazione = Date.Now
        End Sub

#Region "Audit"
        'Protected Overrides Sub OnInitialized()
        '    MyBase.OnInitialized()
        '    Me.AuditorToUse = New EntityAuditor
        'End Sub

        Public Overrides ReadOnly Property AuditDescription As String
            Get
                Return Me.Descrizione
            End Get
        End Property

#End Region



    End Class
End Namespace

