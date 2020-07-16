# VirtualizationVmwareVmCpuShareInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuLimit** | **Int64** | Upper limit on CPU allocation (MHz). | [optional] 
**CpuOverheadLimit** | **Int64** | Amount of CPU for virtualization overhead. | [optional] 
**CpuReservation** | **Int64** | Guaranteed minimum allocation of CPU resource (MHz). | [optional] 
**CpuShares** | **Int64** | Shows the relative importance of a VM. There is no unit for this value. It is a relative measure based on the settings for other resource pools. For more information, see VMware documentation. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmCpuShareInfoAllOf  -CpuLimit null `
 -CpuOverheadLimit null `
 -CpuReservation null `
 -CpuShares null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

