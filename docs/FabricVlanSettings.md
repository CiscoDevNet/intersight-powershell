# FabricVlanSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.VlanSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.VlanSettings"]
**AllowedVlans** | **String** | Allowed VLAN IDs of the virtual interface. | [optional] 
**NativeVlan** | **Int64** | Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface. | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$FabricVlanSettings = Initialize-IntersightFabricVlanSettings  -ClassId null `
 -ObjectType null `
 -AllowedVlans null `
 -NativeVlan null
```

- Convert the resource to JSON
```powershell
$FabricVlanSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

