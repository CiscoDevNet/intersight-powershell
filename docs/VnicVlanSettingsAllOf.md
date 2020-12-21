# VnicVlanSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.VlanSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.VlanSettings"]
**AllowedVlans** | **String** | Allowed VLAN IDs of the virtual interface. | [optional] 
**DefaultVlan** | **Int64** | Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface. | [optional] [default to 0]
**Mode** | **String** | Option to determine if the port can carry single VLAN (Access) or multiple VLANs (Trunk) traffic. * &#x60;ACCESS&#x60; - An access port carries traffic only for a single VLAN on the interface. * &#x60;TRUNK&#x60; - A trunk port can have two or more VLANs configured on the interface. It can carry traffic for several VLANs simultaneously. | [optional] [default to "ACCESS"]

## Examples

- Prepare the resource
```powershell
$VnicVlanSettingsAllOf = Initialize-IntersightVnicVlanSettingsAllOf  -ClassId null `
 -ObjectType null `
 -AllowedVlans null `
 -DefaultVlan null `
 -Mode null
```

- Convert the resource to JSON
```powershell
$VnicVlanSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

