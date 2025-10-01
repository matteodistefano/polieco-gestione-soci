Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class RiunioneEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Tipo = "" Then Throw New ORMEntityValidationException("Tipo non definito", Me)
        End Sub

        Public ReadOnly Property DescrTipo As String
            Get
                Dim rw As DataRow = Lookups.TipiRiunione.Rows.Find(Me.Tipo)
                If rw Is Nothing Then
                    Return "?"
                Else
                    Return rw("Descrizione")
                End If
            End Get
        End Property

    End Class
End Namespace

