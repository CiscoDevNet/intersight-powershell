# VnicEthIfAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthIf"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthIf"]
**Cdn** | [**VnicCdn**](VnicCdn.md) |  | [optional] 
**FailoverEnabled** | **Boolean** | Setting this to true esnures that the traffic failsover from one uplink to another auotmatically in case of an uplink failure. It is applicable for Cisco VIC adapters only which are connected to Fabric Interconnect cluster. The uplink if specified determines the primary uplink in case of a failover. | [optional] [default to $false]
**IscsiIpV4AddressAllocationType** | **String** | Static/Dynamic Type of IP address allocated to the vNIC. It is derived from iSCSI boot policy IP Address type. * &#x60;None&#x60; - Type defines that property is not applicable for an interface. * &#x60;Auto&#x60; - The system selects an interface automatically - DHCP. * &#x60;Static&#x60; - Type represents that static information or properties are associated to an interface. * &#x60;Pool&#x60; - Type defines that property value will be fetched from an associated pool. | [optional] [readonly] [default to "None"]
**IscsiIpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**IscsiIpv4Address** | **String** | IP address associated to the vNIC. | [optional] [readonly] 
**MacAddress** | **String** | The MAC address that is assigned to the vNIC based on the MAC pool that has been assigned to the LAN Connectivity Policy. | [optional] [readonly] 
**MacAddressType** | **String** | Type of allocation selected to assign a MAC address for the vnic. * &#x60;POOL&#x60; - The user selects a pool from which the mac/wwn address will be leased for the Virtual Interface. * &#x60;STATIC&#x60; - The user assigns a static mac/wwn address for the Virtual Interface. | [optional] [default to "POOL"]
**Name** | **String** | Name of the virtual ethernet interface. | [optional] 
**Order** | **Int64** | The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**Placement** | [**VnicPlacementSettings**](VnicPlacementSettings.md) |  | [optional] 
**StandbyVifId** | **Int64** | The Standby VIF Id is applicable for failover enabled vNICS. It should be the same as the channel number of the standby vethernet created on switch in order to set up the standby data path. | [optional] [readonly] 
**StaticMacAddress** | **String** | The MAC address must be in hexadecimal format xx:xx:xx:xx:xx:xx. To ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the following MAC prefix 00:25:B5:xx:xx:xx. | [optional] 
**UsnicSettings** | [**VnicUsnicSettings**](VnicUsnicSettings.md) |  | [optional] 
**VifId** | **Int64** | The Vif Id should be same as the channel number of the vethernet created on switch in order to set up the data path. The property is applicable only for FI attached servers where a vethernet is created on the switch for every vNIC. | [optional] [readonly] 
**VmqSettings** | [**VnicVmqSettings**](VnicVmqSettings.md) |  | [optional] 
**EthAdapterPolicy** | [**VnicEthAdapterPolicyRelationship**](VnicEthAdapterPolicyRelationship.md) |  | [optional] 
**EthNetworkPolicy** | [**VnicEthNetworkPolicyRelationship**](VnicEthNetworkPolicyRelationship.md) |  | [optional] 
**EthQosPolicy** | [**VnicEthQosPolicyRelationship**](VnicEthQosPolicyRelationship.md) |  | [optional] 
**FabricEthNetworkControlPolicy** | [**FabricEthNetworkControlPolicyRelationship**](FabricEthNetworkControlPolicyRelationship.md) |  | [optional] 
**FabricEthNetworkGroupPolicy** | [**FabricEthNetworkGroupPolicyRelationship[]**](FabricEthNetworkGroupPolicyRelationship.md) | An array of relationships to fabricEthNetworkGroupPolicy resources. | [optional] 
**IpLease** | [**IppoolIpLeaseRelationship**](IppoolIpLeaseRelationship.md) |  | [optional] 
**IscsiBootPolicy** | [**VnicIscsiBootPolicyRelationship**](VnicIscsiBootPolicyRelationship.md) |  | [optional] 
**LanConnectivityPolicy** | [**VnicLanConnectivityPolicyRelationship**](VnicLanConnectivityPolicyRelationship.md) |  | [optional] 
**LcpVnic** | [**VnicEthIfRelationship**](VnicEthIfRelationship.md) |  | [optional] 
**MacLease** | [**MacpoolLeaseRelationship**](MacpoolLeaseRelationship.md) |  | [optional] 
**MacPool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 
**VarProfile** | [**PolicyAbstractConfigProfileRelationship**](PolicyAbstractConfigProfileRelationship.md) |  | [optional] 
**SpVnics** | [**VnicEthIfRelationship[]**](VnicEthIfRelationship.md) | An array of relationships to vnicEthIf resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$VnicEthIfAllOf = Initialize-IntersightVnicEthIfAllOf  -ClassId null `
 -ObjectType null `
 -Cdn null `
 -FailoverEnabled null `
 -IscsiIpV4AddressAllocationType null `
 -IscsiIpV4Config null `
 -IscsiIpv4Address null `
 -MacAddress null `
 -MacAddressType null `
 -Name null `
 -Order null `
 -Placement null `
 -StandbyVifId null `
 -StaticMacAddress null `
 -UsnicSettings null `
 -VifId null `
 -VmqSettings null `
 -EthAdapterPolicy null `
 -EthNetworkPolicy null `
 -EthQosPolicy null `
 -FabricEthNetworkControlPolicy null `
 -FabricEthNetworkGroupPolicy null `
 -IpLease null `
 -IscsiBootPolicy null `
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

