Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class ProdottoEntity
        Public ReadOnly Property DescrCategoria As String
            Get
                If Not Me.IdRiferimento.HasValue Then Return ""
                If Me.ProdottoPadre Is Nothing Then Return "?"
                Return Me.ProdottoPadre.Descrizione
            End Get
        End Property

    End Class
End Namespace

