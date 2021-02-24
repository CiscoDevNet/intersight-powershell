# KubernetesNodeGroupTaintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeGroupTaint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeGroupTaint"]
**Effect** | **String** | The effect to enforce when the key does not match the value. | [optional] 
**Key** | **String** | The key for a Kubernetes taint. | [optional] 
**Value** | **String** | If the key does not match this value, the specified effect is enforced. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeGroupTaintAllOf = Initialize-IntersightKubernetesNodeGroupTaintAllOf  -ClassId null `
 -ObjectType null `
 -Effect null `
 -Key null `
 -Value null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeGroupTaintAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

