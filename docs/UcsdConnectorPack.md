# UcsdConnectorPack
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightUcsdConnectorPack  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

