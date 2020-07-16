# CommIpV4Interface
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Gateway** | **String** | The IPv4 address of the default gateway. | [optional] 
**IpAddress** | **String** | The IPv4 Address, represented in the standard dot-decimal notation, e.g. 192.168.1.3. | [optional] 
**Netmask** | **String** | The IPv4 Netmask, represented in the standard dot-decimal notation, e.g. 255.255.255.0. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCommIpV4Interface  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -IpAddress null `
 -Netmask null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

