# ComputeAlarmSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.AlarmSummary"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.AlarmSummary"]
**Critical** | **Int64** | The count of alarms that have severity type Critical. | [optional] 
**Warning** | **Int64** | The count of alarms that have severity type Warning. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeAlarmSummaryAllOf = Initialize-IntersightComputeAlarmSummaryAllOf  -ClassId null `
 -ObjectType null `
 -Critical null `
 -Warning null
```

- Convert the resource to JSON
```powershell
$ComputeAlarmSummaryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

