# BiosSystemBootOrderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootMode** | **String** | The BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. | [optional] [readonly] [default to "Legacy"]
**Dn** | **String** | The Distinguished Name for this object, used to uniquely identify this object. | [optional] [readonly] 
**SecureBoot** | **String** | Secure boot if set to enabled, enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM). | [optional] [readonly] [default to "Disabled"]
**BiosUnit** | [**BiosUnitRelationship**](BiosUnitRelationship.md) |  | [optional] 
**BootDevices** | [**BiosBootDeviceRelationship[]**](BiosBootDeviceRelationship.md) | An array of relationships to biosBootDevice resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBiosSystemBootOrderAllOf  -BootMode null `
 -Dn null `
 -SecureBoot null `
 -BiosUnit null `
 -BootDevices null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

