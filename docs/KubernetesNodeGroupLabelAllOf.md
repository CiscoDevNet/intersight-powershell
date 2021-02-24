# KubernetesNodeGroupLabelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeGroupLabel"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeGroupLabel"]
**Key** | **String** | The key for a Kubernetes label for a node. | [optional] 
**Value** | **String** | The value for a Kubernetes label for a node. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeGroupLabelAllOf = Initialize-IntersightKubernetesNodeGroupLabelAllOf  -ClassId null `
 -ObjectType null `
 -Key null `
 -Value null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeGroupLabelAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

