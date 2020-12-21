# ApplianceKeyValuePairAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.KeyValuePair"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.KeyValuePair"]
**Key** | **String** | The string representation of a tag key. | [optional] [readonly] 
**Value** | **String** | The string representation of a tag value. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceKeyValuePairAllOf = Initialize-IntersightApplianceKeyValuePairAllOf  -ClassId null `
 -ObjectType null `
 -Key null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ApplianceKeyValuePairAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

