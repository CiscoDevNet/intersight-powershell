# NiatelemetryFaultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Fault"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Fault"]
**Code** | **String** | Code of the fault present. | [optional] 
**Description** | **String** | Description of the fault present. | [optional] 
**Dn** | **String** | Dn value for the fault present. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**Severity** | **String** | Severity of the fault present. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters/sites. | [optional] 
**Type** | **String** | Type of the fault present. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryFaultAllOf = Initialize-IntersightNiatelemetryFaultAllOf  -ClassId null `
 -ObjectType null `
 -Code null `
 -Description null `
 -Dn null `
 -RecordType null `
 -RecordVersion null `
 -Severity null `
 -SiteName null `
 -Type null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryFaultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

