# VirtualizationBaseHypervisorManagerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identity** | **String** | Identity of the hypervisor (not manipulated by user). It could be a UUID too. For example, c917093f-5443-4748-bc09-eec72ded7608. | [optional] [readonly] 
**Name** | **String** | The user provided name for the hypervisor manager. For example, vCenterIreland. Usually, this name is subject to manipulation by the user. It is not the identity of the hypervisor. | [optional] 
**Version** | **String** | Release version of the Hypervisor Manger (VMware vCenter Server 6.0.0 build-4541947). | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseHypervisorManagerAllOf  -Identity null `
 -Name null `
 -Version null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

