# VirtualizationEsxiVmComputeConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiVmComputeConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiVmComputeConfiguration"]
**ResourcePool** | **String** | ResourcePool where virtual machine is deployed. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiVmComputeConfiguration = Initialize-IntersightVirtualizationEsxiVmComputeConfiguration  -ClassId null `
 -ObjectType null `
 -ResourcePool null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiVmComputeConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

