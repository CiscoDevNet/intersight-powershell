# HyperflexClusterStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskPartitionCleanup** | **Boolean** | If enabled, formats existing disk partitions (destroys all user data). | [optional] 
**LogicalAvalabilityZoneConfig** | [**HyperflexLogicalAvailabilityZone**](HyperflexLogicalAvailabilityZone.md) |  | [optional] 
**VdiOptimization** | **Boolean** | Enable or disable VDI optimization (hybrid HyperFlex systems only). | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexClusterStoragePolicyAllOf  -DiskPartitionCleanup null `
 -LogicalAvalabilityZoneConfig null `
 -VdiOptimization null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

