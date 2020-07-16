# NiatelemetryNiaLicenseStateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeatureActivated** | **String** | Features activated on device being inventoried. This determines which features are currently enabled on the device that the license API can check. | [optional] 
**LicenseActivated** | **String** | Licenses activated on device being inventoried. This determines which lienceses are currently enabled on the device. | [optional] 
**PidType** | **String** | PID of device being inventoried. This determines the hardware model type of the device. | [optional] 
**Serial** | **String** | Serial number of device being inventoried. The serial number is unique per device. | [optional] 
**Device** | [**NiatelemetryNiaInventoryRelationship**](NiatelemetryNiaInventoryRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiatelemetryNiaLicenseStateAllOf  -FeatureActivated null `
 -LicenseActivated null `
 -PidType null `
 -Serial null `
 -Device null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

