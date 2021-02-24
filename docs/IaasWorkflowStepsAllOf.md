# IaasWorkflowStepsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.WorkflowSteps"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.WorkflowSteps"]
**CompletedTime** | **String** | Completed time of the workflow step. | [optional] [readonly] 
**Name** | **String** | Name of the workflow step. | [optional] [readonly] 
**Status** | **String** | Status of the workflow step. | [optional] [readonly] 
**StatusMessage** | **String** | Status message of the workflow step. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IaasWorkflowStepsAllOf = Initialize-IntersightIaasWorkflowStepsAllOf  -ClassId null `
 -ObjectType null `
 -CompletedTime null `
 -Name null `
 -Status null `
 -StatusMessage null
```

- Convert the resource to JSON
```powershell
$IaasWorkflowStepsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

