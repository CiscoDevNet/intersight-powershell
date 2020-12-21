# ManagementEntityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "management.Entity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "management.Entity"]
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
$ManagementEntityAllOf = Initialize-IntersightManagementEntityAllOf  -ClassId null `
 -ObjectType null `
 -ClusterLinkState null `
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
$ManagementEntityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

