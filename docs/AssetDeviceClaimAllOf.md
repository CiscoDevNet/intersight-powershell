# AssetDeviceClaimAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceUpdates** | [**AssetConnectionControlMessage[]**](AssetConnectionControlMessage.md) |  | [optional] 
**SecurityToken** | **String** | Obtained from the device connector management UI or API (REST endpoint &#39;/connector/SecurityTokens&#39;). | [optional] 
**SerialNumber** | **String** | Obtained from the device connector management UI or API (REST endpoint &#39;/connector/DeviceIdentifiers&#39;). | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetDeviceClaimAllOf  -DeviceUpdates null `
 -SecurityToken null `
 -SerialNumber null `
 -Account null `
 -Device null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

