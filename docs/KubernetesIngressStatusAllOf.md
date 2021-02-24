# KubernetesIngressStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.IngressStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.IngressStatus"]
**LoadBalancer** | [**KubernetesLoadBalancer**](KubernetesLoadBalancer.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesIngressStatusAllOf = Initialize-IntersightKubernetesIngressStatusAllOf  -ClassId null `
 -ObjectType null `
 -LoadBalancer null
```

- Convert the resource to JSON
```powershell
$KubernetesIngressStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

