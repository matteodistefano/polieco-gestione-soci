Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class MaterialeQuadroEntity

        Public ReadOnly Property DescrMateriale As String
            Get
                If Me.Materiale Is Nothing Then Return "?"
                Dim Ret As String = Me.Materiale.Codice
                Return Ret
            End Get
        End Property

    End Class
End Namespace

