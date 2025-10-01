Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class ContattoEntity
        Public ReadOnly Property DescrRuolo As String
            Get
                If Me.RuoloContatto Is Nothing Then Return "?"
                Return Me.RuoloContatto.Descrizione
            End Get
        End Property

        



    End Class
End Namespace

