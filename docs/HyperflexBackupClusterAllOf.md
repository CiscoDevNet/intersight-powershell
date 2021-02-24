# HyperflexBackupClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.BackupCluster"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.BackupCluster"]
**BackupDataStore** | **String** | Defines the backup source cluster and its references. | [optional] [readonly] 
**SrcCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**TgtCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexBackupClusterAllOf = Initialize-IntersightHyperflexBackupClusterAllOf  -ClassId null `
 -ObjectType null `
 -BackupDataStore null `
 -SrcCluster null `
 -TgtCluster null
```

- Convert the resource to JSON
```powershell
$HyperflexBackupClusterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

