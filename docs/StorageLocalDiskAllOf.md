# StorageLocalDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.LocalDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.LocalDisk"]
**SlotNumber** | **Int64** | The slot number of the disk to be referenced. As this is a policy, this slot number may or may not be valid depending on the number of disks in the associated server. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageLocalDiskAllOf = Initialize-IntersightStorageLocalDiskAllOf  -ClassId null `
 -ObjectType null `
 -SlotNumber null
```

- Convert the resource to JSON
```powershell
$StorageLocalDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

