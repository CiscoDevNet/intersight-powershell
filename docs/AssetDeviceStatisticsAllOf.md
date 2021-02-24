# AssetDeviceStatisticsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceStatistics"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceStatistics"]
**ClusterName** | **String** | Name of the cluster. It is specified only for HyperFlex based devices. | [optional] [readonly] 
**Connected** | **Int64** | The status of the persistent connection between the device connector and Intersight, for HyperFlex or UCS device. 1 represents being connected and 0 represents being disconnected. | [optional] [readonly] 
**MembershipRatio** | **Double** | Defines the average proportion of resources used by the device within the cluster. example in a cluster having 3 nodes, the membershipRatio of each node is 1/3 or 0.33. It is specified only for HyperFlex based devices. | [optional] [readonly] 
**VmHost** | [**AssetVmHost**](AssetVmHost.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceStatisticsAllOf = Initialize-IntersightAssetDeviceStatisticsAllOf  -ClassId null `
 -ObjectType null `
 -ClusterName null `
 -Connected null `
 -MembershipRatio null `
 -VmHost null
```

- Convert the resource to JSON
```powershell
$AssetDeviceStatisticsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

