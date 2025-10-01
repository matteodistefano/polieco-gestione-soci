Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports SD.LLBLGen.Pro.DQE.SqlServer
Imports SD.LLBLGen.Pro.ORMSupportClasses.Adapter

Namespace DAL.DatabaseSpecific
    Partial Public Class DataAccessAdapter
        Public Function GetDAFieldPersistenceInfo(Fld As EntityField2) As FieldPersistenceInfo

            'Return Me.GetFieldPersistenceInfo(Fld)
            Return _qcm.GetFPInfo(Fld)




        End Function

        Private _qcm As QCMClass

        Protected Overrides Function CreateQueryCreationManager(persistenceInfoProvider As IPersistenceInfoProvider) As QueryCreationManager
            _qcm = New QCMClass(Me, persistenceInfoProvider)
            Return _qcm
        End Function

    End Class


    Public Class QCMClass
        Inherits SD.LLBLGen.Pro.ORMSupportClasses.Adapter.QueryCreationManager
        Sub New(DA As DataAccessAdapterCore, pip As IPersistenceInfoProvider)
            MyBase.New(DA, pip)
        End Sub

        Public Function GetFPInfo(fieldInfo As IFieldInfo) As IFieldPersistenceInfo
            Return MyBase.GetFieldPersistenceInfo(fieldInfo)
        End Function

    End Class

End Namespace
