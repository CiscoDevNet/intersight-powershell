# PciCoprocessorCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pci.CoprocessorCard"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pci.CoprocessorCard"]
**CardId** | **Int64** | The id of the coprocessor card. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot name for the coprocessor card. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PciCoprocessorCardAllOf = Initialize-IntersightPciCoprocessorCardAllOf  -ClassId null `
 -ObjectType null `
 -CardId null `
 -PciSlot null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$PciCoprocessorCardAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

