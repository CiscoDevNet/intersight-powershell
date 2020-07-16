# HyperflexWwxnPrefixRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndAddr** | **String** | The end WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX. | [optional] 
**StartAddr** | **String** | The start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexWwxnPrefixRangeAllOf  -EndAddr null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

