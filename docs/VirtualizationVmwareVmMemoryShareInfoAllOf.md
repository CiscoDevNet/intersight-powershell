# VirtualizationVmwareVmMemoryShareInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVmMemoryShareInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVmMemoryShareInfo"]
**MemLimit** | **Int64** | Limit on the memory sharing imposed (in Mbytes). | [optional] 
**MemOverheadLimit** | **Int64** | Limit on memory overhead imposed (in Mbytes). | [optional] 
**MemReservation** | **Int64** | Similar to CPU reservations (Mbytes). | [optional] 
**MemShares** | **Int64** | Similar to CPU Shares but applicable to memory. There is no unit for this value. It is a relative measure based on the settings for other resource pools. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareVmMemoryShareInfoAllOf = Initialize-IntersightVirtualizationVmwareVmMemoryShareInfoAllOf  -ClassId null `
 -ObjectType null `
 -MemLimit null `
 -MemOverheadLimit null `
 -MemReservation null `
 -MemShares null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareVmMemoryShareInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

