# VirtualizationEsxiOvaCustomSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiOvaCustomSpec"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiOvaCustomSpec"]
**OvaEnvSpec** | [**AnyType**](.md) | Specify the OVA Environment specification which can be configured on the virtual machine. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiOvaCustomSpecAllOf = Initialize-IntersightVirtualizationEsxiOvaCustomSpecAllOf  -ClassId null `
 -ObjectType null `
 -OvaEnvSpec null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiOvaCustomSpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

