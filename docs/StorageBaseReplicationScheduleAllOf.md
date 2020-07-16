# StorageBaseReplicationScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **String** | Replication frequency. It is an interval at which replication is set to trigger. Examples:     PT2H, Snapshot is generated every 2 hours.     P30D, Snapshot is scheduled for every 30 days.     PT2H34M56.123S is 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 
**Name** | **String** | Replication schedule name. | [optional] [readonly] 
**ReplicationTime** | **String** | Preferred time of day at which to replicate the snapshots on target array. It is applicable only if the replication frequency is set for a day or more. Format: hh:mm:ss Example: 15:00:00, Replication is set for 3:00 PM. | [optional] [readonly] 
**RetentionTime** | **String** | Duration to keep the replicated snapshots on the targets. Replicated snapshots are deleted from target array once the retention period has elapsed. Examples: P30D, Snapshots are available for 30 days. PT2H34M56.123S, 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseReplicationScheduleAllOf  -Frequency null `
 -Name null `
 -ReplicationTime null `
 -RetentionTime null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

