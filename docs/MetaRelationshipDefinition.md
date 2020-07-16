# MetaRelationshipDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ApiAccess** | **String** | API access definition for this relationship. | [optional] [readonly] [default to "NoAccess"]
**Collection** | **Boolean** | Specifies whether the relationship is a collection. | [optional] [readonly] 
**Export** | **Boolean** | When turned off, the peer MO is not exported when the local MO is exported. | [optional] [readonly] 
**ExportWithPeer** | **Boolean** | When turned on, the local MO is exported when the peer is exported. | [optional] [readonly] 
**Name** | **String** | The name of the relationship. | [optional] [readonly] 
**Type** | **String** | Fully qualified type of the foreign managed object. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaRelationshipDefinition  -ClassId null `
 -ObjectType null `
 -ApiAccess null `
 -Collection null `
 -Export null `
 -ExportWithPeer null `
 -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

