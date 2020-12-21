# HyperflexHxNetworkAddressDtAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxNetworkAddressDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxNetworkAddressDt"]
**Address** | **String** | The network address as an FQDN or IPv4 address. | [optional] [readonly] 
**Fqdn** | **String** | The fully qualified domain name for the network address. | [optional] [readonly] 
**Ip** | **String** | The network address as an IPv4 address. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxNetworkAddressDtAllOf = Initialize-IntersightHyperflexHxNetworkAddressDtAllOf  -ClassId null `
 -ObjectType null `
 -Address null `
 -Fqdn null `
 -Ip null
```

- Convert the resource to JSON
```powershell
$HyperflexHxNetworkAddressDtAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

