# TelemetryDruidGreatestLeastPostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**Fields** | **String** | the fields that are used to compute the greatest or least value. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidGreatestLeastPostAggregator  -Type null `
 -Name null `
 -Fields null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

