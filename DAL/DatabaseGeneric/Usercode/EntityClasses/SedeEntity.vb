Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class SedeEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Localita = "" AndAlso Me.Descrizione = "" Then Throw New ORMEntityValidationException("Indicare almeno località o descrizione", Me)
        End Sub

    End Class
End Namespace

