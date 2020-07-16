# ConnectorStreamAcknowledgeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AckSequence** | **Int64** | The latest message sequence processed in the cloud. Device connector will drop all messages up to this sequence from its cache. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorStreamAcknowledgeAllOf  -AckSequence null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

