# TamBaseAdvisoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Description** | **String** | Brief description of the advisory details. | [optional] 
**Name** | **String** | A user defined name for the Intersight Advisory. | [optional] 
**Severity** | [**TamSeverity**](TamSeverity.md) |  | [optional] 
**State** | **String** | Current state of the advisory. * &#x60;ready&#x60; - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created. * &#x60;evaluating&#x60; - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation. | [optional] [default to "ready"]

## Examples

- Prepare the resource
```powershell
$TamBaseAdvisoryAllOf = Initialize-IntersightTamBaseAdvisoryAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -Severity null `
 -State null
```

- Convert the resource to JSON
```powershell
$TamBaseAdvisoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

