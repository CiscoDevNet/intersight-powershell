# HyperflexExtFcStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ExtFcStoragePolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ExtFcStoragePolicy"]
**AdminState** | **Boolean** | Enables or disables external FC storage configuration. | [optional] 
**ExtaTraffic** | [**HyperflexNamedVsan**](HyperflexNamedVsan.md) |  | [optional] 
**ExtbTraffic** | [**HyperflexNamedVsan**](HyperflexNamedVsan.md) |  | [optional] 
**WwxnPrefixRange** | [**HyperflexWwxnPrefixRange**](HyperflexWwxnPrefixRange.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexExtFcStoragePolicyAllOf = Initialize-IntersightHyperflexExtFcStoragePolicyAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -ExtaTraffic null `
 -ExtbTraffic null `
 -WwxnPrefixRange null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexExtFcStoragePolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

