# AssetVmHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.VmHost"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.VmHost"]
**Connected** | **Int64** | The connection status of the host. 1 represents being connected and 0 represents being disconnected. | [optional] [readonly] 
**RegisteredDeviceMoid** | **String** | Reference to virtualization target device ID. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetVmHostAllOf = Initialize-IntersightAssetVmHostAllOf  -ClassId null `
 -ObjectType null `
 -Connected null `
 -RegisteredDeviceMoid null
```

- Convert the resource to JSON
```powershell
$AssetVmHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

