# NiaapiRevisionInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatePublished** | **System.DateTime** | The date the revision is made. | [optional] 
**RevisionComment** | **String** | The changes made in this revision. | [optional] 
**RevisionNo** | **String** | The Revision No. of this revision. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiRevisionInfoAllOf  -DatePublished null `
 -RevisionComment null `
 -RevisionNo null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

