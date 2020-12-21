# BootVirtualMediaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.VirtualMedia"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.VirtualMedia"]
**Subtype** | **String** | The subtype for the selected device type. * &#x60;None&#x60; - No sub type for virtual media. * &#x60;cimc-mapped-dvd&#x60; - The virtual media device is mapped to a virtual DVD device. * &#x60;cimc-mapped-hdd&#x60; - The virtual media device is mapped to a virtual HDD device. * &#x60;kvm-mapped-dvd&#x60; - A KVM mapped DVD virtual media device. * &#x60;kvm-mapped-hdd&#x60; - A KVM mapped HDD virtual media device. * &#x60;kvm-mapped-fdd&#x60; - A KVM mapped FDD virtual media device. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$BootVirtualMediaAllOf = Initialize-IntersightBootVirtualMediaAllOf  -ClassId null `
 -ObjectType null `
 -Subtype null
```

- Convert the resource to JSON
```powershell
$BootVirtualMediaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

