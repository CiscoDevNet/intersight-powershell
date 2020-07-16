# HyperflexNamedVsan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Name** | **String** | The name of the VSAN. The name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens. | [optional] 
**VsanId** | **Int64** | The ID of the named VSAN. The ID can be any number between 1 and 4093, inclusive. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexNamedVsan  -ClassId null `
 -ObjectType null `
 -Name null `
 -VsanId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

