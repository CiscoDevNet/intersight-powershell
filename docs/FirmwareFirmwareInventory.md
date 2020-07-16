# FirmwareFirmwareInventory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Category** | **String** | Component category. For example, MRAID is under storage controller, CIMC is under management controller. | [optional] 
**Label** | **String** | The name of the component to reflect on UI. | [optional] 
**Model** | **String** | Model deatils of component. | [optional] 
**UpdateUri** | **String** | The redfish URI to get the firmware inventory of server components. | [optional] 
**Vendor** | **String** | The vendor of the component. | [optional] 
**Version** | **String** | The firmware running version on the component. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareFirmwareInventory  -ClassId null `
 -ObjectType null `
 -Category null `
 -Label null `
 -Model null `
 -UpdateUri null `
 -Vendor null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

