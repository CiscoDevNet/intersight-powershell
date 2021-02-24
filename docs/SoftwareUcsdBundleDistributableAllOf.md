# SoftwareUcsdBundleDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "software.UcsdBundleDistributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "software.UcsdBundleDistributable"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 
**Images** | [**SoftwareUcsdDistributableRelationship[]**](SoftwareUcsdDistributableRelationship.md) | An array of relationships to softwareUcsdDistributable resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SoftwareUcsdBundleDistributableAllOf = Initialize-IntersightSoftwareUcsdBundleDistributableAllOf  -ClassId null `
 -ObjectType null `
 -Catalog null `
 -Images null
```

- Convert the resource to JSON
```powershell
$SoftwareUcsdBundleDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

