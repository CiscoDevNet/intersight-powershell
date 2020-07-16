# VirtualizationVmwareHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootTime** | **System.DateTime** | The time when this host booted up. | [optional] 
**ConnectionState** | **String** | Indicates if the host is connected to the vCenter. Values are connected, not connected. | [optional] 
**HwPowerState** | **String** | Is the host Powered-up or Powered-down. | [optional] [default to "Unknown"]
**NetworkAdapterCount** | **Int64** | The count of all network adapters attached to this host. | [optional] 
**ResourceConsumed** | [**VirtualizationVmwareResourceConsumption**](VirtualizationVmwareResourceConsumption.md) |  | [optional] 
**StorageAdapterCount** | **Int64** | The count of all storage adapters attached to this host. | [optional] 
**VcenterHostId** | **String** | The identity of this host within vCenter (optional). | [optional] 
**Cluster** | [**VirtualizationVmwareClusterRelationship**](VirtualizationVmwareClusterRelationship.md) |  | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 
**Datastores** | [**VirtualizationVmwareDatastoreRelationship[]**](VirtualizationVmwareDatastoreRelationship.md) | An array of relationships to virtualizationVmwareDatastore resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareHostAllOf  -BootTime null `
 -ConnectionState null `
 -HwPowerState null `
 -NetworkAdapterCount null `
 -ResourceConsumed null `
 -StorageAdapterCount null `
 -VcenterHostId null `
 -Cluster null `
 -Datacenter null `
 -Datastores null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

