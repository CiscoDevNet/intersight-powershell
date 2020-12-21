# ConnectorpackConnectorPackUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connectorpack.ConnectorPackUpdate"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connectorpack.ConnectorPackUpdate"]
**CurrentVersion** | **String** | Version of connector pack currently running in UCS Director. | [optional] [readonly] 
**Name** | **String** | Name of the connector pack. | [optional] [readonly] 
**NewVersion** | **String** | Version of connector pack to be installed in the next upgrade cycle. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ConnectorpackConnectorPackUpdate = Initialize-IntersightConnectorpackConnectorPackUpdate  -ClassId null `
 -ObjectType null `
 -CurrentVersion null `
 -Name null `
 -NewVersion null
```

- Convert the resource to JSON
```powershell
$ConnectorpackConnectorPackUpdate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

