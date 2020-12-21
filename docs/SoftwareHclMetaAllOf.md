# SoftwareHclMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "software.HclMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "software.HclMeta"]
**ContentType** | **String** | The type of content that the Json file holds (Incremental or full dump). * &#x60;Full&#x60; - Indicates that the JSON File does have full content for HCL metadata. * &#x60;Incremental&#x60; - Indicates that the JSON File does have only the diff of the Hcl meta to be uploaded. | [optional] [default to "Full"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwareHclMetaAllOf = Initialize-IntersightSoftwareHclMetaAllOf  -ClassId null `
 -ObjectType null `
 -ContentType null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$SoftwareHclMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

