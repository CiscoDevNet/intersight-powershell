# VnicEthIfAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthIf"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthIf"]
**Cdn** | [**VnicCdn**](VnicCdn.md) |  | [optional] 
**FailoverEnabled** | **Boolean** | Setting this to true esnures that the traffic failsover from one uplink to another auotmatically in case of an uplink failure. It is applicable for Cisco VIC adapters only which are connected to Fabric Interconnect cluster. The uplink if specified determines the primary uplink in case of a failover. | [optional] [default to $false]
**MacAddress** | **String** | The MAC address that is assigned to the vNIC based on the MAC pool that has been assigned to the LAN Connectivity Policy. | [optional] [readonly] 
**Name** | **String** | Name of the virtual ethernet interface. | [optional] 
**Order** | **Int64** | The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**Placement** | [**VnicPlacementSettings**](VnicPlacementSettings.md) |  | [optional] 
**StandbyVifId** | **Int64** | The Standby VIF Id is applicable for failover enabled vNICS. It should be the same as the channel number of the standby vethernet created on switch in order to set up the standby data path. | [optional] [readonly] 
**UsnicSettings** | [**VnicUsnicSettings**](VnicUsnicSettings.md) |  | [optional] 
**VifId** | **Int64** | The Vif Id should be same as the channel number of the vethernet created on switch in order to set up the data path. The property is applicable only for FI attached servers where a vethernet is created on the switch for every vNIC. | [optional] [readonly] 
**VmqSettings** | [**VnicVmqSettings**](VnicVmqSettings.md) |  | [optional] 
**EthAdapterPolicy** | [**VnicEthAdapterPolicyRelationship**](VnicEthAdapterPolicyRelationship.md) |  | [optional] 
**EthNetworkPolicy** | [**VnicEthNetworkPolicyRelationship**](VnicEthNetworkPolicyRelationship.md) |  | [optional] 
**EthQosPolicy** | [**VnicEthQosPolicyRelationship**](VnicEthQosPolicyRelationship.md) |  | [optional] 
**FabricEthNetworkControlPolicy** | [**FabricEthNetworkControlPolicyRelationship**](FabricEthNetworkControlPolicyRelationship.md) |  | [optional] 
**FabricEthNetworkGroupPolicy** | [**FabricEthNetworkGroupPolicyRelationship[]**](FabricEthNetworkGroupPolicyRelationship.md) | An array of relationships to fabricEthNetworkGroupPolicy resources. | [optional] 
**LanConnectivityPolicy** | [**VnicLanConnectivityPolicyRelationship**](VnicLanConnectivityPolicyRelationship.md) |  | [optional] 
**LcpVnic** | [**VnicEthIfRelationship**](VnicEthIfRelationship.md) |  | [optional] 
**MacLease** | [**MacpoolLeaseRelationship**](MacpoolLeaseRelationship.md) |  | [optional] 
**MacPool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 
**VarProfile** | [**PolicyAbstractConfigProfileRelationship**](PolicyAbstractConfigProfileRelationship.md) |  | [optional] 
**SpVnics** | [**VnicEthIfRelationship[]**](VnicEthIfRelationship.md) | An array of relationships to vnicEthIf resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicEthIfAllOf = Initialize-IntersightVnicEthIfAllOf  -ClassId null `
 -ObjectType null `
 -Cdn null `
 -FailoverEnabled null `
 -MacAddress null `
 -Name null `
 -Order null `
 -Placement null `
 -StandbyVifId null `
 -UsnicSettings null `
 -VifId null `
 -VmqSettings null `
 -EthAdapterPolicy null `
 -EthNetworkPolicy null `
 -EthQosPolicy null `
 -FabricEthNetworkControlPolicy null `
 -FabricEthNetworkGroupPolicy null `
 -LanConnectivityPolicy null `
 -LcpVnic null `
 -MacLease null `
 -MacPool null `
 -VarProfile null `
 -SpVnics null
```

- Convert the resource to JSON
```powershell
$VnicEthIfAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

