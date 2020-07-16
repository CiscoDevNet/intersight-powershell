# AssetWorkloadOptimizerVmwareVcenterOptionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreBrowsingEnabled** | **Boolean** | DatastoreBrowsingEnabled controls whether Workload Optimizer scans vCenter datastores to identify files which are not used and can be deleted to reclaim space and improve actual disk utilization. For example orphaned VMDK files. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetWorkloadOptimizerVmwareVcenterOptionsAllOf  -DatastoreBrowsingEnabled null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

