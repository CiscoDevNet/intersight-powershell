# HyperflexIpAddrRange
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**EndAddr** | **String** | The end IPv4 address of the range. | [optional] 
**Gateway** | **String** | The default gateway for the start and end IPv4 addresses. | [optional] 
**Netmask** | **String** | The netmask specified in dot decimal notation. The start address, end address, and gateway must all be within the network specified by this netmask. | [optional] 
**StartAddr** | **String** | The start IPv4 address of the range. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexIpAddrRange  -ClassId null `
 -ObjectType null `
 -EndAddr null `
 -Gateway null `
 -Netmask null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

