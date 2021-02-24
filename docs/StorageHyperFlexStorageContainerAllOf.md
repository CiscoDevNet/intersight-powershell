# StorageHyperFlexStorageContainerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HyperFlexStorageContainer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HyperFlexStorageContainer"]
**LastAccessTime** | **System.DateTime** | Storage container&#39;s last access time. | [optional] [readonly] 
**LastModifiedTime** | **System.DateTime** | Storage container&#39;s last modified time. | [optional] [readonly] 
**ProvisionedCapacity** | **Int64** | Provisioned Capacity of the Storage container in bytes. | [optional] [readonly] 
**Type** | **String** | Storage Container type (SMB/NFS/iSCSI). * &#x60;NFS&#x60; - Storage container created/accesed through NFS protocol. * &#x60;SMB&#x60; - Storage container created/accessed through SMB protocol. * &#x60;iSCSI&#x60; - Storage container created/accessed through iSCSI protocol. | [optional] [readonly] [default to "NFS"]
**UnCompressedUsedBytes** | **Int64** | Uncompressed bytes on Storage Container. | [optional] [readonly] 
**Uuid** | **String** | Uuid of the Datastore/Storage Container. | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHyperFlexStorageContainerAllOf = Initialize-IntersightStorageHyperFlexStorageContainerAllOf  -ClassId null `
 -ObjectType null `
 -LastAccessTime null `
 -LastModifiedTime null `
 -ProvisionedCapacity null `
 -Type null `
 -UnCompressedUsedBytes null `
 -Uuid null `
 -Cluster null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHyperFlexStorageContainerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

