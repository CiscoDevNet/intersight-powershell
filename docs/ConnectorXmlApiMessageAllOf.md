# ConnectorXmlApiMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WithAuth** | **Boolean** | Flag to disable authentication bypassing. If set to true it is expected a valid cookie/login is provided within the XML API request body. | [optional] 
**XmlRequest** | **String** | The XML request body to proxy to the platform. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorXmlApiMessageAllOf  -WithAuth null `
 -XmlRequest null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

