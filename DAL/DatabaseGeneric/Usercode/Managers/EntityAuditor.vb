Public Class EntityAuditor
    Inherits SD.LLBLGen.Pro.ORMSupportClasses.AuditorBase

    Public Overrides Sub AuditDeleteOfEntity(entity As SD.LLBLGen.Pro.ORMSupportClasses.IEntityCore)
        CType(entity, DAL.EntityClasses.CommonEntityBase).AuditDelete()
    End Sub

    Public Overrides Sub AuditInsertOfNewEntity(entity As SD.LLBLGen.Pro.ORMSupportClasses.IEntityCore)
        CType(entity, DAL.EntityClasses.CommonEntityBase).AuditNew()
    End Sub

    Public Overrides Sub AuditUpdateOfExistingEntity(entity As SD.LLBLGen.Pro.ORMSupportClasses.IEntityCore)
        CType(entity, DAL.EntityClasses.CommonEntityBase).AuditEdit()
    End Sub
    
End Class
