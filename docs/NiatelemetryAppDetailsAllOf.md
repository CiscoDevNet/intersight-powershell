# NiatelemetryAppDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.AppDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.AppDetails"]
**AppName** | **String** | Names of apps running on ND. | [optional] 
**AppStatus** | **String** | Status of apps running on ND. | [optional] 
**AppVersion** | **String** | Versions of apps running on ND. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryAppDetailsAllOf = Initialize-IntersightNiatelemetryAppDetailsAllOf  -ClassId null `
 -ObjectType null `
 -AppName null `
 -AppStatus null `
 -AppVersion null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryAppDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

