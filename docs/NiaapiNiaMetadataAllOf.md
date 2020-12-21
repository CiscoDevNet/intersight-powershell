# NiaapiNiaMetadataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.NiaMetadata"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.NiaMetadata"]
**Content** | [**NiaapiDetail[]**](NiaapiDetail.md) |  | [optional] 
**Date** | **System.DateTime** | The date when this package is generated. | [optional] 
**MetadataChksum** | **String** | Chksum used to check the integrity of the Metadata file downloaded. | [optional] 
**MetadataFilename** | **String** | The Filename of this Metadata package. | [optional] 
**Version** | **Int64** | The version number of the Metadata package. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiNiaMetadataAllOf = Initialize-IntersightNiaapiNiaMetadataAllOf  -ClassId null `
 -ObjectType null `
 -Content null `
 -Date null `
 -MetadataChksum null `
 -MetadataFilename null `
 -Version null
```

- Convert the resource to JSON
```powershell
$NiaapiNiaMetadataAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

