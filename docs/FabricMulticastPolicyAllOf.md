# FabricMulticastPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.MulticastPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.MulticastPolicy"]
**QuerierIpAddress** | **String** | Used to define the IGMP Querier IP address. | [optional] 
**QuerierIpAddressPeer** | **String** | Used to define the IGMP Querier IP address of the peer switch. | [optional] 
**QuerierState** | **String** | Administrative state of the IGMP Querier for this VLAN. * &#x60;Disabled&#x60; - IGMP Querier Disabled State. * &#x60;Enabled&#x60; - IGMP Querier Enabled State. | [optional] [default to "Disabled"]
**SnoopingState** | **String** | Administrative state of the IGMP Snooping for this VLAN. * &#x60;Enabled&#x60; - IGMP Snooping Enabled State. * &#x60;Disabled&#x60; - IGMP Snooping Disabled State. | [optional] [default to "Enabled"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricMulticastPolicyAllOf = Initialize-IntersightFabricMulticastPolicyAllOf  -ClassId null `
 -ObjectType null `
 -QuerierIpAddress null `
 -QuerierIpAddressPeer null `
 -QuerierState null `
 -SnoopingState null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$FabricMulticastPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

