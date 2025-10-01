Imports System.Net.Sockets
Public Class AsteriskManager
    Inherits ManagerBase

    Public Class Configuration
        Public Property IndirizzoHost As String
        Public Property PortaHost As String
        Public Property Username As String
        Public Property Password As String
        Public Property TenantId As String
        Public Property Attesa As Integer = 2000
        Public Property Interno As String
    End Class

    Private _configuration As Configuration


    Public Overrides Sub Initialize(cfg As Object)
        _configuration = cfg
    End Sub


    Public Overrides Sub MakeCall(Number As String)
        Number = Number.Trim
        If Number = "" Then Return
        Dim client As New TcpClient
        Try

            Trace.TraceInformation($"Inizializzazione Connessione host --> {_configuration.IndirizzoHost}:{_configuration.PortaHost}...")
            client.Connect(_configuration.IndirizzoHost, _configuration.PortaHost)
            Dim stream As NetworkStream = client.GetStream()

            Dim message As String
            Dim data As Byte()
            Dim responseData(1024) As Byte
            Dim nnBytes As Integer
            Dim response As String

            message = $"ACTION: Login{vbCrLf}" _
                    & $"USERNAME: {_configuration.Username}{vbCrLf}" _
                    & $"SECRET: {_configuration.Password}{vbCrLf}{vbCrLf}"
            Trace.TraceInformation("-----------------------------------------")
            Trace.TraceInformation($"comando --> {message}")
            data = System.Text.Encoding.ASCII.GetBytes(message)
            stream.Write(data, 0, data.Length)

            Threading.Thread.Sleep(_configuration.Attesa)

            nnBytes = stream.Read(responseData, 0, responseData.Length)
            response = System.Text.Encoding.ASCII.GetString(responseData, 0, nnBytes)
            Trace.TraceInformation("-----------------------------------------")
            Trace.TraceInformation($"risposta <-- {response}")

            Dim ll() As String = response.Split(New String() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
            If ll.FirstOrDefault(Function(x) x.ToLower = "message: authentication accepted") Is Nothing Then Throw New Exception("Autenticazione fallita")

            message = $"ACTION: Originate{vbCrLf}"
            message &= $"CHANNEL: PJSIP/{_configuration.TenantId}{_configuration.Interno}{vbCrLf}"
            message &= $"CONTEXT: t-{_configuration.TenantId}{vbCrLf}"
            message &= $"EXTEN: {Number}{vbCrLf}"
            message &= $"PRIORITY: 1{vbCrLf}"
            'message &= $"CALLERID: {_configuration.TenantId}{_configuration.Interno}{vbCrLf}{vbCrLf}"
            message &= $"CALLERID: {Number}{vbCrLf}{vbCrLf}"
            Trace.TraceInformation("-----------------------------------------")
            Trace.TraceInformation($"   comando --> {message}")
            data = System.Text.Encoding.ASCII.GetBytes(message)
            stream.Write(data, 0, data.Length)



            nnBytes = stream.Read(responseData, 0, responseData.Length)
            response = System.Text.Encoding.ASCII.GetString(responseData, 0, nnBytes)
            Trace.TraceInformation("-----------------------------------------")
            Trace.TraceInformation($"   risposta <-- {response}")


            MsgBox("Chiamata al numero " & Number & " inoltrata.", MsgBoxStyle.Information)

        Catch ex As Exception
            Trace.TraceError(ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        client.Close()

    End Sub

    Public Overrides Sub Shutdown()

    End Sub

End Class
