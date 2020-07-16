# ConnectorpackConnectorPackUpdateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentVersion** | **String** | Version of connector pack currently running in UCS Director. | [optional] [readonly] 
**Name** | **String** | Name of the connector pack. | [optional] [readonly] 
**NewVersion** | **String** | Version of connector pack to be installed in the next upgrade cycle. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorpackConnectorPackUpdateAllOf  -CurrentVersion null `
 -Name null `
 -NewVersion null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

