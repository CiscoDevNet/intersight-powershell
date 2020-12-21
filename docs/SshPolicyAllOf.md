# SshPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ssh.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ssh.Policy"]
**Enabled** | **Boolean** | State of SSH service on the endpoint. | [optional] [default to $true]
**Port** | **Int64** | Port used for secure shell access. | [optional] [default to 22]
**Timeout** | **Int64** | Number of seconds to wait before the system considers a SSH request to have timed out. | [optional] [default to 1800]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SshPolicyAllOf = Initialize-IntersightSshPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Port null `
 -Timeout null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$SshPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

