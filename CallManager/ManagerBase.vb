Imports System.Windows.Forms

Public Class ManagerBase
    Public Overridable Sub Initialize(cfg As Object)

    End Sub
    Public Overridable Sub Shutdown()

    End Sub
    Public Overridable Sub MakeCall(Number As String)
        Throw New Exception("Caller non configurato")
    End Sub


    Public Function GetCallableNumber(txt As String) As String()
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

    Public Function GetContextMenu(nn() As String) As ContextMenuStrip
        Dim cm As New ContextMenuStrip
        For i As Integer = 0 To nn.Length - 1
            cm.Items.Add(nn(i), Nothing, New EventHandler(Sub(x, y)
                                                              Try
                                                                  Me.MakeCall(x.text)
                                                              Catch ex As Exception
                                                                  MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                                                              End Try
                                                          End Sub))
        Next
        Return cm
    End Function

End Class
