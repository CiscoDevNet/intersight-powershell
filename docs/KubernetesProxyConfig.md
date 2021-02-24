# KubernetesProxyConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ProxyConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ProxyConfig"]
**Hostname** | **String** | HTTP/HTTPS Proxy server FQDN or IP. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password for the HTTP/HTTPS Proxy. | [optional] 
**Port** | **Int64** | The HTTP Proxy port number. The port number of the HTTP/HTTPS proxy must be between 1 and 65535, inclusive. | [optional] 
**Protocol** | **String** | Protocol to use for the HTTP/HTTPS Proxy. | [optional] 
**Username** | **String** | The username for the HTTP/HTTPS Proxy. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesProxyConfig = Initialize-IntersightKubernetesProxyConfig  -ClassId null `
 -ObjectType null `
 -Hostname null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -Protocol null `
 -Username null
```

- Convert the resource to JSON
```powershell
$KubernetesProxyConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

