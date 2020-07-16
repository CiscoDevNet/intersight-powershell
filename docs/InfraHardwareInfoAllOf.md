# InfraHardwareInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuCores** | **Int64** | The number of cpu cores on this hardware platform. | [optional] 
**CpuSpeed** | **Int64** | Speed of cpu in MHz. Usually cpu speeds are reported for modern cpus in GHz but MHz makes it more precise. | [optional] 
**MemorySize** | **Int64** | The amount of memory allocated (bytes) to this hardware platform. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInfraHardwareInfoAllOf  -CpuCores null `
 -CpuSpeed null `
 -MemorySize null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

