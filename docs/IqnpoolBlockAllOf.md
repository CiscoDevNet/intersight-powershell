# IqnpoolBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iqnpool.Block"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iqnpool.Block"]
**IqnSuffixBlock** | [**IqnpoolIqnSuffixBlock**](IqnpoolIqnSuffixBlock.md) |  | [optional] 
**Pool** | [**IqnpoolPoolRelationship**](IqnpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IqnpoolBlockAllOf = Initialize-IntersightIqnpoolBlockAllOf  -ClassId null `
 -ObjectType null `
 -IqnSuffixBlock null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$IqnpoolBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

