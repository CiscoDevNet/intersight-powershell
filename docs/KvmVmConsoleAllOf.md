# KvmVmConsoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kvm.VmConsole"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kvm.VmConsole"]
**KvmMuxUrl** | **String** | The URL of the KVM MUX to connect to. | [optional] [readonly] 
**VirtualMachine** | [**HyperflexHxapVirtualMachineRelationship**](HyperflexHxapVirtualMachineRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KvmVmConsoleAllOf = Initialize-IntersightKvmVmConsoleAllOf  -ClassId null `
 -ObjectType null `
 -KvmMuxUrl null `
 -VirtualMachine null
```

- Convert the resource to JSON
```powershell
$KvmVmConsoleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

