# TamBaseAdvisoryDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "tam.SecurityAdvisoryDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "tam.SecurityAdvisoryDetails"]
**Description** | **String** | Brief description of details specified for an advisory type. | [optional] 

## Examples

- Prepare the resource
```powershell
$TamBaseAdvisoryDetailsAllOf = Initialize-IntersightTamBaseAdvisoryDetailsAllOf  -ClassId null `
 -ObjectType null `
 -Description null
```

- Convert the resource to JSON
```powershell
$TamBaseAdvisoryDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

