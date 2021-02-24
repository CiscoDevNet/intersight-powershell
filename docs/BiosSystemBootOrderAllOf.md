# BiosSystemBootOrderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "bios.SystemBootOrder"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "bios.SystemBootOrder"]
**BootMode** | **String** | The BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. * &#x60;Legacy&#x60; - Legacy mode refers to the traditional process of booting from BIOS. Legacy mode uses the Master Boot Record (MBR) to locate the bootloader. * &#x60;Uefi&#x60; - UEFI mode uses the GUID Partition Table (GPT) to locate EFI Service Partitions to boot from. | [optional] [readonly] [default to "Legacy"]
**Dn** | **String** | The Distinguished Name for this object, used to uniquely identify this object. | [optional] [readonly] 
**SecureBoot** | **String** | Secure boot if set to enabled, enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM). * &#x60;NotAvailable&#x60; - Set the state of Secure Boot to Not Available. * &#x60;Disabled&#x60; - Set the state of Secure Boot to Disabled. * &#x60;Enabled&#x60; - Set the state of Secure Boot to Enabled. | [optional] [readonly] [default to "NotAvailable"]
**BiosUnit** | [**BiosUnitRelationship**](BiosUnitRelationship.md) |  | [optional] 
**BootDevices** | [**BiosBootDeviceRelationship[]**](BiosBootDeviceRelationship.md) | An array of relationships to biosBootDevice resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BiosSystemBootOrderAllOf = Initialize-IntersightBiosSystemBootOrderAllOf  -ClassId null `
 -ObjectType null `
 -BootMode null `
 -Dn null `
 -SecureBoot null `
 -BiosUnit null `
 -BootDevices null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$BiosSystemBootOrderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

