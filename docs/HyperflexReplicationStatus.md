# HyperflexReplicationStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ReplicationStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ReplicationStatus"]
**BytesReplicated** | **Int64** | Number of bytes currently replicated. | [optional] [readonly] 
**EndTime** | **Int64** | Replication end time for this snapshot. | [optional] [readonly] 
**VarError** | [**HyperflexErrorStack**](HyperflexErrorStack.md) |  | [optional] 
**PackEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**PctComplete** | **Int64** | Completion percentage for the replication job. | [optional] [readonly] 
**RpoStatus** | [**HyperflexRpoStatus**](HyperflexRpoStatus.md) |  | [optional] 
**StartTime** | **Int64** | Replication start time for this snapshot. | [optional] [readonly] 
**Status** | **String** | Current replication state for a particular snapshot. * &#x60;NONE&#x60; - Snapshot replication state is none. * &#x60;SUCCESS&#x60; - Snapshot completed successfully. * &#x60;FAILED&#x60; - Snapshot failed replication status code. * &#x60;PAUSED&#x60; - Snapshot replication paused status code. * &#x60;IN_USE&#x60; - Snapshot replica in use status code. * &#x60;STARTING&#x60; - Snapshot replication starting. * &#x60;REPLICATING&#x60; - Snapshot replication in progress. | [optional] [readonly] [default to "NONE"]

## Examples

- Prepare the resource
```powershell
$HyperflexReplicationStatus = Initialize-IntersightHyperflexReplicationStatus  -ClassId null `
 -ObjectType null `
 -BytesReplicated null `
 -EndTime null `
 -VarError null `
 -PackEntityReference null `
 -PctComplete null `
 -RpoStatus null `
 -StartTime null `
 -Status null
```

- Convert the resource to JSON
```powershell
$HyperflexReplicationStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

