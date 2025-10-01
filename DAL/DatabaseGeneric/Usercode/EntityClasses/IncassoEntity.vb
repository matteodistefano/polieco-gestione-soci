Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses

Namespace DAL.EntityClasses
    Partial Public Class IncassoEntity
        Implements System.ComponentModel.INotifyPropertyChanged

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.CodTipo = "" Then Throw New ORMEntityValidationException("Tipo non definito", Me)
            If Me.CodModalitaPagamento = "" Then Throw New ORMEntityValidationException("Modalita pagamento non definita", Me)
            If Me.CodTipo <> Enums.TipiIncasso.VERSAMENTO Then
                If Not Me.DataScadenza.HasValue Then Throw New Exception("Data scadenza non definita")
                If Me.NumeroRata.GetValueOrDefault <= 0 Then Throw New Exception("Numero rata non valido")
            End If
        End Sub

        Public ReadOnly Property DescrTipo As String
            Get
                Return Lookups.GetLookupDescription(Lookups.TipiIncasso, Me.CodTipo, "Descrizione")
            End Get
        End Property

        Public ReadOnly Property DescrModalitaPagamento As String
            Get
                Return Lookups.GetLookupDescription(Lookups.ModalitaPagamento, Me.CodModalitaPagamento)
            End Get
        End Property

    End Class

End Namespace

