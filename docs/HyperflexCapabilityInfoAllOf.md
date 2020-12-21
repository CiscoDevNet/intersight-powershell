# HyperflexCapabilityInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.CapabilityInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.CapabilityInfo"]
**CapabilityConstraints** | [**HclConstraint[]**](HclConstraint.md) |  | [optional] 
**Name** | **String** | Name of the capability or feature set consisting of a collection of constraint rules and value. | [optional] 
**Value** | **String** | Capability Value which is valid only iff all specified constraints match. | [optional] [readonly] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexCapabilityInfoAllOf = Initialize-IntersightHyperflexCapabilityInfoAllOf  -ClassId null `
 -ObjectType null `
 -CapabilityConstraints null `
 -Name null `
 -Value null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$HyperflexCapabilityInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

