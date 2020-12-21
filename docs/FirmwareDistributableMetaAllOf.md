# FirmwareDistributableMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.DistributableMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.DistributableMeta"]
**BucketName** | **String** | The S3 bucket name where the images are present, if source is external cloud store. | [optional] 
**FileType** | **String** | The type of distributable image, example huu, scu, driver, os. * &#x60;Distributable&#x60; - Stores firmware host utility images and fabric images. * &#x60;DriverDistributable&#x60; - Stores driver distributable images. * &#x60;ServerConfigurationUtilityDistributable&#x60; - Stores server configuration utility images. * &#x60;OperatingSystemFile&#x60; - Stores operating system iso images. * &#x60;HyperflexDistributable&#x60; - It stores HyperFlex images. | [optional] [default to "Distributable"]
**FromVersion** | **String** | The version from which user can download images from amazon store, if source is external cloud store. | [optional] 
**Mdfid** | **String** | The mdfid of the image provided by cisco.com. | [optional] 
**SoftwareTypeId** | **String** | The software type id provided by cisco.com. | [optional] 
**Source** | **String** | The image can be downloaded from cisco.com or external cloud store. * &#x60;Cisco&#x60; - External repository hosted on cisco.com. * &#x60;IntersightCloud&#x60; - Repository hosted by the Intersight Cloud. * &#x60;LocalMachine&#x60; - The file is available on the local client machine. Used as an upload source type. * &#x60;NetworkShare&#x60; - External repository in the customer datacenter. This will typically be a file server. | [optional] [default to "Cisco"]
**SupportedModels** | **String[]** |  | [optional] 
**ToVersion** | **String** | The version till which user can download images from amazon store, if source is external cloud store. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareDistributableMetaAllOf = Initialize-IntersightFirmwareDistributableMetaAllOf  -ClassId null `
 -ObjectType null `
 -BucketName null `
 -FileType null `
 -FromVersion null `
 -Mdfid null `
 -SoftwareTypeId null `
 -Source null `
 -SupportedModels null `
 -ToVersion null
```

- Convert the resource to JSON
```powershell
$FirmwareDistributableMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

