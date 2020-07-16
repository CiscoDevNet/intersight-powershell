# CondAlarm
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
**AffectedMoId** | **String** | MoId of the affected object from the managed system&#39;s point of view. | [optional] 
**AffectedMoType** | **String** | Managed system affected object type. For example Adaptor, FI, CIMC. | [optional] 
**AffectedObject** | **String** | A unique key for an alarm instance, consists of a combination of a unique system name and msAffectedObject. | [optional] 
**AncestorMoId** | **String** | Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault. | [optional] 
**AncestorMoType** | **String** | Parent MO type of the fault from managed system. For example, Blade for adaptor fault. | [optional] 
**Code** | **String** | A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code. | [optional] 
**CreationTime** | **System.DateTime** | The time the alarm was created. | [optional] 
**Description** | **String** | A longer description of the alarm than the name. The description contains details of the component reporting the issue. | [optional] 
**LastTransitionTime** | **System.DateTime** | The time the alarm last had a change in severity. | [optional] 
**MsAffectedObject** | **String** | A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn. | [optional] 
**Name** | **String** | Uniquely identifies the type of alarm. For alarms originating from Intersight, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code. | [optional] 
**OrigSeverity** | **String** | The original severity when the alarm was first created. | [optional] [default to "None"]
**Severity** | **String** | The severity of the alarm. Valid values are Critical, Warning, Info, and Cleared. | [optional] [default to "None"]
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCondAlarm  -AccountMoid null `
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
 -AffectedMoId null `
 -AffectedMoType null `
 -AffectedObject null `
 -AncestorMoId null `
 -AncestorMoType null `
 -Code null `
 -CreationTime null `
 -Description null `
 -LastTransitionTime null `
 -MsAffectedObject null `
 -Name null `
 -OrigSeverity null `
 -Severity null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

