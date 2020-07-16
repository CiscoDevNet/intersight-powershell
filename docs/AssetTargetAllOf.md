# AssetTargetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Connections** | [**AssetConnection[]**](AssetConnection.md) |  | [optional] 
**Services** | [**AssetService[]**](AssetService.md) |  | [optional] 
**Status** | **String** | Status indicates if Intersight can establish a connection and authenticate with the managed target. Status does not include information about the functional health of the target. | [optional] [readonly] [default to ""]
**StatusErrorReason** | **String** | StatusErrorReason provides additional context for the Status. | [optional] [readonly] 
**TargetType** | **String** | The type of the managed target. For example a UCS Server or Vmware Vcenter target. | [optional] [default to ""]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Assist** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetTargetAllOf  -Connections null `
 -Services null `
 -Status null `
 -StatusErrorReason null `
 -TargetType null `
 -Account null `
 -Assist null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

