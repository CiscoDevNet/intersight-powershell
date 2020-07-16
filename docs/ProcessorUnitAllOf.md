# ProcessorUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Architecture** | **String** | The architecture of the installed processor. | [optional] [readonly] 
**NumCores** | **Int64** | The number of cores present in a given processor. | [optional] [readonly] 
**NumCoresEnabled** | **String** | The number of enabled cores in the installed processor. | [optional] [readonly] 
**NumThreads** | **String** | The maximum number of threads available in the installed processor. | [optional] [readonly] 
**OperPowerState** | **String** | The power state of the processor. | [optional] [readonly] 
**OperState** | **String** | The health indicator of the processor, &#39;OK&#39; indicates the processor is operatinal. | [optional] [readonly] 
**Operability** | **String** | Operability state of the central processing unit. | [optional] [readonly] 
**Presence** | **String** | The valid values are &#39;equipped&#39; and &#39;absent&#39;. | [optional] [readonly] 
**ProcessorId** | **Int64** | The ID number of a given processor. | [optional] [readonly] 
**SocketDesignation** | **String** | The socket ID of the installed processor. | [optional] [readonly] 
**Speed** | **Double** | The maximum speed of the installed processor in GHz. | [optional] [readonly] 
**Stepping** | **String** | The CPU stepping of the installed processor. | [optional] [readonly] 
**Thermal** | **String** | The temperature of the processor in centigrade. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightProcessorUnitAllOf  -Architecture null `
 -NumCores null `
 -NumCoresEnabled null `
 -NumThreads null `
 -OperPowerState null `
 -OperState null `
 -Operability null `
 -Presence null `
 -ProcessorId null `
 -SocketDesignation null `
 -Speed null `
 -Stepping null `
 -Thermal null `
 -ComputeBlade null `
 -ComputeBoard null `
 -ComputeRackUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

