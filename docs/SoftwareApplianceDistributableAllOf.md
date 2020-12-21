# SoftwareApplianceDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "software.ApplianceDistributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "software.ApplianceDistributable"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwareApplianceDistributableAllOf = Initialize-IntersightSoftwareApplianceDistributableAllOf  -ClassId null `
 -ObjectType null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$SoftwareApplianceDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

