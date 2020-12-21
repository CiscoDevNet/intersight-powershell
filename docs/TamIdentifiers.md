# TamIdentifiers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.Identifiers"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.Identifiers"]
**Name** | **String** | Name of the filter paramter. | [optional] 
**Value** | **String** | Value of the filter paramter. | [optional] 

## Examples

- Prepare the resource
```powershell
$TamIdentifiers = Initialize-IntersightTamIdentifiers  -ClassId null `
 -ObjectType null `
 -Name null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TamIdentifiers | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

