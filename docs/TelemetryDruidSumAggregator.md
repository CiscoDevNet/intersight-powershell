# TelemetryDruidSumAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | Output name for the summed value. | 
**FieldName** | **String** | Name of the metric column to sum over. | 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidSumAggregator  -Type null `
 -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

