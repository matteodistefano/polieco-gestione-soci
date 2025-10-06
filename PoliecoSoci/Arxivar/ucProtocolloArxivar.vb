Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class ucProtocolloArxivar
    Implements System.ComponentModel.INotifyPropertyChanged

    Public Class ProfileClickEventArgs
        Inherits EventArgs

        Public Property ProfileType As ArxWCF.ProfilemodeEnum

        Public Sub New(ProfileType As ArxWCF.ProfilemodeEnum)
            MyBase.New()
            _ProfileType = ProfileType
        End Sub

    End Class
    Public Event ProfileClick(sender As Object, e As ProfileClickEventArgs)
    Public Event OnOpenDocClick(sender As Object, e As System.ComponentModel.CancelEventArgs)
    Public Shared Property ConnWCF As Abletech.Arxivar.Client.WCFConnectorManager


    Private _AllowProfile As Boolean = True
    Property AllowProfile As Boolean
        Get
            Return _AllowProfile
        End Get
        Set(value As Boolean)
            btnProfile.Visible = value
            _AllowProfile = value
        End Set
    End Property

    Private _ShowContextMenu As Boolean = True
    Property ShowContextMenu As Boolean
        Get
            Return _ShowContextMenu
        End Get
        Set(value As Boolean)
            _ShowContextMenu = value
        End Set
    End Property

    Public Overrides Property BackColor() As Color
        Get
            Return Txt.BackColor
        End Get
        Set(ByVal value As Color)
            Txt.BackColor = value
        End Set
    End Property

    Private Shadows Property Text
    <System.ComponentModel.Bindable(True)> _
    Public Property Protocollo As String
        Get
            Return Me.Txt.Text
        End Get
        Set(value As String)
            Dim raise As Boolean = (value <> Me.Txt.Text)
            Me.Txt.Text = value
            If raise Then RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Protocollo"))
        End Set
    End Property

    Private _ReadOnly As Boolean
    Public Property [ReadOnly]() As Boolean
        Get
            Return Me.Txt.ReadOnly
        End Get
        Set(value As Boolean)
            Me.Txt.ReadOnly = value
        End Set
    End Property

    Private _ProtocolPrefix As String
    Public Property ProtocolPrefix() As String
        Get
            Return _ProtocolPrefix
        End Get
        Set(value As String)
            _ProtocolPrefix = value
        End Set
    End Property


    'Private Sub ucProtocolloArxivar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '    Me.Height = 20
    'End Sub

    Public Property BackColorTxt() As Color
        Get
            Return Me.Txt.BackColor
        End Get
        Set(ByVal Value As Color)
            Me.Txt.BackColor = Value
        End Set
    End Property

    Private Sub txt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt.GotFocus
        Dim Buff As String = Txt.Text.Trim
        If Buff.Length > 0 AndAlso Buff.Substring(Buff.Length - 1) = "/" Then
            Txt.SelectionStart = Buff.Length
        ElseIf Buff.Length = 0 AndAlso _ProtocolPrefix <> "" Then
            Txt.Text = _ProtocolPrefix & "/"
            Txt.SelectionStart = Txt.Text.Length
        End If
    End Sub

    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click

        Dim ce As New System.ComponentModel.CancelEventArgs
        RaiseEvent OnOpenDocClick(Me, ce)
        If ce.Cancel Then Return

        Dim DocNum As String = Me.Txt.Text.Trim
        Dim V() As String = DocNum.Split("-")
        DocNum = V(0).Trim
        If DocNum.Length = 0 Then Return
        If Not IsNumeric(DocNum) Then Return

        Try
            ArxWCF.OpenDocumentById(DocNum)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Txt_LostFocus(sender As Object, e As System.EventArgs) Handles Txt.LostFocus
        RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Protocollo"))
    End Sub

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        If ShowContextMenu Then
            cmProfile.Show(btnProfile, New Point(0, 0))
        Else
            RaiseEvent ProfileClick(Me, New ProfileClickEventArgs(ArxWCF.ProfilemodeEnum.UNDEFINED))
        End If

    End Sub

    Private Sub tsmiPrFile_Click(sender As Object, e As EventArgs) Handles tsmiPrFile.Click
        RaiseEvent ProfileClick(Me, New ProfileClickEventArgs(ArxWCF.ProfilemodeEnum.FILE))
    End Sub

    Private Sub tsmiPrBarcode_Click(sender As Object, e As EventArgs) Handles tsmiPrBarcode.Click
        RaiseEvent ProfileClick(Me, New ProfileClickEventArgs(ArxWCF.ProfilemodeEnum.BARCODE))
    End Sub



End Class
