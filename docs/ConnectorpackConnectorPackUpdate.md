# ConnectorpackConnectorPackUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CurrentVersion** | **String** | Version of connector pack currently running in UCS Director. | [optional] [readonly] 
**Name** | **String** | Name of the connector pack. | [optional] [readonly] 
**NewVersion** | **String** | Version of connector pack to be installed in the next upgrade cycle. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorpackConnectorPackUpdate  -ClassId null `
 -ObjectType null `
 -CurrentVersion null `
 -Name null `
 -NewVersion null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

