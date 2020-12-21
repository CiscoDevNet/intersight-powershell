# VirtualizationVmwareVmCpuSocketInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVmCpuSocketInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVmCpuSocketInfo"]
**CoresPerSocket** | **Int64** | The number of core per CPU socket (value may be empty). | [optional] 
**NumCpus** | **Int64** | Number of CPUs allocated to this VM. | [optional] 
**NumSockets** | **Int64** | The number of CPU sockets allocated. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareVmCpuSocketInfoAllOf = Initialize-IntersightVirtualizationVmwareVmCpuSocketInfoAllOf  -ClassId null `
 -ObjectType null `
 -CoresPerSocket null `
 -NumCpus null `
 -NumSockets null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareVmCpuSocketInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

