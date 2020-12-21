# FirmwareFirmwareInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.FirmwareInventory"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.FirmwareInventory"]
**Category** | **String** | Component category. For example, MRAID is under storage controller, CIMC is under management controller. | [optional] 
**Label** | **String** | The name of the component to reflect on UI. | [optional] 
**Model** | **String** | Model deatils of component. | [optional] 
**UpdateUri** | **String** | The redfish URI to get the firmware inventory of server components. | [optional] 
**Vendor** | **String** | The vendor of the component. | [optional] 
**Version** | **String** | The firmware running version on the component. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareFirmwareInventoryAllOf = Initialize-IntersightFirmwareFirmwareInventoryAllOf  -ClassId null `
 -ObjectType null `
 -Category null `
 -Label null `
 -Model null `
 -UpdateUri null `
 -Vendor null `
 -Version null
```

- Convert the resource to JSON
```powershell
$FirmwareFirmwareInventoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

