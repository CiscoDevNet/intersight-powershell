# VirtualizationCpuInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.CpuInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.CpuInfo"]
**Cores** | **Int64** | Number of cores per CPU, as reported by the manufacturer. | [optional] 
**Description** | **String** | The vendor provided description of the CPU. For example, Intel Xeon E5-2640 v3 @ 2.60GHz. | [optional] 
**Sockets** | **Int64** | Number of CPU sockets available. | [optional] 
**Speed** | **Int64** | Speed of the CPUs in Hertz. For example, 2593749663. | [optional] 
**Vendor** | **String** | Manufacturer of the CPU . For example, Intel. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationCpuInfo = Initialize-IntersightVirtualizationCpuInfo  -ClassId null `
 -ObjectType null `
 -Cores null `
 -Description null `
 -Sockets null `
 -Speed null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$VirtualizationCpuInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

