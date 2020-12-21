# IppoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.Pool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.Pool"]
**IpV4Blocks** | [**IppoolIpV4Block[]**](IppoolIpV4Block.md) |  | [optional] 
**IpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**IpV6Blocks** | [**IppoolIpV6Block[]**](IppoolIpV6Block.md) |  | [optional] 
**IpV6Config** | [**IppoolIpV6Config**](IppoolIpV6Config.md) |  | [optional] 
**V4Assigned** | **Int64** | Number of IPv4 addresses currently in use. | [optional] [readonly] 
**V4Size** | **Int64** | Number of IPv4 addresses in this pool. | [optional] [readonly] 
**V6Assigned** | **Int64** | Number of IPv6 addresses currently in use. | [optional] [readonly] 
**V6Size** | **Int64** | Number of IPv6 addresses in this pool. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ShadowPools** | [**IppoolShadowPoolRelationship[]**](IppoolShadowPoolRelationship.md) | An array of relationships to ippoolShadowPool resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IppoolPoolAllOf = Initialize-IntersightIppoolPoolAllOf  -ClassId null `
 -ObjectType null `
 -IpV4Blocks null `
 -IpV4Config null `
 -IpV6Blocks null `
 -IpV6Config null `
 -V4Assigned null `
 -V4Size null `
 -V6Assigned null `
 -V6Size null `
 -Organization null `
 -ShadowPools null
```

- Convert the resource to JSON
```powershell
$IppoolPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

