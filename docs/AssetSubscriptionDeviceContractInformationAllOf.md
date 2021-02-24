# AssetSubscriptionDeviceContractInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.SubscriptionDeviceContractInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.SubscriptionDeviceContractInformation"]
**DeviceId** | **String** | Unique identifier of the Cisco device. | [optional] [readonly] 
**DeviceInformation** | [**AssetDeviceInformation**](AssetDeviceInformation.md) |  | [optional] 
**DevicePid** | **String** | Product identifier for the specified Cisco device. It is used to distinguish between HyperFlex and UCS devices. | [optional] [readonly] 
**SubscriptionRefId** | **String** | Identifies the consumption-based subscription. | [optional] [readonly] 
**DeviceContractInformation** | [**AssetDeviceContractInformationRelationship**](AssetDeviceContractInformationRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetSubscriptionDeviceContractInformationAllOf = Initialize-IntersightAssetSubscriptionDeviceContractInformationAllOf  -ClassId null `
 -ObjectType null `
 -DeviceId null `
 -DeviceInformation null `
 -DevicePid null `
 -SubscriptionRefId null `
 -DeviceContractInformation null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AssetSubscriptionDeviceContractInformationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

