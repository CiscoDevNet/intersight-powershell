# BiosBootDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "bios.BootDevice"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "bios.BootDevice"]
**DeviceName** | **String** | Name of the Configured Boot Device. | [optional] [readonly] 
**DeviceType** | **String** | Type of the Configured Boot Device. | [optional] [readonly] 
**BiosSystemBootOrder** | [**BiosSystemBootOrderRelationship**](BiosSystemBootOrderRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BiosBootDeviceAllOf = Initialize-IntersightBiosBootDeviceAllOf  -ClassId null `
 -ObjectType null `
 -DeviceName null `
 -DeviceType null `
 -BiosSystemBootOrder null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$BiosBootDeviceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

