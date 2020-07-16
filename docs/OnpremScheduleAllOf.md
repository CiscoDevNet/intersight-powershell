# OnpremScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DayOfMonth** | **Int64** | Schedule a task on a specific day of the month. Valid values are 1 through 31. If monthOfYear is specified, then dayOfMonth value must be valid for that month. DayOfMonth may not be set when dayOfWeek is specfied. | [optional] 
**DayOfWeek** | **Int64** | Schedule a task on a specific day of the week. Valid values are 1 through 7, with 1 being Sunday. DayOfWeek may not be specfied when dayOfMonth is specified. | [optional] 
**MonthOfYear** | **Int64** | Schedule a task on a specific month of the year. Valid values are 1 through 12, with 1 being January. | [optional] 
**RepeatInterval** | **Int64** | Schedule a task to run periodically at an interval. Default unit of the RepeatInterval is in minutes. If the RepeateInterval value is set, then all other properties are ignored by the scheduler. RepeateInterval constraints are enforced by the services that use the schedule. Each service has pre-configured service specific properties for enforcing minimum and maximum values of the RepeatInterval. | [optional] 
**TimeOfDay** | **Int64** | Time of the day in seconds. TimeOfDay is required for all schedule configurations, except when the RepeateInterval field is specified. | [optional] 
**TimeZone** | **String** | Timezone to use for the schedule calculation. If a timezone value is not speficied, then the schedule calculation will be based on UTC. | [optional] [default to "Pacific/Niue"]
**WeekOfMonth** | **Int64** | Schedule a task on a specific week of the month. Valid values are 1 through 5. Value of 5 means last week of the month. WeekOfMonth may not be set when dayOfMonth is specified. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOnpremScheduleAllOf  -DayOfMonth null `
 -DayOfWeek null `
 -MonthOfYear null `
 -RepeatInterval null `
 -TimeOfDay null `
 -TimeZone null `
 -WeekOfMonth null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

