# IamResourceLimitsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.ResourceLimits"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.ResourceLimits"]
**PerAccountUserLimit** | **Int64** | The maximum number of users allowed in an account. The default value is 200. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamResourceLimitsAllOf = Initialize-IntersightIamResourceLimitsAllOf  -ClassId null `
 -ObjectType null `
 -PerAccountUserLimit null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IamResourceLimitsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

