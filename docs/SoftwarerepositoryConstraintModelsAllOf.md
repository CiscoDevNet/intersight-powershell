# SoftwarerepositoryConstraintModelsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.ConstraintModels"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.ConstraintModels"]
**MinVersion** | **String** | Minimum version of the image. | [optional] 
**Name** | **String** | Name of the contraint, used to identify constriant type. | [optional] 
**PlatformRegex** | **String** | Regular expression of the image name. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryConstraintModelsAllOf = Initialize-IntersightSoftwarerepositoryConstraintModelsAllOf  -ClassId null `
 -ObjectType null `
 -MinVersion null `
 -Name null `
 -PlatformRegex null `
 -SupportedModels null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryConstraintModelsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

