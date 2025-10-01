' ///////////////////////////////////////////////////////////////
' // This is generated code. 
' //////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 5.0
' // Code is generated on: 
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates
' // Templates vendor: Solutions Design.
' // Templates version: 
' //////////////////////////////////////////////////////////////
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports DAL
Imports DAL.HelperClasses
Imports DAL.FactoryClasses
Imports DAL.RelationClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END

Namespace DAL.EntityClasses

	''' <summary>Entity class which represents the entity 'DichiarazioneAllegato'.<br/><br/></summary>
	<Serializable()> _
	Public Class DichiarazioneAllegatoEntity 
		Inherits CommonEntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"
		Private WithEvents _elencoMateriali As EntityCollection(Of MaterialeAllegatoEntity)
		Private WithEvents _aziendaAllegato As AziendaAllegatoEntity
		Private WithEvents _azienda As AziendaEntity
		Private WithEvents _dichiarazione As DichiarazioneEntity

		' __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		
#End Region

#Region "Shared Members"
		Private Shared _customProperties As Dictionary(Of String, String)
		Private Shared _fieldsCustomProperties As Dictionary(Of String, Dictionary(Of String, String))

		''' <summary>All names of fields mapped onto a relation. Usable For In-memory filtering</summary>
		Public NotInheritable Class MemberNames
			Private Sub New()
			End Sub
			''' <summary>Member name AziendaAllegato</summary>
			Public Shared ReadOnly [AziendaAllegato] As String = "AziendaAllegato"
			''' <summary>Member name Azienda</summary>
			Public Shared ReadOnly [Azienda] As String = "Azienda"
			''' <summary>Member name Dichiarazione</summary>
			Public Shared ReadOnly [Dichiarazione] As String = "Dichiarazione"
			''' <summary>Member name ElencoMateriali</summary>
			Public Shared ReadOnly [ElencoMateriali] As String  = "ElencoMateriali"
		End Class
#End Region

		''' <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		Shared Sub New()
			SetupCustomPropertyHashtables()
		End Sub

		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New("DichiarazioneAllegatoEntity")
			InitClassEmpty(Nothing, Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <remarks>For framework usage.</remarks>
		''' <param name="fields">Fields object to set as the fields for this entity.</param>
		Public Sub New(fields As IEntityFields2)
			MyBase.New("DichiarazioneAllegatoEntity")
			InitClassEmpty(Nothing, fields)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="validator">The custom validator object for this DichiarazioneAllegatoEntity</param>
		Public Sub New(validator As IValidator)
			MyBase.New("DichiarazioneAllegatoEntity")
			InitClassEmpty(validator, Nothing)
		End Sub
				
		''' <summary>CTor</summary>
		''' <param name="id">PK value for DichiarazioneAllegato which data should be fetched into this DichiarazioneAllegato object</param>
		''' <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		Public Sub New(id As System.Int32)
			MyBase.New("DichiarazioneAllegatoEntity")
			InitClassEmpty(Nothing, Nothing)
			Me.Id = id
		End Sub

		''' <summary>CTor</summary>
		''' <param name="id">PK value for DichiarazioneAllegato which data should be fetched into this DichiarazioneAllegato object</param>
		''' <param name="validator">The custom validator object for this DichiarazioneAllegatoEntity</param>
		''' <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		Public Sub New(id As System.Int32, validator As IValidator)
			MyBase.New("DichiarazioneAllegatoEntity")
			InitClassEmpty(validator, Nothing)
			Me.Id = id
		End Sub

		''' <summary>Protected CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			If SerializationHelper.Optimization <> SerializationOptimization.Fast Then
				_elencoMateriali = CType(info.GetValue("_elencoMateriali", GetType(EntityCollection(Of MaterialeAllegatoEntity))), EntityCollection(Of MaterialeAllegatoEntity))
				_aziendaAllegato = CType(info.GetValue("_aziendaAllegato", GetType(AziendaAllegatoEntity)), AziendaAllegatoEntity)
				If Not _aziendaAllegato Is Nothing Then
					AddHandler _aziendaAllegato.AfterSave, AddressOf OnEntityAfterSave
				End If
				_azienda = CType(info.GetValue("_azienda", GetType(AziendaEntity)), AziendaEntity)
				If Not _azienda Is Nothing Then
					AddHandler _azienda.AfterSave, AddressOf OnEntityAfterSave
				End If
				_dichiarazione = CType(info.GetValue("_dichiarazione", GetType(DichiarazioneEntity)), DichiarazioneEntity)
				If Not _dichiarazione Is Nothing Then
					AddHandler _dichiarazione.AfterSave, AddressOf OnEntityAfterSave
				End If
				Me.FixupDeserialization(FieldInfoProviderSingleton.GetInstance())
			End If
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub

		
		''' <summary>Performs the desync setup when an FK field has been changed. The entity referenced based On the FK field will be dereferenced And sync info will be removed.</summary>
		''' <param name="fieldIndex">The fieldindex.</param>
		Protected Overrides Sub PerformDesyncSetupFKFieldChange(fieldIndex As Integer)
			Select Case CType(fieldIndex, DichiarazioneAllegatoFieldIndex)



				Case DichiarazioneAllegatoFieldIndex.IdAzienda
					DesetupSyncAzienda(True, False)
				Case DichiarazioneAllegatoFieldIndex.IdAziendaAllegato
					DesetupSyncAziendaAllegato(True, False)
				Case DichiarazioneAllegatoFieldIndex.IdDichiarazione
					DesetupSyncDichiarazione(True, False)



				Case Else
					MyBase.PerformDesyncSetupFKFieldChange(fieldIndex)
			End Select
		End Sub


		''' <summary>Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		''' <param name="propertyName">Name of the property.</param>
		''' <param name="entity">Entity to set as an related entity</param>
		''' <remarks>Used by prefetch path logic.</remarks>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Protected Overrides Overloads Sub SetRelatedEntityProperty(propertyName As String, entity As IEntityCore)
			Select Case propertyName
				Case "AziendaAllegato"
					Me.AziendaAllegato = CType(entity, AziendaAllegatoEntity)
				Case "Azienda"
					Me.Azienda = CType(entity, AziendaEntity)
				Case "Dichiarazione"
					Me.Dichiarazione = CType(entity, DichiarazioneEntity)
				Case "ElencoMateriali"
					Me.ElencoMateriali.Add(CType(entity, MaterialeAllegatoEntity))

				Case Else
					Me.OnSetRelatedEntityProperty(propertyName, entity)
			End Select
		End Sub
		
		''' <summary>Gets the relation objects which represent the relation the fieldName specified Is mapped On. </summary>
		''' <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have To be obtained.</param>
		''' <returns>RelationCollection With relation Object(s) which represent the relation the field Is maped On</returns>
		Protected Overrides Function GetRelationsForFieldOfType(fieldName As String ) As RelationCollection 
			Return DichiarazioneAllegatoEntity.GetRelationsForField(fieldName)
		End Function

		''' <summary>Gets the relation objects which represent the relation the fieldName specified Is mapped On. </summary>
		''' <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have To be obtained.</param>
		''' <returns>RelationCollection With relation Object(s) which represent the relation the field Is maped On</returns>
		Friend Shared Function GetRelationsForField(fieldName As String) As RelationCollection 
			Dim toReturn As New RelationCollection()
			Select Case fieldName
				Case "AziendaAllegato"
					toReturn.Add(DichiarazioneAllegatoEntity.Relations.AziendaAllegatoEntityUsingIdAziendaAllegato)
				Case "Azienda"
					toReturn.Add(DichiarazioneAllegatoEntity.Relations.AziendaEntityUsingIdAzienda)
				Case "Dichiarazione"
					toReturn.Add(DichiarazioneAllegatoEntity.Relations.DichiarazioneEntityUsingIdDichiarazione)
				Case "ElencoMateriali"
					toReturn.Add(DichiarazioneAllegatoEntity.Relations.MaterialeAllegatoEntityUsingIdDichiarazione)
				Case Else
			End Select
			Return toReturn
		End Function
#If Not CF Then		
		''' <summary>Checks If the relation mapped by the Property With the name specified Is a one way / Single sided relation. If the passed In name Is null, it will Return True If the entity has any Single-sided relation</summary>
		''' <param name="propertyName">Name of the Property which Is mapped onto the relation To check, Or null To check If the entity has any relation/ which Is Single sided</param>
		''' <returns>True If the relation Is Single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Protected Overrides Overloads Function CheckOneWayRelations(propertyName As String) As Boolean
			Dim numberOfOneWayRelations As Integer = 0
			Select Case propertyName
				Case Nothing
					Return ((numberOfOneWayRelations > 0) Or MyBase.CheckOneWayRelations(Nothing))
				Case Else
					Return MyBase.CheckOneWayRelations(propertyName)
			End Select
		End Function
#End If
		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Protected Overrides Sub SetRelatedEntity(relatedEntity As IEntityCore, fieldName As String)
			Select Case fieldName
				Case "AziendaAllegato"
					SetupSyncAziendaAllegato(relatedEntity)
				Case "Azienda"
					SetupSyncAzienda(relatedEntity)
				Case "Dichiarazione"
					SetupSyncDichiarazione(relatedEntity)
				Case "ElencoMateriali"
					Me.ElencoMateriali.Add(CType(relatedEntity, MaterialeAllegatoEntity))

				Case Else
			End Select
		End Sub

		''' <summary>Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		''' <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Protected Overrides Overloads Sub UnsetRelatedEntity(relatedEntity As IEntityCore, fieldName As String, signalRelatedEntityManyToOne As Boolean)
			Select Case fieldName
				Case "AziendaAllegato"
					DesetupSyncAziendaAllegato(False, True)
				Case "Azienda"
					DesetupSyncAzienda(False, True)
				Case "Dichiarazione"
					DesetupSyncDichiarazione(False, True)
				Case "ElencoMateriali"
					Me.PerformRelatedEntityRemoval(Me.ElencoMateriali, relatedEntity, signalRelatedEntityManyToOne)
				Case Else
			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). </summary>
		''' <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		Protected Overrides Function GetDependingRelatedEntities() As List(Of IEntity2)
			Dim toReturn As New List(Of IEntity2)()
			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields).</summary>
		''' <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		Protected Overrides Function GetDependentRelatedEntities() As List(Of IEntity2)
			Dim toReturn As New List(Of IEntity2)()
			If Not _aziendaAllegato Is Nothing Then
				toReturn.Add(_aziendaAllegato)
			End If
			If Not _azienda Is Nothing Then
				toReturn.Add(_azienda)
			End If
			If Not _dichiarazione Is Nothing Then
				toReturn.Add(_dichiarazione)
			End If
			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		Protected Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection2)
			Dim toReturn As New List(Of IEntityCollection2)()
			toReturn.Add(Me.ElencoMateriali)
			Return toReturn
		End Function


		''' <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext)
			If SerializationHelper.Optimization <> SerializationOptimization.Fast Then
				Dim value As IEntityCollection2 = Nothing
				Dim entityValue As IEntity2 = Nothing
				value = Nothing 
				If (Not (_elencoMateriali Is Nothing)) AndAlso (_elencoMateriali.Count>0) AndAlso Not Me.MarkedForDeletion Then 
					value = _elencoMateriali 
				End If
				info.AddValue("_elencoMateriali", value)
				entityValue = Nothing
				If Not Me.MarkedForDeletion Then
					entityValue = _aziendaAllegato
				End If
				info.AddValue("_aziendaAllegato", entityValue)
				entityValue = Nothing
				If Not Me.MarkedForDeletion Then
					entityValue = _azienda
				End If
				info.AddValue("_azienda", entityValue)
				entityValue = Nothing
				If Not Me.MarkedForDeletion Then
					entityValue = _dichiarazione
				End If
				info.AddValue("_dichiarazione", entityValue)
			End If
			' __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			' __LLBLGENPRO_USER_CODE_REGION_END
			
			MyBase.GetObjectData(info, context)
		End Sub


		''' <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		''' <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		Protected Overrides Overloads Function GetAllRelations() As List(Of IEntityRelation)
			Return New DichiarazioneAllegatoRelations().GetAllRelations()
		End Function

		''' <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'MaterialeAllegato' to this entity.</summary>
		''' <returns></returns>
		Public Overridable Function GetRelationInfoElencoMateriali() As IRelationPredicateBucket
			Dim bucket As IRelationPredicateBucket = New RelationPredicateBucket()
			bucket.PredicateExpression.Add(New FieldCompareValuePredicate(MaterialeAllegatoFields.IdDichiarazione, Nothing, ComparisonOperator.Equal, Me.Id))
			Return bucket
		End Function

		''' <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AziendaAllegato' to this entity.</summary>
		''' <returns></returns>
		Public Overridable Function GetRelationInfoAziendaAllegato() As IRelationPredicateBucket
			Dim bucket As IRelationPredicateBucket = New RelationPredicateBucket()
			bucket.PredicateExpression.Add(New FieldCompareValuePredicate(AziendaAllegatoFields.Id, Nothing, ComparisonOperator.Equal, Me.IdAziendaAllegato))
			Return bucket
		End Function

		''' <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Azienda' to this entity.</summary>
		''' <returns></returns>
		Public Overridable Function GetRelationInfoAzienda() As IRelationPredicateBucket
			Dim bucket As IRelationPredicateBucket = New RelationPredicateBucket()
			bucket.PredicateExpression.Add(New FieldCompareValuePredicate(AziendaFields.Id, Nothing, ComparisonOperator.Equal, Me.IdAzienda))
			Return bucket
		End Function

		''' <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Dichiarazione' to this entity.</summary>
		''' <returns></returns>
		Public Overridable Function GetRelationInfoDichiarazione() As IRelationPredicateBucket
			Dim bucket As IRelationPredicateBucket = New RelationPredicateBucket()
			bucket.PredicateExpression.Add(New FieldCompareValuePredicate(DichiarazioneFields.Id, Nothing, ComparisonOperator.Equal, Me.IdDichiarazione))
			Return bucket
		End Function

		''' <summary>Creates a New instance of the factory related To this entity</summary>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory2 
			Return EntityFactoryCache2.GetEntityFactory(GetType(DichiarazioneAllegatoEntityFactory))
		End Function
#If Not CF Then
		''' <summary>Adds the member collections To the collections queue (base first)</summary>
		''' <param name="collectionsQueue">The collections queue.</param>
		Protected Overrides Sub AddToMemberEntityCollectionsQueue(collectionsQueue As Queue(Of IEntityCollection2)) 
			MyBase.AddToMemberEntityCollectionsQueue(collectionsQueue)
			collectionsQueue.Enqueue(_elencoMateriali)
		End Sub
		
		''' <summary>Gets the member collections queue from the queue (base first)</summary>
		''' <param name="collectionsQueue">The collections queue.</param>
		Protected Overrides Sub GetFromMemberEntityCollectionsQueue(collectionsQueue As Queue(Of IEntityCollection2))
			MyBase.GetFromMemberEntityCollectionsQueue(collectionsQueue)
			_elencoMateriali = CType(collectionsQueue.Dequeue(), EntityCollection(Of MaterialeAllegatoEntity))
		End Sub
		
		''' <summary>Determines whether the entity has populated member collections</summary>
		''' <returns>True If the entity has populated member collections.</returns>
		Protected Overrides Function HasPopulatedMemberEntityCollections() As Boolean
			If (Not _elencoMateriali Is Nothing) Then
				Return True
			End If
			Return MyBase.HasPopulatedMemberEntityCollections()
		End Function
		
		''' <summary>Creates the member entity collections queue.</summary>
		''' <param name="collectionsQueue">The collections queue.</param>
		''' <param name="requiredQueue">The required queue.</param>
		Protected Overrides Overloads Sub CreateMemberEntityCollectionsQueue(collectionsQueue As Queue(Of IEntityCollection2), requiredQueue As Queue(Of Boolean)) 
			MyBase.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue)
			Dim toAdd As IEntityCollection2 = Nothing
			If requiredQueue.Dequeue() Then
				toAdd = New EntityCollection(Of MaterialeAllegatoEntity)(EntityFactoryCache2.GetEntityFactory(GetType(MaterialeAllegatoEntityFactory)))
			Else
				toAdd = Nothing
			End If
			collectionsQueue.Enqueue(toAdd)
		End Sub
#End If
		''' <summary>Gets all related data objects, stored by name. The name Is the field name mapped onto the relation For that particular data element. </summary>
		''' <returns>Dictionary With per name the related referenced data element, which can be an entity collection Or an entity Or null</returns>
		Protected Overrides Overloads Function GetRelatedData() As Dictionary(Of String, Object)
			Dim toReturn As New Dictionary(Of String, Object)()
			toReturn.Add("AziendaAllegato", _aziendaAllegato)
			toReturn.Add("Azienda", _azienda)
			toReturn.Add("Dichiarazione", _dichiarazione)
			toReturn.Add("ElencoMateriali", _elencoMateriali)
			Return toReturn
		End Function

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			PerformDependencyInjection()

			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete()
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()
			Dim fieldHashtable As Dictionary(Of String, String)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("Anno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("CategoriaAzienda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("Id", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("IdAzienda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("IdAziendaAllegato", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("IdDichiarazione", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("Note", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("Periodo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()
			_fieldsCustomProperties.Add("RuoloAziendaAllegato", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _aziendaAllegato</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAziendaAllegato(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			Me.PerformDesetupSyncRelatedEntity( _aziendaAllegato, AddressOf OnAziendaAllegatoPropertyChanged, "AziendaAllegato", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.AziendaAllegatoEntityUsingIdAziendaAllegatoStatic, True, signalRelatedEntity, "DichiarazioniAllegati", resetFKFields, New Integer() { CInt(DichiarazioneAllegatoFieldIndex.IdAziendaAllegato) } )
			_aziendaAllegato = Nothing
		End Sub

		''' <summary>setups the sync logic for member _aziendaAllegato</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAziendaAllegato(relatedEntity As IEntityCore)
			If Not _aziendaAllegato Is relatedEntity Then
				DesetupSyncAziendaAllegato(True, True)
				_aziendaAllegato = CType(relatedEntity, AziendaAllegatoEntity)
				Me.PerformSetupSyncRelatedEntity( _aziendaAllegato, AddressOf OnAziendaAllegatoPropertyChanged, "AziendaAllegato", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.AziendaAllegatoEntityUsingIdAziendaAllegatoStatic, True, New String() {  } )
			End If
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAziendaAllegatoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _azienda</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAzienda(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			Me.PerformDesetupSyncRelatedEntity( _azienda, AddressOf OnAziendaPropertyChanged, "Azienda", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.AziendaEntityUsingIdAziendaStatic, True, signalRelatedEntity, "Dichiaraziones", resetFKFields, New Integer() { CInt(DichiarazioneAllegatoFieldIndex.IdAzienda) } )
			_azienda = Nothing
		End Sub

		''' <summary>setups the sync logic for member _azienda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAzienda(relatedEntity As IEntityCore)
			If Not _azienda Is relatedEntity Then
				DesetupSyncAzienda(True, True)
				_azienda = CType(relatedEntity, AziendaEntity)
				Me.PerformSetupSyncRelatedEntity( _azienda, AddressOf OnAziendaPropertyChanged, "Azienda", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.AziendaEntityUsingIdAziendaStatic, True, New String() {  } )
			End If
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAziendaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _dichiarazione</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncDichiarazione(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			Me.PerformDesetupSyncRelatedEntity( _dichiarazione, AddressOf OnDichiarazionePropertyChanged, "Dichiarazione", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.DichiarazioneEntityUsingIdDichiarazioneStatic, True, signalRelatedEntity, "Dichiaraziones", resetFKFields, New Integer() { CInt(DichiarazioneAllegatoFieldIndex.IdDichiarazione) } )
			_dichiarazione = Nothing
		End Sub

		''' <summary>setups the sync logic for member _dichiarazione</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncDichiarazione(relatedEntity As IEntityCore)
			If Not _dichiarazione Is relatedEntity Then
				DesetupSyncDichiarazione(True, True)
				_dichiarazione = CType(relatedEntity, DichiarazioneEntity)
				Me.PerformSetupSyncRelatedEntity( _dichiarazione, AddressOf OnDichiarazionePropertyChanged, "Dichiarazione", DAL.RelationClasses.StaticDichiarazioneAllegatoRelations.DichiarazioneEntityUsingIdDichiarazioneStatic, True, New String() {  } )
			End If
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnDichiarazionePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validator">The validator object for this DichiarazioneAllegatoEntity</param>
		''' <param name="fields">Fields of this entity</param>
		Private Sub InitClassEmpty(validator As IValidator, fields As IEntityFields2)
			OnInitializing()
			If fields Is Nothing Then
				Me.Fields = CreateFields()
			Else
				Me.Fields = fields
			End If
			Me.Validator = validator
			InitClassMembers()

			' __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			' __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized()
		End Sub

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As DichiarazioneAllegatoRelations
			Get	
				Return New DichiarazioneAllegatoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property


		''' <summary>Creates a New PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'MaterialeAllegato'  for this entity.</summary>
		''' <Returns>Ready to use IPrefetchPathElement2 implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathElencoMateriali() As IPrefetchPathElement2
			Get
				Return New PrefetchPathElement2( New EntityCollection(Of MaterialeAllegatoEntity)(EntityFactoryCache2.GetEntityFactory(GetType(MaterialeAllegatoEntityFactory))), _
					CType(GetRelationsForField("ElencoMateriali")(0), IEntityRelation), CType(DAL.EntityType.DichiarazioneAllegatoEntity, Integer), CType(DAL.EntityType.MaterialeAllegatoEntity, Integer), 0, Nothing, Nothing, Nothing, Nothing, "ElencoMateriali", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property


		''' <summary>Creates a New PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AziendaAllegato' for this entity.</summary>
		''' <Returns>Ready to use IPrefetchPathElement2 implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAziendaAllegato() As IPrefetchPathElement2
			Get
				Return New PrefetchPathElement2( New EntityCollection(EntityFactoryCache2.GetEntityFactory(GetType(AziendaAllegatoEntityFactory))), _
					CType(GetRelationsForField("AziendaAllegato")(0), IEntityRelation), CType(DAL.EntityType.DichiarazioneAllegatoEntity, Integer), CType(DAL.EntityType.AziendaAllegatoEntity, Integer), 0, Nothing, Nothing, Nothing, Nothing, "AziendaAllegato", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property

		''' <summary>Creates a New PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Azienda' for this entity.</summary>
		''' <Returns>Ready to use IPrefetchPathElement2 implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAzienda() As IPrefetchPathElement2
			Get
				Return New PrefetchPathElement2( New EntityCollection(EntityFactoryCache2.GetEntityFactory(GetType(AziendaEntityFactory))), _
					CType(GetRelationsForField("Azienda")(0), IEntityRelation), CType(DAL.EntityType.DichiarazioneAllegatoEntity, Integer), CType(DAL.EntityType.AziendaEntity, Integer), 0, Nothing, Nothing, Nothing, Nothing, "Azienda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property

		''' <summary>Creates a New PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dichiarazione' for this entity.</summary>
		''' <Returns>Ready to use IPrefetchPathElement2 implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDichiarazione() As IPrefetchPathElement2
			Get
				Return New PrefetchPathElement2( New EntityCollection(EntityFactoryCache2.GetEntityFactory(GetType(DichiarazioneEntityFactory))), _
					CType(GetRelationsForField("Dichiarazione")(0), IEntityRelation), CType(DAL.EntityType.DichiarazioneAllegatoEntity, Integer), CType(DAL.EntityType.DichiarazioneEntity, Integer), 0, Nothing, Nothing, Nothing, Nothing, "Dichiarazione", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property


		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return DichiarazioneAllegatoEntity.CustomProperties
			End Get
		End Property

		''' <summary>The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property FieldsCustomProperties() As Dictionary(Of String, Dictionary(Of String, String))
			Get
				Return _fieldsCustomProperties
			End Get
		End Property

		''' <summary>The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property FieldsCustomPropertiesOfType() As Dictionary(Of String, Dictionary(Of String, String))
			Get
				Return DichiarazioneAllegatoEntity.FieldsCustomProperties
			End Get
		End Property

		''' <summary>The Anno property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."Anno"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False</remarks>
		Public Overridable Property [Anno]() As Nullable(Of System.Int32)
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.Anno), False), Nullable(Of System.Int32))
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.Anno), value)
			End Set
		End Property
		''' <summary>The CategoriaAzienda property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."CategoriaAzienda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False</remarks>
		Public Overridable Property [CategoriaAzienda]() As System.String
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.CategoriaAzienda), True), System.String)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.CategoriaAzienda), value)
			End Set
		End Property
		''' <summary>The Id property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."Id"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True</remarks>
		Public Overridable Property [Id]() As System.Int32
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.Id), True), System.Int32)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.Id), value)
			End Set
		End Property
		''' <summary>The IdAzienda property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."IdAzienda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False</remarks>
		Public Overridable Property [IdAzienda]() As System.Int32
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.IdAzienda), True), System.Int32)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.IdAzienda), value)
			End Set
		End Property
		''' <summary>The IdAziendaAllegato property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."IdAziendaAllegato"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False</remarks>
		Public Overridable Property [IdAziendaAllegato]() As System.Int32
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.IdAziendaAllegato), True), System.Int32)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.IdAziendaAllegato), value)
			End Set
		End Property
		''' <summary>The IdDichiarazione property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."IdDichiarazione"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False</remarks>
		Public Overridable Property [IdDichiarazione]() As System.Int32
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.IdDichiarazione), True), System.Int32)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.IdDichiarazione), value)
			End Set
		End Property
		''' <summary>The Note property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."Note"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 1000<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False</remarks>
		Public Overridable Property [Note]() As System.String
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.Note), True), System.String)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.Note), value)
			End Set
		End Property
		''' <summary>The Periodo property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."Periodo"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False</remarks>
		Public Overridable Property [Periodo]() As System.String
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.Periodo), True), System.String)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.Periodo), value)
			End Set
		End Property
		''' <summary>The RuoloAziendaAllegato property of the Entity DichiarazioneAllegato<br/><br/></summary>
		''' <remarks> Mapped on  table field: "Dichiarazione"."RuoloAziendaAllegato"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False</remarks>
		Public Overridable Property [RuoloAziendaAllegato]() As System.String
			Get
				Return CType(GetValue(CInt(DichiarazioneAllegatoFieldIndex.RuoloAziendaAllegato), True), System.String)
			End Get
			Set
				SetValue(CInt(DichiarazioneAllegatoFieldIndex.RuoloAziendaAllegato), value)
			End Set
		End Property

		''' <summary>Gets the EntityCollection with the related entities of type 'MaterialeAllegatoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/>
		''' </summary>
		<TypeContainedAttribute(GetType(MaterialeAllegatoEntity))> _
		Public Overridable ReadOnly Property [ElencoMateriali]() As EntityCollection(Of MaterialeAllegatoEntity)
			Get
				If _elencoMateriali Is Nothing Then
					_elencoMateriali = New EntityCollection(Of MaterialeAllegatoEntity)(EntityFactoryCache2.GetEntityFactory(GetType(MaterialeAllegatoEntityFactory)))
					_elencoMateriali.ActiveContext = Me.ActiveContext
					_elencoMateriali.SetContainingEntityInfo(Me, "Dichiarazione")
				End If
				Return _elencoMateriali
			End Get
		End Property


		''' <summary>Gets / sets related entity of type 'AziendaAllegatoEntity' which has to be set Imports a fetch action earlier. If no related entity is set for this property, null is returned.
		''' This property is not visible in databound grids.<br/><br/>
		''' </summary>
		<Browsable(False)> _
		Public Overridable Property [AziendaAllegato]() As AziendaAllegatoEntity
			Get
				Return _aziendaAllegato
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAziendaAllegato(value)
				Else
					SetSingleRelatedEntityNavigator(value, "DichiarazioniAllegati", "AziendaAllegato", _aziendaAllegato, True) 
				End If
			End Set
		End Property

		''' <summary>Gets / sets related entity of type 'AziendaEntity' which has to be set Imports a fetch action earlier. If no related entity is set for this property, null is returned.
		''' This property is not visible in databound grids.<br/><br/>
		''' </summary>
		<Browsable(False)> _
		Public Overridable Property [Azienda]() As AziendaEntity
			Get
				Return _azienda
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAzienda(value)
				Else
					SetSingleRelatedEntityNavigator(value, "Dichiaraziones", "Azienda", _azienda, True) 
				End If
			End Set
		End Property

		''' <summary>Gets / sets related entity of type 'DichiarazioneEntity' which has to be set Imports a fetch action earlier. If no related entity is set for this property, null is returned.
		''' This property is not visible in databound grids.<br/><br/>
		''' </summary>
		<Browsable(False)> _
		Public Overridable Property [Dichiarazione]() As DichiarazioneEntity
			Get
				Return _dichiarazione
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncDichiarazione(value)
				Else
					SetSingleRelatedEntityNavigator(value, "Dichiaraziones", "Dichiarazione", _dichiarazione, True) 
				End If
			End Set
		End Property

	

		''' <summary>Gets the type of the hierarchy this entity Is In. </summary>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property LLBLGenProIsInHierarchyOfType() As  InheritanceHierarchyType
			Get 
				Return InheritanceHierarchyType.None
			End Get
		End Property

		''' <summary>Gets Or sets a value indicating whether this entity Is a subtype</summary>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property LLBLGenProIsSubType As Boolean
			Get 
				Return False
			End Get
		End Property

		''' <summary>Returns the DAL.EntityType Enum value For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property LLBLGenProEntityTypeValue As Integer
			Get 
				Return CInt(DAL.EntityType.DichiarazioneAllegatoEntity)
			End Get
		End Property
#End Region


#Region "Custom Entity Code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		' __LLBLGENPRO_USER_CODE_REGION_END
		
#End Region

#Region "Included Code"

#End Region
	End Class
End Namespace
