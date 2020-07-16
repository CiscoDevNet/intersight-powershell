# CmrfCmRf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The Object Type of the referenced REST resource. | [readonly] 
**Moid** | **String** | The Moid of the referenced REST resource. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCmrfCmRf  -ClassId null `
 -ObjectType null `
 -Moid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

