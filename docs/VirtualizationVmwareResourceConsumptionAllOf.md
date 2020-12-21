# VirtualizationVmwareResourceConsumptionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareResourceConsumption"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareResourceConsumption"]
**CpuConsumed** | **Int64** | The amount of CPU consumed in Hz. | [optional] 
**MemoryConsumed** | **Int64** | Memory consumed by this host in bytes. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareResourceConsumptionAllOf = Initialize-IntersightVirtualizationVmwareResourceConsumptionAllOf  -ClassId null `
 -ObjectType null `
 -CpuConsumed null `
 -MemoryConsumed null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareResourceConsumptionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

