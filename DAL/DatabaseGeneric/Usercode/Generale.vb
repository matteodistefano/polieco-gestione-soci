Imports System
Imports System.ComponentModel
Imports System.Collections
Imports DAL.FactoryClasses
Imports DAL.RelationClasses
Imports DAL.HelperClasses
Imports DAL.EntityClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Namespace DAL
    Public Module Generale
        Private _DA As DataAccessAdapterBase
        Public ReadOnly Property DA As DataAccessAdapterBase
            Get
                Return _DA
            End Get
        End Property

        Private _DbLib As mdsDBLib.SqlServer
        Public ReadOnly Property DbLib As mdsDBLib.SqlServer
            Get
                Return _DbLib
            End Get
        End Property

        Private _SSPoliNet As mdsDbLib.SqlServer
        Public ReadOnly Property SSPoliNet As mdsDbLib.SqlServer
            Get
                If _SSPoliNet Is Nothing Then
                    Dim cs As String = Config.clsCommonConfig.Instance.ConnessioneDBPolietileNet
                    If cs = "" Then Throw New Exception("Connessione DB Polietile.Net non definita")
                    _SSPoliNet = New mdsDbLib.SqlServer(cs)
                End If
                Return _SSPoliNet
            End Get
        End Property

        Public Sub InitDataAccess(DA As DataAccessAdapterBase)
            _DA = DA
            _DbLib = New mdsDBLib.SqlServer(_DA.ConnectionString)
        End Sub

        Public Function GetQuadri(Dichiarazione As DichiarazioneEntity) As IEnumerable(Of QuadroEntity)
            Return GetQuadri(Dichiarazione.DataInizio, Dichiarazione.DataFine)
        End Function

        Public Function GetQuadri(DtIni As Date?, DtFine As Date?) As IEnumerable(Of QuadroEntity)
            Dim pr As New PredicateExpression(QuadroFields.Utilizzato = True)
            If DtIni.HasValue Then
                pr.AddWithAnd(New FieldCompareNullPredicate(QuadroFields.DataInizio, Nothing) Or QuadroFields.DataInizio <= DtIni.Value)
            End If
            If DtFine.HasValue Then
                pr.AddWithAnd(New FieldCompareNullPredicate(QuadroFields.DataFine, Nothing) Or QuadroFields.DataFine > DtFine.Value)
            End If
            Return Lookups.Quadri.CreateView(pr, New SortExpression(QuadroFields.Codice Or SortOperator.Ascending))
        End Function

        Public Function GetMateriali(Dichiarazione As DichiarazioneEntity) As IEnumerable(Of QuadroEntity)
            Return GetMateriali(Dichiarazione.DataInizio, Dichiarazione.DataFine)
        End Function

        Public Function GetMateriali(DtIni As Date?, DtFine As Date?) As IEnumerable(Of MaterialeEntity)
            Dim pr As New PredicateExpression(MaterialeFields.Utilizzato = True)
            If DtIni.HasValue Then
                pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataInizio, Nothing) Or MaterialeFields.DataInizio <= DtIni.Value)
            End If
            If DtFine.HasValue Then
                pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataFine, Nothing) Or MaterialeFields.DataFine >= DtFine.Value)
            End If

            Return Lookups.Materiali.CreateView(pr, New SortExpression(MaterialeFields.Codice Or SortOperator.Ascending))
        End Function

        Public Function GetAliquotaIVA(Dt As Date) As Decimal
            Dim pr As New PredicateExpression
            pr.AddWithAnd(New FieldCompareNullPredicate(AliquotaIvaFields.DataIniziale, Nothing) Or AliquotaIvaFields.DataIniziale <= Dt)
            pr.AddWithAnd(New FieldCompareNullPredicate(AliquotaIvaFields.DataFinale, Nothing) Or AliquotaIvaFields.DataFinale >= Dt)
            Dim ris As List(Of Integer) = Lookups.AliquoteIVA.FindMatches(pr)
            If ris.Count = 0 Then
                Return 0
            Else
                Return Lookups.AliquoteIVA.Item(ris(0)).Valore
            End If
        End Function
    End Module
End Namespace

