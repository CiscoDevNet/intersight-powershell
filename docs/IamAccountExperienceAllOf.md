# IamAccountExperienceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.AccountExperience"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.AccountExperience"]
**Features** | [**IamFeatureDefinition[]**](IamFeatureDefinition.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamAccountExperienceAllOf = Initialize-IntersightIamAccountExperienceAllOf  -ClassId null `
 -ObjectType null `
 -Features null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IamAccountExperienceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

