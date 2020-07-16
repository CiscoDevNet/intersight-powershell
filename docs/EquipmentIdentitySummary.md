# EquipmentIdentitySummary
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
**AdapterSerial** | **String** | Serial Identifier of an adapter participating in SWM. | [optional] [readonly] 
**AdminAction** | **String** | Updated by UI/API to trigger specific chassis action type. | [optional] [readonly] [default to "None"]
**AdminActionState** | **String** | The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed. | [optional] [readonly] [default to "None"]
**ChassisId** | **Int64** | Chassis Identifier of a blade server. | [optional] [readonly] 
**DeviceMoId** | **String** | FI Device registration Mo ID. | [optional] [readonly] 
**Identifier** | **Int64** | Numeric Identifier assigned by the management system to the equipment. | [optional] [readonly] 
**IoCardIdentityList** | [**EquipmentIoCardIdentity[]**](EquipmentIoCardIdentity.md) |  | [optional] 
**Lifecycle** | **String** | The equipment&#39;s lifecycle status. | [optional] [readonly] [default to "None"]
**Model** | **String** | The vendor provided model name for the equipment. | [optional] [readonly] 
**PendingDiscovery** | **String** | Indicates pending discovery flag. | [optional] [readonly] 
**Serial** | **String** | The serial number of the equipment. | [optional] [readonly] 
**SlotId** | **Int64** | Chassis slot number of a blade server. | [optional] [readonly] 
**SourceObjectType** | **String** | The source object type of this view MO. | [optional] [readonly] 
**SwitchId** | **Int64** | Switch ID to which Fabric Extender is connected, ID can be either 1 or 2, equalent to A or B. | [optional] [readonly] 
**Vendor** | **String** | The manufacturer of the equipment. | [optional] [readonly] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIdentitySummary  -AccountMoid null `
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
 -AdapterSerial null `
 -AdminAction null `
 -AdminActionState null `
 -ChassisId null `
 -DeviceMoId null `
 -Identifier null `
 -IoCardIdentityList null `
 -Lifecycle null `
 -Model null `
 -PendingDiscovery null `
 -Serial null `
 -SlotId null `
 -SourceObjectType null `
 -SwitchId null `
 -Vendor null `
 -DeviceRegistration null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

