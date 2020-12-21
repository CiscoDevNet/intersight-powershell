# SoftwarerepositoryReleaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.Release"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.Release"]
**ReleaseDate** | **System.DateTime** | The date when the file was released or distributed by its vendor. | [optional] 
**ReleaseNotesUrl** | **String** | The URL for the release notes of this image. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 
**Type** | **String** | The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware. * &#x60;FabricSwitch&#x60; - The images in a release that correspond to Fabric Interconnect switches. * &#x60;ComputeSystem&#x60; - The images in a release that correspond to servers. | [optional] [default to "FabricSwitch"]
**Version** | **String** | Cisco provided release version. | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryReleaseAllOf = Initialize-IntersightSoftwarerepositoryReleaseAllOf  -ClassId null `
 -ObjectType null `
 -ReleaseDate null `
 -ReleaseNotesUrl null `
 -SupportedModels null `
 -Type null `
 -Version null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryReleaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

