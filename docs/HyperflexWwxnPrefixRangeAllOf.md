# HyperflexWwxnPrefixRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.WwxnPrefixRange"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.WwxnPrefixRange"]
**EndAddr** | **String** | The end WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX. | [optional] 
**StartAddr** | **String** | The start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexWwxnPrefixRangeAllOf = Initialize-IntersightHyperflexWwxnPrefixRangeAllOf  -ClassId null `
 -ObjectType null `
 -EndAddr null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$HyperflexWwxnPrefixRangeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

