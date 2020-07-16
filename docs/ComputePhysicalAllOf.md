# ComputePhysicalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminPowerState** | **String** | The desired power state of the server. | [optional] [readonly] 
**AssetTag** | **String** | The user defined asset tag assigned to the server. | [optional] [readonly] 
**AvailableMemory** | **Int64** | The amount of memory available on the server. | [optional] [readonly] 
**BiosPostComplete** | **Boolean** | The BIOS POST completion status of the server. | [optional] 
**FaultSummary** | **Int64** | The fault summary for the server. | [optional] 
**KvmIpAddresses** | [**ComputeIpAddress[]**](ComputeIpAddress.md) |  | [optional] 
**ManagementMode** | **String** | The management mode of the server. | [optional] [default to "IntersightStandalone"]
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
**MgmtIdentity** | [**EquipmentPhysicalIdentityRelationship**](EquipmentPhysicalIdentityRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputePhysicalAllOf  -AdminPowerState null `
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
 -MgmtIdentity null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

