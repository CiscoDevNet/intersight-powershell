# StorageNetAppClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppCluster"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppCluster"]
**Location** | **String** | Location of the storage controller. | [optional] [readonly] 
**ManagementAddress** | **String** | FQDN or IP Address of Storage Cluster. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppClusterAllOf = Initialize-IntersightStorageNetAppClusterAllOf  -ClassId null `
 -ObjectType null `
 -Location null `
 -ManagementAddress null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageNetAppClusterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

