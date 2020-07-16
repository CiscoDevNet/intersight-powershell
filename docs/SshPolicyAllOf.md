# SshPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | State of SSH service on the endpoint. | [optional] 
**Port** | **Int64** | Port used for secure shell access. | [optional] 
**Timeout** | **Int64** | Number of seconds to wait before the system considers a SSH request to have timed out. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSshPolicyAllOf  -Enabled null `
 -Port null `
 -Timeout null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

