# BootPchStorage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.PchStorage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.PchStorage"]
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] [default to $false]
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. It is the Virtual Drive number for Cisco UCS C-Series Servers. Virtual Drive number is found in storage inventory. | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$BootPchStorage = Initialize-IntersightBootPchStorage  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -Bootloader null `
 -Lun null
```

- Convert the resource to JSON
```powershell
$BootPchStorage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

