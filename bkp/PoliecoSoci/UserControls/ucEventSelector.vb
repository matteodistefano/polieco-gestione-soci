Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL.TypedViewClasses
Imports DAL
Imports DAL.Managers
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient



Public Class ucEventSelector

    Public Event SelectionChanged(sender As Object, e As System.EventArgs)

    Private _SelectedEvent As EventoEntity
    Public Property SelectedEvent() As EventoEntity
        Get
            Return _SelectedEvent
        End Get
        Set(value As EventoEntity)
            _SelectedEvent = value
            If _SelectedEvent Is Nothing Then
                lDescrizione.Text = ""
            Else
                lDescrizione.Text = _SelectedEvent.Nome
            End If
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End Set
    End Property

    Public Property SelectedCode() As String
        Get
            If _SelectedEvent Is Nothing Then Return ""
            Return _SelectedEvent.Codice
        End Get
        Set(value As String)
            If value = "" Then
                SelectedEvent = Nothing
            Else
                SelectedEvent = DAL.Lookups.Eventi.FirstOrDefault(Function(x) x.Codice = value)
            End If
        End Set
    End Property

    Private _DropDownAlignment As System.Windows.Forms.HorizontalAlignment = HorizontalAlignment.Left
    Public Property DropDownAlignment() As System.Windows.Forms.HorizontalAlignment
        Get
            Return _DropDownAlignment
        End Get
        Set(value As System.Windows.Forms.HorizontalAlignment)
            _DropDownAlignment = value
        End Set
    End Property

    Private _ManualOnly As Boolean
    Public Property ManualOnly() As Boolean
        Get
            Return _ManualOnly
        End Get
        Set(value As Boolean)
            _ManualOnly = value
        End Set
    End Property

    Private Sub btnSel_Click(sender As Object, e As EventArgs) Handles btnSel.Click
        Dim pos As Point
        If _DropDownAlignment = HorizontalAlignment.Left Then
            pos = Me.Parent.PointToScreen(New Point(Me.Left, Me.Top + Me.Height))
        ElseIf _DropDownAlignment = HorizontalAlignment.Right Then
            pos = Me.Parent.PointToScreen(New Point(Me.Left + Me.Width - 730, Me.Top + Me.Height))
        Else
            pos = Me.Parent.PointToScreen(New Point((730 - Me.Width) / 2 + Me.Left, Me.Top + Me.Height))
        End If

        Dim F As New dlgSelEvento
        Me.SelectedEvent = F.GetEvent(Me.SelectedEvent, pos, _ManualOnly)
    End Sub

    Private Sub ucEventSelector_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        btnSel.Left = Me.Width - btnSel.Width
        lDescrizione.Width = btnSel.Left - 4
        btnSel.Height = Me.Height - 1
        lDescrizione.Height = Me.Height - 1
    End Sub
End Class
