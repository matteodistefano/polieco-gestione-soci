Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports SD.LLBLGen.Pro.ORMSupportClasses


Namespace DAL.EntityClasses
    Partial Public Class CommonEntityBase
        
        Public Overridable ReadOnly Property AuditDescription As String
            Get
                Dim Buff As String = ""
                For Each f In Me.Fields.PrimaryKeyFields
                    Buff &= f.Name & ":" & f.CurrentValue & "  "
                Next
                Buff = Buff.TrimEnd
                Return Buff
            End Get
        End Property

        Public Function GetSimpleName() As String
            Dim Nm As String = Me.GetType.ToString
            Nm = Nm.Replace("Entity", "")
            Nm = Nm.Replace("DAL.Classes.", "")
            Return Nm
        End Function

        Public Sub AuditNew()
            Audit(Managers.AuditManager.OperazioneEnum.ADD)
        End Sub

        Public Sub AuditEdit()
            Audit(Managers.AuditManager.OperazioneEnum.EDIT)
        End Sub

        Public Sub AuditDelete()
            Audit(Managers.AuditManager.OperazioneEnum.DEL)
        End Sub

        Public Sub AuditNewOrEdit()
            If Me.IsNew Then
                AuditNew()
            Else
                AuditEdit()
            End If
        End Sub
        
        Public Sub Audit(Op As Managers.AuditManager.OperazioneEnum)
            Dim St As EntityState = Me.Fields.State
            Me.Fields.State = EntityState.Fetched
            Managers.AuditManager.AddAudit(GetSimpleName, Op, Me.AuditDescription)
            Me.Fields.State = St
        End Sub


        'Protected Overrides Sub OnAuditDeleteOfEntity()
        '    If TypeOf (Me) Is AuditEntity Then Return
        '    Dim St As EntityState = Me.Fields.State
        '    Me.Fields.State = EntityState.Fetched
        '    Managers.AuditManager.AddAudit(GetSimpleName, Managers.AuditManager.OperazioneEnum.ELIMINA, Me.AuditDescription)
        '    Me.Fields.State = St
        '    MyBase.OnAuditInsertOfNewEntity()
        'End Sub

        'Protected Overrides Sub OnAuditInsertOfNewEntity()
        '    If TypeOf (Me) Is AuditEntity Then Return
        '    Dim St As EntityState = Me.Fields.State
        '    Me.Fields.State = EntityState.Fetched
        '    Managers.AuditManager.AddAudit(GetSimpleName, Managers.AuditManager.OperazioneEnum.NUOVA, Me.AuditDescription)
        '    Me.Fields.State = St
        '    MyBase.OnAuditInsertOfNewEntity()
        'End Sub

        'Protected Overrides Sub OnAuditUpdateOfExistingEntity()
        '    If TypeOf (Me) Is AuditEntity Then Return
        '    Dim St As EntityState = Me.Fields.State
        '    Me.Fields.State = EntityState.Fetched
        '    Managers.AuditManager.AddAudit(GetSimpleName, Managers.AuditManager.OperazioneEnum.MODIFICA, Me.AuditDescription)
        '    Me.Fields.State = St
        '    MyBase.OnAuditInsertOfNewEntity()
        'End Sub

   
            
    End Class
End Namespace

