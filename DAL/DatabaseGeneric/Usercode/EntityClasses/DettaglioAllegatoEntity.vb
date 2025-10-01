Imports SD.LLBLGen.Pro.ORMSupportClasses
Namespace DAL.EntityClasses
    Partial Public Class DettaglioAllegatoEntity
        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.AziendaAllegato Is Nothing Then Throw New ORMEntityValidationException("Azienda non definita", Me)
            If Me.Allegato.CategoriaAzienda = "B" Then
                Me.UnitaMisura = Enums.UNITA_MISURA.KG
            Else
                Me.UnitaMisura = Enums.UNITA_MISURA.TONN
                If Me.MaterialeCer Is Nothing Then Throw New ORMEntityValidationException("Codice CER non definito", Me)
            End If
            If Me.RuoloAziendaAllegato = "" Then Throw New ORMEntityValidationException("Ruolo non definito", Me)
            If Me.UnitaMisura = "" Then Throw New ORMEntityValidationException("Unità misura non definita", Me)
            If Me.Quantita.GetValueOrDefault = 0 Then Throw New ORMEntityValidationException("Quantità non definita", Me)
        End Sub

        Public ReadOnly Property AziendaRagioneSociale As String
            Get
                If Me.AziendaAllegato Is Nothing Then Return "?"
                Return Me.AziendaAllegato.RagioneSociale
            End Get
        End Property

        Public ReadOnly Property AziendaLocalita As String
            Get
                If Me.AziendaAllegato Is Nothing Then Return "?"
                Return Me.AziendaAllegato.Localita
            End Get
        End Property

        Public ReadOnly Property AziendaProvincia As String
            Get
                If Me.AziendaAllegato Is Nothing Then Return "?"
                Return Me.AziendaAllegato.Provincia
            End Get
        End Property

        Public ReadOnly Property AziendaPartitaIva As String
            Get
                If Me.AziendaAllegato Is Nothing Then Return "?"
                Return Me.AziendaAllegato.PartitaIva
            End Get
        End Property

        Public ReadOnly Property AziendaDescrizioneSede As String
            Get
                If Me.AziendaAllegato Is Nothing Then Return "?"
                Return Me.AziendaAllegato.DescrizioneSede
            End Get
        End Property

        Public ReadOnly Property DescrizioneMateriale As String
            Get
                If Me.MaterialeCer Is Nothing Then Return "?"
                Return Me.MaterialeCer.Descrizione
            End Get
        End Property

        Public ReadOnly Property DescrizioneDichiarazione As String
            Get
                If Me.Allegato Is Nothing Then Return "?"
                If Me.Allegato.Dichiarazione Is Nothing Then Return "?"
                Return String.Format("{0} - {1}", Me.Allegato.Dichiarazione.Anno, Me.Allegato.Dichiarazione.Periodo)
            End Get
        End Property

        Public ReadOnly Property DichiaranteDescrizione As String
            Get
                If Me.Allegato Is Nothing Then Return "?"
                If Me.Allegato.Azienda Is Nothing Then Return "?"
                Return String.Format("{0}", Me.Allegato.Azienda.RagioneSociale)
            End Get
        End Property

        Public ReadOnly Property DichiaranteSede As String
            Get
                If Me.Allegato Is Nothing Then Return "?"
                If Me.Allegato.Azienda Is Nothing Then Return "?"
                Return String.Format("{0} {1}", Me.Allegato.Azienda.Localita, Me.Allegato.Azienda.Provincia)
            End Get
        End Property




    End Class
End Namespace

