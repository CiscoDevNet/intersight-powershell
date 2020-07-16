# NiaapiReleaseRecommendAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cll** | **String** | Current long-lived release. | [optional] 
**Crr** | **String** | Customer recommended releases. | [optional] 
**VarPid** | **String** | Hardware model identificator. | [optional] 
**Ull** | **String** | Upcoming long-lived release. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiReleaseRecommendAllOf  -Cll null `
 -Crr null `
 -VarPid null `
 -Ull null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

