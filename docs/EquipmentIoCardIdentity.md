# EquipmentIoCardIdentity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**IoCardMoid** | **String** | MO Reference to equipmentIoCard MO in inventory service. | [optional] 
**ModuleId** | **Int64** | IOM/MUX Module ID connected to the FI. | [optional] 
**NetworkElementMoid** | **String** | MO Reference to networkElement MO in inventory service. | [optional] 
**SwitchId** | **Int64** | Switch ID to which IOM is connected, ID can be either 1 or 2, equalent to A or B. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIoCardIdentity  -ClassId null `
 -ObjectType null `
 -IoCardMoid null `
 -ModuleId null `
 -NetworkElementMoid null `
 -SwitchId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

