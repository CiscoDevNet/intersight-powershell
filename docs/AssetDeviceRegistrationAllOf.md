# AssetDeviceRegistrationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKeyId** | **String** | An identifier for the credential used by the device connector to authenticate with the Intersight web socket gateway. | [optional] 
**ClaimedByUserName** | **String** | The name of the user who claimed the device for the account. | [optional] [readonly] 
**ClaimedTime** | **System.DateTime** | The date and time at which the device was claimed to this account. | [optional] [readonly] 
**DeviceHostname** | **String[]** |  | [optional] 
**DeviceIpAddress** | **String[]** |  | [optional] 
**ExecutionMode** | **String** | Indicates if the platform is an actual device or an emulated device for testing, demos, etc. Permitted values are [Normal, Emulator, ContainerEmulator]. | [optional] [default to ""]
**ParentSignature** | [**AssetParentConnectionSignature**](AssetParentConnectionSignature.md) |  | [optional] 
**VarPid** | **String[]** |  | [optional] 
**PlatformType** | **String** | The platform type on which device connector is executing. | [optional] [default to ""]
**PublicAccessKey** | **String** | The device connector&#39;s public key used by Intersight to authenticate a connection from the device connector. The public key is used to verify that the signature a device connector sends on connect has been signed by the connector&#39;s private key stored on the device&#39;s filesystem. Must be a PEM encoded RSA public key string. | [optional] [readonly] 
**ReadOnly** | **Boolean** | Flag reported by devices to indicate an administrator of the device has disabled management operations of the device connector and only monitoring is permitted. | [optional] [readonly] 
**Serial** | **String[]** |  | [optional] 
**Vendor** | **String** | The vendor of the managed device. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ClaimedByUser** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 
**ClusterMembers** | [**AssetClusterMemberRelationship[]**](AssetClusterMemberRelationship.md) | An array of relationships to assetClusterMember resources. | [optional] [readonly] 
**DeviceClaim** | [**AssetDeviceClaimRelationship**](AssetDeviceClaimRelationship.md) |  | [optional] 
**DeviceConfiguration** | [**AssetDeviceConfigurationRelationship**](AssetDeviceConfigurationRelationship.md) |  | [optional] 
**DomainGroup** | [**IamDomainGroupRelationship**](IamDomainGroupRelationship.md) |  | [optional] 
**ParentConnection** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetDeviceRegistrationAllOf  -AccessKeyId null `
 -ClaimedByUserName null `
 -ClaimedTime null `
 -DeviceHostname null `
 -DeviceIpAddress null `
 -ExecutionMode null `
 -ParentSignature null `
 -VarPid null `
 -PlatformType null `
 -PublicAccessKey null `
 -ReadOnly null `
 -Serial null `
 -Vendor null `
 -Account null `
 -ClaimedByUser null `
 -ClusterMembers null `
 -DeviceClaim null `
 -DeviceConfiguration null `
 -DomainGroup null `
 -ParentConnection null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

