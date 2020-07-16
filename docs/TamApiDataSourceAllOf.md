# TamApiDataSourceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MoType** | **String** | Type of Intersight managed object used as data source. | [optional] 
**Queries** | [**TamQueryEntry[]**](TamQueryEntry.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamApiDataSourceAllOf  -MoType null `
 -Queries null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

