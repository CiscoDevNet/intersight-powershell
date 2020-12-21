# StorageFlexFlashControllerPropsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexFlashControllerProps"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexFlashControllerProps"]
**CardsManageable** | **String** | Manageable card on the flex flash controller. | [optional] 
**ConfiguredMode** | **String** | Mode configured on the flex flash controller. | [optional] 
**ControllerName** | **String** | The current name of the flex flash controller. | [optional] 
**ControllerStatus** | **String** | The current status of the flex flash controller. | [optional] 
**FwVersion** | **String** | Firmware version of the flex flash controller. | [optional] 
**InternalState** | **String** | Internal state of the flex flash controller. | [optional] 
**OperatingMode** | **String** | Operating mode of flex flash controller. | [optional] 
**PhysicalDriveCount** | **String** | Number of connected physical drives to a specific Flex flash controller. | [optional] 
**ProductName** | **String** | Product name of the flex flash controller. | [optional] 
**StartupFwVersion** | **String** | Startup firmware version of the Flex flash controller. | [optional] 
**VirtualDriveCount** | **String** | Number of virtual drives for a specific Flex flash controller. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexFlashController** | [**StorageFlexFlashControllerRelationship**](StorageFlexFlashControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageFlexFlashControllerPropsAllOf = Initialize-IntersightStorageFlexFlashControllerPropsAllOf  -ClassId null `
 -ObjectType null `
 -CardsManageable null `
 -ConfiguredMode null `
 -ControllerName null `
 -ControllerStatus null `
 -FwVersion null `
 -InternalState null `
 -OperatingMode null `
 -PhysicalDriveCount null `
 -ProductName null `
 -StartupFwVersion null `
 -VirtualDriveCount null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexFlashController null
```

- Convert the resource to JSON
```powershell
$StorageFlexFlashControllerPropsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

