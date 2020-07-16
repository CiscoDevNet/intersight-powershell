# AssetManagedDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Credential** | [**CommCredential**](CommCredential.md) |  | [optional] 
**DeviceType** | **String** | Type of the Device such as VMware, Pure Storage supported by Intersight Assist. | [optional] [default to ""]
**IgnoreCert** | **Boolean** | Ignore Certificates with protocol https for connecting to the Managed Device. It is not used for other protocols. | [optional] 
**IsEnabled** | **Boolean** | Device is Enabled/Disabled. | [optional] 
**ManagementAddress** | **String** | Management address of the device. It can be IPv4, IPv6 or FQDN. | [optional] 
**Port** | **Int64** | Port to use for connecting to the Managed Device. Port is optional. If not specified, default port for protocol is used. | [optional] 
**Protocol** | **String** | Protocol to use for connecting to the Managed Device. | [optional] [default to "https"]
**Status** | [**AssetManagedDeviceStatus**](AssetManagedDeviceStatus.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**DeviceConnectorManager** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetManagedDeviceAllOf  -Credential null `
 -DeviceType null `
 -IgnoreCert null `
 -IsEnabled null `
 -ManagementAddress null `
 -Port null `
 -Protocol null `
 -Status null `
 -Account null `
 -DeviceConnectorManager null `
 -RegisteredDevice null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

