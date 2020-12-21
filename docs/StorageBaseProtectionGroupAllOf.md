# StorageBaseProtectionGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureProtectionGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureProtectionGroup"]
**Name** | **String** | Name of the protection Group. | [optional] 
**Prefix** | **String** | Prefix used for all generated snapshots from the protection group. | [optional] 
**ReplicationEnabled** | **Boolean** | Flag to determine if replication is enabled. Snapshots are replicated to the target array if this flag is set. | [optional] 
**SnapshotEnabled** | **Boolean** | Flag to determine if snapshot creation is enabled. Snapshots are created on local array if this flag is set. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageBaseProtectionGroupAllOf = Initialize-IntersightStorageBaseProtectionGroupAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Prefix null `
 -ReplicationEnabled null `
 -SnapshotEnabled null
```

- Convert the resource to JSON
```powershell
$StorageBaseProtectionGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

