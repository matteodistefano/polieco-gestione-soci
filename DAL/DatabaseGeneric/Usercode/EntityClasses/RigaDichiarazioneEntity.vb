Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses

Namespace DAL.EntityClasses
    Partial Public Class RigaDichiarazioneEntity
        Implements System.ComponentModel.INotifyPropertyChanged

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.CodQuadro = "" Then Throw New ORMEntityValidationException("Quadro non definito", Me)
        End Sub

        Protected Overrides Sub OnPropertyChanged(propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
            If propertyName = "Valore" OrElse propertyName = "PrezzoUnitario" OrElse propertyName = "Iva" Then
                OnPropertyChanged("ImportoNetto")
                OnPropertyChanged("ImportoIVA")
                OnPropertyChanged("ImportoLordo")
            End If
        End Sub

        Public ReadOnly Property ImportoNetto As Decimal
            Get
                Return Me.PrezzoUnitario * Me.Valore
            End Get
        End Property

        Public ReadOnly Property ImportoIVA As Decimal
            Get
                Return Me.ImportoNetto * (Me.Iva / 100)
            End Get
        End Property

        Public ReadOnly Property ImportoLordo As Decimal
            Get
                Return ImportoNetto + ImportoIVA
            End Get
        End Property

    End Class

End Namespace

