# CondAlarmAggregationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "cond.AlarmAggregation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "cond.AlarmAggregation"]
**AlarmSummary** | [**CondAlarmSummary**](CondAlarmSummary.md) |  | [optional] 
**CriticalAlarmsCount** | **Int64** | Count of all alarms with severity Critical, irrespective of acknowledgement status. | [optional] 
**Health** | **String** | Health of the managed end point. The highest severity computed from alarmSummary property is set as the health. * &#x60;None&#x60; - The Enum value None represents that there is no severity. * &#x60;Info&#x60; - The Enum value Info represents the Informational level of severity. * &#x60;Critical&#x60; - The Enum value Critical represents the Critical level of severity. * &#x60;Warning&#x60; - The Enum value Warning represents the Warning level of severity. * &#x60;Cleared&#x60; - The Enum value Cleared represents that the alarm severity has been cleared. | [optional] [default to "None"]
**InfoAlarmsCount** | **Int64** | Count of all alarms with severity Info, irrespective of acknowledgement status. | [optional] 
**MoType** | **String** | Managed object type. For example, FI managed object type will be network.Element. | [optional] 
**WarningAlarmsCount** | **Int64** | Count of all alarms with severity Warning, irrespective of acknowledgement status. | [optional] 
**AlarmAggregationSource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CondAlarmAggregationAllOf = Initialize-IntersightCondAlarmAggregationAllOf  -ClassId null `
 -ObjectType null `
 -AlarmSummary null `
 -CriticalAlarmsCount null `
 -Health null `
 -InfoAlarmsCount null `
 -MoType null `
 -WarningAlarmsCount null `
 -AlarmAggregationSource null
```

- Convert the resource to JSON
```powershell
$CondAlarmAggregationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

