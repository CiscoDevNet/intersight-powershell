# VirtualizationVmwareClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreCount** | **Int64** | Count of all datastores associated with this cluster. | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareClusterAllOf  -DatastoreCount null `
 -Datacenter null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

