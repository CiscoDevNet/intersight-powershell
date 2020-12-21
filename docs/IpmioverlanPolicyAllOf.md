# IpmioverlanPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ipmioverlan.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ipmioverlan.Policy"]
**Enabled** | **Boolean** | State of the IPMI Over LAN service on the endpoint. | [optional] [default to $true]
**EncryptionKey** | **String** | The encryption key to use for IPMI communication. It should have an even number of hexadecimal characters and not exceed 40 characters. | [optional] 
**IsEncryptionKeySet** | **Boolean** | Indicates whether the value of the &#39;encryptionKey&#39; property has been set. | [optional] [readonly] [default to $false]
**Privilege** | **String** | The highest privilege level that can be assigned to an IPMI session on a server. * &#x60;admin&#x60; - Privilege to perform all actions available through IPMI. * &#x60;user&#x60; - Privilege to perform some functions through IPMI but restriction on performing administrative tasks. * &#x60;read-only&#x60; - Privilege to view information throught IPMI but restriction on making any changes. | [optional] [default to "admin"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IpmioverlanPolicyAllOf = Initialize-IntersightIpmioverlanPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -EncryptionKey null `
 -IsEncryptionKeySet null `
 -Privilege null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$IpmioverlanPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

