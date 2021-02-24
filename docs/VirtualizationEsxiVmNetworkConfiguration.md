# VirtualizationEsxiVmNetworkConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiVmNetworkConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiVmNetworkConfiguration"]
**Interfaces** | [**VirtualizationNetworkInterface[]**](VirtualizationNetworkInterface.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiVmNetworkConfiguration = Initialize-IntersightVirtualizationEsxiVmNetworkConfiguration  -ClassId null `
 -ObjectType null `
 -Interfaces null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiVmNetworkConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

