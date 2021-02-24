# NiatelemetryNexusDashboardControllerDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NexusDashboardControllerDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NexusDashboardControllerDetails"]
**SiteHealth** | **Int64** | Health of the site serviced by ND. | [optional] 
**SiteName** | **String** | Name of fabric domain of the controller. | [optional] 
**VersionOfController** | **String** | Version of the controller serviced by ND. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNexusDashboardControllerDetailsAllOf = Initialize-IntersightNiatelemetryNexusDashboardControllerDetailsAllOf  -ClassId null `
 -ObjectType null `
 -SiteHealth null `
 -SiteName null `
 -VersionOfController null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNexusDashboardControllerDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

