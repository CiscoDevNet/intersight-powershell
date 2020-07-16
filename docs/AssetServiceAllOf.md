# AssetServiceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Options** | [**AssetServiceOptions**](AssetServiceOptions.md) |  | [optional] 
**Status** | **String** | Status indicates if the respective Service can establish a connection and authenticate with the managed target. Status does not include information about the functional health of the target. | [optional] [default to ""]
**StatusErrorReason** | **String** | When &#39;Status&#39; is not Connected, statusErrorReason provides further details about why the device is not connected with Intersight. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetServiceAllOf  -Options null `
 -Status null `
 -StatusErrorReason null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

