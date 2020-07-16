# VnicRoceSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassOfService** | **Int32** | The Class of Service for RoCE on this virtual interface. | [optional] [default to 5]
**Enabled** | **Boolean** | If enabled sets RDMA over Converged Ethernet (RoCE) on this virtual interface. | [optional] 
**MemoryRegions** | **Int64** | The number of memory regions per adapter. Recommended value &#x3D; integer power of 2. | [optional] 
**QueuePairs** | **Int64** | The number of queue pairs per adapter. Recommended value &#x3D; integer power of 2. | [optional] 
**ResourceGroups** | **Int64** | The number of resource groups per adapter. Recommended value &#x3D; be an integer power of 2 greater than or equal to the number of CPU cores on the system for optimum performance. | [optional] 
**Version** | **Int32** | Configures RDMA over Converged Ethernet (RoCE) version on the virtual interface. Only RoceV1 is supported onn Cisco VIC models 13xx and only RoceV2 is supported on models 14xx. | [optional] [default to 1]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicRoceSettingsAllOf  -ClassOfService null `
 -Enabled null `
 -MemoryRegions null `
 -QueuePairs null `
 -ResourceGroups null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

