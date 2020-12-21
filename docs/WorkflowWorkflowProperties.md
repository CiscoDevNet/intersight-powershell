# WorkflowWorkflowProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkflowProperties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkflowProperties"]
**ExternalMeta** | **Boolean** | When set to false the workflow is owned by the system and used for internal services. Such workflows cannot be directly used by external entities. | [optional] [default to $false]
**Retryable** | **Boolean** | When true, this workflow can be retried if has not been modified for more than a period of 2 weeks. | [optional] [default to $false]
**SupportStatus** | **String** | Supported status of the definition. * &#x60;Supported&#x60; - The definition is a supported version and there will be no changes to the mandatory inputs or outputs. * &#x60;Beta&#x60; - The definition is a Beta version and this version can under go changes until the version is marked supported. * &#x60;Deprecated&#x60; - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added. | [optional] [default to "Supported"]

## Examples

- Prepare the resource
```powershell
$WorkflowWorkflowProperties = Initialize-IntersightWorkflowWorkflowProperties  -ClassId null `
 -ObjectType null `
 -ExternalMeta null `
 -Retryable null `
 -SupportStatus null
```

- Convert the resource to JSON
```powershell
$WorkflowWorkflowProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

