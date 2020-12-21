# HyperflexUcsmConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.UcsmConfigPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.UcsmConfigPolicy"]
**KvmIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**MacPrefixRange** | [**HyperflexMacAddrPrefixRange**](HyperflexMacAddrPrefixRange.md) |  | [optional] 
**ServerFirmwareVersion** | **String** | The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc. | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexUcsmConfigPolicyAllOf = Initialize-IntersightHyperflexUcsmConfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -KvmIpRange null `
 -MacPrefixRange null `
 -ServerFirmwareVersion null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexUcsmConfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

