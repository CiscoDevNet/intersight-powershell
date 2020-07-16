# VirtualizationVmwareVmCpuSocketInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CoresPerSocket** | **Int64** | The number of core per CPU socket (value may be empty). | [optional] 
**NumCpus** | **Int64** | Number of CPUs allocated to this VM. | [optional] 
**NumSockets** | **Int64** | The number of CPU sockets allocated. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmCpuSocketInfoAllOf  -CoresPerSocket null `
 -NumCpus null `
 -NumSockets null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

