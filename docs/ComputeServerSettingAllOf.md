# ComputeServerSettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminLocatorLedState** | **String** | User configured state of the locator LED for the server. | [optional] [default to "None"]
**AdminPowerState** | **String** | User configured power state of the server. | [optional] [default to "Policy"]
**ConfigState** | **String** | The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server. Applying - This state denotes that the settings are being applied in the target server. Failed - This state denotes that the settings could not be applied in the target server. | [optional] [readonly] [default to "Applied"]
**OneTimeBootDevice** | **String** | The name of the device chosen by user for configuring One-Time Boot device. | [optional] 
**PersistentMemoryOperation** | [**ComputePersistentMemoryOperation**](ComputePersistentMemoryOperation.md) |  | [optional] 
**ServerConfig** | [**ComputeServerConfig**](ComputeServerConfig.md) |  | [optional] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningWorkflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeServerSettingAllOf  -AdminLocatorLedState null `
 -AdminPowerState null `
 -ConfigState null `
 -OneTimeBootDevice null `
 -PersistentMemoryOperation null `
 -ServerConfig null `
 -LocatorLed null `
 -RegisteredDevice null `
 -RunningWorkflow null `
 -Server null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

