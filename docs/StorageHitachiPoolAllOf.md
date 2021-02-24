# StorageHitachiPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiPool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiPool"]
**BlockingModeBlockade** | **String** | Setting the protection function for a virtual volume. When the DP pool is blockade, whether the read and write operations can be performed for the DP volume that uses the target DP pool is output. Yes, read and write operations are not possible. No, read and write operations are possible. -, Thin Image pool or not available. | [optional] [readonly] 
**BlockingModeFull** | **String** | Setting the protection function for a virtual volume. When the DP pool is full, whether the read and write operations can be performed for the DP volume that uses the target DP pool is output. Yes, read and write operations are not possible. No, read and write operations are possible. -, Thin Image pool or not available. | [optional] [readonly] 
**DepletionThreshold** | **String** | The depletion threshold set for the pool (%). | [optional] [readonly] 
**IsShrinking** | **Boolean** | Whether the pool is shrinking is output. | [optional] [readonly] 
**MonitoringMode** | **String** | Performance monitoring execution mode (monitor mode). * &#x60;N/A&#x60; - Not available. * &#x60;Period mode&#x60; - Period mode. * &#x60;Continuous mode&#x60; - Continuous mode. | [optional] [readonly] [default to "N/A"]
**MonitoringStatus** | **String** | Status of monitor information. | [optional] [readonly] 
**PoolActionMode** | **String** | Execution mode for the pool. * &#x60;N/A&#x60; - Not available. * &#x60;Auto&#x60; - The mode in which the monitor is started or stopped at the specified time, and the Tier range is specified by automatic calculation of the DKC (specified by using Storage Navigator). * &#x60;Manual&#x60; - The mode in which the monitor is started or stopped by instructions from the REST API server, and the Tier range is specified by automatic calculation of the DKC. | [optional] [readonly] [default to "N/A"]
**ProgressOfReplacing** | **String** | Displays the status of the tier relocation processing. | [optional] [readonly] 
**TotalReservedCapacity** | **Int64** | Total capacity of the reserved page (bytes) of the DP volume that is related to the DP pool. | [optional] [readonly] 
**WarningThreshold** | **Int64** | The warning threshold set for the pool (%). | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiPoolAllOf = Initialize-IntersightStorageHitachiPoolAllOf  -ClassId null `
 -ObjectType null `
 -BlockingModeBlockade null `
 -BlockingModeFull null `
 -DepletionThreshold null `
 -IsShrinking null `
 -MonitoringMode null `
 -MonitoringStatus null `
 -PoolActionMode null `
 -ProgressOfReplacing null `
 -TotalReservedCapacity null `
 -WarningThreshold null `
 -Array null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

