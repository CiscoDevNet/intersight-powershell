# HyperflexClusterNetworkPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterNetworkPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterNetworkPolicy"]
**JumboFrame** | **Boolean** | Enable or disable jumbo frames. | [optional] 
**KvmIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**MacPrefixRange** | [**HyperflexMacAddrPrefixRange**](HyperflexMacAddrPrefixRange.md) |  | [optional] 
**MgmtVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**UplinkSpeed** | **String** | Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be &#39;1G&#39; or &#39;10G+&#39;. Use &#39;10G+&#39; for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be &#39;default&#39; only. * &#x60;default&#x60; - Current default value set on the hardware platform. * &#x60;1G&#x60; - A link speed of 1 gigabit per second. * &#x60;10G&#x60; - A link speed of 10 gigabits per second or above. | [optional] [default to "default"]
**VmMigrationVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**VmNetworkVlans** | [**HyperflexNamedVlan[]**](HyperflexNamedVlan.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterNetworkPolicyAllOf = Initialize-IntersightHyperflexClusterNetworkPolicyAllOf  -ClassId null `
 -ObjectType null `
 -JumboFrame null `
 -KvmIpRange null `
 -MacPrefixRange null `
 -MgmtVlan null `
 -UplinkSpeed null `
 -VmMigrationVlan null `
 -VmNetworkVlans null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterNetworkPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

