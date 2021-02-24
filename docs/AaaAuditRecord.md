# AaaAuditRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "aaa.AuditRecord"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "aaa.AuditRecord"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**VarEvent** | **String** | The operation that was performed on this Managed Object. The event is a compound string that includes the CRUD operation such as Create, Modify, Delete, and a string representing the Managed Object type. | [optional] 
**MoDisplayNames** | [**AnyType**](.md) | The user-friendly names of the changed MO. | [optional] 
**MoType** | **String** | The object type of the REST resource that was created, modified or deleted. | [optional] 
**ObjectMoid** | **String** | The Moid of the REST resource that was created, modified or deleted. | [optional] 
**Request** | [**AnyType**](.md) | The body of the REST request that was received from a client to create or modify a REST resource, represented as a JSON document. | [optional] 
**TraceId** | **String** | The trace id of the request that was used to create, modify or delete a REST resource. A trace id is a unique identifier for one particular REST request. It may be used for troubleshooting purpose by the Intersight technical support team. | [optional] 
**Email** | **String** | The email of the associated user that made the change.  In case the user is later deleted, we still have some reference to the information. | [optional] 
**InstId** | **String** | The instance id of AuditRecordLocal, which is used to identify if the comming AuditRecordLocal was already processed before. | [optional] 
**SessionId** | **String** | The sessionId in which the user made the change. In case that the session is later deleted, we still have some reference to the information. | [optional] 
**SourceIp** | **String** | The source IP of the client. | [optional] 
**Timestamp** | **System.DateTime** | The creation time of AuditRecordLocal, which is the time when the affected MO was created/modified/deleted. | [optional] [readonly] 
**UserIdOrEmail** | **String** | The userId or the email of the associated user that made the change. In case that user is later deleted, we still have some reference to the information. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Sessions** | [**IamSessionRelationship**](IamSessionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AaaAuditRecord = Initialize-IntersightAaaAuditRecord  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -VarEvent null `
 -MoDisplayNames null `
 -MoType null `
 -ObjectMoid null `
 -Request null `
 -TraceId null `
 -Email null `
 -InstId null `
 -SessionId null `
 -SourceIp null `
 -Timestamp null `
 -UserIdOrEmail null `
 -Account null `
 -Sessions null `
 -User null
```

- Convert the resource to JSON
```powershell
$AaaAuditRecord | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

