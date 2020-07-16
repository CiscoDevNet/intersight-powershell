# EquipmentChassis
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
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**ChassisId** | **Int64** | The assigned identifier for a chassis. | [optional] [readonly] 
**ConnectionPath** | **String** | This field identifies the connectivity path for the chassis enclosure. | [optional] [readonly] 
**ConnectionStatus** | **String** | This field identifies the connectivity status for the chassis enclosure. | [optional] [readonly] 
**Description** | **String** | This field is to provide description for chassis model. | [optional] [readonly] 
**FaultSummary** | **Int64** | This field summarizes the faults on the chassis enclosure. | [optional] 
**ManagementMode** | **String** | The management mode of the blade server chassis. | [optional] [readonly] [default to "IntersightStandalone"]
**Name** | **String** | This field identifies the name for the chassis enclosure. | [optional] [readonly] 
**OperState** | **String** | This field identifies the Chassis Operational State. | [optional] [readonly] 
**PartNumber** | **String** | Part Number identifier for the chassis enclosure. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the chassis enclosure. | [optional] [readonly] 
**PlatformType** | **String** | The platform type that the chassis is a part of. | [optional] 
**ProductName** | **String** | This field identifies the Product Name for the chassis enclosure. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stock Keeping Unit for the chassis enclosure. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for the chassis enclosure. | [optional] [readonly] 
**Blades** | [**ComputeBladeRelationship[]**](ComputeBladeRelationship.md) | An array of relationships to computeBlade resources. | [optional] [readonly] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Ioms** | [**EquipmentIoCardRelationship[]**](EquipmentIoCardRelationship.md) | An array of relationships to equipmentIoCard resources. | [optional] [readonly] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**PsuControl** | [**EquipmentPsuControlRelationship**](EquipmentPsuControlRelationship.md) |  | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Sasexpanders** | [**StorageSasExpanderRelationship[]**](StorageSasExpanderRelationship.md) | An array of relationships to storageSasExpander resources. | [optional] [readonly] 
**Siocs** | [**EquipmentSystemIoControllerRelationship[]**](EquipmentSystemIoControllerRelationship.md) | An array of relationships to equipmentSystemIoController resources. | [optional] [readonly] 
**StorageEnclosures** | [**StorageEnclosureRelationship[]**](StorageEnclosureRelationship.md) | An array of relationships to storageEnclosure resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentChassis  -AccountMoid null `
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
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -ChassisId null `
 -ConnectionPath null `
 -ConnectionStatus null `
 -Description null `
 -FaultSummary null `
 -ManagementMode null `
 -Name null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -PlatformType null `
 -ProductName null `
 -Sku null `
 -Vid null `
 -Blades null `
 -Fanmodules null `
 -InventoryDeviceInfo null `
 -Ioms null `
 -LocatorLed null `
 -PsuControl null `
 -Psus null `
 -RegisteredDevice null `
 -Sasexpanders null `
 -Siocs null `
 -StorageEnclosures null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

