Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class QuadroEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Codice = "" Then Throw New ORMEntityValidationException("Codice non definito", Me)
        End Sub

        Public ReadOnly Property DescrPeriodo As String
            Get
                Dim Ret As String = ""
                If Me.DataInizio.HasValue Then
                    Ret = "dal " & Me.DataInizio.Value.ToShortDateString
                End If

                If Me.DataFine.HasValue Then
                    Ret &= " fino al " & Me.DataFine.Value.ToShortDateString
                End If
                Return Ret
            End Get
        End Property

        

    End Class
End Namespace

