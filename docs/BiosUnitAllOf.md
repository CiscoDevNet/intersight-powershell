# BiosUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InitSeq** | **String** | The initSeq of the equipment. | [optional] [readonly] 
**InitTs** | **String** | The initTs of the equipment. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 
**SystemBootOrder** | [**BiosSystemBootOrderRelationship**](BiosSystemBootOrderRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBiosUnitAllOf  -InitSeq null `
 -InitTs null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -RunningFirmware null `
 -SystemBootOrder null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

