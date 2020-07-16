# BootPchStorageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. It is the Virtual Drive number for Cisco UCS C-Series Servers. Virtual Drive number is found in storage inventory. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootPchStorageAllOf  -Bootloader null `
 -Lun null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

