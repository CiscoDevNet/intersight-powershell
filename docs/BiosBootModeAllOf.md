# BiosBootModeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "bios.BootMode"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "bios.BootMode"]
**ActualBootMode** | **String** | The actual BIOS boot mode as reported by the platform BIOS. | [optional] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BiosBootModeAllOf = Initialize-IntersightBiosBootModeAllOf  -ClassId null `
 -ObjectType null `
 -ActualBootMode null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$BiosBootModeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

