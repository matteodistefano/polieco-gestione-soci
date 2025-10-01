Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FElencoScadenze
    Private _PP As PrefetchPath2
    Private _Scadenze As EntityView2(Of ScadenzaEntity)
    Private _SelScadenze() As ScadenzaEntity
    Private _CanEdit As Boolean

    Public Sub Apri()
        tsbSelect.Available = False
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function GetScadenze() As IEnumerable(Of ScadenzaEntity)
        tsbSelect.Available = True
        Inizializza()
        Me.ShowDialog()
        Return _SelScadenze
    End Function

    Private Sub InitUISecurity()

        _CanEdit = DAL.Managers.UtentiManager.IsLoggedUserInRole(Enums.Ruolo.DIREZIONE)
        tsbNuova.Available = _CanEdit
        tsbModifica.Available = _CanEdit
        tsbElimina.Available = _CanEdit
        tsbDuplica.Available = _CanEdit

    End Sub



    Private Sub Inizializza()



        '_PP = New PrefetchPath2(CInt(EntityType.ScadenzaEntity))
        '_PP.Add(UtenteEntity.PrefetchPathRuoli)
        ccCategoria.SetData(Lookups.Categorie, "Descrizione", "Codice")

        Dim aa(11) As Integer
        Dim a1 As Integer = Date.Today.Year
        For i As Integer = 0 To 11
            aa(i) = a1 + 1 - i
        Next
        ccAnno.SetData(aa, "", "")
        ccAnno.SelectedIndex = -1


        _Scadenze = Lookups.Scadenze(True).CreateView
        'Dim so As New SortExpression(ScadenzaFields.Codice Or SortOperator.Descending)
        'DA.FetchEntityCollection(_Scadenze, Nothing, 0, so)
        CaricaDati()
        InitUISecurity()
    End Sub

    Private Sub CaricaDati()
        If _Scadenze Is Nothing Then Return

        Dim pr As New PredicateExpression
        If ccCategoria.Checked Then
            pr.AddWithAnd(ScadenzaFields.CodCategoria = ccCategoria.SelectedValue)
        End If
        If ccAnno.Checked AndAlso Val(ccAnno.ComboText) <> 0 Then
            pr.AddWithAnd(ScadenzaFields.Anno = Val(ccAnno.ComboText))
        End If
        If chkAuto.Checked Then
            pr.AddWithAnd(ScadenzaFields.CreaAutomatico = True)
        End If

        _Scadenze.Filter = pr
        Me.bsScadenze.DataSource = _Scadenze
    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        _SelScadenze = Nothing
        Me.Close()
    End Sub

    Private Sub tsbNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuova.Click
        Dim Scad As New ScadenzaEntity
        Scad.CreaAutomatico = True
        Scad.DataInizio = Date.Today
        Scad.Anno = Date.Today.Year

        Dim F As New dlgScadenza
        If F.Apri(Scad) Then
            Me._Scadenze.RelatedCollection.Add(Scad)
            CaricaDati()
            bsScadenze.Position = bsScadenze.IndexOf(Scad)
        End If
    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriScadenza()
    End Sub

    Private Sub ApriScadenza()
        If Not _CanEdit Then Return
        If Me.bsScadenze.Current Is Nothing Then Return
        Dim F As New dlgScadenza
        F.Apri(Me.bsScadenze.Current)
        CaricaDati()
        dgvElenco.Invalidate()
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim Scad As ScadenzaEntity = bsScadenze.Current
        If Scad Is Nothing Then Return
        If MsgBox("Eliminare la scadenza selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Scadenza", Managers.AuditManager.OperazioneEnum.DEL, Scad.Codice)
            DA.DeleteEntity(Scad)
            Me.bsScadenze.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccCategoria_SelectionChanged(sender As Object, e As EventArgs) Handles ccCategoria.SelectionChanged, ccAnno.SelectionChanged, chkAuto.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub tsbSelect_Click(sender As Object, e As EventArgs) Handles tsbSelect.Click
        Dim ss() As ScadenzaEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of ScadenzaEntity)(dgvElenco, False)
        If ss Is Nothing OrElse ss.Length = 0 Then Return
        _SelScadenze = ss
        Me.Close()
    End Sub

    Private Sub tsbDuplica_Click(sender As Object, e As EventArgs) Handles tsbDuplica.Click
        Try
            Dim ss() As ScadenzaEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of ScadenzaEntity)(dgvElenco, False)
            If ss.Count = 0 Then Return
            Dim F As New mdsUIControls.dlgGetInfo()
            Dim itAnno As New mdsUIControls.dlgGetInfo.InfoType("Anno", GetType(System.String), False, Date.Today.Year)
            If Not F.Apri(itAnno, "Richiesta anno", "Inserire l'anno da assegnare alle nuove scadenze") Then Return
            Dim Anno As Integer = itAnno.Value
            If Anno < 1900 Or Anno > Date.Today.Year + 10 Then Throw New Exception("Anno non valido")

            Dim newSS As New EntityCollection(Of ScadenzaEntity)

            For Each s In ss
                Dim ns As ScadenzaEntity = newSS.AddNew
                Dim DiffAnno As Integer = Anno - s.Anno

                ns.Anno = s.Anno + DiffAnno
                ns.RifPeriodo = s.RifPeriodo
                ns.ApplicaInteressi = s.ApplicaInteressi
                ns.CodCategoria = s.CodCategoria
                ns.Codice = Anno & s.Codice.Substring(4)
                ns.CreaAutomatico = s.CreaAutomatico
                ns.DataFine = Microsoft.VisualBasic.DateSerial(s.DataFine.Year + DiffAnno, s.DataFine.Month, s.DataFine.Day).Add(New TimeSpan(23, 59, 0))
                ns.DataInizio = Microsoft.VisualBasic.DateSerial(s.DataInizio.Year + DiffAnno, s.DataInizio.Month, s.DataInizio.Day)
                ns.DataScadenzaDichiarazione = Microsoft.VisualBasic.DateSerial(s.DataScadenzaDichiarazione.Year + DiffAnno, s.DataScadenzaDichiarazione.Month, s.DataScadenzaDichiarazione.Day).Add(New TimeSpan(23, 59, 0))
                ns.DataScadenzaPagamento = Microsoft.VisualBasic.DateSerial(s.DataScadenzaPagamento.Year + DiffAnno, s.DataScadenzaPagamento.Month, s.DataScadenzaPagamento.Day).Add(New TimeSpan(23, 59, 0))
                ns.TassoInteresse = s.TassoInteresse
            Next

            DA.SaveEntityCollection(newSS)
            Lookups.ResetCollection("Scadenze")

            _Scadenze = Lookups.Scadenze.CreateView

            CaricaDati()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FElencoScadenze_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub dgvElenco_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElenco.CellContentClick

    End Sub
End Class