Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class EventoEntity
        Public ReadOnly Property HasPrecedente As Boolean
            Get
                Return Me.CodEventoPrecedente <> ""
            End Get
        End Property

        Public ReadOnly Property HasSuccessivo As Boolean
            Get
                Return Me.EventiFigli.Count > 0
            End Get
        End Property

        Public ReadOnly Property IsManuale As Boolean
            Get
                Return Me.Codice.EndsWith("_M")
            End Get
        End Property

    End Class
End Namespace

