# HyperflexClusterHealthCheckExecutionSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterHealthCheckExecutionSnapshot"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterHealthCheckExecutionSnapshot"]
**Timestamp** | **System.DateTime** | Timestamp of the last health check execution on the HyperFlex cluster. | [optional] 
**HxCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterHealthCheckExecutionSnapshotAllOf = Initialize-IntersightHyperflexClusterHealthCheckExecutionSnapshotAllOf  -ClassId null `
 -ObjectType null `
 -Timestamp null `
 -HxCluster null `
 -RegisteredDevice null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterHealthCheckExecutionSnapshotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

