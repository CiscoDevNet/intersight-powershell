# BootBootloader
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.Bootloader"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.Bootloader"]
**Description** | **String** | Carries more information about the bootloader. | [optional] 
**Name** | **String** | Name of the bootloader image. | [optional] 
**Path** | **String** | Path to the bootloader image. | [optional] 

## Examples

- Prepare the resource
```powershell
$BootBootloader = Initialize-IntersightBootBootloader  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -Path null
```

- Convert the resource to JSON
```powershell
$BootBootloader | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

