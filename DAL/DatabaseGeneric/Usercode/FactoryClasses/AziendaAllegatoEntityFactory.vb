Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.HelperClasses

Namespace DAL.FactoryClasses
    Partial Public Class AziendaAllegatoEntityFactory
        Public Overrides Function CreateFields() As IEntityFields2
            Dim ret As EntityFields2 = MyBase.CreateFields()
            ret.Expand(2)

            Dim fld As EntityField2
            fld = New EntityField2("IsFornitore", New ScalarQueryExpression(DettaglioAllegatoFields.Id.SetAggregateFunction(AggregateFunction.Count),
                                                                                 DettaglioAllegatoFields.IdAziendaAllegato = AziendaAllegatoFields.Id _
                                                                                 And DettaglioAllegatoFields.RuoloAziendaAllegato = Enums.RuoloAziendaAllegato.FORNITORE))

            ret.DefineField(fld, ret.Count - 2)

            fld = New EntityField2("IsRicevitore", New ScalarQueryExpression(DettaglioAllegatoFields.Id.SetAggregateFunction(AggregateFunction.Count),
                                                                                 DettaglioAllegatoFields.IdAziendaAllegato = AziendaAllegatoFields.Id _
                                                                                 And DettaglioAllegatoFields.RuoloAziendaAllegato = Enums.RuoloAziendaAllegato.RICEVITORE))

            ret.DefineField(fld, ret.Count - 1)
            Return ret
        End Function
    End Class
End Namespace

