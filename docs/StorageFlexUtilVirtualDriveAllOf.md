# StorageFlexUtilVirtualDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexUtilVirtualDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexUtilVirtualDrive"]
**DriveStatus** | **String** | Status of the Flex Util virtual drive. | [optional] 
**DriveType** | **String** | Type of virtual drive managed by flex util controller. | [optional] 
**PartitionId** | **String** | Disk Partition Id of virtual drive managed by flex util controller. | [optional] 
**PartitionName** | **String** | Partition name of the Flex Util virtual drive. | [optional] 
**ResidentImage** | **String** | The resident image on the flex util virtual Drive. | [optional] 
**Size** | **String** | Size of the Flex Util virtual drive. | [optional] 
**VirtualDrive** | **String** | Virtual drive on the Flex Util controller. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexUtilController** | [**StorageFlexUtilControllerRelationship**](StorageFlexUtilControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageFlexUtilVirtualDriveAllOf = Initialize-IntersightStorageFlexUtilVirtualDriveAllOf  -ClassId null `
 -ObjectType null `
 -DriveStatus null `
 -DriveType null `
 -PartitionId null `
 -PartitionName null `
 -ResidentImage null `
 -Size null `
 -VirtualDrive null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexUtilController null
```

- Convert the resource to JSON
```powershell
$StorageFlexUtilVirtualDriveAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

