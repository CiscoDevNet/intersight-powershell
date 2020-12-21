# FirmwareDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.Distributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.Distributable"]
**FileLocation** | **String** | The file location of the distributable. | [optional] 
**ImageCategory** | **String** | The category into which the distributable falls into according to the supported platform series. For e.g.; C-Series/B-Series/Infrastructure. | [optional] 
**Origin** | **String** | The source of the distributable. If it has been created by the user or system. * &#x60;System&#x60; - The distributable has been created by the System. * &#x60;User&#x60; - The distributable has been created by the User. | [optional] [default to "System"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareDistributableAllOf = Initialize-IntersightFirmwareDistributableAllOf  -ClassId null `
 -ObjectType null `
 -FileLocation null `
 -ImageCategory null `
 -Origin null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$FirmwareDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

