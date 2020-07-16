# VirtualizationVmwareDatastoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessible** | **Boolean** | Shows if this datastore is accessible. | [optional] 
**MaintenanceMode** | **Boolean** | Indicates if the datastore is in maintenance mode. Will be set to True, when in maintenance mode. | [optional] 
**MultipleHostAccess** | **Boolean** | Indicates if this datastore is connected to multiple hosts. | [optional] 
**Status** | **String** | Datastore health status, as reported by the hypervisor platform. | [optional] [default to "Unknown"]
**ThinProvisioningSupported** | **Boolean** | Indicates if this datastore supports thin provisioning for files. | [optional] 
**UnCommitted** | **Int64** | Space uncommitted in this datastore in bytes. | [optional] 
**Url** | **String** | The URL to access this datastore (example - &#39;ds:///vmfs/volumes/562a4e8a-0eeb5372-dd61-78baf9cb9afa/&#39;). | [optional] 
**Cluster** | [**VirtualizationVmwareClusterRelationship**](VirtualizationVmwareClusterRelationship.md) |  | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 
**Hosts** | [**VirtualizationVmwareHostRelationship[]**](VirtualizationVmwareHostRelationship.md) | An array of relationships to virtualizationVmwareHost resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareDatastoreAllOf  -Accessible null `
 -MaintenanceMode null `
 -MultipleHostAccess null `
 -Status null `
 -ThinProvisioningSupported null `
 -UnCommitted null `
 -Url null `
 -Cluster null `
 -Datacenter null `
 -Hosts null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

