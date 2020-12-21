# IamLdapProviderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LdapProvider"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LdapProvider"]
**Port** | **Int64** | LDAP Server Port for connection establishment. | [optional] [default to 389]
**Server** | **String** | LDAP Server Address, can be IP address or hostname. | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamLdapProviderAllOf = Initialize-IntersightIamLdapProviderAllOf  -ClassId null `
 -ObjectType null `
 -Port null `
 -Server null `
 -LdapPolicy null
```

- Convert the resource to JSON
```powershell
$IamLdapProviderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

