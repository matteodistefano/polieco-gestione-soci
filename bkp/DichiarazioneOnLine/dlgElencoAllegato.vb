Public Class dlgElencoAllegato


    Private _TipiAllegati As DataTable
    Private _data As DAL.Datasets.dsDichiarazione
    Private _isReady As Boolean

    Public Sub Apri(d As DAL.Datasets.dsDichiarazione)
        _data = d
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        Dim tt As DataTable = mdsUtility.Dataset.GetDistinctValue(_data.Voce, "TipoAllegato")
        _TipiAllegati = Manager.TipiAllegato.Clone()
        For Each rw In tt.Rows
            Dim Cat As String = CStr(rw(0))
            If _data.Dichiarazione(0)("Cat" & Cat.Substring(0, 1)) Then
                _TipiAllegati.ImportRow(Manager.TipiAllegato.Rows.Find(Cat))
            End If
        Next

        cbTipo.DataSource = _TipiAllegati
        cbTipo.DisplayMember = "Descrizione"
        cbTipo.ValueMember = "Codice"

        dgvData.AutoGenerateColumns = False
        dgvData.DataSource = bsData

        _isReady = True

        cbTipo_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub CaricaDati()
        If Not _isReady Then Return
        Dim tipoall As String = cbTipo.SelectedValue
        Dim td As DataView = New DataView(_data.Voce, "TipoAllegato='" & tipoAll & "'", "", DataViewRowState.CurrentRows)
        bsData.DataSource = td



    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        If Not _isReady Then Return
        Dim tipoall As String = cbTipo.SelectedValue
        Select Case tipoall
            Case "B"
                dgvcB_Periodo.Visible = True
                dgvcB_Contributo.Visible = True
                dgvcCE_CodCER.Visible = False
                dgvcCE_Provenienza.Visible = False
                dgvcE_Autorizzazioni.Visible = False
                dgvcE_Lavorazione.Visible = False
                dgvcE_Licenze.Visible = False
                dgvcE_Nazione.Visible = False
                dgvcE_ProcProduttivo.Visible = False
            Case "C"
                dgvcB_Periodo.Visible = False
                dgvcB_Contributo.Visible = False
                dgvcCE_CodCER.Visible = True
                dgvcCE_Provenienza.Visible = True
                dgvcE_Autorizzazioni.Visible = False
                dgvcE_Lavorazione.Visible = False
                dgvcE_Licenze.Visible = False
                dgvcE_Nazione.Visible = False
                dgvcE_ProcProduttivo.Visible = False
            Case "E1"
                dgvcB_Periodo.Visible = False
                dgvcB_Contributo.Visible = False
                dgvcCE_CodCER.Visible = True
                dgvcCE_Provenienza.Visible = True
                dgvcE_Autorizzazioni.Visible = False
                dgvcE_Lavorazione.Visible = False
                dgvcE_Licenze.Visible = False
                dgvcE_Nazione.Visible = False
                dgvcE_ProcProduttivo.Visible = False
            Case "E2"
                dgvcB_Periodo.Visible = False
                dgvcB_Contributo.Visible = False
                dgvcCE_CodCER.Visible = True
                dgvcCE_Provenienza.Visible = False
                dgvcE_Autorizzazioni.Visible = False
                dgvcE_Lavorazione.Visible = True
                dgvcE_Licenze.Visible = False
                dgvcE_Nazione.Visible = False
                dgvcE_ProcProduttivo.Visible = False
            Case "E3"
                dgvcB_Periodo.Visible = False
                dgvcB_Contributo.Visible = False
                dgvcCE_CodCER.Visible = True
                dgvcCE_Provenienza.Visible = False
                dgvcE_Autorizzazioni.Visible = False
                dgvcE_Lavorazione.Visible = False
                dgvcE_Licenze.Visible = True
                dgvcE_Nazione.Visible = True
                dgvcE_ProcProduttivo.Visible = True
        End Select

        CaricaDati()

    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub
End Class