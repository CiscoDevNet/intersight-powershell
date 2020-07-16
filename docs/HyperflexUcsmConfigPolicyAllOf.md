# HyperflexUcsmConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KvmIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**MacPrefixRange** | [**HyperflexMacAddrPrefixRange**](HyperflexMacAddrPrefixRange.md) |  | [optional] 
**ServerFirmwareVersion** | **String** | The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc. | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexUcsmConfigPolicyAllOf  -KvmIpRange null `
 -MacPrefixRange null `
 -ServerFirmwareVersion null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

