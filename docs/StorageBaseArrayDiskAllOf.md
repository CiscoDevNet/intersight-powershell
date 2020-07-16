# StorageBaseArrayDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Disk name available in storage array. | [optional] [readonly] 
**PartNumber** | **String** | Storage disk part number. | [optional] [readonly] 
**Protocol** | **String** | Storage protocol used in disk for communication. Possible values are SAS, SATA and NVMe. | [optional] [readonly] [default to "Unknown"]
**Speed** | **Int64** | Disk speed for read or write operation measured in rpm. | [optional] [readonly] 
**Status** | **String** | Storage disk health status. | [optional] [readonly] [default to "Unknown"]
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
**Type** | **String** | Storage disk type - it can be SSD, HDD, NVRAM. | [optional] [readonly] [default to "Unknown"]
**Version** | **String** | Storage disk version number. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseArrayDiskAllOf  -Name null `
 -PartNumber null `
 -Protocol null `
 -Speed null `
 -Status null `
 -StorageUtilization null `
 -Type null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

