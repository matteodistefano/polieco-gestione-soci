Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class LicenzaAziendaEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.CodLicenza = "" Then Throw New ORMEntityValidationException("Tipo licenza non definita", Me)
        End Sub

        Public ReadOnly Property DescrLicenza As String
            Get
                If Me.TipoLicenza Is Nothing Then Return "?"
                Return Me.TipoLicenza.Descrizione
            End Get
        End Property

    End Class
End Namespace

