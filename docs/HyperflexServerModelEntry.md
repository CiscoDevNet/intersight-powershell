# HyperflexServerModelEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ServerModelEntry"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ServerModelEntry"]
**Name** | **String** | The application setting identifier. | [optional] 
**Value** | **String** | The application setting value. | [optional] 
**Constraint** | [**HyperflexAppSettingConstraint**](HyperflexAppSettingConstraint.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexServerModelEntry = Initialize-IntersightHyperflexServerModelEntry  -ClassId null `
 -ObjectType null `
 -Name null `
 -Value null `
 -Constraint null
```

- Convert the resource to JSON
```powershell
$HyperflexServerModelEntry | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

