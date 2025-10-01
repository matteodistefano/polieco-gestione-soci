Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports DAL.TypedViewClasses

Public Class FRicercaQuantitativi
    Private _Data As VwRicercaQuantitativiTypedView
    Private _IsReady As Boolean

    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()

        'DichiarazioneOnLine.Manager.SetDataAdapter(Generale.DA)

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbRegione, Lookups.Regioni, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbProvincia, Lookups.Province, True)
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbMateriale, Lookups.TipiMateriale.CreateView(New FieldCompareRangePredicate(TipoMaterialeFields.Codice, Nothing, True, New Object() {"RESEPRODOTTI", "RIMBORSOMP"})), True)

        _Data = New VwRicercaQuantitativiTypedView
        _Data.Columns.Add("_ValoreTn", GetType(Decimal), "ValoreKg/1000")

        dgslPeso.Initialize(dgvcPeso, mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM)

        mcCat.Initialize(New CheckBox() {chkCatA, chkCatB, chkCatC, chkCatD, chkCatE})

        Dim aa(10) As Integer
        Dim a1 As Integer = Date.Today.Year
        For i As Integer = 0 To 10
            aa(i) = a1 - i
        Next
        ccAnno.SetData(aa, "", "")
        ccAnno.SelectedIndex = 1
        ccAnno.Checked = True

        cbUm.SelectedIndex = 0

        ResetFilters()
        
    End Sub

    Private Sub CaricaDati()
        Try
            If Not _IsReady Then Return
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim txt As String
            Dim pr As New PredicateExpression

            txt = txtRagioneSociale.Text.Trim
            If txt <> "" Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.RagioneSociale Mod ("%" & txt & "%"))
            End If

            txt = cbRegione.Text
            If txt <> "" Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.Regione = txt)
            End If

            txt = IIf(cbProvincia.Text = "", "", cbProvincia.SelectedValue)
            If txt <> "" Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.Provincia = txt)
            End If

            If mcCat.HasUnCheck Then
                Dim prCat As New PredicateExpression
                For Each chk In mcCat.GetAllChecked
                    prCat.AddWithOr(VwRicercaQuantitativiFields.CodCategoria = chk.Text)
                Next
                pr.AddWithAnd(prCat)
            End If

            txt = IIf(cbMateriale.Text = "", "", cbMateriale.SelectedValue)
            If txt <> "" Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.CodTipo = txt)
            End If

            If ccAnno.Checked AndAlso Val(ccAnno.ComboText) <> 0 Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.Anno = Val(ccAnno.ComboText))
            End If

            If chkNoNull.Checked Then
                pr.AddWithAnd(VwRicercaQuantitativiFields.Valorekg <> 0)
            End If

            txt = txtPeso.Text.Trim
            If txt <> "" Then
                Dim Ratio As Decimal
                If cbUm.Text = "Tn" Then
                    Ratio = 1000
                Else
                    Ratio = 1
                End If
                Dim PesoCond As Predicate = mdsLLBLGenUtility.Common.ParseNumericCondition(txt, VwRicercaQuantitativiFields.Valorekg, Ratio)
                If PesoCond IsNot Nothing Then
                    pr.AddWithAnd(PesoCond)
                Else
                    MsgBox("Attenzione !!! Condizione su peso non riconosciuta.", MsgBoxStyle.Information)
                End If
            End If


            _Data.Clear()
            DA.FetchTypedView(_Data, New RelationPredicateBucket(pr), True)
            Me.bsData.DataSource = _Data
            lTotVoci.Text = String.Format("{0:n0}", _Data.Count)
            dgslPeso.UpdateSummary()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try



    End Sub

    Private Sub ResetFilters()
        _IsReady = False

        txtRagioneSociale.Text = ""
        cbRegione.Text = ""
        cbProvincia.Text = ""
        mcCat.CheckAll()
        cbMateriale.Text = ""
        ccAnno.Checked = True
        txtPeso.Text = ""
        _IsReady = True
        CaricaDati()
    End Sub



    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    
    Private Sub tsbDettaglio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDettaglio.Click, dgvElenco.DoubleClick
        ApriDOL()
    End Sub

    Private Sub ApriDOL()
        Try
            If Me.bsData.Current Is Nothing Then Return
            Dim rq As VwRicercaQuantitativiRow = bsData.Current.row
            Dim F As New FAzienda
            F.Apri(rq.IdAzienda)
            bsData.Position = bsData.IndexOf(rq)
            dgvElenco.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccAnno_SelectionChanged(sender As Object, e As EventArgs) _
                            Handles ccAnno.SelectionChanged _
                                , cbRegione.SelectedValueChanged _
                                , cbProvincia.SelectedValueChanged _
                                , cbMateriale.SelectedValueChanged

        CaricaDati()
    End Sub

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        CaricaDati()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFilters()
    End Sub

    Private Sub mcStato_CheckedChanged(sender As Object, e As EventArgs) Handles mcCat.CheckedChanged, chkNoNull.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub cbUm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUm.SelectedIndexChanged
        If cbUm.Text = "Tn" Then
            dgvcPeso.DataPropertyName = "_valoreTn"
            dgvcPeso.HeaderText = "Peso (Tn)"
            lTotPeso.Text = "Totale (Tn)"
            dgvcPeso.Width = 120
        Else
            dgvcPeso.DataPropertyName = "valoreKg"
            dgvcPeso.HeaderText = "Peso (Kg)"
            lTotPeso.Text = "Totale (Kg)"
            dgvcPeso.Width = 160
        End If
        dgslPeso.UpdateSummary()
        dgslPeso.UpdatePosition()
    End Sub

    Private Sub FRicercaQuantitativi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            btnCerca.PerformClick()
        End If
    End Sub

    Private Sub btnHelpImporto_Click(sender As Object, e As EventArgs) Handles btnHelpImporto.Click
        MsgBox("Oltre al valore numerico, è possibile definire delle semplici condizioni per filtrare sul peso." & vbCr & vbCr _
              & "Esempi:" & vbCr _
              & "> 100.66 (maggiore di)" & vbCr _
              & "< 100.66 (minore di)" & vbCr _
              & "! 200.11 (diverso da)" & vbCr _
              & "da 120 a 234 (compreso tra)" & vbCr _
              & "tra 0 e 100 (compreso tra)" & vbCr _
              & "1000 - 1500 (compreso tra)" & vbCr _
              & "100 +- 1 (con tolleranza assoluta di)" & vbCr _
              & "100 +- 0,5% (con tolleranza relativa di)", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try

            'Me._Data.WriteXmlSchema("E:\NET2012\PoliecoSoci\Solution\PoliecoSoci\Datasets\elencoquantitativi.xml")
            Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim F As New mdsReport.FReport
            Rpt = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\elencoquantitativi.rpt")

            'Dim sc As DataGridViewColumn = dgvElenco.SortedColumn
            'If sc IsNot Nothing Then
            '    Dim sd As String = IIf(dgvElenco.SortOrder = SortOrder.Ascending, "ASC", "DESC")
            '    Dim srtExp As String = String.Format("vwRicercaQuantitativi.{0} {1}", sc.DataPropertyName, sd)
            '    F.ApplySortFormula(Rpt, srtExp)
            'End If

            F.ApplyLogonData(Rpt, DA.ConnectionString, _Data)

            F.Apri(Rpt)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class