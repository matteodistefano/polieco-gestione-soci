Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class AttivitaEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.CodTipoAttivita = "" Then Throw New ORMEntityValidationException("Tipo attivià non definito", Me)
            If Me.CodCategoria = "" Then Throw New ORMEntityValidationException("Categoria non definita", Me)
        End Sub

        Public ReadOnly Property DescrConsuntivo As String
            Get
                Return String.Format("{0} : {1:N2}", Me.AnnoPrecedente, Me.QuantitaAnnoPrecedente)
            End Get
        End Property

        Public ReadOnly Property DescrPreventivo As String
            Get
                Return String.Format("{0} : {1:N2}", Me.AnnoCorrente, Me.QuantitaAnnoCorrente)
            End Get
        End Property

        Public ReadOnly Property HasAttrezzatura As Boolean
            Get
                Return Me.Attrezzature.Count > 0
            End Get
        End Property

    End Class
End Namespace

