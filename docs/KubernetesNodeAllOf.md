# KubernetesNodeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.Node"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.Node"]
**NodeAddresses** | [**KubernetesNodeAddress[]**](KubernetesNodeAddress.md) |  | [optional] 
**NodeInfo** | [**KubernetesNodeInfo**](KubernetesNodeInfo.md) |  | [optional] 
**NodeSpec** | [**KubernetesNodeSpec**](KubernetesNodeSpec.md) |  | [optional] 
**NodeStatuses** | [**KubernetesNodeStatus[]**](KubernetesNodeStatus.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeAllOf = Initialize-IntersightKubernetesNodeAllOf  -ClassId null `
 -ObjectType null `
 -NodeAddresses null `
 -NodeInfo null `
 -NodeSpec null `
 -NodeStatuses null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

