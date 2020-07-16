# ServerConfigImportAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Description of the imported profile. | [optional] 
**PolicyPrefix** | **String** | Policy prefix for the policies of the imported server profile. | [optional] 
**PolicyTypes** | **String[]** |  | [optional] 
**ProfileName** | **String** | Profile name for the imported server profile. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Server** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**ServerProfile** | [**ServerProfileRelationship**](ServerProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightServerConfigImportAllOf  -Description null `
 -PolicyPrefix null `
 -PolicyTypes null `
 -ProfileName null `
 -Organization null `
 -Server null `
 -ServerProfile null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

