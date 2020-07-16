# ManagementEntityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterLinkState** | **String** | Cluster link state between the Fabric Interconnects. | [optional] [readonly] 
**ClusterReadiness** | **String** | Cluster readiness of the Fabric Interconnect. | [optional] [readonly] 
**ClusterState** | **String** | Cluster state of the Fabric Interconnect. | [optional] [readonly] 
**EntityId** | **String** | Identity of the Fabric Interconnect - A/B. | [optional] [readonly] 
**Leadership** | **String** | Role (Primary / Subordinate) of the Fabric Interconnect. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightManagementEntityAllOf  -ClusterLinkState null `
 -ClusterReadiness null `
 -ClusterState null `
 -EntityId null `
 -Leadership null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

