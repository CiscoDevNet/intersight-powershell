# StorageVirtualDriveContainerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.VirtualDriveContainer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.VirtualDriveContainer"]
**ContainerId** | **Int64** | The identifier for this container. | [optional] [readonly] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**VirtualDrive** | [**StorageVirtualDriveRelationship[]**](StorageVirtualDriveRelationship.md) | An array of relationships to storageVirtualDrive resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageVirtualDriveContainerAllOf = Initialize-IntersightStorageVirtualDriveContainerAllOf  -ClassId null `
 -ObjectType null `
 -ContainerId null `
 -EquipmentChassis null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -VirtualDrive null
```

- Convert the resource to JSON
```powershell
$StorageVirtualDriveContainerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

