# HyperflexMacAddrPrefixRange
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.MacAddrPrefixRange"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.MacAddrPrefixRange"]
**EndAddr** | **String** | The end MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX. | [optional] 
**StartAddr** | **String** | The start MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexMacAddrPrefixRange = Initialize-IntersightHyperflexMacAddrPrefixRange  -ClassId null `
 -ObjectType null `
 -EndAddr null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$HyperflexMacAddrPrefixRange | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

