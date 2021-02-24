# IqnpoolIqnSuffixBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iqnpool.IqnSuffixBlock"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iqnpool.IqnSuffixBlock"]
**VarFrom** | **Int64** | The first suffix number in the block. | [optional] [readonly] 
**Suffix** | **String** | The suffix for this bock of IQNs. | [optional] 
**To** | **Int64** | The last suffix number in the block. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IqnpoolIqnSuffixBlockAllOf = Initialize-IntersightIqnpoolIqnSuffixBlockAllOf  -ClassId null `
 -ObjectType null `
 -VarFrom null `
 -Suffix null `
 -To null
```

- Convert the resource to JSON
```powershell
$IqnpoolIqnSuffixBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

