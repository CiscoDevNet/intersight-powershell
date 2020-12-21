# NiaapiNewReleasePostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**PostDate** | **System.DateTime** | The date when this new release notice is posted. | [optional] 
**PostDetail** | [**NiaapiNewReleaseDetail**](NiaapiNewReleaseDetail.md) |  | [optional] 
**PostType** | **String** | The document type of this post. | [optional] 
**Postid** | **String** | Identificator of this inbox post. | [optional] 
**Revision** | **String** | Revision number of this notice. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiNewReleasePostAllOf = Initialize-IntersightNiaapiNewReleasePostAllOf  -ClassId null `
 -ObjectType null `
 -PostDate null `
 -PostDetail null `
 -PostType null `
 -Postid null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$NiaapiNewReleasePostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

