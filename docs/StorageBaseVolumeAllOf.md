# StorageBaseVolumeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Short description about the volume. | [optional] [readonly] 
**NaaId** | **String** | NAA id of volume. It is a significant number to identify corresponding lun path in hypervisor. | [optional] [readonly] 
**Name** | **String** | Named entity of the volume. | [optional] [readonly] 
**Size** | **Int64** | User provisioned volume size. It is the size exposed to host. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseVolumeAllOf  -Description null `
 -NaaId null `
 -Name null `
 -Size null `
 -StorageUtilization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

