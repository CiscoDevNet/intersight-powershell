# IamLdapBaseProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LdapBaseProperties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LdapBaseProperties"]
**Attribute** | **String** | Role and locale information of the user. | [optional] 
**BaseDn** | **String** | Base Distinguished Name (DN). Starting point from where server will search for users and groups. | [optional] 
**BindDn** | **String** | Distinguished Name (DN) of the user, that is used to authenticate against LDAP servers. | [optional] 
**BindMethod** | **String** | Authentication method to access LDAP servers. * &#x60;LoginCredentials&#x60; - Requires the user credentials. If the bind process fails, then user is denied access. * &#x60;Anonymous&#x60; - Requires no username and password. If this option is selected and the LDAP server is configured for Anonymous logins, then the user gains access. * &#x60;ConfiguredCredentials&#x60; - Requires a known set of credentials to be specified for the initial bind process. If the initial bind process succeeds, then the distinguished name (DN) of the user name is queried and re-used for the re-binding process. If the re-binding process fails, then the user is denied access. | [optional] [default to "LoginCredentials"]
**Domain** | **String** | The IPv4 domain that all users must be in. | [optional] 
**EnableEncryption** | **Boolean** | If enabled, the endpoint encrypts all information it sends to the LDAP server. | [optional] 
**EnableGroupAuthorization** | **Boolean** | If enabled, user authorization is also done at the group level for LDAP users not in the local user database. | [optional] 
**VarFilter** | **String** | Criteria to identify entries in search requests. | [optional] 
**GroupAttribute** | **String** | Groups to which an LDAP entry belongs. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**NestedGroupSearchDepth** | **Int64** | Search depth to look for a nested LDAP group in an LDAP group map. | [optional] [default to 128]
**Password** | **String** | The password of the user for initial bind process. It can be any string that adheres to the following constraints. It can have character except spaces, tabs, line breaks. It cannot be more than 254 characters. | [optional] 
**Timeout** | **Int64** | LDAP authentication timeout duration, in seconds. | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$IamLdapBaseProperties = Initialize-IntersightIamLdapBaseProperties  -ClassId null `
 -ObjectType null `
 -Attribute null `
 -BaseDn null `
 -BindDn null `
 -BindMethod null `
 -Domain null `
 -EnableEncryption null `
 -EnableGroupAuthorization null `
 -VarFilter null `
 -GroupAttribute null `
 -IsPasswordSet null `
 -NestedGroupSearchDepth null `
 -Password null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$IamLdapBaseProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

