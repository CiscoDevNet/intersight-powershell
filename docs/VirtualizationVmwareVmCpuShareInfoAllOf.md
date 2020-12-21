# VirtualizationVmwareVmCpuShareInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVmCpuShareInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVmCpuShareInfo"]
**CpuLimit** | **Int64** | Upper limit on CPU allocation (MHz). | [optional] 
**CpuOverheadLimit** | **Int64** | Amount of CPU for virtualization overhead. | [optional] 
**CpuReservation** | **Int64** | Guaranteed minimum allocation of CPU resource (MHz). | [optional] 
**CpuShares** | **Int64** | Shows the relative importance of a VM. There is no unit for this value. It is a relative measure based on the settings for other resource pools. For more information, see VMware documentation. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareVmCpuShareInfoAllOf = Initialize-IntersightVirtualizationVmwareVmCpuShareInfoAllOf  -ClassId null `
 -ObjectType null `
 -CpuLimit null `
 -CpuOverheadLimit null `
 -CpuReservation null `
 -CpuShares null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareVmCpuShareInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

