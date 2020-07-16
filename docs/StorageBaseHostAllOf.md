# StorageBaseHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Short description about the host. | [optional] [readonly] 
**Initiators** | [**StorageBaseInitiator[]**](StorageBaseInitiator.md) |  | [optional] 
**Name** | **String** | Name of the host in storage array. | [optional] [readonly] 
**OsType** | **String** | Operating system running on the host. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseHostAllOf  -Description null `
 -Initiators null `
 -Name null `
 -OsType null `
 -StorageUtilization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

