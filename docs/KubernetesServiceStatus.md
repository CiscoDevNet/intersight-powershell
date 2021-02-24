# KubernetesServiceStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ServiceStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ServiceStatus"]
**LoadBalancer** | [**KubernetesLoadBalancer**](KubernetesLoadBalancer.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesServiceStatus = Initialize-IntersightKubernetesServiceStatus  -ClassId null `
 -ObjectType null `
 -LoadBalancer null
```

- Convert the resource to JSON
```powershell
$KubernetesServiceStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

