# AdapterEthSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.EthSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.EthSettings"]
**LldpEnabled** | **Boolean** | Status of LLDP protocol on the adapter interfaces. | [optional] [default to $true]

## Examples

- Prepare the resource
```powershell
$AdapterEthSettings = Initialize-IntersightAdapterEthSettings  -ClassId null `
 -ObjectType null `
 -LldpEnabled null
```

- Convert the resource to JSON
```powershell
$AdapterEthSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

