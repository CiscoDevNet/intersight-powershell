# SoftwareHyperflexBundleDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "software.HyperflexBundleDistributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "software.HyperflexBundleDistributable"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 
**Images** | [**SoftwareHyperflexDistributableRelationship[]**](SoftwareHyperflexDistributableRelationship.md) | An array of relationships to softwareHyperflexDistributable resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SoftwareHyperflexBundleDistributableAllOf = Initialize-IntersightSoftwareHyperflexBundleDistributableAllOf  -ClassId null `
 -ObjectType null `
 -Catalog null `
 -Images null
```

- Convert the resource to JSON
```powershell
$SoftwareHyperflexBundleDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

