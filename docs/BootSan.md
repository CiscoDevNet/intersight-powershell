# BootSan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.San"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.San"]
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] [default to $false]
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**InterfaceName** | **String** | The name of the underlying vHBA interface to be used by the SAN boot device. | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. | [optional] [default to 0]
**Slot** | **String** | Slot ID of the device. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot; ). | [optional] 
**Wwpn** | **String** | The WWPN Address of the underlying fiber channel interface used by the SAN boot device. Value must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx. Allowed ranges are 20:00:00:00:00:00:00:00 to 20:FF:FF:FF:FF:FF:FF:FF or from 50:00:00:00:00:00:00:00 to 5F:FF:FF:FF:FF:FF:FF:FF. | [optional] 

## Examples

- Prepare the resource
```powershell
$BootSan = Initialize-IntersightBootSan  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -Bootloader null `
 -InterfaceName null `
 -Lun null `
 -Slot null `
 -Wwpn null
```

- Convert the resource to JSON
```powershell
$BootSan | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

