# ComputePhysical
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**AdminPowerState** | **String** | The desired power state of the server. | [optional] [readonly] 
**AlarmSummary** | [**ComputeAlarmSummary**](ComputeAlarmSummary.md) |  | [optional] 
**AssetTag** | **String** | The user defined asset tag assigned to the server. | [optional] [readonly] 
**AvailableMemory** | **Int64** | The amount of memory available on the server. | [optional] [readonly] 
**BiosPostComplete** | **Boolean** | The BIOS POST completion status of the server. | [optional] 
**FaultSummary** | **Int64** | The fault summary for the server. | [optional] 
**KvmIpAddresses** | [**ComputeIpAddress[]**](ComputeIpAddress.md) |  | [optional] 
**ManagementMode** | **String** | The management mode of the server. * &#x60;IntersightStandalone&#x60; - Intersight Standalone mode of operation. * &#x60;UCSM&#x60; - Unified Computing System Manager mode of operation. * &#x60;Intersight&#x60; - Intersight managed mode of operation. | [optional] [default to "IntersightStandalone"]
**MemorySpeed** | **String** | The maximum memory speed in MHz available on the server. | [optional] [readonly] 
**MgmtIpAddress** | **String** | Management address of the server. | [optional] 
**NumAdaptors** | **Int64** | The total number of network adapters present on the server. | [optional] [readonly] 
**NumCpuCores** | **Int64** | The total number of CPU cores present on the server. | [optional] [readonly] 
**NumCpuCoresEnabled** | **Int64** | The total number of CPU cores enabled on the server. | [optional] [readonly] 
**NumCpus** | **Int64** | The total number of CPUs present on the server. | [optional] [readonly] 
**NumEthHostInterfaces** | **Int64** | The total number of vNICs which are visible to a host on the server. | [optional] [readonly] 
**NumFcHostInterfaces** | **Int64** | The total number of vHBAs which are visible to a host on the server. | [optional] [readonly] 
**NumThreads** | **Int64** | The total number of threads the server is capable of handling. | [optional] [readonly] 
**OperPowerState** | **String** | The actual power state of the server. | [optional] [readonly] 
**OperState** | **String** | The operational state of the server. | [optional] [readonly] 
**Operability** | **String** | The operability of the server. | [optional] [readonly] 
**PlatformType** | **String** | The platform type of the registered device - whether managed by UCSM or operating in standalone mode. | [optional] 
**Presence** | **String** | Indicates if a server is present in a slot and is applicable for blade servers. | [optional] [readonly] 
**ServiceProfile** | **String** | The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM. | [optional] [readonly] 
**TotalMemory** | **Int64** | The total memory available on the server. | [optional] [readonly] 
**UserLabel** | **String** | The user defined label assigned to the server. | [optional] [readonly] 
**Uuid** | **String** | The universally unique identity of the server. | [optional] [readonly] 
**BootCddDevices** | [**BootCddDeviceRelationship[]**](BootCddDeviceRelationship.md) | An array of relationships to bootCddDevice resources. | [optional] 
**BootHddDevices** | [**BootHddDeviceRelationship[]**](BootHddDeviceRelationship.md) | An array of relationships to bootHddDevice resources. | [optional] 
**BootIscsiDevices** | [**BootIscsiDeviceRelationship[]**](BootIscsiDeviceRelationship.md) | An array of relationships to bootIscsiDevice resources. | [optional] 
**BootNvmeDevices** | [**BootNvmeDeviceRelationship[]**](BootNvmeDeviceRelationship.md) | An array of relationships to bootNvmeDevice resources. | [optional] 
**BootPchStorageDevices** | [**BootPchStorageDeviceRelationship[]**](BootPchStorageDeviceRelationship.md) | An array of relationships to bootPchStorageDevice resources. | [optional] 
**BootPxeDevices** | [**BootPxeDeviceRelationship[]**](BootPxeDeviceRelationship.md) | An array of relationships to bootPxeDevice resources. | [optional] 
**BootSanDevices** | [**BootSanDeviceRelationship[]**](BootSanDeviceRelationship.md) | An array of relationships to bootSanDevice resources. | [optional] 
**BootSdDevices** | [**BootSdDeviceRelationship[]**](BootSdDeviceRelationship.md) | An array of relationships to bootSdDevice resources. | [optional] 
**BootUefiShellDevices** | [**BootUefiShellDeviceRelationship[]**](BootUefiShellDeviceRelationship.md) | An array of relationships to bootUefiShellDevice resources. | [optional] 
**BootUsbDevices** | [**BootUsbDeviceRelationship[]**](BootUsbDeviceRelationship.md) | An array of relationships to bootUsbDevice resources. | [optional] 
**BootVmediaDevices** | [**BootVmediaDeviceRelationship[]**](BootVmediaDeviceRelationship.md) | An array of relationships to bootVmediaDevice resources. | [optional] 
**MgmtIdentity** | [**EquipmentPhysicalIdentityRelationship**](EquipmentPhysicalIdentityRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputePhysical = Initialize-IntersightComputePhysical  -ClassId null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -AdminPowerState null `
 -AlarmSummary null `
 -AssetTag null `
 -AvailableMemory null `
 -BiosPostComplete null `
 -FaultSummary null `
 -KvmIpAddresses null `
 -ManagementMode null `
 -MemorySpeed null `
 -MgmtIpAddress null `
 -NumAdaptors null `
 -NumCpuCores null `
 -NumCpuCoresEnabled null `
 -NumCpus null `
 -NumEthHostInterfaces null `
 -NumFcHostInterfaces null `
 -NumThreads null `
 -OperPowerState null `
 -OperState null `
 -Operability null `
 -PlatformType null `
 -Presence null `
 -ServiceProfile null `
 -TotalMemory null `
 -UserLabel null `
 -Uuid null `
 -BootCddDevices null `
 -BootHddDevices null `
 -BootIscsiDevices null `
 -BootNvmeDevices null `
 -BootPchStorageDevices null `
 -BootPxeDevices null `
 -BootSanDevices null `
 -BootSdDevices null `
 -BootUefiShellDevices null `
 -BootUsbDevices null `
 -BootVmediaDevices null `
 -MgmtIdentity null
```

- Convert the resource to JSON
```powershell
$ComputePhysical | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

