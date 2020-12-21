# TelemetryDruidDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**Name** | **String** | The name of a data source. | 
**DataSources** | **String[]** | A list of data sources. | 
**Query** | [**TelemetryDruidGroupByRequest**](TelemetryDruidGroupByRequest.md) |  | 
**Lookup** | **String** | the name of the lookup object. | 
**Left** | **String** | Left-hand datasource. Must be of type table, join, lookup, query, or inline. Placing another join as the left datasource allows you to join arbitrarily many datasources. | 
**Right** | **String** | Right-hand datasource. Must be of type lookup, query, or inline. | 
**RightPrefix** | **String** | String prefix that will be applied to all columns from the right-hand datasource, to prevent them from colliding with columns from the left-hand datasource. Can be any string, so long as it is nonempty and is not be a prefix of the string __time. Any columns from the left-hand side that start with your rightPrefix will be shadowed. It is up to you to provide a prefix that will not shadow any important columns from the left side. | 
**Condition** | **String** | Expression that must be an equality where one side is an expression of the left-hand side, and the other side is a simple column reference to the right-hand side. The right-hand reference must be a simple column reference. | 
**JoinType** | **String** |  | 
**ColumnNames** | **String[]** | the column names. | 
**Rows** | [**String[][]**](Array.md) | an array of rows. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidDataSource = Initialize-IntersightTelemetryDruidDataSource  -Type null `
 -Name null `
 -DataSources null `
 -Query null `
 -Lookup null `
 -Left null `
 -Right null `
 -RightPrefix null `
 -Condition null `
 -JoinType null `
 -ColumnNames null `
 -Rows null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

