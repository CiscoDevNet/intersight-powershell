# HyperflexAlarm
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
**Acknowledged** | **Boolean** |  | [optional] [readonly] 
**AcknowledgedBy** | **String** |  | [optional] [readonly] 
**AcknowledgedTime** | **Int64** |  | [optional] [readonly] 
**AcknowledgedTimeAsUtc** | **String** |  | [optional] [readonly] 
**Description** | **String** |  | [optional] [readonly] 
**EntityData** | **String** |  | [optional] [readonly] 
**EntityName** | **String** |  | [optional] [readonly] 
**EntityType** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**EntityUuId** | **String** |  | [optional] [readonly] 
**Message** | **String** |  | [optional] [readonly] 
**Name** | **String** |  | [optional] [readonly] 
**Status** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**TriggeredTime** | **Int64** |  | [optional] [readonly] 
**TriggeredTimeAsUtc** | **String** |  | [optional] [readonly] 
**Uuid** | **String** |  | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexAlarm  -AccountMoid null `
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
 -Acknowledged null `
 -AcknowledgedBy null `
 -AcknowledgedTime null `
 -AcknowledgedTimeAsUtc null `
 -Description null `
 -EntityData null `
 -EntityName null `
 -EntityType null `
 -EntityUuId null `
 -Message null `
 -Name null `
 -Status null `
 -TriggeredTime null `
 -TriggeredTimeAsUtc null `
 -Uuid null `
 -Cluster null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

