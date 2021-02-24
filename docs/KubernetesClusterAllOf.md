# KubernetesClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.Cluster"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.Cluster"]
**ConnectionStatus** | **String** | Status of the endpoint connection of this Kubernetes cluster. * &#x60;&#x60; - The target details have been persisted but Intersight has not yet attempted to connect to the target. * &#x60;Connected&#x60; - Intersight is able to establish a connection to the target and initiate management activities. * &#x60;NotConnected&#x60; - Intersight is unable to establish a connection to the target. * &#x60;ClaimInProgress&#x60; - Claim of the target is in progress. A connection to the target has not been fully established. * &#x60;Unclaimed&#x60; - The device was un-claimed from the users account by an Administrator of the device. Also indicates the failure to claim Custom Target details in Intersight. * &#x60;Claimed&#x60; - Custom Target is successfully claimed in Intersight. Currently no validation is performed to verify the Target connectivity from Intersight at the time of creation. However invoking API from Intersight Orchestrator fails if this Target is not reachable from Intersight or if Target credentials are incorrect. | [optional] [default to ""]
**KubeConfig** | **String** | Kubeconfig for the cluster to collect inventory for. | [optional] 
**Name** | **String** | Name of the Kubernetes cluster. | [optional] 
**Var0ClusterProfile** | [**KubernetesClusterProfileRelationship**](KubernetesClusterProfileRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RegisteredDevices** | [**AssetDeviceRegistrationRelationship[]**](AssetDeviceRegistrationRelationship.md) | An array of relationships to assetDeviceRegistration resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesClusterAllOf = Initialize-IntersightKubernetesClusterAllOf  -ClassId null `
 -ObjectType null `
 -ConnectionStatus null `
 -KubeConfig null `
 -Name null `
 -Var0ClusterProfile null `
 -Organization null `
 -RegisteredDevices null
```

- Convert the resource to JSON
```powershell
$KubernetesClusterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

