Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgAziendaAllegato

    Private _Azienda As AziendaAllegatoEntity
    Private _CanEdit As Boolean
    Private _IsNew As Boolean
    Public Property IsNew As Boolean
        Get
            Return _IsNew
        End Get
        Set(value As Boolean)
            _IsNew = value
            If value Then
                Label12.Visible = False
                dgvDettaglio.Visible = False
                Me.Height = Label12.Top + tsMain.Height + 26
            End If
        End Set
    End Property


    Public Sub Apri(Id As Integer)
        _Azienda = New AziendaAllegatoEntity(Id)
        _Azienda.SaveFields("Edit")
        _Azienda.Fetch()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova() As AziendaAllegatoEntity
        _Azienda = New AziendaAllegatoEntity
        Inizializza()
        Me.ShowDialog()
        Return _Azienda
    End Function

    Private Sub Inizializza()
        InitUiSecurity()

        bsAzienda.DataSource = _Azienda
        IsNew = _Azienda.IsNew

        If Not IsNew Then
            bsDati.DataSource = _Azienda.DettagliAllegati
            dgvDettaglio.AutoGenerateColumns = False
            dgvDettaglio.DataSource = bsDati
        End If


        UpdateSocioVisibility()
    End Sub

    Private Sub InitUiSecurity()
        _CanEdit = UtentiManager.IsLoggedUserSegreteria

        tsbOk.Available = _CanEdit
        If Not _CanEdit Then
            tsbExit.Text = "Chiudi"
        End If
    End Sub

    Private Sub UpdateSocioVisibility()
        If _Azienda.IdSocio.HasValue Then
            pnlSocio.Visible = True
            txtSocio.Text = String.Format("{0} - {1}", _Azienda.IdSocio, _Azienda.Azienda.RagioneSociale)
        Else
            pnlSocio.Visible = False
        End If
    End Sub

    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            bsAzienda.EndEdit()
            _Azienda.ValidateEntity()
            DA.SaveEntity(_Azienda, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Azienda.IsNew Then
            _Azienda = Nothing
        Else
            bsAzienda.CancelEdit()
            _Azienda.RollbackFields("Edit")
            _Azienda = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub btnVerSocio_Click(sender As Object, e As EventArgs) Handles btnVerSocio.Click
        Try
            Dim txt As String = txtPIva.Text.Trim.Replace("'", "''")
            If txt = "" Then Return

            If txt.Length < 11 Or txt.Length > 16 Then  Throw New Exception("Partita iva non valida")

            Dim sql As String = "SELECT top 1 Id,RagioneSociale From Allegati.AziendaAllegato where PartitaIva='" & txt & "'"
            If Not _Azienda.IsNew Then sql &= " and id<>" & _Azienda.Id
            Dim tb As DataTable = DAL.Generale.DbLib.GetDbTable(sql)
            If tb.Rows.Count <> 0 Then
                Dim rwAz As DataRow = tb.Rows(0)
                Throw New Exception("Partita iva già assegnata all'azienda [" & rwAz("Id") & "] - " & rwAz("RagioneSociale"))
            End If

            sql = "SELECT Id,RagioneSociale,Indirizzo,Localita,Cap,Provincia,CodTipoIscrizione From Azienda where PartitaIva='" & txt & "' or CodiceFiscale='" & txt & "'"
            tb = DAL.Generale.DbLib.GetDbTable(sql)
            If tb.Rows.Count = 0 Then Throw New Exception("Non è stata trovata nessuna azienda")
            If tb.Rows.Count > 1 Then Throw New Exception("Esistono più aziende con la partita IVA indicata")

            Dim rw As DataRow = tb.Rows(0)
            Dim Msg As String = String.Format("Azienda trovata:
{0}-{1}
{2}", rw("Id"), rw("RagioneSociale"), rw("Localita"))
            If rw("CodTipoIscrizione") = Enums.TipoSocio.ARC_STO Then
                Msg &= vbCr & "Attenzione !!! L'azienda è nello storico."
            End If

            If MsgBox(Msg & vbCr & "Impostare i dati ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            Dim az As New AziendaEntity(CInt(rw("Id")))
            DA.FetchEntity(az)

            _Azienda.Azienda = az
            _Azienda.RagioneSociale = rw("RagioneSociale") & ""
            _Azienda.Indirizzo = rw("Indirizzo") & ""
            _Azienda.Localita = rw("Localita") & ""
            _Azienda.Cap = rw("Cap") & ""
            _Azienda.Provincia = rw("Provincia") & ""

            UpdateSocioVisibility()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class