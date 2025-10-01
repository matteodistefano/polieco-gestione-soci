Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgSelFiltroEvento

    Public Class SelEvento
        Public Property Evento As EventoEntity
        Public Property DataIniziale As Date?
        Public Property DataFinale As Date?
        Public Property SoloAperti As Boolean
        Public Property SoloUrgenti As Boolean
        Public Property MotivazioniNote As String
        Public Property DataNotificaIniziale As Date?
        Public Property DataNotificaFinale As Date?

        Public Property Utente As String


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

        Public ReadOnly Property DescrizioneNotifica
            Get
                Dim Buff As String = ""
                If DataNotificaIniziale.HasValue Then Buff = "dal " & DataNotificaIniziale.Value.ToShortDateString
                If DataNotificaFinale.HasValue Then
                    If Buff <> "" Then Buff &= " "
                    Buff &= "fino al " & DataNotificaFinale.Value.ToShortDateString
                End If
                Return Buff
            End Get
        End Property

        Public ReadOnly Property DescrizioneOpzioni
            Get
                Dim Buff As String = ""
                If Me.MotivazioniNote.Trim <> "" Then
                    Buff = "Motivazione/Note contiene """ & Me.MotivazioniNote & """ "
                End If
                If SoloAperti Then
                    If Buff <> "" Then Buff = " - " & Buff
                    Buff &= "Solo aperti"
                End If
                If SoloUrgenti Then
                    If Buff <> "" Then Buff = " - " & Buff
                    Buff &= "(urgenti)"
                End If

                Dim descrNot As String = DescrizioneNotifica
                If descrNot <> "" Then
                    Buff &= " - da notificare " & descrNot
                End If

                If Utente <> "" Then
                    Buff &= " - solo per " & Utente
                End If


                Return Buff
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

        ucSelEvento.SelectedEvent = _Ret.Evento
        cdiPeriodo.SetInterval(_Ret.DataIniziale, _Ret.DataFinale)
        cdiNotifica.SetInterval(_Ret.DataNotificaIniziale, _Ret.DataNotificaFinale)
        chkOnlyCurrUser.Checked = (_Ret.Utente <> "")
        If Not _IsNew Then chkSoloAperti.Checked = _Ret.SoloAperti
        txtMotivazione.Text = _Ret.MotivazioniNote
        chkUrgente.Checked = _Ret.SoloUrgenti

    End Sub

    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        _Ret = Nothing
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            If ucSelEvento.SelectedEvent Is Nothing Then Return
            _Ret.Evento = ucSelEvento.SelectedEvent
            _Ret.DataIniziale = cdiPeriodo.DataIniziale
            _Ret.DataFinale = cdiPeriodo.DataFinale

            _Ret.DataNotificaIniziale = cdiNotifica.DataIniziale
            _Ret.DataNotificaFinale = cdiNotifica.DataFinale

            _Ret.SoloAperti = chkSoloAperti.Checked
            _Ret.MotivazioniNote = txtMotivazione.Text
            _Ret.SoloUrgenti = chkUrgente.Checked

            _Ret.Utente = IIf(chkOnlyCurrUser.Checked, DAL.Managers.UtentiManager.UtenteCorrente.UserName, "")


            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub cbEvento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ucSelEvento.SelectionChanged
        Dim ev As EventoEntity = ucSelEvento.SelectedEvent
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