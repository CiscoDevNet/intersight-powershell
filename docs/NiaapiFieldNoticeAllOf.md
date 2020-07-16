# NiaapiFieldNoticeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bugid** | **String** | Bug Id associated with this notice. | [optional] 
**FieldNoticeDesc** | **String** | Field notice Description. | [optional] 
**FieldNoticeId** | **String** | Fieldnotice Id of this notice. | [optional] 
**FieldNoticeUrl** | **String** | Field notice URL link to the notice webpage. | [optional] 
**Headline** | **String** | The headline of this field notice. | [optional] 
**Hwpid** | **String** | Hardware PID for affected models. | [optional] 
**RevisionInfo** | [**NiaapiRevisionInfo[]**](NiaapiRevisionInfo.md) |  | [optional] 
**SwRelease** | **String** | Software Release number for affected versions. | [optional] 
**WorkaroundUrl** | **String** | URL of workaround of this notice. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiFieldNoticeAllOf  -Bugid null `
 -FieldNoticeDesc null `
 -FieldNoticeId null `
 -FieldNoticeUrl null `
 -Headline null `
 -Hwpid null `
 -RevisionInfo null `
 -SwRelease null `
 -WorkaroundUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

