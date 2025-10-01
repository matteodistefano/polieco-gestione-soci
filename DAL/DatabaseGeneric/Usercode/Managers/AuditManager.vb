Imports System
Imports System.ComponentModel
Imports System.Collections
Imports DAL.FactoryClasses
Imports DAL.RelationClasses
Imports DAL.EntityClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.Managers
    Public Class AuditManager
        Public Shared IpAddress As String

        Public Enum OperazioneEnum
            LOGIN
            ADD
            EDIT
            DEL
            PWD_CHANGE
            ENTER
            ANALIZE
            IMPORT
            DOWNLOAD
            LOGOUT
        End Enum

        Public Shared Sub AddAudit(Target As String, Operazione As OperazioneEnum, Dati As String)
            AddAudit(UtentiManager.UtenteCorrente.UserName, Target, Operazione, Dati)
        End Sub

        Public Shared Sub AddAudit(UserName As String, Target As String, Operazione As OperazioneEnum, Dati As String)
            Dim ae As New AuditEntity
            ae.Data = Date.Now
            ae.Username = UserName
            ae.Target = Target
            ae.Operazione = [Enum].GetName(GetType(OperazioneEnum), Operazione)
            ae.Dati = Dati
            ae.Ip = IpAddress
            DA.SaveEntity(ae)
        End Sub

    End Class
End Namespace

