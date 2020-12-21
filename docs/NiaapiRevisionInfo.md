# NiaapiRevisionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.RevisionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.RevisionInfo"]
**DatePublished** | **System.DateTime** | The date the revision is made. | [optional] 
**RevisionComment** | **String** | The changes made in this revision. | [optional] 
**RevisionNo** | **String** | The Revision No. of this revision. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiRevisionInfo = Initialize-IntersightNiaapiRevisionInfo  -ClassId null `
 -ObjectType null `
 -DatePublished null `
 -RevisionComment null `
 -RevisionNo null
```

- Convert the resource to JSON
```powershell
$NiaapiRevisionInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

