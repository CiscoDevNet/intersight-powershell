# HyperflexHxapClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxapCluster"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxapCluster"]
**DatacenterName** | **String** | Datacenter to which the cluster belongs. | [optional] 
**FailureReason** | **String** | Reason of the failure when cluster is in failed state. | [optional] 
**ManagementIpAddress** | **String** | Management IP Address of the cluster. | [optional] 
**Version** | **String** | Product version of HyperFlex compute cluster. | [optional] 
**HxCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxapClusterAllOf = Initialize-IntersightHyperflexHxapClusterAllOf  -ClassId null `
 -ObjectType null `
 -DatacenterName null `
 -FailureReason null `
 -ManagementIpAddress null `
 -Version null `
 -HxCluster null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$HyperflexHxapClusterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

