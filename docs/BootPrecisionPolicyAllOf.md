# BootPrecisionPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootDevices** | [**BootDeviceBase[]**](BootDeviceBase.md) |  | [optional] 
**ConfiguredBootMode** | **String** | Sets the BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. | [optional] [default to "Legacy"]
**EnforceUefiSecureBoot** | **Boolean** | If UEFI secure boot is enabled, the boot mode is set to UEFI by default. Secure boot enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM). | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootPrecisionPolicyAllOf  -BootDevices null `
 -ConfiguredBootMode null `
 -EnforceUefiSecureBoot null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

