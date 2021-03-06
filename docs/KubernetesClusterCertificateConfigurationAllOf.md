# KubernetesClusterCertificateConfigurationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ClusterCertificateConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ClusterCertificateConfiguration"]
**CaCert** | **String** | Certificate for the Kubernetes API server. | [optional] 
**CaKey** | **String** | Private Key for the Kubernetes API server. | [optional] 
**EtcdCert** | **String** | Certificate for the etcd cluster. | [optional] 
**EtcdEncryptionKey** | **String[]** |  | [optional] 
**EtcdKey** | **String** | Private key for the etcd cluster. | [optional] 
**FrontProxyCert** | **String** | Certificate for the front proxy to support Kubernetes API aggregators. | [optional] 
**FrontProxyKey** | **String** | Private key for the front proxy to support Kubernetes API aggregators. | [optional] 
**SaPrivateKey** | **String** | Service account private key used by Kubernetes Token Controller to sign generated service account tokens. | [optional] 
**SaPublicKey** | **String** | Service account public key used by Kubernetes API Server to validate service account tokens generated by the Token Controller. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesClusterCertificateConfigurationAllOf = Initialize-IntersightKubernetesClusterCertificateConfigurationAllOf  -ClassId null `
 -ObjectType null `
 -CaCert null `
 -CaKey null `
 -EtcdCert null `
 -EtcdEncryptionKey null `
 -EtcdKey null `
 -FrontProxyCert null `
 -FrontProxyKey null `
 -SaPrivateKey null `
 -SaPublicKey null
```

- Convert the resource to JSON
```powershell
$KubernetesClusterCertificateConfigurationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

