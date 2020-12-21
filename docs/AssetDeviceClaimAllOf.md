# AssetDeviceClaimAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceClaim"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceClaim"]
**DeviceUpdates** | [**AssetConnectionControlMessage[]**](AssetConnectionControlMessage.md) |  | [optional] 
**SecurityToken** | **String** | Obtained from the device connector management UI or API (REST endpoint &#39;/connector/SecurityTokens&#39;). | [optional] 
**SerialNumber** | **String** | Obtained from the device connector management UI or API (REST endpoint &#39;/connector/DeviceIdentifiers&#39;). | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceClaimAllOf = Initialize-IntersightAssetDeviceClaimAllOf  -ClassId null `
 -ObjectType null `
 -DeviceUpdates null `
 -SecurityToken null `
 -SerialNumber null `
 -Account null `
 -Device null
```

- Convert the resource to JSON
```powershell
$AssetDeviceClaimAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

