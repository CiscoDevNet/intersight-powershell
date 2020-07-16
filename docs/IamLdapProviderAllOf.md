# IamLdapProviderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Port** | **Int64** | LDAP Server Port for connection establishment. | [optional] 
**Server** | **String** | LDAP Server Address, can be IP address or hostname. | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamLdapProviderAllOf  -Port null `
 -Server null `
 -LdapPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

