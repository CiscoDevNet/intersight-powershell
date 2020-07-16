# AaaAuditRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**VarEvent** | **String** | The operation that was performed on this Managed Object. The event is a compound string that includes the CRUD operation such as Create, Modify, Delete, and a string representing the Managed Object type. | [optional] 
**MoDisplayNames** | [**AnyType**](.md) | The user-friendly names of the changed MO. | [optional] 
**MoType** | **String** | The object type of the REST resource that was created, modified or deleted. | [optional] 
**ObjectMoid** | **String** | The Moid of the REST resource that was created, modified or deleted. | [optional] 
**Request** | [**AnyType**](.md) | The body of the REST request that was received from a client to create or modify a REST resource, represented as a JSON document. | [optional] 
**TraceId** | **String** | The trace id of the request that was used to create, modify or delete a REST resource. A trace id is a unique identifier for one particular REST request. It may be used for troubleshooting purpose by the Intersight technical support team. | [optional] 
**Email** | **String** | The email of the associated user that made the change.  In case the user is later deleted, we still have some reference to the information. | [optional] 
**InstId** | **String** | The instance id of AuditRecordLocal, which is used to identify if the comming AuditRecordLocal was already processed before. | [optional] 
**SourceIp** | **String** | The source IP of the client. | [optional] 
**Timestamp** | **System.DateTime** | The creation time of AuditRecordLocal, which is the time when the affected MO was created/modified/deleted. | [optional] [readonly] 
**UserIdOrEmail** | **String** | The userId or the email of the associated user that made the change. In case that user is later deleted, we still have some reference to the information. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Sessions** | [**IamSessionRelationship**](IamSessionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAaaAuditRecord  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
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
 -SourceIp null `
 -Timestamp null `
 -UserIdOrEmail null `
 -Account null `
 -Sessions null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

