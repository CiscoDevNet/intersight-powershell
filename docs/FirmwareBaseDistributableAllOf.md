# FirmwareBaseDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**BundleType** | **String** | The bundle type of the image, as published on cisco.com. | [optional] [readonly] 
**ComponentMeta** | [**FirmwareComponentMeta[]**](FirmwareComponentMeta.md) |  | [optional] 
**Guid** | **String** | The unique identifier for an image in a Cisco repository. | [optional] [readonly] 
**Mdfid** | **String** | The mdfid of the image provided by cisco.com. | [optional] 
**Model** | **String** | The endpoint model for which this firmware image is applicable. | [optional] 
**PlatformType** | **String** | The platform type of the image. | [optional] [readonly] 
**RecommendedBuild** | **String** | The build which is recommended by Cisco. | [optional] 
**ReleaseNotesUrl** | **String** | The url for the release notes of this image. | [optional] 
**SoftwareTypeId** | **String** | The software type id provided by cisco.com. | [optional] [readonly] 
**SupportedModels** | **String[]** |  | [optional] 
**Vendor** | **String** | The vendor or publisher of this file. | [optional] [default to "Cisco"]
**DistributableMetas** | [**FirmwareDistributableMetaRelationship[]**](FirmwareDistributableMetaRelationship.md) | An array of relationships to firmwareDistributableMeta resources. | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareBaseDistributableAllOf = Initialize-IntersightFirmwareBaseDistributableAllOf  -ClassId null `
 -ObjectType null `
 -BundleType null `
 -ComponentMeta null `
 -Guid null `
 -Mdfid null `
 -Model null `
 -PlatformType null `
 -RecommendedBuild null `
 -ReleaseNotesUrl null `
 -SoftwareTypeId null `
 -SupportedModels null `
 -Vendor null `
 -DistributableMetas null `
 -Release null
```

- Convert the resource to JSON
```powershell
$FirmwareBaseDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

