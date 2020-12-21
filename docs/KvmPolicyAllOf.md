# KvmPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kvm.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kvm.Policy"]
**EnableLocalServerVideo** | **Boolean** | If enabled, displays KVM session on any monitor attached to the server. | [optional] [default to $true]
**EnableVideoEncryption** | **Boolean** | If enabled, encrypts all video information sent through KVM. | [optional] [default to $true]
**Enabled** | **Boolean** | State of the vKVM service on the endpoint. | [optional] [default to $true]
**MaximumSessions** | **Int64** | The maximum number of concurrent KVM sessions allowed. | [optional] [default to 4]
**RemotePort** | **Int64** | The port used for KVM communication. | [optional] [default to 2068]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$KvmPolicyAllOf = Initialize-IntersightKvmPolicyAllOf  -ClassId null `
 -ObjectType null `
 -EnableLocalServerVideo null `
 -EnableVideoEncryption null `
 -Enabled null `
 -MaximumSessions null `
 -RemotePort null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$KvmPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

