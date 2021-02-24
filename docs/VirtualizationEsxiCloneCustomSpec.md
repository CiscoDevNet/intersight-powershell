# VirtualizationEsxiCloneCustomSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiCloneCustomSpec"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiCloneCustomSpec"]
**ExtraConfig** | [**AnyType**](.md) | Specify the Extra Config specification which can be configured on virtual machine. | [optional] 
**OvaEnvSpec** | [**AnyType**](.md) | Specify the OVA Environment specification which can be configured on virtual machine. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiCloneCustomSpec = Initialize-IntersightVirtualizationEsxiCloneCustomSpec  -ClassId null `
 -ObjectType null `
 -ExtraConfig null `
 -OvaEnvSpec null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiCloneCustomSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

