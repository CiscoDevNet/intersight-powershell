# KubernetesDeploymentStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.DeploymentStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.DeploymentStatus"]
**AvailableReplicas** | **Int64** | Total number of available pods (ready for at least minReadySeconds) targeted by this deployment. | [optional] 
**ObservedGeneration** | **Int64** | The generation observed by the deployment controller. | [optional] 
**ReadyReplicas** | **Int64** | Total number of ready pods targeted by this deployment. | [optional] 
**Replicas** | **Int64** | Total number of non-terminated pods targeted by this deployment (their labels match the selector). | [optional] 
**UpdatedReplicas** | **Int64** | Total number of non-terminated pods targeted by this deployment that have the desired template spec. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesDeploymentStatusAllOf = Initialize-IntersightKubernetesDeploymentStatusAllOf  -ClassId null `
 -ObjectType null `
 -AvailableReplicas null `
 -ObservedGeneration null `
 -ReadyReplicas null `
 -Replicas null `
 -UpdatedReplicas null
```

- Convert the resource to JSON
```powershell
$KubernetesDeploymentStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

