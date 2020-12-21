# UcsdConnectorPackAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ucsd.ConnectorPack"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ucsd.ConnectorPack"]
**ConnectorFeature** | **String** | State of the connector pack whether it is enabled or disabled. | [optional] [readonly] 
**DependencyNames** | **String[]** |  | [optional] 
**DownloadedVersion** | **String** | Version of the connector pack that is last downloaded successfully to UCS Director. | [optional] [readonly] 
**Name** | **String** | Name of the connector pack running on the UCS Director. | [optional] [readonly] 
**Services** | **String[]** |  | [optional] 
**State** | **String** | State of the connector pack whether it is enabled or disabled. | [optional] [readonly] 
**Version** | **String** | Version of the connector pack. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$UcsdConnectorPackAllOf = Initialize-IntersightUcsdConnectorPackAllOf  -ClassId null `
 -ObjectType null `
 -ConnectorFeature null `
 -DependencyNames null `
 -DownloadedVersion null `
 -Name null `
 -Services null `
 -State null `
 -Version null
```

- Convert the resource to JSON
```powershell
$UcsdConnectorPackAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

