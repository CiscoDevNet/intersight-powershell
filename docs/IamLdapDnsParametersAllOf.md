# IamLdapDnsParametersAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchDomain** | **String** | Domain name that acts as a source for a DNS query. | [optional] 
**SearchForest** | **String** | Forest name that acts as a source for a DNS query. | [optional] 
**Source** | **String** | Source of the domain name used for the DNS SRV request. | [optional] [default to "Extracted"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamLdapDnsParametersAllOf  -SearchDomain null `
 -SearchForest null `
 -Source null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

