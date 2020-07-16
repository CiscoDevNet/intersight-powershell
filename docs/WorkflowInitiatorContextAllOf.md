# WorkflowInitiatorContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InitiatorMoid** | **String** | The moid of the Intersigt managed object that initiated the workflow. | [optional] 
**InitiatorName** | **String** | Name of the initiator who started the workflow. The initiator can be Intersight managed object that triggered the workflow. | [optional] 
**InitiatorType** | **String** | Type of Intersight managed object that initiated the workflow. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowInitiatorContextAllOf  -InitiatorMoid null `
 -InitiatorName null `
 -InitiatorType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

