# BootIscsi
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.Iscsi"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.Iscsi"]
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] [default to $false]
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**InterfaceName** | **String** | The name of the underlying virtual ethernet interface used by the iSCSI boot device. | [optional] 
**Port** | **Int64** | Port ID of the ISCSI boot device. | [optional] [default to 0]
**Slot** | **String** | The slot id of the device. Supported values are (1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot;, &quot;&quot;OCP&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
$BootIscsi = Initialize-IntersightBootIscsi  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -Bootloader null `
 -InterfaceName null `
 -Port null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$BootIscsi | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

