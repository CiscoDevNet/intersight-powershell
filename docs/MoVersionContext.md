# MoVersionContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**InterestedMos** | [**MoMoRef[]**](MoMoRef.md) |  | [optional] 
**RefMo** | [**MoMoRef**](MoMoRef.md) |  | [optional] 
**Timestamp** | **System.DateTime** | The time this versioned Managed Object was created. | [optional] [readonly] 
**Version** | **String** | The version of the Managed Object, e.g. an incrementing number or a hash id. | [optional] [readonly] 
**VersionType** | **String** | Specifies type of version. Currently the only supported value is &quot;&quot;Configured&quot;&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. | [optional] [readonly] [default to "Modified"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMoVersionContext  -ClassId null `
 -ObjectType null `
 -InterestedMos null `
 -RefMo null `
 -Timestamp null `
 -Version null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

