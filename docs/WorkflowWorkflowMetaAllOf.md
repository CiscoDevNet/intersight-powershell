# WorkflowWorkflowMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkflowMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkflowMeta"]
**Description** | **String** | The description for the workflow. | [optional] 
**InputParameters** | **String[]** |  | [optional] 
**Name** | **String** | The name given to the workflow. | [optional] 
**OutputParameters** | [**AnyType**](.md) | The workflow output parameters. | [optional] 
**Retryable** | **Boolean** | When true, this workflow can be retried for 2 weeks since the last modification of the workflow. | [optional] [default to $false]
**SchemaVersion** | **Int64** | The Conductor schema version that decides what attribute can be supported. | [optional] 
**Src** | **String** | The src is workflow owner service. | [optional] 
**Tasks** | [**AnyType**](.md) | The tasks contained inside of the workflow. | [optional] 
**Type** | **String** | The type of workflow definition. * &#x60;SystemDefined&#x60; - System defined workflow definition. * &#x60;UserDefined&#x60; - User defined workflow definition. * &#x60;Dynamic&#x60; - Dynamically defined workflow definition. | [optional] [default to "SystemDefined"]
**Version** | **Int64** | The version for the workflow so we can support multiple versions for the same workflow name. | [optional] [default to 1]
**WaitOnDuplicate** | **Boolean** | Parameter decides if workflows will wait for a duplicate to finish before starting a new one. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowWorkflowMetaAllOf = Initialize-IntersightWorkflowWorkflowMetaAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
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
$WorkflowWorkflowMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

