# BiosSystemBootOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "bios.SystemBootOrder"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "bios.SystemBootOrder"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**BootMode** | **String** | The BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. * &#x60;Legacy&#x60; - Legacy mode refers to the traditional process of booting from BIOS. Legacy mode uses the Master Boot Record (MBR) to locate the bootloader. * &#x60;Uefi&#x60; - UEFI mode uses the GUID Partition Table (GPT) to locate EFI Service Partitions to boot from. | [optional] [readonly] [default to "Legacy"]
**Dn** | **String** | The Distinguished Name for this object, used to uniquely identify this object. | [optional] [readonly] 
**SecureBoot** | **String** | Secure boot if set to enabled, enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM). * &#x60;Disabled&#x60; - Set the state of Secure Boot to Disabled. * &#x60;Enabled&#x60; - Set the state of Secure Boot to Enabled. | [optional] [readonly] [default to "Disabled"]
**BiosUnit** | [**BiosUnitRelationship**](BiosUnitRelationship.md) |  | [optional] 
**BootDevices** | [**BiosBootDeviceRelationship[]**](BiosBootDeviceRelationship.md) | An array of relationships to biosBootDevice resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BiosSystemBootOrder = Initialize-IntersightBiosSystemBootOrder  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -BootMode null `
 -Dn null `
 -SecureBoot null `
 -BiosUnit null `
 -BootDevices null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$BiosSystemBootOrder | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

