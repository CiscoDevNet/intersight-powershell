# ComputePhysicalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
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
**OperReason** | **String[]** |  | [optional] 
**OperState** | **String** | The operational state of the server. | [optional] [readonly] 
**Operability** | **String** | The operability of the server. | [optional] [readonly] 
**PlatformType** | **String** | The platform type of the registered device - whether managed by UCSM or operating in standalone mode. | [optional] 
**Presence** | **String** | Indicates if a server is present in a slot and is applicable for blade servers. | [optional] [readonly] 
**ServiceProfile** | **String** | The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM. | [optional] [readonly] 
**TotalMemory** | **Int64** | The total memory available on the server. | [optional] [readonly] 
**UserLabel** | **String** | The user defined label assigned to the server. | [optional] [readonly] 
**Uuid** | **String** | The universally unique identity of the server. | [optional] [readonly] 
**BootCddDevices** | [**BootCddDeviceRelationship[]**](BootCddDeviceRelationship.md) | An array of relationships to bootCddDevice resources. | [optional] 
**BootDeviceBootSecurity** | [**BootDeviceBootSecurityRelationship**](BootDeviceBootSecurityRelationship.md) |  | [optional] 
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
**Vmedia** | [**ComputeVmediaRelationship**](ComputeVmediaRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputePhysicalAllOf = Initialize-IntersightComputePhysicalAllOf  -ClassId null `
 -ObjectType null `
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
 -OperReason null `
 -OperState null `
 -Operability null `
 -PlatformType null `
 -Presence null `
 -ServiceProfile null `
 -TotalMemory null `
 -UserLabel null `
 -Uuid null `
 -BootCddDevices null `
 -BootDeviceBootSecurity null `
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
 -MgmtIdentity null `
 -Vmedia null
```

- Convert the resource to JSON
```powershell
$ComputePhysicalAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

