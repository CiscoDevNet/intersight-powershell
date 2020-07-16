# TamAdvisoryInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **String** | Current state of the advisory for the owner. Indicates if the user is interested in getting updates for the advisory. | [optional] [default to "active"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Advisory** | [**TamBaseAdvisoryRelationship**](TamBaseAdvisoryRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamAdvisoryInfoAllOf  -State null `
 -Account null `
 -Advisory null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

