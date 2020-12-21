# InfraHardwareInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "infra.HardwareInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "infra.HardwareInfo"]
**CpuCores** | **Int64** | The number of cpu cores on this hardware platform. | [optional] 
**CpuSpeed** | **Int64** | Speed of cpu in MHz. Usually cpu speeds are reported for modern cpus in GHz but MHz makes it more precise. | [optional] 
**MemorySize** | **Int64** | The amount of memory allocated (bytes) to this hardware platform. | [optional] 

## Examples

- Prepare the resource
```powershell
$InfraHardwareInfo = Initialize-IntersightInfraHardwareInfo  -ClassId null `
 -ObjectType null `
 -CpuCores null `
 -CpuSpeed null `
 -MemorySize null
```

- Convert the resource to JSON
```powershell
$InfraHardwareInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

