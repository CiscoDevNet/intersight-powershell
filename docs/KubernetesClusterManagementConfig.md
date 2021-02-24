# KubernetesClusterManagementConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ClusterManagementConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ClusterManagementConfig"]
**EncryptedEtcd** | **Boolean** | Encrypt ETCD data at rest using the etcdEncryptionKey specified in the cluster Kubernetes configuration. | [optional] 
**InternalMgmtPrivateKey** | [**SystemByte**](SystemByte.md) | Private key for internal mgmt of the cluster via SSH. | [optional] 
**InternalMgmtPublicKey** | **String** | Public key for internal mgmt of the cluster via SSH. | [optional] 
**LoadBalancerCount** | **Int64** | Number of IP addresses to reserve for load balancer services. | [optional] 
**LoadBalancers** | **String[]** |  | [optional] 
**MasterVip** | **String** | VIP for the cluster Kubernetes API server. If this is empty and a cluster IP pool is specified, it will be allocated from the IP pool. | [optional] 
**SshKeys** | **String[]** |  | [optional] 
**SshUser** | **String** | Name of the user to SSH to nodes in a cluster. | [optional] [readonly] [default to "iksadmin"]

## Examples

- Prepare the resource
```powershell
$KubernetesClusterManagementConfig = Initialize-IntersightKubernetesClusterManagementConfig  -ClassId null `
 -ObjectType null `
 -EncryptedEtcd null `
 -InternalMgmtPrivateKey null `
 -InternalMgmtPublicKey null `
 -LoadBalancerCount null `
 -LoadBalancers null `
 -MasterVip null `
 -SshKeys null `
 -SshUser null
```

- Convert the resource to JSON
```powershell
$KubernetesClusterManagementConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

