# VirtualizationVmwareVmCpuShareInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CpuLimit** | **Int64** | Upper limit on CPU allocation (MHz). | [optional] 
**CpuOverheadLimit** | **Int64** | Amount of CPU for virtualization overhead. | [optional] 
**CpuReservation** | **Int64** | Guaranteed minimum allocation of CPU resource (MHz). | [optional] 
**CpuShares** | **Int64** | Shows the relative importance of a VM. There is no unit for this value. It is a relative measure based on the settings for other resource pools. For more information, see VMware documentation. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmCpuShareInfo  -ClassId null `
 -ObjectType null `
 -CpuLimit null `
 -CpuOverheadLimit null `
 -CpuReservation null `
 -CpuShares null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

