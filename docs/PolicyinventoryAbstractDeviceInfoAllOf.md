# PolicyinventoryAbstractDeviceInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "inventory.DeviceInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "inventory.DeviceInfo"]
**ConfigState** | **String** | Configuration state of server profile config context. | [optional] [readonly] 
**ControlAction** | **String** | Control action of server profile config context. | [optional] [readonly] 
**ErrorState** | **String** | Error state of server profile config context. | [optional] [readonly] 
**JobInfo** | [**PolicyinventoryJobInfo[]**](PolicyinventoryJobInfo.md) |  | [optional] 
**OperState** | **String** | Operational state of server profile config context. | [optional] [readonly] 
**ProfileMoId** | **String** | Server profile MO ID of the server. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyinventoryAbstractDeviceInfoAllOf = Initialize-IntersightPolicyinventoryAbstractDeviceInfoAllOf  -ClassId null `
 -ObjectType null `
 -ConfigState null `
 -ControlAction null `
 -ErrorState null `
 -JobInfo null `
 -OperState null `
 -ProfileMoId null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$PolicyinventoryAbstractDeviceInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

