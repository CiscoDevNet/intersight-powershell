# HyperflexNamedVsanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the VSAN. The name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens. | [optional] 
**VsanId** | **Int64** | The ID of the named VSAN. The ID can be any number between 1 and 4093, inclusive. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexNamedVsanAllOf  -Name null `
 -VsanId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

