# VirtualizationVmwareVmMemoryShareInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**MemLimit** | **Int64** | Limit on the memory sharing imposed (in Mbytes). | [optional] 
**MemOverheadLimit** | **Int64** | Limit on memory overhead imposed (in Mbytes). | [optional] 
**MemReservation** | **Int64** | Similar to CPU reservations (Mbytes). | [optional] 
**MemShares** | **Int64** | Similar to CPU Shares but applicable to memory. There is no unit for this value. It is a relative measure based on the settings for other resource pools. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo  -ClassId null `
 -ObjectType null `
 -MemLimit null `
 -MemOverheadLimit null `
 -MemReservation null `
 -MemShares null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

