# StorageNetAppStorageVmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppStorageVm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppStorageVm"]
**CifsEnabled** | **Boolean** | Status for Common Internet File System protocol ( CIFS ) allowed to run on Vservers. | [optional] [readonly] 
**FcpEnabled** | **Boolean** | Status for Fibre Channel Protocol ( FCP ) allowed to run on Vservers. | [optional] [readonly] 
**IscsiEnabled** | **Boolean** | Status for iSCSI protocol allowed to run on Vservers. | [optional] [readonly] 
**NfsEnabled** | **Boolean** | Status for Network File System Protocol ( NFS ) allowed to run on  Vservers. | [optional] [readonly] 
**NvmeEnabled** | **Boolean** | Status for NVME protocol allowed to run on Vservers. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**DiskPool** | [**StorageNetAppAggregateRelationship[]**](StorageNetAppAggregateRelationship.md) | An array of relationships to storageNetAppAggregate resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppStorageVmAllOf = Initialize-IntersightStorageNetAppStorageVmAllOf  -ClassId null `
 -ObjectType null `
 -CifsEnabled null `
 -FcpEnabled null `
 -IscsiEnabled null `
 -NfsEnabled null `
 -NvmeEnabled null `
 -Array null `
 -DiskPool null
```

- Convert the resource to JSON
```powershell
$StorageNetAppStorageVmAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

