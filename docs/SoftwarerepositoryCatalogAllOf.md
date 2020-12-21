# SoftwarerepositoryCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.Catalog"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.Catalog"]
**IsImagePullFailure** | **Boolean** | The status of the image catalog synchronization operation. | [optional] [readonly] 
**Name** | **String** | The name of the catalog. The names are populated and predefined during MO creation. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryCatalogAllOf = Initialize-IntersightSoftwarerepositoryCatalogAllOf  -ClassId null `
 -ObjectType null `
 -IsImagePullFailure null `
 -Name null `
 -Organization null `
 -System null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryCatalogAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

