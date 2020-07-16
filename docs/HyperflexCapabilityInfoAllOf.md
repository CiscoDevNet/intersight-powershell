# HyperflexCapabilityInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapabilityConstraints** | [**HclConstraint[]**](HclConstraint.md) |  | [optional] 
**Name** | **String** | Name of the capability or feature set consisting of a collection of constraint rules and value. | [optional] 
**Value** | **String** | Capability Value which is valid only iff all specified constraints match. | [optional] [readonly] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexCapabilityInfoAllOf  -CapabilityConstraints null `
 -Name null `
 -Value null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

