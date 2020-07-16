# AssetManagedDeviceStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CloudPort** | **Int64** | Port used for the connection to the Cloud by the Device Connector for the Managed Device. | [optional] 
**ConnectionFailureReason** | **String** | Maintains the reason for the failure of connection to the Device in case of connection failure. | [optional] 
**ConnectionStatus** | **String** | Maintains the status of the connection to the Device. | [optional] [default to "Unknown"]
**ErrorCode** | **Int64** | Maintains code related to error from Device Connector, if any. | [optional] 
**ErrorReason** | **String** | Maintains the reason for the error from Device Connector, if any. | [optional] 
**ProcessId** | **Int64** | Maintains the process pid of the Device Connector for the Managed Device. | [optional] 
**ServerPort** | **Int64** | Port used for receiving requests from Intersight Assist by the Device Connector for the Managed Device. | [optional] 
**State** | **String** | Maintains the state of the Managed Device, such as Start Success, Start Failure, etc. See ManagedDeviceState for device connection states. | [optional] [default to "New"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetManagedDeviceStatus  -ClassId null `
 -ObjectType null `
 -CloudPort null `
 -ConnectionFailureReason null `
 -ConnectionStatus null `
 -ErrorCode null `
 -ErrorReason null `
 -ProcessId null `
 -ServerPort null `
 -State null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

