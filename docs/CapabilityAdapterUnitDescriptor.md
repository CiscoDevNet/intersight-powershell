# CapabilityAdapterUnitDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.AdapterUnitDescriptor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.AdapterUnitDescriptor"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | Detailed information about the endpoint. | [optional] 
**Model** | **String** | The model of the endpoint, for which this capability information is applicable. | [optional] 
**Vendor** | **String** | The vendor of the endpoint, for which this capability information is applicable. | [optional] 
**Version** | **String** | The firmware or software version of the endpoint, for which this capability information is applicable. | [optional] 
**Capabilities** | [**CapabilityCapabilityRelationship[]**](CapabilityCapabilityRelationship.md) | An array of relationships to capabilityCapability resources. | [optional] 
**ConnectivityOrder** | **String** | Order in which the ports are connected; sequential or cyclic. | [optional] 
**EthernetPortSpeed** | **Int64** | The port speed for ethernet ports in Mbps. | [optional] 
**FibreChannelPortSpeed** | **Int64** | The port speed for fibre channel ports in Mbps. | [optional] 
**NumDcePorts** | **Int64** | Number of Dce Ports for the adaptor. | [optional] 
**PromCardType** | **String** | Prom card type for the adaptor. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityAdapterUnitDescriptor = Initialize-IntersightCapabilityAdapterUnitDescriptor  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -Model null `
 -Vendor null `
 -Version null `
 -Capabilities null `
 -ConnectivityOrder null `
 -EthernetPortSpeed null `
 -FibreChannelPortSpeed null `
 -NumDcePorts null `
 -PromCardType null
```

- Convert the resource to JSON
```powershell
$CapabilityAdapterUnitDescriptor | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

