# TelemetryDruidGroupByResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **System.DateTime** | The ISO 8601 timestamp. | [optional] 
**Version** | **String** | The version of the Druid GroupBy Engine used in query | [optional] 
**VarEvent** | [**SystemCollectionsHashtable**](.md) | Grouped aggregate dimension(s) with values | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidGroupByResult = Initialize-IntersightTelemetryDruidGroupByResult  -Timestamp null `
 -Version null `
 -VarEvent null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidGroupByResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

