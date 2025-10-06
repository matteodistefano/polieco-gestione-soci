Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FElencoRiunioni
    Private _PP As PrefetchPath2
    Private _Riunioni As EntityCollection(Of RiunioneEntity)
    Private _SelRiunioni() As RiunioneEntity
    Private _IsReady As Boolean


    Public Sub Apri()
        tsbSelect.Available = False
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function GetRiunioni() As IEnumerable(Of RiunioneEntity)
        tsbSelect.Available = True
        Inizializza()
        Me.ShowDialog()
        Return _SelRiunioni
    End Function

    Private Sub Inizializza()

        '_PP = New PrefetchPath2(CInt(EntityType.RiunioneEntity))
        '_PP.Add(UtenteEntity.PrefetchPathRuoli)
        ccTipo.SetData(Lookups.TipiRiunione, "Descrizione", "Codice")

        cdiPeriodo.DataIniziale = Date.Today.AddMonths(-6)

        _Riunioni = New EntityCollection(Of RiunioneEntity)

        'Dim so As New SortExpression(ScadenzaFields.Codice Or SortOperator.Descending)
        'DA.FetchEntityCollection(_Scadenze, Nothing, 0, so)
        _IsReady = True
        CaricaDati()
    End Sub

    Private Sub CaricaDati()
        If Not _IsReady Then Return
        Try
            Cursor = Cursors.WaitCursor
            Dim pr As New PredicateExpression
            If ccTipo.Checked Then
                pr.AddWithAnd(RiunioneFields.Tipo = ccTipo.SelectedValue)
            End If
            If cdiPeriodo.HasCondition Then
                If cdiPeriodo.DataIniziale.HasValue Then pr.AddWithAnd(RiunioneFields.Data >= cdiPeriodo.DataIniziale.Value)
                If cdiPeriodo.DataFinale.HasValue Then pr.AddWithAnd(RiunioneFields.Data <= cdiPeriodo.DataFinale.Value)
            End If

            Dim txt As String = txtNote.Text.Trim
            If txt <> "" Then
                pr.AddWithAnd(RiunioneFields.Note Mod ("%" & txt & "%"))
            End If

            _Riunioni.Clear()
            Generale.DA.FetchEntityCollection(_Riunioni, New RelationPredicateBucket(pr), 0, New SortExpression(RiunioneFields.Data Or SortOperator.Descending))

            Me.bsRiunioni.DataSource = _Riunioni
        Finally
            Cursor = Cursors.Default
        End Try
        
    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        _SelRiunioni = Nothing
        Me.Close()
    End Sub

    Private Sub tsbNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuova.Click
        Try
            Dim Riunione As New RiunioneEntity
            Riunione.Data = Date.Today
            Dim F As New dlgRiunione
            If F.Apri(Riunione) Then
                Me._Riunioni.Add(Riunione)
                CaricaDati()
                bsRiunioni.Position = bsRiunioni.IndexOf(Riunione)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriRiunione()
    End Sub

    Private Sub ApriRiunione()
        If Me.bsRiunioni.Current Is Nothing Then Return
        Try
            Dim F As New dlgRiunione
            F.Apri(Me.bsRiunioni.Current)
            CaricaDati()
            dgvElenco.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim Riun As RiunioneEntity = bsRiunioni.Current
        If Riun Is Nothing Then Return
        If MsgBox("Eliminare la riunione selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Riunione", Managers.AuditManager.OperazioneEnum.DEL, Riun.Id & "-" & Riun.Data)
            DA.DeleteEntity(Riun)
            Me.bsRiunioni.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccTipo_SelectionChanged(sender As Object, e As EventArgs) Handles ccTipo.SelectionChanged
        CaricaDati()
    End Sub

    Private Sub tsbSelect_Click(sender As Object, e As EventArgs) Handles tsbSelect.Click
        Dim ss() As RiunioneEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of RiunioneEntity)(dgvElenco, False)
        If ss Is Nothing OrElse ss.Length = 0 Then Return
        _SelRiunioni = ss
        Me.Close()
    End Sub

    Private Sub cdiPeriodo_SelectionChanged(sender As Object, e As mdsUIControls.ctlDateInterval.SelectionChangedEvetArgs) Handles cdiPeriodo.SelectionChanged
        CaricaDati()
    End Sub

    Private Sub FElencoRiunioni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub cdiPeriodo_Load()

    End Sub
End Class