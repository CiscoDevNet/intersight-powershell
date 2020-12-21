# StorageBaseProtectionGroupSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureProtectionGroupSnapshot"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.PureProtectionGroupSnapshot"]
**CreatedTime** | **System.DateTime** | Protection group snapshot creation time. | [optional] [readonly] 
**Name** | **String** | Protection group snapshot name which represents point-in-time copy of all members in protection group. | [optional] [readonly] 
**Size** | **Int64** | Snapshot size represented in bytes. It is a cumulative size of all snapshots in a set. | [optional] [readonly] 
**Source** | **String** | Source protection group name on which the snapshot is created. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseProtectionGroupSnapshotAllOf = Initialize-IntersightStorageBaseProtectionGroupSnapshotAllOf  -ClassId null `
 -ObjectType null `
 -CreatedTime null `
 -Name null `
 -Size null `
 -Source null
```

- Convert the resource to JSON
```powershell
$StorageBaseProtectionGroupSnapshotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

