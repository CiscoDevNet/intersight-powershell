# ConnectorScopedInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NamingProperty** | **String** | A property that uniquely identifies the object to be inventoried as a part of the scoped inventory. | [optional] 
**Type** | **String** | Type of the object for which scoped inventory needs to be run. | [optional] 
**Values** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorScopedInventoryAllOf  -NamingProperty null `
 -Type null `
 -Values null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

