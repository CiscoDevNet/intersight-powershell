# StorageBaseSnapshotScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **String** | Snapshot frequency. It is an interval at which snapshot is set to trigger on source array. Examples:     PT2H Snapshot is generated every 2 hours.     P4D, Snapshot is scheduled for every 4 days.     PT2H34M56.123S is 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 
**Name** | **String** | Name of the snapshot schedule. | [optional] 
**RetentionTime** | **String** | Duration to keep the snapshots on the source array. Once this period expires, system deletes the snapshot automatically from the source array. Examples: P200D,  200 days. PT2H34M56.123S, 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 
**SnapshotTime** | **String** | Preferred time of the day to capture the snapshot. It is applicable only if the frequency is set for a day or more. Format: hh:mm:ss Example: 08:30:00, Snapshot is set for 08:30 AM. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseSnapshotScheduleAllOf  -Frequency null `
 -Name null `
 -RetentionTime null `
 -SnapshotTime null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

