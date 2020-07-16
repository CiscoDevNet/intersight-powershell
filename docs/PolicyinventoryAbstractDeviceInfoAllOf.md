# PolicyinventoryAbstractDeviceInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightPolicyinventoryAbstractDeviceInfoAllOf  -ConfigState null `
 -ControlAction null `
 -ErrorState null `
 -JobInfo null `
 -OperState null `
 -ProfileMoId null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

