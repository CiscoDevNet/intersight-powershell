# AssetClusterMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Leadership** | **String** | The current leadershipstate of this member. Updated by the device connector on failover or leadership change. If a member is elected as Primary within the cluster this connection will be the same as the DeviceRegistration connection. E.g a message addressed to the DeviceRegistration will be forwarded to the ClusterMember connection. | [optional] [readonly] [default to "Unknown"]
**LockedLeader** | **Boolean** | Devices lock their leadership on failure to heartbeat with peers. Value acts as a third party tie breaker in election between nodes. Intersight enforces that only one cluster member exists with this value set to true. | [optional] 
**MemberIdentity** | **String** | The unique identity of the member within the cluster. The identity is retrieved from the platform and reported by the device connector at connection time. | [optional] [readonly] 
**ParentClusterMemberIdentity** | **String** | The member idenity of the cluster member through which this device is connected if applicable. | [optional] [readonly] 
**Sudi** | [**AssetSudiInfo**](AssetSudiInfo.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetClusterMemberAllOf  -Leadership null `
 -LockedLeader null `
 -MemberIdentity null `
 -ParentClusterMemberIdentity null `
 -Sudi null `
 -Device null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

