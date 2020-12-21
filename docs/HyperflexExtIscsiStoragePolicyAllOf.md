# HyperflexExtIscsiStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ExtIscsiStoragePolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ExtIscsiStoragePolicy"]
**AdminState** | **Boolean** | Enable or disable external FCoE storage configuration. | [optional] 
**ExtaTraffic** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**ExtbTraffic** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexExtIscsiStoragePolicyAllOf = Initialize-IntersightHyperflexExtIscsiStoragePolicyAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -ExtaTraffic null `
 -ExtbTraffic null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexExtIscsiStoragePolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

