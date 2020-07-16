# IamResourceLimitsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PerAccountUserLimit** | **Int64** | The maximum number of users allowed in an account. The default value is 200. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamResourceLimitsAllOf  -PerAccountUserLimit null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

