# HclConstraintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.Constraint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.Constraint"]
**ConstraintName** | **String** | Name or key of the applicable compatibility constraint. | [optional] 
**ConstraintValue** | **String** | Value of the applicable compatibility constraint. Could either be a string value or a regex. | [optional] 

## Examples

- Prepare the resource
```powershell
$HclConstraintAllOf = Initialize-IntersightHclConstraintAllOf  -ClassId null `
 -ObjectType null `
 -ConstraintName null `
 -ConstraintValue null
```

- Convert the resource to JSON
```powershell
$HclConstraintAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

