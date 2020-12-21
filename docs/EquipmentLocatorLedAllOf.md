# EquipmentLocatorLedAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.LocatorLed"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.LocatorLed"]
**Color** | **String** | Color of the locatorled available on an equipment. | [optional] [readonly] 
**OperState** | **String** | Identifies the operational state of locatorled. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StoragePhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentLocatorLedAllOf = Initialize-IntersightEquipmentLocatorLedAllOf  -ClassId null `
 -ObjectType null `
 -Color null `
 -OperState null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -EquipmentChassis null `
 -EquipmentFex null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StoragePhysicalDisk null
```

- Convert the resource to JSON
```powershell
$EquipmentLocatorLedAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

