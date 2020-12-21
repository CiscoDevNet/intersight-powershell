# ComputePhysicalSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.PhysicalSummary"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.PhysicalSummary"]
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
**AdminPowerState** | **String** | The desired power state of the server. | [optional] [readonly] 
**AlarmSummary** | [**ComputeAlarmSummary**](ComputeAlarmSummary.md) |  | [optional] 
**AssetTag** | **String** | The user defined asset tag assigned to the server. | [optional] [readonly] 
**AvailableMemory** | **Int64** | The amount of memory available on the server. | [optional] [readonly] 
**BiosPostComplete** | **Boolean** | The BIOS POST completion status of the server. | [optional] [readonly] 
**ChassisId** | **String** | The id of the chassis that the blade is located in. | [optional] [readonly] 
**ConnectionStatus** | **String** | Connectivity Status of RackUnit to Switch - A or B or AB. | [optional] [readonly] 
**CpuCapacity** | **Double** | CPU Capacity &#x3D; Number of CPU Sockets x Enabled Cores x Speed (GHz). | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**FaultSummary** | **Int64** | The fault summary for the server. | [optional] [readonly] 
**Firmware** | **String** | The firmware version of the Cisco Integrated Management Controller (CIMC) for this server. | [optional] [readonly] 
**Ipv4Address** | **String** | The IPv4 address configured on the management interface of the Integrated Management Controller. | [optional] [readonly] 
**KvmIpAddresses** | [**ComputeIpAddress[]**](ComputeIpAddress.md) |  | [optional] 
**ManagementMode** | **String** | The management mode of the server. * &#x60;IntersightStandalone&#x60; - Intersight Standalone mode of operation. * &#x60;UCSM&#x60; - Unified Computing System Manager mode of operation. * &#x60;Intersight&#x60; - Intersight managed mode of operation. | [optional] [readonly] [default to "IntersightStandalone"]
**MemorySpeed** | **String** | The maximum memory speed in MHz available on the server. | [optional] [readonly] 
**MgmtIpAddress** | **String** | Management address of the server. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Name** | **String** | The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. | [optional] [readonly] 
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
**PlatformType** | **String** | The platform type of the registered device - whether managed by UCSM or operating in standalone mode. | [optional] [readonly] 
**Presence** | **String** | Indicates if a server is present in a slot and is applicable for blade servers. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**ScaledMode** | **String** | The mode of the server that determines it is scaled. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**ServerId** | **Int64** | RackUnit ID that uniquely identifies the server. | [optional] [readonly] 
**ServiceProfile** | **String** | The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM. | [optional] [readonly] 
**SlotId** | **Int64** | The slot number in the chassis that the blade is located in. | [optional] [readonly] 
**SourceObjectType** | **String** | The source object type of this view MO. | [optional] [readonly] 
**TopologyScanStatus** | **String** | To maintain the Topology workflow run status. | [optional] [readonly] 
**TotalMemory** | **Int64** | The total memory available on the server. | [optional] [readonly] 
**UserLabel** | **String** | The user defined label assigned to the server. | [optional] [readonly] 
**Uuid** | **String** | The universally unique identity of the server. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputePhysicalSummary = Initialize-IntersightComputePhysicalSummary  -ClassId null `
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
 -AdminPowerState null `
 -AlarmSummary null `
 -AssetTag null `
 -AvailableMemory null `
 -BiosPostComplete null `
 -ChassisId null `
 -ConnectionStatus null `
 -CpuCapacity null `
 -DeviceMoId null `
 -Dn null `
 -FaultSummary null `
 -Firmware null `
 -Ipv4Address null `
 -KvmIpAddresses null `
 -ManagementMode null `
 -MemorySpeed null `
 -MgmtIpAddress null `
 -Model null `
 -Name null `
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
 -Revision null `
 -Rn null `
 -ScaledMode null `
 -Serial null `
 -ServerId null `
 -ServiceProfile null `
 -SlotId null `
 -SourceObjectType null `
 -TopologyScanStatus null `
 -TotalMemory null `
 -UserLabel null `
 -Uuid null `
 -Vendor null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ComputePhysicalSummary | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

