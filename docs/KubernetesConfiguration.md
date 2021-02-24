# KubernetesConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.Configuration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.Configuration"]
**KubeConfig** | **String** | Kubernetes configuration to connect to the cluster as an system administrator. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$KubernetesConfiguration = Initialize-IntersightKubernetesConfiguration  -ClassId null `
 -ObjectType null `
 -KubeConfig null
```

- Convert the resource to JSON
```powershell
$KubernetesConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

