Imports ATAPI = JulMar.Atapi
Public Class AtapiManager

    Private Shared WithEvents _Manager As ATAPI.TapiManager
    'Private Shared _CurrentCall As ATAPI.TapiCall
    Private Shared _CurrentCallId As Integer?
    
    Public Shared ReadOnly Property Manager As ATAPI.TapiManager
        Get
            If _Manager Is Nothing Then
                _Manager = New ATAPI.TapiManager("Contatti")
                _Manager.Initialize()

            End If
            Return _Manager
        End Get
    End Property

    'Public Shared ReadOnly Property CurrentCall As ATAPI.TapiCall
    '    Get
    '        Return _CurrentCall
    '    End Get
    'End Property

    Public Shared ReadOnly Property CurrentCallId As Integer?
        Get
            Return _CurrentCallId
        End Get
    End Property


    Public Shared Sub MakeCall(Number As String, LineId As Integer)
        Number = Number.Trim
        If Number = "" Then Return

        If LineId = -1 Then Throw New Exception("Linea TAPI non definita.")
        Dim l As ATAPI.TapiLine = Manager.GetLineByPermanentId(LineId)
        If l Is Nothing Then Throw New Exception("Linea non disponibile")
        'If l.IsOpen Then
        '    If MsgBox("La linea è già aperta." & vbCr _
        '              & "Chiuderla ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        l.Close()
        '    End If
        '    Return
        'End If
        
        l.Open(ATAPI.MediaModes.All)
        Dim c As ATAPI.TapiCall = l.MakeCall(Number)
        l.Close()
        
        
        MsgBox("Chiamata al numero " & Number & " inoltrata.", MsgBoxStyle.Information)

    End Sub



    Public Shared Function GetCallableNumber(txt As String) As String()
        txt = txt.Trim
        If txt = "" Then Return Nothing
        
        '1) Elimino spazi e punti
        txt = txt.Replace(" ", "")
        txt = txt.Replace(".", "")
        '2) Separo 

        Dim re As New System.Text.RegularExpressions.Regex("(/?\d+)")
        Dim mm As System.Text.RegularExpressions.MatchCollection = re.Matches(txt)
        Dim v(mm.Count - 1) As String

        Dim baseNum As String = ""
        For i As Integer = 0 To mm.Count - 1
            v(i) = mm(i).Value
            If Not v(i).StartsWith("/") Then
                baseNum = v(i)
            ElseIf v(i).Length - 1 >= baseNum.Length Then
                v(i) = v(i).Substring(1)
            Else
                Dim subN As String = v(i).Substring(1)
                v(i) = baseNum.Substring(0, baseNum.Length - subN.Length) & subN
            End If
        Next
        Return v
    End Function

    Public Shared Function GetContextMenu(nn() As String, LineId As Integer) As ContextMenuStrip
        Dim cm As New ContextMenuStrip
        For i As Integer = 0 To nn.Length - 1
            cm.Items.Add(nn(i), Nothing, New EventHandler(Sub(x, y) AtapiManager.MakeCall(x.text, LineId)))
        Next
        Return cm
    End Function
    
    Public Shared Sub Shutdown()
        If _Manager Is Nothing Then Return
        _Manager.Shutdown()
    End Sub

    'Private Shared Sub _Manager_CallStateChanged(sender As Object, e As JulMar.Atapi.CallStateEventArgs) Handles _Manager.CallStateChanged
    '    If _CurrentCallId.HasValue AndAlso e.Call.Id = _CurrentCallId AndAlso e.CallState = ATAPI.CallState.OnHold Then
    '        MsgBox("Chiamata terminata")
    '        _CurrentCallId = Nothing
    '    End If
    '    MsgBox("evento - stato chiamata:" & e.CallState.ToString)
    'End Sub
End Class
