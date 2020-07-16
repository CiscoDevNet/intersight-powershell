# TamBaseDataSourceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name is used to unique identify and refer a given data source in an alert definition. | [optional] 
**Type** | **String** | Type of data source (for e.g. TextFsmTempalate based, Intersight API based etc.). | [optional] [default to "nxos"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamBaseDataSourceAllOf  -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

