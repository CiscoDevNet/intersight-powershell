# NtpPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | State of NTP service on the endpoint. | [optional] 
**NtpServers** | **String[]** |  | [optional] 
**Timezone** | **String** | Timezone of services on the endpoint. | [optional] [default to "Pacific/Niue"]
**ApplianceAccount** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNtpPolicyAllOf  -Enabled null `
 -NtpServers null `
 -Timezone null `
 -ApplianceAccount null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

