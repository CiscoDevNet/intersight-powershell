# StorageBaseHostGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Short description about the host group. | [optional] [readonly] 
**Name** | **String** | Name of the host group in storage array. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseHostGroupAllOf  -Description null `
 -Name null `
 -StorageUtilization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

