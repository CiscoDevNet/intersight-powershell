# ConnectorpackConnectorPackUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectorPackOpType** | **String** | The type of operation to be performed on UCS Director. | [optional] [default to "Install"]
**UcsdInfo** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorpackConnectorPackUpgradeAllOf  -ConnectorPackOpType null `
 -UcsdInfo null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

