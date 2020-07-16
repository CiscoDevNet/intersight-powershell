# BootSan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] 
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**Bootloader** | [**BootBootloader**](BootBootloader.md) |  | [optional] 
**Lun** | **Int64** | The Logical Unit Number (LUN) of the device. | [optional] 
**Slot** | **String** | Slot ID of the device. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot; ). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootSan  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -Bootloader null `
 -Lun null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

