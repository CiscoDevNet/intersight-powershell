# TamAdvisoryCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdvisoryCount** | **Int64** | Total number of advisories affecting the account. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamAdvisoryCountAllOf  -AdvisoryCount null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

