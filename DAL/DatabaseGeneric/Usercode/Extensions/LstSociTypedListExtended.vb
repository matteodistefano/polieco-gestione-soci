Imports DAL
Imports DAL.EntityClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace DAL.TypedListClasses
    Public Class LstSociTypedListExtended
        Inherits LstSociTypedList


        Protected _columnTelefoni As DataColumn
        Protected _columnCatAttivitaPrincipale As DataColumn
        Protected _columnCatAttivitaSecondaria As DataColumn

        'Private _InfoSchede As Boolean
        'Public Property InfoScheda() As Boolean
        '    Get
        '        Return _InfoSchede
        '    End Get
        '    Set(value As Boolean)
        '        _InfoSchede = value
        '    End Set
        'End Property

        Protected Overrides Sub OnInitialized()
            _columnTelefoni = GeneralUtils.CreateTypedDataTableColumn("DescrTelefoni", "Telefoni", GetType(System.String), Me.Columns)
            _columnTelefoni.Expression = "TELEFONO1+IIF(TELEFONO2<>'','" & vbCr & "'+TELEFONO2,'')"

            _columnCatAttivitaPrincipale = GeneralUtils.CreateTypedDataTableColumn("CatAttivitaPrincipale", "CatAttivitaPrincipale", GetType(System.String), Me.Columns)
            _columnCatAttivitaSecondaria = GeneralUtils.CreateTypedDataTableColumn("CatAttivitaSecondaria", "CatAttivitaSecondaria", GetType(System.String), Me.Columns)

        End Sub

        Protected Overrides Sub OnResultsetBuilt(fields As SD.LLBLGen.Pro.ORMSupportClasses.IEntityFields2)
            Dim Id As Integer
            'If _ControllaCheck Then
            Id = fields.Count
            fields.Expand(2)


            fields.DefineField(New EntityField2("CatAttivitaPrincipale", _
                    New Expression(HelperClasses.AziendaFields.Id.SetExpression( _
                    New DbFunctionCall("(Select top 1 CodCategoria from Attivita where idazienda={0} and CodTipoAttivita='PRI')", _
                    New Object() {HelperClasses.AziendaFields.Id})))), Id)

            fields.DefineField(New EntityField2("CatAttivitaSecondaria", _
                    New Expression(HelperClasses.AziendaFields.Id.SetExpression( _
                    New DbFunctionCall("(Select top 1 CodCategoria from Attivita where idazienda={0} and CodTipoAttivita='SEC')", _
                    New Object() {HelperClasses.AziendaFields.Id})))), Id + 1)


            'End If

        End Sub




    End Class

End Namespace
