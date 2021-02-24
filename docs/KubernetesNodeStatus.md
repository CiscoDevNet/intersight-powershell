# KubernetesNodeStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeStatus"]
**Status** | **String** | Statue of the node. Indicate if the node is kubernetes ready or not. | [optional] 
**Type** | **String** | Type of the node. It can be either Master or Worker. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeStatus = Initialize-IntersightKubernetesNodeStatus  -ClassId null `
 -ObjectType null `
 -Status null `
 -Type null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

