# IpmioverlanPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | State of the IPMI Over LAN service on the endpoint. | [optional] 
**EncryptionKey** | **String** | The encryption key to use for IPMI communication. It should have an even number of hexadecimal characters and not exceed 40 characters. | [optional] 
**IsEncryptionKeySet** | **Boolean** | Indicates whether the value of the &#39;encryptionKey&#39; property has been set. | [optional] [readonly] 
**Privilege** | **String** | The highest privilege level that can be assigned to an IPMI session on a server. | [optional] [default to "admin"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIpmioverlanPolicyAllOf  -Enabled null `
 -EncryptionKey null `
 -IsEncryptionKeySet null `
 -Privilege null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

