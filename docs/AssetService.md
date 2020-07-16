# AssetService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Options** | [**AssetServiceOptions**](AssetServiceOptions.md) |  | [optional] 
**Status** | **String** | Status indicates if the respective Service can establish a connection and authenticate with the managed target. Status does not include information about the functional health of the target. | [optional] [default to ""]
**StatusErrorReason** | **String** | When &#39;Status&#39; is not Connected, statusErrorReason provides further details about why the device is not connected with Intersight. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetService  -ClassId null `
 -ObjectType null `
 -Options null `
 -Status null `
 -StatusErrorReason null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

