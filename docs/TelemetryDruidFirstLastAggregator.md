# TelemetryDruidFirstLastAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | Output name for the first/last value. | 
**FieldName** | **String** | Name of the metric column. | 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidFirstLastAggregator  -Type null `
 -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

