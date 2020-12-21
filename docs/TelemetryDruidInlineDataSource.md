# TelemetryDruidInlineDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**ColumnNames** | **String[]** | the column names. | 
**Rows** | [**String[][]**](Array.md) | an array of rows. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidInlineDataSource = Initialize-IntersightTelemetryDruidInlineDataSource  -Type null `
 -ColumnNames null `
 -Rows null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidInlineDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

