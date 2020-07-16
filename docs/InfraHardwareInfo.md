# InfraHardwareInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CpuCores** | **Int64** | The number of cpu cores on this hardware platform. | [optional] 
**CpuSpeed** | **Int64** | Speed of cpu in MHz. Usually cpu speeds are reported for modern cpus in GHz but MHz makes it more precise. | [optional] 
**MemorySize** | **Int64** | The amount of memory allocated (bytes) to this hardware platform. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInfraHardwareInfo  -ClassId null `
 -ObjectType null `
 -CpuCores null `
 -CpuSpeed null `
 -MemorySize null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

