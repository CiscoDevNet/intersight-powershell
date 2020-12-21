# AssetWorkloadOptimizerVmwareVcenterOptionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.WorkloadOptimizerVmwareVcenterOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.WorkloadOptimizerVmwareVcenterOptions"]
**DatastoreBrowsingEnabled** | **Boolean** | DatastoreBrowsingEnabled controls whether Workload Optimizer scans vCenter datastores to identify files which are not used and can be deleted to reclaim space and improve actual disk utilization. For example orphaned VMDK files. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetWorkloadOptimizerVmwareVcenterOptionsAllOf = Initialize-IntersightAssetWorkloadOptimizerVmwareVcenterOptionsAllOf  -ClassId null `
 -ObjectType null `
 -DatastoreBrowsingEnabled null
```

- Convert the resource to JSON
```powershell
$AssetWorkloadOptimizerVmwareVcenterOptionsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

