# HyperflexRpoStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.RpoStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.RpoStatus"]
**Actual** | **Int64** | Actual end time for the snapshot. | [optional] [readonly] 
**Expected** | **Int64** | Expected end time for the snapshot. | [optional] [readonly] 
**RpoExceeded** | **Boolean** | A flag to determine if snapshot delivery is delayed. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexRpoStatusAllOf = Initialize-IntersightHyperflexRpoStatusAllOf  -ClassId null `
 -ObjectType null `
 -Actual null `
 -Expected null `
 -RpoExceeded null
```

- Convert the resource to JSON
```powershell
$HyperflexRpoStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

