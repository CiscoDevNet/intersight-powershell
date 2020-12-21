# ServerConfigImportAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "server.ConfigImport"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "server.ConfigImport"]
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
$ServerConfigImportAllOf = Initialize-IntersightServerConfigImportAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -PolicyPrefix null `
 -PolicyTypes null `
 -ProfileName null `
 -Organization null `
 -Server null `
 -ServerProfile null
```

- Convert the resource to JSON
```powershell
$ServerConfigImportAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

