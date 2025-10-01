Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class AziendaAllegatoEntity

        Public Sub Fetch()
            Dim PP As New PrefetchPath2(CInt(EntityType.AziendaAllegatoEntity))
            Dim ppda As PrefetchPathElement2 = PP.Add(AziendaAllegatoEntity.PrefetchPathDettagliAllegati)
            ppda.SubPath.Add(DettaglioAllegatoEntity.PrefetchPathMaterialeCer)
            Dim ppa As PrefetchPathElement2 = ppda.SubPath.Add(DettaglioAllegatoEntity.PrefetchPathAllegato)
            ppa.SubPath.Add(AllegatoEntity.PrefetchPathAzienda)
            ppa.SubPath.Add(AllegatoEntity.PrefetchPathDichiarazione)

            PP.Add(AziendaAllegatoEntity.PrefetchPathAzienda)
            DA.FetchEntity(Me, PP)
            If Me.IsNew Then Throw New Exception("Azienda non trovata")
        End Sub

        Public Overrides Sub ValidateEntity()
            If Me.PartitaIva.Trim.Length < 11 Then Throw New ORMEntityValidationException("Partita iva non valida", Me)
            If Me.RagioneSociale.Trim = "" Then Throw New ORMEntityValidationException("Ragione sociale non valida", Me)
            MyBase.ValidateEntity()

        End Sub

        Public ReadOnly Property DescrizioneSede As String
            Get
                Return String.Format("{0} {1} {2}", Me.Localita, Me.Provincia, Me.Nazione)
            End Get
        End Property

        'Private _IsFornitore As Boolean
        'Public ReadOnly Property IsFornitore As Boolean
        '    Get
        '        Return Me.Fields("IsFornitore").CurrentValue <> 0
        '    End Get
        'End Property

        ''Private _IsRicevitore As Boolean
        'Public ReadOnly Property IsRicevitore As Boolean
        '    Get
        '        Return Me.Fields("IsRicevitore").CurrentValue <> 0
        '    End Get
        'End Property


    End Class
End Namespace

