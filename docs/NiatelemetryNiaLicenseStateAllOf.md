# NiatelemetryNiaLicenseStateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaLicenseState"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaLicenseState"]
**FeatureActivated** | **String** | Features activated on device being inventoried. This determines which features are currently enabled on the device that the license API can check. | [optional] 
**LicenseActivated** | **String** | Licenses activated on device being inventoried. This determines which lienceses are currently enabled on the device. | [optional] 
**PidType** | **String** | PID of device being inventoried. This determines the hardware model type of the device. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**Serial** | **String** | Serial number of device being inventoried. The serial number is unique per device. | [optional] 
**Device** | [**NiatelemetryNiaInventoryRelationship**](NiatelemetryNiaInventoryRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNiaLicenseStateAllOf = Initialize-IntersightNiatelemetryNiaLicenseStateAllOf  -ClassId null `
 -ObjectType null `
 -FeatureActivated null `
 -LicenseActivated null `
 -PidType null `
 -RecordType null `
 -RecordVersion null `
 -Serial null `
 -Device null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNiaLicenseStateAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

