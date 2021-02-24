# CommAbstractHttpProxyPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "comm.HttpProxyPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "comm.HttpProxyPolicy"]
**Hostname** | **String** | HTTP Proxy server FQDN or IP. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password for the HTTP Proxy. | [optional] 
**Port** | **Int64** | The HTTP Proxy port number. The port number of the HTTP proxy must be between 1 and 65535, inclusive. | [optional] 
**Username** | **String** | The username for the HTTP Proxy. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CommAbstractHttpProxyPolicyAllOf = Initialize-IntersightCommAbstractHttpProxyPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Hostname null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -Username null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$CommAbstractHttpProxyPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

