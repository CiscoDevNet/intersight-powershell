# BootLocalDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.LocalDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.LocalDisk"]
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Slot** | **String** | The slot id of the local disk device. Supported values are (1-255, &quot;&quot;M&quot;&quot;, &quot;&quot;HBA&quot;&quot;, &quot;&quot;SAS&quot;&quot;, &quot;&quot;RAID&quot;&quot;, &quot;&quot;MRAID&quot;&quot;, &quot;&quot;MSTOR-RAID&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
$BootLocalDiskAllOf = Initialize-IntersightBootLocalDiskAllOf  -ClassId null `
 -ObjectType null `
 -Bootloader null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$BootLocalDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

