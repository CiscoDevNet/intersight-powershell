# NiatelemetryApicFanDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.ApicFanDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.ApicFanDetails"]
**ModelNumber** | **String** | Model number of the fan in APIC. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**SerialNumber** | **String** | Serial number of the fan in APIC. | [optional] 
**VendorName** | **String** | Vendor name of the fan in APIC. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryApicFanDetailsAllOf = Initialize-IntersightNiatelemetryApicFanDetailsAllOf  -ClassId null `
 -ObjectType null `
 -ModelNumber null `
 -RecordType null `
 -RecordVersion null `
 -SerialNumber null `
 -VendorName null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryApicFanDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

