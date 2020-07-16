# StorageLocalDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SlotNumber** | **Int64** | The slot number of the disk to be referenced. As this is a policy, this slot number may or may not be valid depending on the number of disks in the associated server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageLocalDiskAllOf  -SlotNumber null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

