# HyperflexVmSnapshotInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmSnapshotInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmSnapshotInfo"]
**ClusterIdSnapMap** | [**HyperflexMapClusterIdToStSnapshotPoint[]**](HyperflexMapClusterIdToStSnapshotPoint.md) |  | [optional] 
**ErrorStack** | [**HyperflexErrorStack**](HyperflexErrorStack.md) |  | [optional] 
**Label** | **String** | The name of the Virtual Machine and the time stamp of the snapshot. | [optional] 
**Mode** | **String** | Quiesce Mode for snapshot taken on Hyperflex cluster. * &#x60;NONE&#x60; - The snapshot quiesce mode is none. * &#x60;CRASH&#x60; - The snapshot quiesce mode is crash. * &#x60;VMTOOLS&#x60; - The snapshot quiesce mode is VMTOOLS. * &#x60;APP_CONSISTENT&#x60; - The snapshot quiesce mode is app consistent. | [optional] [readonly] [default to "NONE"]
**ParentSnapshot** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**ReplicationStatus** | **String** | Replication status of the least successful target cluster. * &#x60;NONE&#x60; - Snapshot replication state is none. * &#x60;SUCCESS&#x60; - Snapshot completed successfully. * &#x60;FAILED&#x60; - Snapshot failed replication status code. * &#x60;PAUSED&#x60; - Snapshot replication paused status code. * &#x60;IN_USE&#x60; - Snapshot replica in use status code. * &#x60;STARTING&#x60; - Snapshot replication starting. * &#x60;REPLICATING&#x60; - Snapshot replication in progress. | [optional] [readonly] [default to "NONE"]
**SnapshotStatus** | **String** | Snapshot status of the source cluster. * &#x60;SUCCESS&#x60; - This snapshot status code is success. * &#x60;FAILED&#x60; - This snapshot status code is failed. * &#x60;IN_PROGRESS&#x60; - This snapshot status code is in progress. * &#x60;DELETING&#x60; - This snapshot status code is deleting. * &#x60;DELETED&#x60; - This snapshot status code is deleted. * &#x60;NONE&#x60; - This snapshot status code is none. | [optional] [readonly] [default to "SUCCESS"]
**SourceTimestamp** | **Int64** | Timestamp the snapshot was created on the source cluster. | [optional] [readonly] 
**VmEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**VmSnapshotEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**SrcCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**TgtCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**VmBackupInfo** | [**HyperflexVmBackupInfoRelationship**](HyperflexVmBackupInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmSnapshotInfoAllOf = Initialize-IntersightHyperflexVmSnapshotInfoAllOf  -ClassId null `
 -ObjectType null `
 -ClusterIdSnapMap null `
 -ErrorStack null `
 -Label null `
 -Mode null `
 -ParentSnapshot null `
 -ReplicationStatus null `
 -SnapshotStatus null `
 -SourceTimestamp null `
 -VmEntityReference null `
 -VmSnapshotEntityReference null `
 -SrcCluster null `
 -TgtCluster null `
 -VmBackupInfo null
```

- Convert the resource to JSON
```powershell
$HyperflexVmSnapshotInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

