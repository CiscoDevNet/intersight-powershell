# VnicFcIfRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.FcIf"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.FcIf"]
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
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
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
$VnicFcIfRelationship = Initialize-IntersightVnicFcIfRelationship  -ClassId null `
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
$VnicFcIfRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

