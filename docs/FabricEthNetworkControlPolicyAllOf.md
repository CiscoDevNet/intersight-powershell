# FabricEthNetworkControlPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CdpEnabled** | **Boolean** | Enables the CDP on an interface. | [optional] 
**ForgeMac** | **String** | Determines if the MAC forging is allowed or denied on an interface. | [optional] [default to "allow"]
**LldpSettings** | [**FabricLldpSettings**](FabricLldpSettings.md) |  | [optional] 
**MacRegistrationMode** | **String** | Determines the MAC addresses that have to be registered with the switch. | [optional] [default to "nativeVlanOnly"]
**UplinkFailAction** | **String** | Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned. | [optional] [default to "linkDown"]
**NetworkPolicy** | [**VnicEthNetworkPolicyRelationship[]**](VnicEthNetworkPolicyRelationship.md) | An array of relationships to vnicEthNetworkPolicy resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricEthNetworkControlPolicyAllOf  -CdpEnabled null `
 -ForgeMac null `
 -LldpSettings null `
 -MacRegistrationMode null `
 -UplinkFailAction null `
 -NetworkPolicy null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

