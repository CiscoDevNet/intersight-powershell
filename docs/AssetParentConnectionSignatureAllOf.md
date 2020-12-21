# AssetParentConnectionSignatureAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ParentConnectionSignature"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ParentConnectionSignature"]
**DeviceId** | **String** | The moid of the parent device registration. | [optional] 
**NodeId** | **String** | The node identity of the parent device, corresponds to the parents ClusterMember.memberIdentity. Used on connect to establish through which device in a cluster the child is connected through. | [optional] 
**Signature** | [**SystemByte**](SystemByte.md) | The result of signing the deviceId appended with the timeStamp fields with the devices private key. | [optional] 
**TimeStamp** | **System.DateTime** | The time at which the signature was generated. Date is accurate to Intersights clock. Used to expire the signature. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetParentConnectionSignatureAllOf = Initialize-IntersightAssetParentConnectionSignatureAllOf  -ClassId null `
 -ObjectType null `
 -DeviceId null `
 -NodeId null `
 -Signature null `
 -TimeStamp null
```

- Convert the resource to JSON
```powershell
$AssetParentConnectionSignatureAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

