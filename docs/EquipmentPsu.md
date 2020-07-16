# EquipmentPsu
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
**Description** | **String** | This field is to provide description for the power supply unit. | [optional] [readonly] 
**OperState** | **String** | This field identifies the psu operational state. | [optional] [readonly] 
**PartNumber** | **String** | This field identifies the Part Number for this Power Supply Unit. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the Power Supply. | [optional] [readonly] 
**Presence** | **String** | This field identifies the presence state of the psu. | [optional] [readonly] 
**PsuFwVersion** | **String** | This field identifies the Firmware Version of the Power Supply. | [optional] [readonly] 
**PsuId** | **Int64** | This represents power supply unit identifier in chassis/server. | [optional] [readonly] 
**PsuInputSrc** | **String** | This field identifies the input source for the Power Supply. | [optional] [readonly] 
**PsuType** | **String** | This field identifies the type of the Power Supply. | [optional] [readonly] 
**PsuWattage** | **String** | This field identifies the Wattage of the Power Supply. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stockkeeping Unit for this Power Supply. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for this Power Supply Unit. | [optional] [readonly] 
**Voltage** | **String** | This field is used to indicate the Voltage for this Power Supply. | [optional] [readonly] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**EquipmentRackEnclosure** | [**EquipmentRackEnclosureRelationship**](EquipmentRackEnclosureRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentPsu  -AccountMoid null `
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
 -Description null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -PsuFwVersion null `
 -PsuId null `
 -PsuInputSrc null `
 -PsuType null `
 -PsuWattage null `
 -Sku null `
 -Vid null `
 -Voltage null `
 -ComputeRackUnit null `
 -EquipmentChassis null `
 -EquipmentFex null `
 -EquipmentRackEnclosure null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

