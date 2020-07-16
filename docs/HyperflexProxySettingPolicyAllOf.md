# HyperflexProxySettingPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **String** | HTTP Proxy server FQDN or IP. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | The password for the HTTP Proxy. | [optional] 
**Port** | **Int64** | The HTTP Proxy port number. The port number of the HTTP proxy must be between 1 and 65535, inclusive. | [optional] 
**Username** | **String** | The username for the HTTP Proxy. | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexProxySettingPolicyAllOf  -Hostname null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -Username null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

