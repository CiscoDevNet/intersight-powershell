# FirmwareDriverDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.DriverDistributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.DriverDistributable"]
**Category** | **String** | The device type on which the driver is installable. | [optional] 
**Directory** | **String** | Indicates in which directory path this driver will be added. | [optional] 
**Osname** | **String** | The operating system name to which this driver is compatible. | [optional] 
**Osversion** | **String** | OS Version. It is populated as part of the image import operation. | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareDriverDistributableAllOf = Initialize-IntersightFirmwareDriverDistributableAllOf  -ClassId null `
 -ObjectType null `
 -Category null `
 -Directory null `
 -Osname null `
 -Osversion null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$FirmwareDriverDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

