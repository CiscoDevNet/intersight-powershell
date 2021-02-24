# NiatelemetryNexusDashboardDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NexusDashboardDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NexusDashboardDetails"]
**NexusDashboardName** | **String** | Name of the NexusDashboard. | [optional] 
**NexusDashboardSerialNumber** | **String** | Serial number of NexusDashboard. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNexusDashboardDetailsAllOf = Initialize-IntersightNiatelemetryNexusDashboardDetailsAllOf  -ClassId null `
 -ObjectType null `
 -NexusDashboardName null `
 -NexusDashboardSerialNumber null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNexusDashboardDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

