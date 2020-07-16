# VnicPlacementSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Id** | **String** | PCIe Slot where the VIC adapter is installed. Supported values are (1-15) and MLOM. | [optional] 
**PciLink** | **Int64** | The PCI Link used as transport for the virtual interface. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**SwitchId** | **String** | The fabric port to which the vnics will be associated. | [optional] [default to "None"]
**Uplink** | **Int64** | Adapter port on which the virtual interface will be created. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicPlacementSettings  -ClassId null `
 -ObjectType null `
 -Id null `
 -PciLink null `
 -SwitchId null `
 -Uplink null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

