# HyperflexReplicationClusterReferenceToScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ReplicationClusterReferenceToSchedule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ReplicationClusterReferenceToSchedule"]
**Schedule** | [**HyperflexReplicationSchedule**](HyperflexReplicationSchedule.md) |  | [optional] 
**TargetClusterEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexReplicationClusterReferenceToScheduleAllOf = Initialize-IntersightHyperflexReplicationClusterReferenceToScheduleAllOf  -ClassId null `
 -ObjectType null `
 -Schedule null `
 -TargetClusterEntityReference null
```

- Convert the resource to JSON
```powershell
$HyperflexReplicationClusterReferenceToScheduleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

