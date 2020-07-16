# IppoolIpV4Config
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Gateway** | **String** | IP address of the default IPv4 gateway. | [optional] [readonly] 
**Netmask** | **String** | A subnet mask is a 32-bit number that masks an IP address and divides the IP address into network address and host address. | [optional] [readonly] 
**PrimaryDns** | **String** | IP Address of the primary Domain Name System (DNS) server. | [optional] [readonly] 
**SecondaryDns** | **String** | IP Address of the secondary Domain Name System (DNS) server. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIppoolIpV4Config  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -Netmask null `
 -PrimaryDns null `
 -SecondaryDns null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

