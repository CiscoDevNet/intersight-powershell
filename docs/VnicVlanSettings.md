# VnicVlanSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**AllowedVlans** | **String** | Allowed VLAN IDs of the virtual interface. | [optional] 
**DefaultVlan** | **Int64** | Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface. | [optional] 
**Mode** | **String** | Option to determine if the port can carry single VLAN (Access) or multiple VLANs (Trunk) traffic. | [optional] [default to "ACCESS"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicVlanSettings  -ClassId null `
 -ObjectType null `
 -AllowedVlans null `
 -DefaultVlan null `
 -Mode null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

