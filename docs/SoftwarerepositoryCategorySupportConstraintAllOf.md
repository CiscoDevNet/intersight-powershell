# SoftwarerepositoryCategorySupportConstraintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.CategorySupportConstraint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.CategorySupportConstraint"]
**ConstraintId** | **String** | Identifier for this managed object. | [optional] 
**FilteredModels** | [**SoftwarerepositoryConstraintModels[]**](SoftwarerepositoryConstraintModels.md) |  | [optional] 
**MdfId** | **String** | Cisco software repository image category identifier. | [optional] 
**MinVersion** | **String** | Minimum image version from where the models can be supported. | [optional] 
**ParseFromImageName** | **Boolean** | Fields which tells if the constraint is based on image name parsing. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryCategorySupportConstraintAllOf = Initialize-IntersightSoftwarerepositoryCategorySupportConstraintAllOf  -ClassId null `
 -ObjectType null `
 -ConstraintId null `
 -FilteredModels null `
 -MdfId null `
 -MinVersion null `
 -ParseFromImageName null `
 -SupportedModels null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryCategorySupportConstraintAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

