# AssetDeviceTransactionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceTransaction"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceTransaction"]
**Action** | **String** | The action taken by Cisco Install Base on the device. | [optional] [readonly] 
**StatusDescription** | **String** | Description of status of Cisco device reported by Cisco Install Base. | [optional] [readonly] 
**StatusId** | **Int32** | Status ID of device reported by Cisco Install Base. * &#x60;0&#x60; - A default value to catch cases where device status is not correctly detected. * &#x60;10000&#x60; - Device is installed successfully. * &#x60;1010041&#x60; - Device is currently in Return Material Authorization process. * &#x60;10005&#x60; - Device is replaced successfully with another device. * &#x60;10007&#x60; - Device is returned succcessfuly. * &#x60;10009&#x60; - Device is terminated at customer&#39;s end. | [optional] [readonly] [default to 0]
**Timestamp** | **String** | Timestamp field reported by Cisco Install Base. | [optional] [readonly] 
**TransactionBatchId** | **Int64** | Transaction batch ID reported by Cisco Install Base. | [optional] [readonly] 
**TransactionDate** | **String** | Transaction Date reported by Cisco Install Base. | [optional] [readonly] 
**TransactionSequence** | **Int64** | Transaction sequence reported by Cisco Install Base. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceTransactionAllOf = Initialize-IntersightAssetDeviceTransactionAllOf  -ClassId null `
 -ObjectType null `
 -Action null `
 -StatusDescription null `
 -StatusId null `
 -Timestamp null `
 -TransactionBatchId null `
 -TransactionDate null `
 -TransactionSequence null
```

- Convert the resource to JSON
```powershell
$AssetDeviceTransactionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

