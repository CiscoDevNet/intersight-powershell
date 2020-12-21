# TelemetryDruidInlineDataSourceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnNames** | **String[]** | the column names. | 
**Rows** | [**String[][]**](Array.md) | an array of rows. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidInlineDataSourceAllOf = Initialize-IntersightTelemetryDruidInlineDataSourceAllOf  -ColumnNames null `
 -Rows null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidInlineDataSourceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

