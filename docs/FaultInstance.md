# FaultInstance
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Acknowledged** | **String** | The user acknowledgement state of the fault. | [optional] [readonly] 
**AffectedDn** | **String** | The Distinguished Name of the Managed object which was affected. | [optional] [readonly] 
**AffectedMoId** | **String** | Managed object Id which was affected. | [optional] [readonly] 
**AffectedMoType** | **String** | Managed object type which was affected. | [optional] [readonly] 
**AncestorMoId** | **String** | Object Id of the parent of the Managed object which was affected. | [optional] [readonly] 
**AncestorMoType** | **String** | Object type of the parent of the Managed object which was affected. | [optional] [readonly] 
**Code** | **String** | Numerical fault code of the fault found. | [optional] [readonly] 
**CreationTime** | **String** | The time of creation of the fault instance. | [optional] [readonly] 
**Description** | **String** | Detailed message of the fault. | [optional] [readonly] 
**LastTransitionTime** | **String** | Last transition time of the fault. | [optional] [readonly] 
**NumOccurrences** | **Int64** | The number of times this fault has occured. | [optional] [readonly] 
**OriginalSeverity** | **String** | Current Severity of the fault found. | [optional] [readonly] 
**PreviousSeverity** | **String** | The Severity of the fault prior to user update. | [optional] [readonly] 
**Rule** | **String** | The rule that is responsible for generation of the fault. | [optional] [readonly] 
**Severity** | **String** | Severity of the fault found. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFaultInstance  -AccountMoid null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Acknowledged null `
 -AffectedDn null `
 -AffectedMoId null `
 -AffectedMoType null `
 -AncestorMoId null `
 -AncestorMoType null `
 -Code null `
 -CreationTime null `
 -Description null `
 -LastTransitionTime null `
 -NumOccurrences null `
 -OriginalSeverity null `
 -PreviousSeverity null `
 -Rule null `
 -Severity null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

