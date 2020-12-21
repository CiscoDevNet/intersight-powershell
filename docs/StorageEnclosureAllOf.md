# StorageEnclosureAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.Enclosure"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.Enclosure"]
**ChassisId** | **Int64** | This represent the chassis-ID that houses the storage enclosure. | [optional] [readonly] 
**Description** | **String** | This represnets the description for the storage enclosure. | [optional] [readonly] 
**EnclosureId** | **Int64** | This represnets the Identifier for the storage enclosure. | [optional] [readonly] 
**NumSlots** | **Int64** | This represent the number of slots present in storage enclosure. | [optional] [readonly] 
**Presence** | **String** | This represent the availability of storage enclosure. | [optional] [readonly] 
**ServerId** | **Int64** | This represent the server-ID that houses the storage enclosure. | [optional] [readonly] 
**Type** | **String** | This represent the type of storage enclosure. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EnclosureDiskSlots** | [**StorageEnclosureDiskSlotEpRelationship[]**](StorageEnclosureDiskSlotEpRelationship.md) | An array of relationships to storageEnclosureDiskSlotEp resources. | [optional] [readonly] 
**EnclosureDisks** | [**StorageEnclosureDiskRelationship[]**](StorageEnclosureDiskRelationship.md) | An array of relationships to storageEnclosureDisk resources. | [optional] [readonly] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDisks** | [**StoragePhysicalDiskRelationship[]**](StoragePhysicalDiskRelationship.md) | An array of relationships to storagePhysicalDisk resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageEnclosureAllOf = Initialize-IntersightStorageEnclosureAllOf  -ClassId null `
 -ObjectType null `
 -ChassisId null `
 -Description null `
 -EnclosureId null `
 -NumSlots null `
 -Presence null `
 -ServerId null `
 -Type null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -EnclosureDiskSlots null `
 -EnclosureDisks null `
 -EquipmentChassis null `
 -InventoryDeviceInfo null `
 -PhysicalDisks null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageEnclosureAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

