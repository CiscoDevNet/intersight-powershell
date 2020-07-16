# VnicEthIfRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Cdn** | [**VnicCdn**](VnicCdn.md) |  | [optional] 
**FailoverEnabled** | **Boolean** | Setting this to true esnures that the traffic failsover from one uplink to another auotmatically in case of an uplink failure. It is applicable for Cisco VIC adapters only which are connected to Fabric Interconnect cluster. The uplink if specified determines the primary uplink in case of a failover. | [optional] 
**MacAddress** | **String** | The MAC address that is assigned to the vnic based on the MAC pool that has been assigned to the LAN Connectivity Policy. | [optional] [readonly] 
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
**LanConnectivityPolicy** | [**VnicLanConnectivityPolicyRelationship**](VnicLanConnectivityPolicyRelationship.md) |  | [optional] 
**LcpVnic** | [**VnicEthIfRelationship**](VnicEthIfRelationship.md) |  | [optional] 
**MacLease** | [**MacpoolLeaseRelationship**](MacpoolLeaseRelationship.md) |  | [optional] 
**MacPool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 
**VarProfile** | [**PolicyAbstractConfigProfileRelationship**](PolicyAbstractConfigProfileRelationship.md) |  | [optional] 
**SpVnics** | [**VnicEthIfRelationship[]**](VnicEthIfRelationship.md) | An array of relationships to vnicEthIf resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicEthIfRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
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
 -LanConnectivityPolicy null `
 -LcpVnic null `
 -MacLease null `
 -MacPool null `
 -VarProfile null `
 -SpVnics null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

