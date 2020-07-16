# VirtualizationVmwareVmMemoryShareInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemLimit** | **Int64** | Limit on the memory sharing imposed (in Mbytes). | [optional] 
**MemOverheadLimit** | **Int64** | Limit on memory overhead imposed (in Mbytes). | [optional] 
**MemReservation** | **Int64** | Similar to CPU reservations (Mbytes). | [optional] 
**MemShares** | **Int64** | Similar to CPU Shares but applicable to memory. There is no unit for this value. It is a relative measure based on the settings for other resource pools. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmMemoryShareInfoAllOf  -MemLimit null `
 -MemOverheadLimit null `
 -MemReservation null `
 -MemShares null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

