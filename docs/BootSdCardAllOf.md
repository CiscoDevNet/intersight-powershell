# BootSdCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. | [optional] 
**Subtype** | **String** | The subtype for the selected device type. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootSdCardAllOf  -Bootloader null `
 -Lun null `
 -Subtype null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

