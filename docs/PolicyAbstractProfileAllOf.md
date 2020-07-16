# PolicyAbstractProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Description of the profile. | [optional] 
**Name** | **String** | Name of the concrete profile. | [optional] 
**Type** | **String** | Defines the type of the profile. Accepted value is instance. | [optional] [default to "instance"]
**SrcTemplate** | [**PolicyAbstractProfileRelationship**](PolicyAbstractProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyAbstractProfileAllOf  -Description null `
 -Name null `
 -Type null `
 -SrcTemplate null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

