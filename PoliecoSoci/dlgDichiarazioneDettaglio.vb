Imports DAL.DatabaseSpecific
Imports DAL.EntityClasses
Imports DAL.FactoryClasses
Imports DAL.HelperClasses
Imports DAL.RelationClasses
Imports DAL
Imports DAL.Managers

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class dlgDichiarazioneDettaglio
    'Private _Materiali As EntityCollection(Of MaterialeEntity)
    Private _Quadro As QuadroEntity
    Private _RigaDettaglio As RigaDichiarazioneEntity
    Private _CanEdit As Boolean

    Public Sub Apri(RigaDettaglio As RigaDichiarazioneEntity)
        _RigaDettaglio = RigaDettaglio
        _RigaDettaglio.SaveFields("Edit")
        _Quadro = _RigaDettaglio.Dichiarazione.QuadriConsentiti.First(Function(x) x.Codice = RigaDettaglio.CodQuadro)
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function Nuova(Dic As DichiarazioneEntity, Quadro As QuadroEntity) As RigaDichiarazioneEntity
        If Not Dic.DataRicezione.HasValue Then Throw New Exception("Data ricezione non definita")
        _RigaDettaglio = Dic.RigheDettaglio.AddNew
        _RigaDettaglio.CodQuadro = Quadro.Codice
        _RigaDettaglio.Procedura = Quadro.Procedura
        'If Quadro.Materiali.Count > 0 Then
        '    Dim m As MaterialeEntity = Quadro.Materiali(0)
        '    _RigaDettaglio.IdMateriale = m.Id
        '    _RigaDettaglio.CodUnitaMisura = m.CodUnitaMisura
        '    _RigaDettaglio.PrezzoUnitario = m.Prezzo
        '    '_RigaDettaglio.Iva = m.Iva
        '    _RigaDettaglio.Iva = DAL.Generale.GetAliquotaIVA(Dic.DataRicezione)
        '    _RigaDettaglio.Descrizione = m.Codice
        'End If

        _Quadro = Quadro
        Inizializza()
        txtValore.Focus()
        Me.ShowDialog()
        Return _RigaDettaglio
    End Function

    Private Sub Inizializza()
        InitUiSecurity()
        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbUM, Lookups.UnitaMisura.CreateView)
        bsData.DataSource = _RigaDettaglio

        'For Each m In _Quadro.Materiali
        '    Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro.FirstOrDefault(Function(x) x.IdMateriale = m.Id)
        '    m.PosizioneInQuadro = mq.Posizione
        'Next

        'SoloSoloMaterialiConsentiti = True
       

        mdsLLBLGenUtility.Adapter.InitLookupCombo(cbMateriale, _Quadro.MaterialiQuadro, True, "IdMateriale", "DescrMateriale")
        cbMateriale.Enabled = _RigaDettaglio.IsNew

        If _RigaDettaglio.IsNew AndAlso _Quadro.MaterialiQuadro.Count > 0 Then
            '_RigaDettaglio.IdMateriale = _Quadro.MaterialiQuadro(0).IdMateriale
            'cbMateriale.SelectedItem = _Quadro.MaterialiQuadro(0)
            cbMateriale.SelectedIndex = 0
            UpdateMaterialeSel()

        End If

    End Sub

    'Private _SoloMaterialiConsentiti As Boolean
    'Private Property SoloSoloMaterialiConsentiti As Boolean
    '    Get
    '        Return _SoloMaterialiConsentiti
    '    End Get
    '    Set(value As Boolean)
    '        _SoloMaterialiConsentiti = value
    '        If value Then
    '            _Materiali.Filter = New PredicateExpression()
    '            Dim pr As New PredicateExpression
    '            pr.AddWithAnd((New FieldCompareNullPredicate(MaterialeFields.DataInizio, Nothing) Or MaterialeFields.DataInizio <= _RigaDettaglio.Dichiarazione.DataInizio))
    '            pr.AddWithAnd((New FieldCompareNullPredicate(MaterialeFields.DataFine, Nothing) Or MaterialeFields.DataFine >= _RigaDettaglio.Dichiarazione.DataInizio))
    '            _Materiali.Filter = pr
    '        Else
    '            _Materiali.Filter = Nothing
    '        End If
    '    End Set
    'End Property

    Private Sub InitUiSecurity()
        _CanEdit = UtentiManager.IsLoggedUserSegreteria

        tsbOk.Available = _CanEdit
        If Not _CanEdit Then
            tsbExit.Text = "Chiudi"
        End If
    End Sub

    Private Sub tsbOk_Click(sender As System.Object, e As System.EventArgs) Handles tsbOk.Click
        Try
            bsData.EndEdit()
            _RigaDettaglio.ValidateEntity()
            DA.SaveEntity(_RigaDettaglio, True)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click
        If _RigaDettaglio.IsNew Then
            _RigaDettaglio.Dichiarazione.RigheDettaglio.Remove(_RigaDettaglio)
        Else
            bsData.CancelEdit()
            _RigaDettaglio.RollbackFields("Edit")
            _RigaDettaglio = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub cbMateriale_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbMateriale.SelectionChangeCommitted
        UpdateMaterialeSel()
    End Sub


    Private Sub UpdateMaterialeSel()
        If _RigaDettaglio.IsNew Then
            Dim mat As MaterialeEntity = CType(cbMateriale.SelectedItem, MaterialeQuadroEntity).Materiale
            If mat Is Nothing Then
                cbUM.SelectedIndex = -1
                txtImpUnitario.Text = "0"
                txtIVA.Text = "0"
            Else
                _RigaDettaglio.CodUnitaMisura = mat.CodUnitaMisura
                _RigaDettaglio.PrezzoUnitario = mat.Prezzo
                '_RigaDettaglio.Iva = mat.Iva
                _RigaDettaglio.Iva = DAL.Generale.GetAliquotaIVA(_RigaDettaglio.Dichiarazione.DataRicezione)
                _RigaDettaglio.Descrizione = mat.Codice
                _RigaDettaglio.IdMateriale = mat.Id
            End If

            '_RigaDettaglio.IdMateriale = cbMateriale.SelectedValue

        End If

    End Sub

End Class