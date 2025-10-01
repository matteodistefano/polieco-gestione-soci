Imports System
Imports System.ComponentModel
Imports System.Collections
Imports DAL.FactoryClasses
Imports DAL.RelationClasses
Imports DAL.EntityClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.Managers
    Public Class UtentiManager
        Private Shared _IsLoggedUserAdmin As Boolean
        Private Shared _IsLoggedUserContabilita As Boolean
        Private Shared _IsLoggedUserSegreteria As Boolean
        Private Shared _UtenteCorrente As UtenteEntity

        Public Shared ReadOnly Property UtenteCorrente() As UtenteEntity
            Get
                Return _UtenteCorrente
            End Get
        End Property

        Public Shared ReadOnly Property IsLoggedUserSegreteria() As Boolean
            Get
                Return _IsLoggedUserSegreteria
            End Get
        End Property

        Public Shared ReadOnly Property IsLoggedUserContabilita() As Boolean
            Get
                Return _IsLoggedUserContabilita
            End Get
        End Property

        Public Shared ReadOnly Property IsLoggedUserAdmin() As Boolean
            Get
                Return _IsLoggedUserAdmin
            End Get
        End Property

        Public Enum LoginResponseEnum
            NO
            OK
            NO_ACTIVE
            CHANGE_PASSWORD
        End Enum

        Public Shared Function Login(ByVal UserName As String, ByVal Password As String) As LoginResponseEnum

            If UserName.Trim.Length = 0 OrElse Password.Trim.Length = 0 Then Return LoginResponseEnum.NO

            Dim Ut As New UtenteEntity
            Ut.UserName = UserName
            Dim pp As New PrefetchPath2(CInt(EntityType.UtenteEntity))
            pp.Add(UtenteEntity.PrefetchPathRuoli)

            Dim test As Boolean = DA.FetchEntity(Ut, pp)
            If Not test Then Return LoginResponseEnum.NO

            If Not Ut.IsAttivo Then Return LoginResponseEnum.NO_ACTIVE
            If Ut.PasswordProvvisoria <> "" Then
                If String.Compare(Ut.PasswordProvvisoria, Password, True) = 0 Then
                    _UtenteCorrente = Ut
                    Return LoginResponseEnum.CHANGE_PASSWORD
                Else
                    Return LoginResponseEnum.NO
                End If
            End If

            Dim Enc As New System.Text.UTF8Encoding
            Dim Buff As String = Ut.UserName & Password
            Dim HashIn As String = Enc.GetString(mdsUtility.Cryptografy.SHA1Encrypt(Buff))
            Dim HashDb As String = Enc.GetString(Ut.Password)
            If HashDb = HashIn Then
                Ut.DataAccesso = Date.Now
                Ut.NumeroAccessi = Ut.NumeroAccessi.GetValueOrDefault + 1
                SetCurrentUser(Ut)
                DA.SaveEntity(Ut, True)

                Return LoginResponseEnum.OK
            Else
                Return LoginResponseEnum.NO
            End If
        End Function

        Public Shared Sub SetCurrentUser(ut As UtenteEntity)
            _UtenteCorrente = ut
            _IsLoggedUserAdmin = ut.IsInRole(Enums.Ruolo.AMMINISTRATORE)
            _IsLoggedUserContabilita = _IsLoggedUserAdmin OrElse ut.IsInRole(Enums.Ruolo.CONTABILITA)
            _IsLoggedUserSegreteria = _IsLoggedUserContabilita OrElse ut.IsInRole(Enums.Ruolo.SEGRETERIA)
        End Sub


        Public Shared Sub SetNewPassword(ByVal Pwd As String)
            If Pwd = "" Then Throw New Exception("Password nulla non ammessa")
            If UtenteCorrente Is Nothing Then Throw New Exception("Utente non impostato")
            Dim Ut As UtenteEntity = UtenteCorrente
            Dim Hash() As Byte = mdsUtility.Cryptografy.SHA1Encrypt(Ut.UserName & Pwd)
            Ut.Password = Hash
            Ut.PasswordProvvisoria = ""
            Ut.DataRilascioPassword = Date.Now
            DA.SaveEntity(Ut, True)
        End Sub

        Public Shared Sub DeleteUtente(ByVal Ut As UtenteEntity)
            If Ut.UserName = UtenteCorrente.UserName Then
                Throw New ORMEntityValidationException("Impossibile eliminare l'utente corrente", Ut)
            End If
            DA.DeleteEntity(Ut)
        End Sub

        Public Shared Sub SalvaUtente(ByVal Ut As UtenteEntity)
            DA.SaveEntity(Ut, True)
        End Sub

        Public Shared Sub CheckLoggedUserRole(ParamArray Roles() As String)
            If _UtenteCorrente.IsInRole(Enums.Ruolo.AMMINISTRATORE) Then Return
            'Verifica se l'utente è in almeno uno dei ruoli
            Dim Ok As Boolean
            For Each r In Roles
                If IsLoggedUserInRole(r) Then
                    Ok = True
                    Exit For
                End If
            Next

            If Not Ok Then
                Throw New Security.SecurityException("Non si dispone dei privilegi per effettuare l'operazione")
            End If
        End Sub

        Public Shared Function IsLoggedUserInRole(ParamArray Roles() As String)
            If _UtenteCorrente.IsInRole(Enums.Ruolo.AMMINISTRATORE) Then Return True
            For Each r In Roles
                If _UtenteCorrente.IsInRole(r) Then Return True
            Next
            Return False
        End Function



    End Class
End Namespace