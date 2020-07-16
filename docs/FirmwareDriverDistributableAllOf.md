# FirmwareDriverDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **String** | The device type on which the driver is installable. | [optional] 
**Directory** | **String** | Indicates in which directory path this driver will be added. | [optional] 
**Osname** | **String** | The operating system name to which this driver is compatible. | [optional] 
**Osversion** | **String** | OS Version. It is populated as part of the image import operation. | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareDriverDistributableAllOf  -Category null `
 -Directory null `
 -Osname null `
 -Osversion null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

