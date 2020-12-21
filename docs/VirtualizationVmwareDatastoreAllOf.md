# VirtualizationVmwareDatastoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareDatastore"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareDatastore"]
**Accessible** | **Boolean** | Shows if this datastore is accessible. | [optional] 
**MaintenanceMode** | **Boolean** | Indicates if the datastore is in maintenance mode. Will be set to True, when in maintenance mode. | [optional] 
**MultipleHostAccess** | **Boolean** | Indicates if this datastore is connected to multiple hosts. | [optional] 
**Status** | **String** | Datastore health status, as reported by the hypervisor platform. * &#x60;Unknown&#x60; - Entity status is unknown. * &#x60;Degraded&#x60; - State is degraded, and might impact normal operation of the entity. * &#x60;Critical&#x60; - Entity is in a critical state, impacting operations. * &#x60;Ok&#x60; - Entity status is in a stable state, operating normally. | [optional] [default to "Unknown"]
**ThinProvisioningSupported** | **Boolean** | Indicates if this datastore supports thin provisioning for files. | [optional] 
**UnCommitted** | **Int64** | Space uncommitted in this datastore in bytes. | [optional] 
**Url** | **String** | The URL to access this datastore (example - &#39;ds:///vmfs/volumes/562a4e8a-0eeb5372-dd61-78baf9cb9afa/&#39;). | [optional] 
**Cluster** | [**VirtualizationVmwareClusterRelationship**](VirtualizationVmwareClusterRelationship.md) |  | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 
**Hosts** | [**VirtualizationVmwareHostRelationship[]**](VirtualizationVmwareHostRelationship.md) | An array of relationships to virtualizationVmwareHost resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareDatastoreAllOf = Initialize-IntersightVirtualizationVmwareDatastoreAllOf  -ClassId null `
 -ObjectType null `
 -Accessible null `
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
$VirtualizationVmwareDatastoreAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

