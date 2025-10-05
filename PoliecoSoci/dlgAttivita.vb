Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgAttivita
    Private _Attivita As AttivitaEntity
    Private _CanEdit As Boolean
    Private _tbAtt As DataTable

    Public Sub Apri(Attivita As AttivitaEntity)
        _Attivita = Attivita
        _Attivita.Attrezzature.RemovedEntitiesTracker = New EntityCollection(Of AttrezzaturaAttivitaEntity)
        _Attivita.SaveFields("Edit")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova(Az As AziendaEntity) As AttivitaEntity
        _Attivita = Az.Attivita.AddNew
        _Attivita.CodTipoAttivita = IIf(Az.Attivita.LongCount(Function(x) x.CodTipoAttivita = Enums.CodTipoAttivita.PRINCIPALE) = 0, Enums.CodTipoAttivita.PRINCIPALE, Enums.CodTipoAttivita.SECONDARIA)
        _Attivita.AnnoCorrente = Date.Today.Year
        _Attivita.AnnoPrecedente = Date.Today.Year - 1
        Inizializza()
        Me.ShowDialog()
        Return _Attivita
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        lAzienda.Text = String.Format("{0} - {1}", _Attivita.Azienda.Id, _Attivita.Azienda.RagioneSociale)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbTipo, Lookups.TipiAttivita)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbCategoria, Lookups.Categorie)

        LoadAttrezzature()
        bsAttrezzature.DataSource = _tbAtt


        bsData.DataSource = _Attivita
    End Sub

    Private Sub LoadAttrezzature()
        _tbAtt = New DataTable
        _tbAtt.Columns.Add("Codice")
        _tbAtt.Columns.Add("Descrizione")
        _tbAtt.Columns.Add("Altezza")
        _tbAtt.Columns.Add("Larghezza")
        _tbAtt.Columns.Add("Selected", GetType(Boolean))

        For Each att In Lookups.TipiAttrezzatura
            Dim rw As DataRow = _tbAtt.Rows.Add(New Object() {att.Codice, att.Descrizione, "", "", False})
            Dim aa As AttrezzaturaAttivitaEntity = _Attivita.Attrezzature.FirstOrDefault(Function(x) x.CodAttrezzatura = att.Codice)
            If aa IsNot Nothing Then
                rw("Selected") = True
                If aa.Altezza.HasValue Then rw("Altezza") = aa.Altezza
                If aa.Larghezza.HasValue Then rw("Larghezza") = aa.Larghezza
            End If
        Next
    End Sub

    Private Sub InitUiSecurity()
        _CanEdit = UtentiManager.IsLoggedUserSegreteria

        tsbOk.Available = _CanEdit
        If Not _CanEdit Then
            tsbExit.Text = "Chiudi"
        End If
    End Sub

    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            Dim wasNew As Boolean = _Attivita.IsNew
            _Attivita.CodCategoria = cbCategoria.SelectedValue
            dgvAttrezzature.EndEdit()
            bsData.EndEdit()
            _Attivita.ValidateEntity()
            SaveAttrezzature()

            If _Attivita.Azienda.CodCategoria = "" AndAlso _Attivita.CodTipoAttivita = Enums.CodTipoAttivita.PRINCIPALE Then
                _Attivita.Azienda.CodCategoria = _Attivita.CodCategoria
            End If

            If _Attivita.Azienda.IsNew Then
                SociManager.SaveAzienda(_Attivita.Azienda)
            Else
                DA.SaveEntity(_Attivita, True)
                DA.SaveEntityCollection(_Attivita.Attrezzature)
            End If
            If Not wasNew Then DA.DeleteEntityCollection(_Attivita.Attrezzature.RemovedEntitiesTracker)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _Attivita.IsNew Then
            _Attivita.Azienda.Attivita.Remove(_Attivita)
        Else
            bsData.CancelEdit()
            _Attivita.RollbackFields("Edit")
            _Attivita = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub SaveAttrezzature()
        For i As Integer = 0 To _tbAtt.Rows.Count - 1
            Dim rw As DataRow = _tbAtt.Rows(i)
            Dim Cod As String = rw("Codice")
            Dim atz As AttrezzaturaAttivitaEntity = _Attivita.Attrezzature.FirstOrDefault(Function(x) x.CodAttrezzatura = Cod)
            If rw("Selected") Then
                'Aggiunge o aggiorna

                If atz Is Nothing Then
                    atz = _Attivita.Attrezzature.AddNew()
                    atz.CodAttrezzatura = Cod
                End If
                If Enums.AttrezzatureConMisure.Contains(Cod) Then
                    If IsNumeric(rw("Altezza")) Then
                        atz.Altezza = CSng(rw("Altezza"))
                    Else
                        atz.Altezza = Nothing
                    End If

                    If IsNumeric(rw("Larghezza")) Then
                        atz.Larghezza = CSng(rw("Larghezza"))
                    Else
                        atz.Larghezza = Nothing
                    End If

                End If
            Else
                'Elimina se esiste
                If atz IsNot Nothing Then
                    _Attivita.Attrezzature.Remove(atz)
                End If
            End If
        Next
    End Sub

    Private Sub dgvAttrezzature_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttrezzature.CellClick
        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DataRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row
        If col Is dgvcAttSel Then

            rw("Selected") = Not rw("Selected")
            dgvAttrezzature.InvalidateRow(e.RowIndex)
        End If
    End Sub

    Private Sub dgvAttrezzature_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAttrezzature.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DataRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row

        If col Is dgvcAttrAltezza OrElse col Is dgvcAttrLarghezza Then
            If rw("Selected") AndAlso Enums.AttrezzatureConMisure.Contains(rw("Codice")) Then
                e.CellStyle.BackColor = Color.White
                e.CellStyle.SelectionBackColor = Nothing
            Else
                e.CellStyle.BackColor = Color.FromArgb(200, 200, 200)
                e.CellStyle.SelectionBackColor = Color.FromArgb(100, 100, 100)
                e.Value = ""
            End If
        End If

    End Sub

    Private Sub dgvAttrezzature_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvAttrezzature.CellValidating

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DataRow = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem.row
        If col Is dgvcAttrAltezza OrElse col Is dgvcAttrLarghezza Then
            If e.FormattedValue <> "" AndAlso Not IsNumeric(e.FormattedValue) Then
                MsgBox("Inserire un valore numerico")
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub dgvAttrezzature_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvAttrezzature.EditingControlShowing
        Dim r As Integer = dgvAttrezzature.CurrentCell.RowIndex
        Dim c As Integer = dgvAttrezzature.CurrentCell.ColumnIndex

        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(c)
        Dim rw As DataRow = CType(sender, DataGridView).Rows(r).DataBoundItem.row

        If col Is dgvcAttrAltezza OrElse col Is dgvcAttrLarghezza Then
            Dim txt As TextBox = e.Control
            If rw("Selected") AndAlso Enums.AttrezzatureConMisure.Contains(rw("Codice")) Then
                txt.Enabled = True
            Else
                txt.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvAttrezzature_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttrezzature.CellContentClick

    End Sub
End Class