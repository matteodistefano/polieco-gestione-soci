Imports ATAPI = JulMar.Atapi
Public Class AtapiManager
    Inherits ManagerBase

    Public Class Configuration
        Public Property LineId As Integer
    End Class

    Private _configuration As Configuration
    Private _Manager As ATAPI.TapiManager

    Public Overrides Sub Initialize(cfg As Object)
        _configuration = cfg
        _Manager = New ATAPI.TapiManager("Contatti")
        _Manager.Initialize()
        dlgEditAtapi.Caller = Me
    End Sub

    Public Function GetLines() As ATAPI.TapiLine()
        Return _Manager.Lines
    End Function
    'Public Shared ReadOnly Property Manager As ATAPI.TapiManager
    '    Get
    '        If _Manager Is Nothing Then
    '            _Manager = New ATAPI.TapiManager("Contatti")
    '            _Manager.Initialize()

    '        End If
    '        Return _Manager
    '    End Get
    'End Property

    Public Overrides Sub MakeCall(Number As String)
        Number = Number.Trim
        If Number = "" Then Return

        If _configuration.LineId = -1 Then Throw New Exception("Linea TAPI non definita.")
        Dim l As ATAPI.TapiLine = _Manager.GetLineByPermanentId(_configuration.LineId)
        If l Is Nothing Then Throw New Exception("Linea non disponibile")
        l.Open(ATAPI.MediaModes.All)
        Dim c As ATAPI.TapiCall = l.MakeCall(Number)
        l.Close()
        MsgBox("Chiamata al numero " & Number & " inoltrata.", MsgBoxStyle.Information)
    End Sub

    Public Overrides Sub Shutdown()
        If _Manager Is Nothing Then Return
        _Manager.Shutdown()
    End Sub

End Class
