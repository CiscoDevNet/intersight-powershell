# KvmPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableLocalServerVideo** | **Boolean** | If enabled, displays KVM session on any monitor attached to the server. | [optional] 
**EnableVideoEncryption** | **Boolean** | If enabled, encrypts all video information sent through KVM. | [optional] 
**Enabled** | **Boolean** | State of the vKVM service on the endpoint. | [optional] 
**MaximumSessions** | **Int64** | The maximum number of concurrent KVM sessions allowed. | [optional] 
**RemotePort** | **Int64** | The port used for KVM communication. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightKvmPolicyAllOf  -EnableLocalServerVideo null `
 -EnableVideoEncryption null `
 -Enabled null `
 -MaximumSessions null `
 -RemotePort null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

