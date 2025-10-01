Namespace DAL.DatabaseSpecific
    Public Module Generale

        Private _DA As DAL.DatabaseSpecific.DataAccessAdapter
        Private _SSHelp As mdsDBLib.SqlServer

        Public Sub InitConnection(CS As String)
            _DA = New DAL.DatabaseSpecific.DataAccessAdapter(CS)
            _SSHelp = New mdsDBLib.SqlServer(CS)
        End Sub

        Public ReadOnly Property DA As DAL.DatabaseSpecific.DataAccessAdapter
            Get
                Return _DA
            End Get
        End Property

        Public ReadOnly Property SSHelp As mdsDBLib.SqlServer
            Get
                Return _SSHelp
            End Get
        End Property

    End Module

End Namespace
