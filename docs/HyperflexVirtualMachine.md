# HyperflexVirtualMachine
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VirtualMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VirtualMachine"]
**RunTimeInfo** | [**HyperflexVirtualMachineRuntimeInfo**](HyperflexVirtualMachineRuntimeInfo.md) |  | [optional] 
**StatusCode** | **String** | Virtual Machine Status Code. * &#x60;VM_ACCESSIBLE&#x60; - This virtual machine is accessible. * &#x60;VM_INACCESSIBLE&#x60; - This virtual machine is not accessible. * &#x60;VM_NOT_SUPPORTED&#x60; - This virtual machine is not supported. * &#x60;NONE&#x60; - This virtual machine does not have a status code. | [optional] [readonly] [default to "VM_ACCESSIBLE"]
**Uuid** | **String** | Virtual machine unique UUID. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVirtualMachine = Initialize-IntersightHyperflexVirtualMachine  -ClassId null `
 -ObjectType null `
 -RunTimeInfo null `
 -StatusCode null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$HyperflexVirtualMachine | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

