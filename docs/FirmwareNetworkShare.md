# FirmwareNetworkShare
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CifsServer** | [**FirmwareCifsServer**](FirmwareCifsServer.md) |  | [optional] 
**HttpServer** | [**FirmwareHttpServer**](FirmwareHttpServer.md) |  | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**MapType** | **String** | File server protocols such as CIFS, NFS, WWW for HTTP (S) that hosts the image. | [optional] [default to "nfs"]
**NfsServer** | [**FirmwareNfsServer**](FirmwareNfsServer.md) |  | [optional] 
**Password** | **String** | Password as configured on the file server. | [optional] 
**Upgradeoption** | **String** | Option to control the upgrade operation. Some examples, 1) nw_upgrade_mount_only - mount the image from a file server and run the upgrade on the next server boot and 2) nw_upgrade_full - mount the image and immediately run the upgrade. | [optional] [default to "nw_upgrade_full"]
**Username** | **String** | Username as configured on the file server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareNetworkShare  -ClassId null `
 -ObjectType null `
 -CifsServer null `
 -HttpServer null `
 -IsPasswordSet null `
 -MapType null `
 -NfsServer null `
 -Password null `
 -Upgradeoption null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

