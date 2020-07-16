# MetaPropDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ApiAccess** | **String** | API access control for the property. Examples are NoAccess, ReadOnly, CreateOnly etc. | [optional] [readonly] [default to "NoAccess"]
**Name** | **String** | The name of the property. | [optional] [readonly] 
**OpSecurity** | **String** | The data-at-rest security protection applied to this property when a Managed Object is persisted. For example, Encrypted or Cleartext. | [optional] [readonly] [default to "ClearText"]
**SearchWeight** | **Double** | Enables the property to be searchable from global search. A value of 0 means this property is not globally searchable. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaPropDefinition  -ClassId null `
 -ObjectType null `
 -ApiAccess null `
 -Name null `
 -OpSecurity null `
 -SearchWeight null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

