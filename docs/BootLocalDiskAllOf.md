# BootLocalDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Slot** | **String** | The slot id of the local disk device. Supported values are (1-255, &quot;&quot;M&quot;&quot;, &quot;&quot;HBA&quot;&quot;, &quot;&quot;SAS&quot;&quot;, &quot;&quot;RAID&quot;&quot;, &quot;&quot;MRAID&quot;&quot;, &quot;&quot;MSTOR-RAID&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootLocalDiskAllOf  -Bootloader null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

