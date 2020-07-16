# PolicyAbstractConfigProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **String** | User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign. | [optional] 
**ConfigContext** | [**PolicyConfigContext**](PolicyConfigContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyAbstractConfigProfileAllOf  -Action null `
 -ConfigContext null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

