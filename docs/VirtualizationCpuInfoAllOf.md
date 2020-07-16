# VirtualizationCpuInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cores** | **Int64** | Number of cores per CPU, as reported by the manufacturer. | [optional] 
**Description** | **String** | The vendor provided description of the CPU. For example, Intel Xeon E5-2640 v3 @ 2.60GHz. | [optional] 
**Sockets** | **Int64** | Number of CPU sockets available. | [optional] 
**Speed** | **Int64** | Speed of the CPUs in Hertz. For example, 2593749663. | [optional] 
**Vendor** | **String** | Manufacturer of the CPU . For example, Intel. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationCpuInfoAllOf  -Cores null `
 -Description null `
 -Sockets null `
 -Speed null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

