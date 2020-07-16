# FirmwareComponentMeta
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ComponentLabel** | **String** | The name of the component in the compressed HSU bundle. | [optional] 
**ComponentType** | **String** | The type of component image within the distributable. | [optional] [default to "ALL"]
**Description** | **String** | This shows the description of component image within the distributable. | [optional] 
**Disruption** | **String** | The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle. | [optional] [default to "None"]
**IsOobSupported** | **Boolean** | If set, the component can be updated through out-of-band management, else, is updated through the booting host service utility. | [optional] 
**Model** | **String** | The model of the component image in the distributable. | [optional] 
**OobManageability** | **String[]** |  | [optional] 
**PackedVersion** | **String** | The packaged version of component image within the distributable. | [optional] 
**RedfishUrl** | **String** | The redfish target for each component. | [optional] 
**Vendor** | **String** | The version of the component image in the distributable. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareComponentMeta  -ClassId null `
 -ObjectType null `
 -ComponentLabel null `
 -ComponentType null `
 -Description null `
 -Disruption null `
 -IsOobSupported null `
 -Model null `
 -OobManageability null `
 -PackedVersion null `
 -RedfishUrl null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

