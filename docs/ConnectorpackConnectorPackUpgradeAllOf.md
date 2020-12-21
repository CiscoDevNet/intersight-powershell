# ConnectorpackConnectorPackUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connectorpack.ConnectorPackUpgrade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connectorpack.ConnectorPackUpgrade"]
**ConnectorPackOpType** | **String** | The type of operation to be performed on UCS Director. * &#x60;Install&#x60; - Installs the requisite connector packs on UCS Director. * &#x60;Push&#x60; - Pushes the requisite connector packs to UCS Director. | [optional] [default to "Install"]
**UcsdInfo** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorpackConnectorPackUpgradeAllOf = Initialize-IntersightConnectorpackConnectorPackUpgradeAllOf  -ClassId null `
 -ObjectType null `
 -ConnectorPackOpType null `
 -UcsdInfo null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$ConnectorpackConnectorPackUpgradeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

