# ComputeServerSettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.ServerSetting"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.ServerSetting"]
**AdminLocatorLedState** | **String** | User configured state of the locator LED for the server. * &#x60;None&#x60; - No operation property for locator led. * &#x60;On&#x60; - The Locator Led is turned on. * &#x60;Off&#x60; - The Locator Led is turned off. | [optional] [default to "None"]
**AdminPowerState** | **String** | User configured power state of the server. * &#x60;Policy&#x60; - Power state is set to the default value in the policy. * &#x60;PowerOn&#x60; - Power state of the server is set to On. * &#x60;PowerOff&#x60; - Power state is the server set to Off. * &#x60;PowerCycle&#x60; - Power state the server is reset. * &#x60;HardReset&#x60; - Power state the server is hard reset. * &#x60;Shutdown&#x60; - Operating system on the server is shut down. * &#x60;Reboot&#x60; - Power state of IMC is rebooted. | [optional] [default to "Policy"]
**ConfigState** | **String** | The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server. Applying - This state denotes that the settings are being applied in the target server. Failed - This state denotes that the settings could not be applied in the target server. * &#x60;Applied&#x60; - User configured settings are in applied state. * &#x60;Applying&#x60; - User settings are being applied on the target server. * &#x60;Failed&#x60; - User configured settings could not be applied. | [optional] [readonly] [default to "Applied"]
**Name** | **String** | The property used to identify the name of the server it is associated with. | [optional] [readonly] 
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
$ComputeServerSettingAllOf = Initialize-IntersightComputeServerSettingAllOf  -ClassId null `
 -ObjectType null `
 -AdminLocatorLedState null `
 -AdminPowerState null `
 -ConfigState null `
 -Name null `
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
$ComputeServerSettingAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

