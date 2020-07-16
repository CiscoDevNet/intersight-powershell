# VirtualizationVmwareResourceConsumptionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuConsumed** | **Int64** | The amount of CPU consumed in Hz. | [optional] 
**MemoryConsumed** | **Int64** | Memory consumed by this host in bytes. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareResourceConsumptionAllOf  -CpuConsumed null `
 -MemoryConsumed null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

