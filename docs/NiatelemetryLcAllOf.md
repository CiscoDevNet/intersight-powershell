# NiatelemetryLcAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Lc"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Lc"]
**Description** | **String** | Description of the line cards present. | [optional] 
**Dn** | **String** | Dn value for the line cards present. | [optional] 
**HardwareVersion** | **String** | Hardware version of the line cards present. | [optional] 
**Model** | **String** | Model of the line cards present. | [optional] 
**OperationalState** | **String** | Opretaional state of the line cards present. | [optional] 
**PowerState** | **String** | Power state of the line cards present. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**RedundancyState** | **String** | Redundancy state of the line cards present. | [optional] 
**SerialNumber** | **String** | Serial number of the line card present. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryLcAllOf = Initialize-IntersightNiatelemetryLcAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Dn null `
 -HardwareVersion null `
 -Model null `
 -OperationalState null `
 -PowerState null `
 -RecordType null `
 -RecordVersion null `
 -RedundancyState null `
 -SerialNumber null `
 -SiteName null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryLcAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

