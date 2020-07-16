# IppoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpV4Blocks** | [**IppoolIpBlock[]**](IppoolIpBlock.md) |  | [optional] 
**IpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**V4Assigned** | **Int64** | Number of IPv4 addresses currently in use. | [optional] [readonly] 
**V4Size** | **Int64** | Number of IPv4 addresses in this pool. | [optional] [readonly] 
**V6Assigned** | **Int64** | Number of IPv6 addresses currently in use. | [optional] [readonly] 
**V6Size** | **Int64** | Number of IPv6 addresses in this pool. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ShadowPools** | [**IppoolShadowPoolRelationship[]**](IppoolShadowPoolRelationship.md) | An array of relationships to ippoolShadowPool resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIppoolPoolAllOf  -IpV4Blocks null `
 -IpV4Config null `
 -V4Assigned null `
 -V4Size null `
 -V6Assigned null `
 -V6Size null `
 -Organization null `
 -ShadowPools null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

