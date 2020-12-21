# IamLdapDnsParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LdapDnsParameters"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LdapDnsParameters"]
**SearchDomain** | **String** | Domain name that acts as a source for a DNS query. | [optional] 
**SearchForest** | **String** | Forest name that acts as a source for a DNS query. | [optional] 
**Source** | **String** | Source of the domain name used for the DNS SRV request. * &#x60;Extracted&#x60; - The domain name extracted-domain from the login ID. * &#x60;Configured&#x60; - The configured-search domain. * &#x60;ConfiguredExtracted&#x60; - The domain name extracted from the login ID than the configured-search domain. | [optional] [default to "Extracted"]

## Examples

- Prepare the resource
```powershell
$IamLdapDnsParameters = Initialize-IntersightIamLdapDnsParameters  -ClassId null `
 -ObjectType null `
 -SearchDomain null `
 -SearchForest null `
 -Source null
```

- Convert the resource to JSON
```powershell
$IamLdapDnsParameters | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

