# StorageBaseHostLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hlu** | **Int64** | Logical unit number (LUN) by which hosts address specified volume. Hlu is a decimal representation of the LUN from the endpoint. | [optional] [readonly] 
**HostName** | **String** | Name of the host associated with LUN. | [optional] [readonly] 
**VolumeName** | **String** | Name of the storage volume associated with LUN. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseHostLunAllOf  -Hlu null `
 -HostName null `
 -VolumeName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

