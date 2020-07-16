# HyperflexExtIscsiStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **Boolean** | Enable or disable external FCoE storage configuration. | [optional] 
**ExtaTraffic** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**ExtbTraffic** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexExtIscsiStoragePolicyAllOf  -AdminState null `
 -ExtaTraffic null `
 -ExtbTraffic null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

