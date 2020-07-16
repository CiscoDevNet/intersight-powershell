# BootSanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. | [optional] 
**Slot** | **String** | Slot ID of the device. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot; ). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootSanAllOf  -Bootloader null `
 -Lun null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

