# StorageFlexUtilControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexUtilController"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexUtilController"]
**ControllerName** | **String** | Name of the Flex Util Controller. | [optional] 
**ControllerStatus** | **String** | The current status of the controller. | [optional] 
**FfControllerId** | **String** | Identifier for the Storage Flex Util Controller. | [optional] 
**InternalState** | **String** | The internal state of the controller. | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**FlexUtilPhysicalDrives** | [**StorageFlexUtilPhysicalDriveRelationship[]**](StorageFlexUtilPhysicalDriveRelationship.md) | An array of relationships to storageFlexUtilPhysicalDrive resources. | [optional] [readonly] 
**FlexUtilVirtualDrives** | [**StorageFlexUtilVirtualDriveRelationship[]**](StorageFlexUtilVirtualDriveRelationship.md) | An array of relationships to storageFlexUtilVirtualDrive resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageFlexUtilControllerAllOf = Initialize-IntersightStorageFlexUtilControllerAllOf  -ClassId null `
 -ObjectType null `
 -ControllerName null `
 -ControllerStatus null `
 -FfControllerId null `
 -InternalState null `
 -ComputeBoard null `
 -FlexUtilPhysicalDrives null `
 -FlexUtilVirtualDrives null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageFlexUtilControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

