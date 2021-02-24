# VmrcConsoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vmrc.Console"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vmrc.Console"]
**Session** | [**IamSessionRelationship**](IamSessionRelationship.md) |  | [optional] 
**Vcenter** | [**VirtualizationVmwareVcenterRelationship**](VirtualizationVmwareVcenterRelationship.md) |  | [optional] 
**VirtualMachine** | [**VirtualizationVmwareVirtualMachineRelationship**](VirtualizationVmwareVirtualMachineRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VmrcConsoleAllOf = Initialize-IntersightVmrcConsoleAllOf  -ClassId null `
 -ObjectType null `
 -Session null `
 -Vcenter null `
 -VirtualMachine null
```

- Convert the resource to JSON
```powershell
$VmrcConsoleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

