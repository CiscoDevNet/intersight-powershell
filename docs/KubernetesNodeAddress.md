# KubernetesNodeAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeAddress"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeAddress"]
**Address** | **String** | The address of type specified by the type field. | [optional] 
**Type** | **String** | The address type of the Node. The usage of the IP address depending on the cloud provider or bare metal configuration. HostName - The hostname as reported by the node&#39;s kernel. ExternalIP - Typically the IP address of the node that is externally routable (available from outside the cluster) InternalIP - Typically the IP address of the node that is routable only within the cluster. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeAddress = Initialize-IntersightKubernetesNodeAddress  -ClassId null `
 -ObjectType null `
 -Address null `
 -Type null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeAddress | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

