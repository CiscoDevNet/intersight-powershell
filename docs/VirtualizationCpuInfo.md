# VirtualizationCpuInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Cores** | **Int64** | Number of cores per CPU, as reported by the manufacturer. | [optional] 
**Description** | **String** | The vendor provided description of the CPU. For example, Intel Xeon E5-2640 v3 @ 2.60GHz. | [optional] 
**Sockets** | **Int64** | Number of CPU sockets available. | [optional] 
**Speed** | **Int64** | Speed of the CPUs in Hertz. For example, 2593749663. | [optional] 
**Vendor** | **String** | Manufacturer of the CPU . For example, Intel. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationCpuInfo  -ClassId null `
 -ObjectType null `
 -Cores null `
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

