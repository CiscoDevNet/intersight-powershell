# WorkflowInitiatorContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.InitiatorContext"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.InitiatorContext"]
**InitiatorMoid** | **String** | The moid of the Intersigt managed object that initiated the workflow. | [optional] 
**InitiatorName** | **String** | Name of the initiator who started the workflow. The initiator can be Intersight managed object that triggered the workflow. | [optional] 
**InitiatorType** | **String** | Type of Intersight managed object that initiated the workflow. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowInitiatorContext = Initialize-IntersightWorkflowInitiatorContext  -ClassId null `
 -ObjectType null `
 -InitiatorMoid null `
 -InitiatorName null `
 -InitiatorType null
```

- Convert the resource to JSON
```powershell
$WorkflowInitiatorContext | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

