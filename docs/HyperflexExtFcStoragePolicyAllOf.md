# HyperflexExtFcStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **Boolean** | Enables or disables external FC storage configuration. | [optional] 
**ExtaTraffic** | [**HyperflexNamedVsan**](HyperflexNamedVsan.md) |  | [optional] 
**ExtbTraffic** | [**HyperflexNamedVsan**](HyperflexNamedVsan.md) |  | [optional] 
**WwxnPrefixRange** | [**HyperflexWwxnPrefixRange**](HyperflexWwxnPrefixRange.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexExtFcStoragePolicyAllOf  -AdminState null `
 -ExtaTraffic null `
 -ExtbTraffic null `
 -WwxnPrefixRange null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

