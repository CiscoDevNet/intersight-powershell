# NiatelemetryNexusDashboardMemoryDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NexusDashboardMemoryDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NexusDashboardMemoryDetails"]
**DeviceName** | **String** | Name of the node in Nexus Dashboard cluster. | [optional] 
**MemoryCapacity** | **Int64** | Memory capacity of a node in Nexus Dashboard. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNexusDashboardMemoryDetailsAllOf = Initialize-IntersightNiatelemetryNexusDashboardMemoryDetailsAllOf  -ClassId null `
 -ObjectType null `
 -DeviceName null `
 -MemoryCapacity null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNexusDashboardMemoryDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

