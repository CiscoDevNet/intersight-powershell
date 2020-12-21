# ConnectorXmlApiMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.XmlApiMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.XmlApiMessage"]
**WithAuth** | **Boolean** | Flag to disable authentication bypassing. If set to true it is expected a valid cookie/login is provided within the XML API request body. | [optional] 
**XmlRequest** | **String** | The XML request body to proxy to the platform. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorXmlApiMessageAllOf = Initialize-IntersightConnectorXmlApiMessageAllOf  -ClassId null `
 -ObjectType null `
 -WithAuth null `
 -XmlRequest null
```

- Convert the resource to JSON
```powershell
$ConnectorXmlApiMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

