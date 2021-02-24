# StorageBaseSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**CreatedTime** | **System.DateTime** | Exact date and time at which snapshot was created. | [optional] [readonly] 
**Name** | **String** | Name of the snapshot which represents point-in-time copy of volume. | [optional] [readonly] 
**ProtectionGroupName** | **String** | Name of the protection group to which the snapshot belongs. Value is empty, if the snapshot is created directly on volume. | [optional] [readonly] 
**Size** | **Int64** | Snapshot size represented in bytes. | [optional] [readonly] 
**Source** | **String** | Source object on which the snapshot is created. It is the name of the originating volume. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseSnapshotAllOf = Initialize-IntersightStorageBaseSnapshotAllOf  -ClassId null `
 -ObjectType null `
 -CreatedTime null `
 -Name null `
 -ProtectionGroupName null `
 -Size null `
 -Source null
```

- Convert the resource to JSON
```powershell
$StorageBaseSnapshotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

