# FabricEthNetworkControlPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.EthNetworkControlPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.EthNetworkControlPolicy"]
**CdpEnabled** | **Boolean** | Enables the CDP on an interface. | [optional] [default to $false]
**ForgeMac** | **String** | Determines if the MAC forging is allowed or denied on an interface. * &#x60;allow&#x60; - Allows mac forging on an interface. * &#x60;deny&#x60; - Denies mac forging on an interface. | [optional] [default to "allow"]
**LldpSettings** | [**FabricLldpSettings**](FabricLldpSettings.md) |  | [optional] 
**MacRegistrationMode** | **String** | Determines the MAC addresses that have to be registered with the switch. * &#x60;nativeVlanOnly&#x60; - Register only the MAC addresses learnt on the native VLAN. * &#x60;allVlans&#x60; - Register all the MAC addresses learnt on all the allowed VLANs. | [optional] [default to "nativeVlanOnly"]
**UplinkFailAction** | **String** | Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned. * &#x60;linkDown&#x60; - The vethernet will go down in case a suitable uplink is not pinned. * &#x60;warning&#x60; - The vethernet will remain up even if a suitable uplink is not pinned. | [optional] [default to "linkDown"]
**NetworkPolicy** | [**VnicEthNetworkPolicyRelationship[]**](VnicEthNetworkPolicyRelationship.md) | An array of relationships to vnicEthNetworkPolicy resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricEthNetworkControlPolicyAllOf = Initialize-IntersightFabricEthNetworkControlPolicyAllOf  -ClassId null `
 -ObjectType null `
 -CdpEnabled null `
 -ForgeMac null `
 -LldpSettings null `
 -MacRegistrationMode null `
 -UplinkFailAction null `
 -NetworkPolicy null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$FabricEthNetworkControlPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

