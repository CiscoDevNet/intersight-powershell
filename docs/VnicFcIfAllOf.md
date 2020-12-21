# VnicFcIfAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.FcIf"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.FcIf"]
**Name** | **String** | Name of the virtual fibre channel interface. | [optional] 
**Order** | **Int64** | The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**PersistentBindings** | **Boolean** | Enables retention of LUN ID associations in memory until they are manually cleared. | [optional] 
**Placement** | [**VnicPlacementSettings**](VnicPlacementSettings.md) |  | [optional] 
**Type** | **String** | VHBA Type configuration for SAN Connectivity Policy. This configuration is supported only on Cisco VIC 14XX series and higher series of adapters. * &#x60;fc-initiator&#x60; - The default value set for vHBA Type Configuration. Fc-initiator specifies vHBA as a consumer of storage. Enables SCSI commands to transfer data and status information between host and target storage systems. * &#x60;fc-nvme-initiator&#x60; - Fc-nvme-initiator specifies vHBA as a consumer of storage. Enables NVMe-based message commands to transfer data and status information between host and target storage systems. * &#x60;fc-nvme-target&#x60; - Fc-nvme-target specifies vHBA as a provider of storage volumes to initiators. Enables NVMe-based message commands to transfer data and status information between host and target storage systems. Currently tech-preview, only enabled with an asynchronous driver. * &#x60;fc-target&#x60; - Fc-target specifies vHBA as a provider of storage volumes to initiators. Enables SCSI commands to transfer data and status information between host and target storage systems. fc-target is enabled only with an asynchronous driver. | [optional] [default to "fc-initiator"]
**VifId** | **Int64** | This should be the same as the channel number of the vfc created on switch in order to set up the data path. The property is applicable only for FI attached servers where a vfc is created on the switch for every vHBA. | [optional] [readonly] 
**Wwpn** | **String** | The WWPN address that is assigned to the vHBA based on the wwn pool that has been assigned to the SAN Connectivity Policy. | [optional] [readonly] 
**FcAdapterPolicy** | [**VnicFcAdapterPolicyRelationship**](VnicFcAdapterPolicyRelationship.md) |  | [optional] 
**FcNetworkPolicy** | [**VnicFcNetworkPolicyRelationship**](VnicFcNetworkPolicyRelationship.md) |  | [optional] 
**FcQosPolicy** | [**VnicFcQosPolicyRelationship**](VnicFcQosPolicyRelationship.md) |  | [optional] 
**VarProfile** | [**PolicyAbstractConfigProfileRelationship**](PolicyAbstractConfigProfileRelationship.md) |  | [optional] 
**SanConnectivityPolicy** | [**VnicSanConnectivityPolicyRelationship**](VnicSanConnectivityPolicyRelationship.md) |  | [optional] 
**ScpVhba** | [**VnicFcIfRelationship**](VnicFcIfRelationship.md) |  | [optional] 
**SpVhbas** | [**VnicFcIfRelationship[]**](VnicFcIfRelationship.md) | An array of relationships to vnicFcIf resources. | [optional] 
**WwpnLease** | [**FcpoolLeaseRelationship**](FcpoolLeaseRelationship.md) |  | [optional] 
**WwpnPool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicFcIfAllOf = Initialize-IntersightVnicFcIfAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Order null `
 -PersistentBindings null `
 -Placement null `
 -Type null `
 -VifId null `
 -Wwpn null `
 -FcAdapterPolicy null `
 -FcNetworkPolicy null `
 -FcQosPolicy null `
 -VarProfile null `
 -SanConnectivityPolicy null `
 -ScpVhba null `
 -SpVhbas null `
 -WwpnLease null `
 -WwpnPool null
```

- Convert the resource to JSON
```powershell
$VnicFcIfAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

