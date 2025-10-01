Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class AziendaProdottoEntity
        Public ReadOnly Property DescrCategoria As String
            Get
                If Me.Prodotto Is Nothing Then Return "?"
                Return Me.Prodotto.DescrCategoria
            End Get
        End Property

        Public ReadOnly Property DescrProdotto As String
            Get
                If Me.Prodotto Is Nothing Then Return "?"
                Return Me.Prodotto.Descrizione
            End Get
        End Property

        Public ReadOnly Property DescrUtilizzo As String
            Get
                If Me.TipoUtilizzo = "P" Then
                    Return "Produttore"
                Else
                    Return "Utilizzatore"
                End If
            End Get
        End Property




    End Class
End Namespace

