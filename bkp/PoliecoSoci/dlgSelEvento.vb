Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgSelEvento

    Public Class SelEvento
        Public Property Evento As EventoEntity
        Public Property DataIniziale As Date?
        Public Property DataFinale As Date?
        Public Property SoloAperti As Boolean
        Public ReadOnly Property DescrizionePeriodo
            Get
                Dim Buff As String = ""
                If DataIniziale.HasValue Then Buff = "dal " & DataIniziale.Value.ToShortDateString
                If DataFinale.HasValue Then
                    If Buff <> "" Then Buff &= " "
                    Buff &= "fino al " & DataFinale.Value.ToShortDateString
                End If
                Return Buff
            End Get
        End Property

        Public ReadOnly Property DescrizioneOpzioni
            Get
                Return IIf(SoloAperti, "Solo aperti", "Tutti")
            End Get
        End Property

    End Class

    Private _Ret As SelEvento
    Private _IsNew As Boolean

    Public Function GetEvento() As SelEvento
        _IsNew = True
        _Ret = New SelEvento
        _Ret.Evento = Lookups.Eventi.Item(0)
        _Ret.DataIniziale = Date.Today.AddMonths(-2)
        Inizializza()
        Me.ShowDialog()
        Return _Ret
    End Function

    Public Function Apri(li As ListViewItem) As SelEvento
        _IsNew = False
        _Ret = li.Tag
        Inizializza()
        Me.ShowDialog()
        Return _Ret
    End Function

    Private Sub Inizializza()

        cbEvento.DataSource = Lookups.Eventi.CreateView(Nothing)
        cbEvento.DisplayMember = "Nome"
        cbEvento.ValueMember = "Codice"
        cbEvento.SelectedValue = _Ret.Evento.Codice
        cdiPeriodo.SetInterval(_Ret.DataIniziale, _Ret.DataFinale)
        If Not _IsNew Then chkSoloAperti.Checked = _Ret.SoloAperti

    End Sub

    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        _Ret = Nothing
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            If cbEvento.SelectedValue Is Nothing Then Return
            _Ret.Evento = cbEvento.SelectedItem
            _Ret.DataIniziale = cdiPeriodo.DataIniziale
            _Ret.DataFinale = cdiPeriodo.DataFinale
            _Ret.SoloAperti = chkSoloAperti.Checked
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub cbEvento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEvento.SelectedIndexChanged
        Dim ev As EventoEntity = cbEvento.SelectedItem
        If ev Is Nothing Then
            chkSoloAperti.Checked = False
            chkSoloAperti.Enabled = False
        ElseIf ev.EventiFigli.Count > 0 Then
            If _IsNew Then chkSoloAperti.Checked = True
            chkSoloAperti.Enabled = True
        Else
            If _IsNew Then chkSoloAperti.Checked = False
            chkSoloAperti.Enabled = False
        End If

    End Sub
End Class