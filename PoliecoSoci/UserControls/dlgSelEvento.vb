Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL.TypedViewClasses
Imports DAL
Imports DAL.Managers
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgSelEvento

    Private _retValue As EventoEntity
    Private _ManualOnly As Boolean

    Public Function GetEvent(Current As EventoEntity, Position As Point, ManualOnly As Boolean) As EventoEntity
        _retValue = Current
        _ManualOnly = ManualOnly

        Inizializza()

        Me.TopMost = True
        Me.StartPosition = FormStartPosition.Manual
        Me.DesktopLocation = Position

        Me.setCurrentLabel()
        Me.ShowDialog()
        Return _retValue
    End Function

    'Public Shared Sub ForceRefresh()
    '    _Instance.Close()
    '    _Instance = Nothing
    'End Sub

    Private Sub Inizializza()

        Dim lastY As Integer = 0
        Dim P As Panel

        If Not _ManualOnly Then
            P = CreatePanel("Gestione soci", 350)
            P.Location = New Point(10, lastY + 10)
            pnlMain.Controls.Add(P)

            SetEvento(P, "LETTER_GENERATION")
            SetEvento(P, "COMPANY_IN")
            SetEvento(P, "BOARD_OF_DIR_PASSAGE")
            SetEvento(P, "PLENUM_PASSAGE")
            SetEvento(P, "COMPANY_NAME_CHANGE")
            SetEvento(P, "COMPANY_NAME_CHANGE_PASSED")
            SetEvento(P, "CATEGORY_CHANGE")
            SetEvento(P, "COMPANY_ACTIVITY_IN")
            lastY = P.Top + P.Height
        End If


        P = CreatePanel("Ispezioni", 350)
        P.Location = New Point(10, lastY + 10)
        pnlMain.Controls.Add(P)
        SetEvento(P, "INSPECTION_NECESSARY_M")
        SetEvento(P, "INSPECTION_REQUEST_M")
        SetEvento(P, "INSPECTION_RESPONSE_M")
        SetEvento(P, "AGENCY_ADVICE_TO_M", 10)
        SetEvento(P, "AGENCY_RESPONSE_M")
        lastY = P.Top + P.Height

        P = CreatePanel("Uscite", 350)
        P.Location = New Point(10, lastY + 10)
        pnlMain.Controls.Add(P)
        SetEvento(P, "EXIT_FROM_POLIECO_M")
        SetEvento(P, "EXIT_CDA")
        SetEvento(P, "EXIT_PLENUM")
        SetEvento(P, "EXIT")
        lastY = P.Top + P.Height


        P = CreatePanel("Dichiarazioni", 350)
        P.Location = New Point(10, lastY + 10)
        pnlMain.Controls.Add(P)
        SetEvento(P, "RICHIESTA_DICHIARAZIONE_M")
        SetEvento(P, "DA_SANARE_M")
        SetEvento(P, "SANATORIUM_GRANTED_M")
        lastY = P.Top + P.Height
        Dim LastYC1 As Integer = lastY


        lastY = 0
        P = CreatePanel("Contributi", 350)
        P.Location = New Point(370, lastY + 10)
        pnlMain.Controls.Add(P)
        SetEvento(P, "ASSIGNMENT_NEW_TO_SUB_M")
        SetEvento(P, "ASSIGNMENT_RECYCLING_M")
        SetEvento(P, "ASSIGNMENT_TO_SUBJECT_M")
        SetEvento(P, "PAYMENT_DONE_TO_SUB_M")
        SetEvento(P, "SANCTION_INVOICE_SENT_M")
        SetEvento(P, "RICHIESTA_CREDITO_M")
        SetEvento(P, "ESITO_RICHIESTA_CREDITO_M")
        lastY = P.Top + P.Height

        P = CreatePanel("Varie", 350)
        P.Location = New Point(370, lastY + 10)
        pnlMain.Controls.Add(P)
        SetEvento(P, "ADVICE_SENT_M")
        SetEvento(P, "CERTIFICATE_DECLARATION")
        SetEvento(P, "EXAM_PROCEDURE_COMM_M")
        SetEvento(P, "EXTRA_TRANS_COMM_M")
        SetEvento(P, "RECYCLING_OFFER_M")
        SetEvento(P, "RECYCLING_REQUEST_M")
        SetEvento(P, "RIC_RECESSO_M")
        SetEvento(P, "RIC_RECESSO_CLOSE_M")
        SetEvento(P, "GENERIC_EVENT_M")
        SetEvento(P, DAL.Enums.TipoEvento.REMINDER_M)
        SetEvento(P, DAL.Enums.TipoEvento.RECESSO_ECOPLT_M)
        SetEvento(P, DAL.Enums.TipoEvento.AUTH_M)
        lastY = P.Top + P.Height

        Dim LastYC2 As Integer = lastY


        Me.Width = 730
        Me.Height = Math.Max(LastYC1, LastYC2) + 10

    End Sub

    Private Function CreatePanel(Title As String, Width As Integer) As Panel
        Dim P As New Panel
        P.Size = New Size(Width, 200)
        P.BorderStyle = BorderStyle.FixedSingle
        Dim l As New Label
        l.Text = Title
        l.BackColor = Color.FromArgb(255, 255, 192)
        l.TextAlign = ContentAlignment.MiddleLeft
        l.Dock = DockStyle.Top
        l.BorderStyle = BorderStyle.FixedSingle
        P.Controls.Add(l)
        Return P
    End Function

    Private Sub SetEvento(pnl As Panel, CodEvento As String, Optional OffsetY As Integer = 0)
        If _ManualOnly And Not CodEvento.EndsWith("_M") Then Return
        Dim l As New Label
        Dim ev As EventoEntity = DAL.Lookups.Eventi.FirstOrDefault(Function(x) x.Codice = CodEvento)
        If ev Is Nothing Then Return
        l.Tag = ev.Codice
        l.Text = ev.Nome
        l.Tag = ev
        l.Cursor = Cursors.Hand
        AddHandler l.MouseHover, AddressOf HighLightLabel
        AddHandler l.MouseLeave, AddressOf LowLightLabel
        AddHandler l.Click, AddressOf LabelEventoClick

        l.Dock = DockStyle.Top
        l.Visible = True
        l.Margin = New Windows.Forms.Padding(0, OffsetY, 0, 0)


        pnl.Controls.Add(l)
        l.BringToFront()
        pnl.Height = l.Top + l.Height + 4



    End Sub

    Private Sub setCurrentLabel()
        If _retValue Is Nothing Then Return
        For Each pg As Control In Me.pnlMain.Controls
            If TypeOf pg Is Panel Then
                For Each c In pg.Controls
                    Dim lc As Label = TryCast(c, Label)
                    If lc IsNot Nothing Then
                        Dim ev As EventoEntity = TryCast(lc.Tag, EventoEntity)
                        If ev IsNot Nothing AndAlso ev.Codice = _retValue.Codice Then
                            lc.Font = New Font(lc.Font, FontStyle.Bold)
                            Return
                        End If
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub HighLightLabel(sender As Object, e As System.EventArgs)
        Dim l As Label = sender
        l.BackColor = Color.FromArgb(200, 255, 200)
    End Sub

    Private Sub LowLightLabel(sender As Object, e As System.EventArgs)
        Dim l As Label = sender
        l.BackColor = Color.Transparent
    End Sub

    Private Sub LabelEventoClick(sender As Object, e As System.EventArgs)
        Dim l As Label = sender
        _retValue = l.Tag
        Me.Hide()
    End Sub

    Private Sub pnlMain_Click(sender As Object, e As EventArgs) Handles pnlMain.Click
        Me.Hide()
    End Sub

    Private Sub dlgSelEvento_Keyup(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Private Sub dlgSelEvento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim diff As Integer = Me.Top + Me.Height - Screen.PrimaryScreen.Bounds.Height
        If diff > 0 Then Me.Top -= diff
    End Sub
End Class