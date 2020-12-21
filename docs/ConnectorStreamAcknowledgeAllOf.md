# ConnectorStreamAcknowledgeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.StreamAcknowledge"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.StreamAcknowledge"]
**AckSequence** | **Int64** | The latest message sequence processed in the cloud. Device connector will drop all messages up to this sequence from its cache. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorStreamAcknowledgeAllOf = Initialize-IntersightConnectorStreamAcknowledgeAllOf  -ClassId null `
 -ObjectType null `
 -AckSequence null
```

- Convert the resource to JSON
```powershell
$ConnectorStreamAcknowledgeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

