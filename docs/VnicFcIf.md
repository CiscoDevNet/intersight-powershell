# VnicFcIf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Name** | **String** | Name of the virtual fibre channel interface. | [optional] 
**Order** | **Int64** | The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**PersistentBindings** | **Boolean** | Enables retention of LUN ID associations in memory until they are manually cleared. | [optional] 
**Placement** | [**VnicPlacementSettings**](VnicPlacementSettings.md) |  | [optional] 
**Type** | **String** | VHBA Type configuration for SAN Connectivity Policy. This configuration is supported only on Cisco VIC 14XX series and higher series of adapters. | [optional] [default to "fc-initiator"]
**VifId** | **Int64** | This should be the same as the channel number of the vfc created on switch in order to set up the data path. The property is applicable only for FI attached servers where a vfc is created on the switch for every vHBA. | [optional] [readonly] 
**Wwpn** | **String** | The WWPN address that is assigned to the vhba based on the wwn pool that has been assigned to the SAN Connectivity Policy. | [optional] [readonly] 
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
Initialize-IntersightVnicFcIf  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

