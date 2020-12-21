# VirtualizationVmwareHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareHost"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareHost"]
**BootTime** | **System.DateTime** | The time when this host booted up. | [optional] 
**ConnectionState** | **String** | Indicates if the host is connected to the vCenter. Values are connected, not connected. | [optional] 
**HwPowerState** | **String** | Is the host Powered-up or Powered-down. * &#x60;Unknown&#x60; - The entity&#39;s power state is unknown. * &#x60;PoweredOn&#x60; - The entity is powered on. * &#x60;PoweredOff&#x60; - The entity is powered down. * &#x60;StandBy&#x60; - The entity is in standby mode. * &#x60;Paused&#x60; - The entity is in pause state. | [optional] [default to "Unknown"]
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
$VirtualizationVmwareHostAllOf = Initialize-IntersightVirtualizationVmwareHostAllOf  -ClassId null `
 -ObjectType null `
 -BootTime null `
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
$VirtualizationVmwareHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

