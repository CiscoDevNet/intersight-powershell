# BootNvmeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.Nvme"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.Nvme"]
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BootNvmeAllOf = Initialize-IntersightBootNvmeAllOf  -ClassId null `
 -ObjectType null `
 -Bootloader null
```

- Convert the resource to JSON
```powershell
$BootNvmeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

