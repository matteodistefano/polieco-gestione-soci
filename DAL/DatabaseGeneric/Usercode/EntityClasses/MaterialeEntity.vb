Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class MaterialeEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Codice.Trim = "" Then Throw New ORMEntityValidationException("Definire un codice valido", Me)
            If Me.CodTipo = "" Then Throw New ORMEntityValidationException("Tipo non definito", Me)
            If Me.CodUnitaMisura = "" Then Throw New ORMEntityValidationException("Unita di misura non definita", Me)
            If Me.Descrizione = "" Then Throw New ORMEntityValidationException("Descrizione non definita", Me)
        End Sub

        Public ReadOnly Property DescrizioneEstesa As String
            Get
                Return String.Format("{0} - [{1}] - Validita:{2}", Me.Codice, Me.Prezzo, DescrPeriodo)
            End Get
        End Property

        Public ReadOnly Property DescrPeriodo As String
            Get
                Return mdsUtility.TextUtils.GetDateRangeDescription(Me.DataInizio, Me.DataFine, "sempre")
            End Get
        End Property

        Public Property PosizioneInQuadro As String

    End Class
End Namespace

