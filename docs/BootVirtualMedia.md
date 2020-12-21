# BootVirtualMedia
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.VirtualMedia"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.VirtualMedia"]
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] [default to $false]
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**Subtype** | **String** | The subtype for the selected device type. * &#x60;None&#x60; - No sub type for virtual media. * &#x60;cimc-mapped-dvd&#x60; - The virtual media device is mapped to a virtual DVD device. * &#x60;cimc-mapped-hdd&#x60; - The virtual media device is mapped to a virtual HDD device. * &#x60;kvm-mapped-dvd&#x60; - A KVM mapped DVD virtual media device. * &#x60;kvm-mapped-hdd&#x60; - A KVM mapped HDD virtual media device. * &#x60;kvm-mapped-fdd&#x60; - A KVM mapped FDD virtual media device. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$BootVirtualMedia = Initialize-IntersightBootVirtualMedia  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -Subtype null
```

- Convert the resource to JSON
```powershell
$BootVirtualMedia | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

