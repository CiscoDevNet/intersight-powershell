# BootUsbAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.Usb"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.Usb"]
**Subtype** | **String** | The subtype for the selected device type. * &#x60;None&#x60; - No sub type for USB boot device. * &#x60;usb-cd&#x60; - Use of Compact Disk (CD) as sub-type for the USB boot device. * &#x60;usb-fdd&#x60; - Use of Floppy Disk Drive (FDD) as sub-type for the USB boot device. * &#x60;usb-hdd&#x60; - Use of Hard Disk Drive (HDD) as sub-type for the USB boot device. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$BootUsbAllOf = Initialize-IntersightBootUsbAllOf  -ClassId null `
 -ObjectType null `
 -Subtype null
```

- Convert the resource to JSON
```powershell
$BootUsbAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

