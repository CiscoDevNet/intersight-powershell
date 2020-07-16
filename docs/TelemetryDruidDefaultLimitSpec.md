# TelemetryDruidDefaultLimitSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The limit spec type. | 
**Limit** | **Int32** | How many rows to return. If not specified, all rows will be returned. | 
**Columns** | [**TelemetryDruidOrderByColumnSpec[]**](TelemetryDruidOrderByColumnSpec.md) | null | 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidDefaultLimitSpec  -Type null `
 -Limit null `
 -Columns null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

