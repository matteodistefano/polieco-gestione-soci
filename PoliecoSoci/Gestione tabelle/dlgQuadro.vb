Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgQuadro
    Private _Quadro As QuadroEntity
    Private _Materiali As EntityView2(Of MaterialeEntity)
    Private retValue As Boolean

    Public Function Apri(ByVal Q As QuadroEntity) As Boolean
        Me._Quadro = Q
        Q.AuditorToUse = New EntityAuditor


        'Refetch Materiali
        'Dim PP As New PrefetchPath2(CInt(EntityType.MaterialeQuadroEntity))
        'PP.Add(MaterialeQuadroEntity.PrefetchPathMateriale)
        'DA.FetchEntityCollection(Q.MaterialiQuadro, Q.GetRelationInfoMaterialiQuadro, PP)

        If Not Q.IsNew Then
            Dim PP As New PrefetchPath2(CInt(EntityType.QuadroEntity))
            PP.Add(QuadroEntity.PrefetchPathMateriali)
            PP.Add(QuadroEntity.PrefetchPathMaterialiQuadro)
            DA.FetchEntity(Q, PP)
        End If

        _Quadro.Materiali.IsReadOnly = False

        Inizializza()
        Me.ShowDialog()
        Q.AuditorToUse = Nothing
        Return retValue
    End Function

    Private Sub Inizializza()

        DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)

        _Quadro.SaveFields("Edit")
        

        _Quadro.MaterialiQuadro.RemovedEntitiesTracker = New EntityCollection(Of MaterialeQuadroEntity)

        cbTipo.DataSource = Lookups.TipiQuadro
        cbTipo.DisplayMember = "Descrizione"
        cbTipo.ValueMember = "Codice"
        cbTipo.DataBindings.Add("SelectedValue", bsEntity, "CodTipo")

        If _Quadro.Segno >= 0 Then
            rbS0.Checked = True
        Else
            rbS1.Checked = True
        End If
        Me.bsEntity.DataSource = _Quadro

        For i As Integer = 0 To _Quadro.MaterialiQuadro.Count - 1
            Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro(i)
            Dim m As MaterialeEntity = _Quadro.Materiali.FirstOrDefault(Function(x) x.Id = mq.IdMateriale)
            m.PosizioneInQuadro = mq.Posizione
            If m.PosizioneInQuadro = "" Then m.PosizioneInQuadro = i + 1
        Next

        _Materiali = _Quadro.Materiali.CreateView(Nothing, New SortExpression(New EntityProperty("PosizioneInQuadro") Or SortOperator.Ascending))
        bsMateriali.DataSource = _Materiali


        dgvMateriali.AutoGenerateColumns = False
        dgvMateriali.DataSource = bsMateriali


    End Sub


    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        Me.bsEntity.CancelEdit()
        If Not _Quadro.IsNew Then
            _Quadro.RollbackFields("Edit")
        End If
        retValue = False
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            Me.bsEntity.EndEdit()
            If rbS0.Checked Then
                _Quadro.Segno = 1
            Else
                _Quadro.Segno = -1
            End If
            Me._Quadro.ValidateEntity()

            If Not _Quadro.IsNew Then
                For Each m In _Quadro.MaterialiQuadro.RemovedEntitiesTracker
                    DA.DeleteEntity(m)
                Next
                _Quadro.MaterialiQuadro.RemovedEntitiesTracker.Clear()
            End If

            For Each m As MaterialeEntity In _Quadro.Materiali
                Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro.FirstOrDefault(Function(x) x.IdMateriale = m.Id)
                mq.Posizione = m.PosizioneInQuadro
            Next

            DA.SaveEntity(_Quadro, True, True)
            retValue = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnMatAdd_Click(sender As Object, e As EventArgs) Handles btnMatAdd.Click
        Try
            Dim F As New mdsUIControls.FSelTabella
            Dim sel() As Object = F.GetMultiSelectedRow("Selezione materiale", Lookups.Materiali.DefaultView, "DescrizioneEstesa")
            If sel Is Nothing OrElse sel.Count = 0 Then Return
            For Each s As MaterialeEntity In sel
                If _Quadro.Materiali.FirstOrDefault(Function(x) x.Id = s.Id) Is Nothing Then


                    _Quadro.Materiali.Add(s)

                    Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro.AddNew
                    mq.IdMateriale = s.Id
                    s.PosizioneInQuadro = _Quadro.Materiali.Count
                    'Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro.AddNew()
                    'mq.Materiale = s
                End If
            Next
            _Materiali.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnMatDel_Click(sender As Object, e As EventArgs) Handles btnMatDel.Click
        Try
            Dim m As MaterialeEntity = bsMateriali.Current
            If m Is Nothing Then Return
            Dim mq As MaterialeQuadroEntity = _Quadro.MaterialiQuadro.FirstOrDefault(Function(x) x.IdMateriale = m.Id)
            _Quadro.MaterialiQuadro.Remove(mq)
            _Quadro.Materiali.Remove(m)
            'bsMateriali.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnMatUp_Click(sender As Object, e As EventArgs) Handles btnMatUp.Click
        Try
            Dim p As Integer = bsMateriali.Position
            If p <= 0 Then Return
            Dim m1 As MaterialeEntity = bsMateriali.Item(p - 1)
            Dim m2 As MaterialeEntity = bsMateriali.Item(p)
            Dim pos As String = m1.PosizioneInQuadro
            m1.PosizioneInQuadro = m2.PosizioneInQuadro
            m2.PosizioneInQuadro = pos
            _Materiali.Refresh()
            dgvMateriali.Invalidate()
            bsMateriali.Position = p - 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnMatDown_Click(sender As Object, e As EventArgs) Handles btnMatDown.Click
        Try
            Dim p As Integer = bsMateriali.Position
            If p = -1 OrElse p = bsMateriali.Count - 1 Then Return
            Dim m1 As MaterialeEntity = bsMateriali.Item(p)
            Dim m2 As MaterialeEntity = bsMateriali.Item(p + 1)
            Dim pos As String = m1.PosizioneInQuadro
            m1.PosizioneInQuadro = m2.PosizioneInQuadro
            m2.PosizioneInQuadro = pos
            _Materiali.Refresh()
            dgvMateriali.Invalidate()
            bsMateriali.Position = p + 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class