Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class ScadenzaEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Codice.Trim = "" Then Throw New ORMEntityValidationException("Definire un codice valido", Me)
            If Me.CodCategoria = "" Then Throw New ORMEntityValidationException("Definire una categoria", Me)
            If Me.ApplicaInteressi And Me.TassoInteresse.GetValueOrDefault = 0 Then Me.ApplicaInteressi = False

        End Sub

    End Class
End Namespace

