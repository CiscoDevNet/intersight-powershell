# CommConcreteCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | Password for the Managed Device. | [optional] 
**Username** | **String** | Username for the Managed Device. Format and restrictions are not enforced here but usually follow the ManagedDevice requirements. | [optional] 
**Name** | **String** | Name for the credential entry that is created. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCommConcreteCredential  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -Password null `
 -Username null `
 -Name null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

