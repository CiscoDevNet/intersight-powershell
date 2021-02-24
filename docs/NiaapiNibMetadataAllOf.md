# NiaapiNibMetadataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.NibMetadata"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.NibMetadata"]
**Content** | [**NiaapiDetail[]**](NiaapiDetail.md) |  | [optional] 
**Date** | **System.DateTime** | The date when the package was generated. | [optional] 
**MetadataChksum** | **String** | Chksum used to check the integrity of the metadata file downloaded. | [optional] 
**MetadataFilename** | **String** | The filename of the metadata package. | [optional] 
**Version** | **Int64** | The version number of the metadata package. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiNibMetadataAllOf = Initialize-IntersightNiaapiNibMetadataAllOf  -ClassId null `
 -ObjectType null `
 -Content null `
 -Date null `
 -MetadataChksum null `
 -MetadataFilename null `
 -Version null
```

- Convert the resource to JSON
```powershell
$NiaapiNibMetadataAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

