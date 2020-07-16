# HyperflexMacAddrPrefixRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndAddr** | **String** | The end MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX. | [optional] 
**StartAddr** | **String** | The start MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexMacAddrPrefixRangeAllOf  -EndAddr null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

