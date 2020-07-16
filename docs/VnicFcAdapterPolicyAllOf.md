# VnicFcAdapterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorDetectionTimeout** | **Int64** | Error Detection Timeout, also referred to as EDTOV, is the number of milliseconds to wait before the system assumes that an error has occurred. | [optional] 
**ErrorRecoverySettings** | [**VnicFcErrorRecoverySettings**](VnicFcErrorRecoverySettings.md) |  | [optional] 
**FlogiSettings** | [**VnicFlogiSettings**](VnicFlogiSettings.md) |  | [optional] 
**InterruptSettings** | [**VnicFcInterruptSettings**](VnicFcInterruptSettings.md) |  | [optional] 
**IoThrottleCount** | **Int64** | The maximum number of data or control I/O operations that can be pending for the virtual interface at one time. If this value is exceeded, the additional I/O operations wait in the queue until the number of pending I/O operations decreases and the additional operations can be processed. | [optional] 
**LunCount** | **Int64** | The maximum number of LUNs that the Fibre Channel driver will export or show. The maximum number of LUNs is usually controlled by the operating system running on the server. | [optional] 
**LunQueueDepth** | **Int64** | The number of commands that the HBA can send and receive in a single transmission per LUN. | [optional] 
**PlogiSettings** | [**VnicPlogiSettings**](VnicPlogiSettings.md) |  | [optional] 
**ResourceAllocationTimeout** | **Int64** | Resource Allocation Timeout, also referred to as RATOV, is the number of milliseconds to wait before the system assumes that a resource cannot be properly allocated. | [optional] 
**RxQueueSettings** | [**VnicFcQueueSettings**](VnicFcQueueSettings.md) |  | [optional] 
**ScsiQueueSettings** | [**VnicScsiQueueSettings**](VnicScsiQueueSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicFcQueueSettings**](VnicFcQueueSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicFcAdapterPolicyAllOf  -ErrorDetectionTimeout null `
 -ErrorRecoverySettings null `
 -FlogiSettings null `
 -InterruptSettings null `
 -IoThrottleCount null `
 -LunCount null `
 -LunQueueDepth null `
 -PlogiSettings null `
 -ResourceAllocationTimeout null `
 -RxQueueSettings null `
 -ScsiQueueSettings null `
 -TxQueueSettings null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

