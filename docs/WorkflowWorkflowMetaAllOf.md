# WorkflowWorkflowMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | The description for the workflow. | [optional] 
**InputParameters** | **String[]** |  | [optional] 
**Name** | **String** | The name given to the workflow. | [optional] 
**OutputParameters** | [**AnyType**](.md) | The workflow output parameters. | [optional] 
**Retryable** | **Boolean** | When true, this workflow can be retried for 2 weeks since the last modification of the workflow. | [optional] 
**SchemaVersion** | **Int64** | The Conductor schema version that decides what attribute can be supported. | [optional] 
**Src** | **String** | The src is workflow owner service. | [optional] 
**Tasks** | [**AnyType**](.md) | The tasks contained inside of the workflow. | [optional] 
**Type** | **String** | The type of workflow definition. | [optional] [default to "SystemDefined"]
**Version** | **Int64** | The version for the workflow so we can support multiple versions for the same workflow name. | [optional] 
**WaitOnDuplicate** | **Boolean** | Parameter decides if workflows will wait for a duplicate to finish before starting a new one. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowMetaAllOf  -Description null `
 -InputParameters null `
 -Name null `
 -OutputParameters null `
 -Retryable null `
 -SchemaVersion null `
 -Src null `
 -Tasks null `
 -Type null `
 -Version null `
 -WaitOnDuplicate null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

