# ServerProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigChanges** | [**PolicyConfigChange**](PolicyConfigChange.md) |  | [optional] 
**IsPmcDeployedSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;pmcDeployedSecurePassphrase&#39; property has been set. | [optional] [readonly] 
**PmcDeployedSecurePassphrase** | **String** | Secure passphrase that is already deployed on all the Persistent Memory Modules on the server. This deployed passphrase is required during deploy of server profile if secure passphrase is changed or security is disabled in the attached persistent memory policy. | [optional] 
**TargetPlatform** | **String** | The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight. | [optional] [default to "Standalone"]
**AssignedServer** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 
**AssociatedServer** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 
**ConfigChangeDetails** | [**ServerConfigChangeDetailRelationship[]**](ServerConfigChangeDetailRelationship.md) | An array of relationships to serverConfigChangeDetail resources. | [optional] [readonly] 
**ConfigResult** | [**ServerConfigResultRelationship**](ServerConfigResultRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RunningWorkflows** | [**WorkflowWorkflowInfoRelationship[]**](WorkflowWorkflowInfoRelationship.md) | An array of relationships to workflowWorkflowInfo resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightServerProfileAllOf  -ConfigChanges null `
 -IsPmcDeployedSecurePassphraseSet null `
 -PmcDeployedSecurePassphrase null `
 -TargetPlatform null `
 -AssignedServer null `
 -AssociatedServer null `
 -ConfigChangeDetails null `
 -ConfigResult null `
 -Organization null `
 -RunningWorkflows null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

