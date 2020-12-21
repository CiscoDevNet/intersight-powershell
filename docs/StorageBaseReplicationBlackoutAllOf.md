# StorageBaseReplicationBlackoutAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureReplicationBlackout"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureReplicationBlackout"]
**VarEnd** | **String** | The end time of day for replication blackout window. Example: 17:00:01 which is 17 hours, 0 minutes, 1 seconds. | [optional] [readonly] 
**Start** | **String** | The start time of day when replication blackout is active. When replication blackout is active, the storage array temporarily disables replication. Example: 15:04:03.123 which is 15 hours, 4 minutes, 3 seconds and 123 milliseconds. The fractional seconds are written using the standard decimal notation which can be used for setting milliseconds and microseconds. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseReplicationBlackoutAllOf = Initialize-IntersightStorageBaseReplicationBlackoutAllOf  -ClassId null `
 -ObjectType null `
 -VarEnd null `
 -Start null
```

- Convert the resource to JSON
```powershell
$StorageBaseReplicationBlackoutAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

