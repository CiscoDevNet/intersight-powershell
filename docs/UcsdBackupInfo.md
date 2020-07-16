# UcsdBackupInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**BackupFileName** | **String** | Auto generated backup File Name with combination of file prefix given an user input and the timestamp. | [optional] [readonly] 
**BackupLocation** | **String** | Backup location that contains the backup images for end device which can be used for restore operation. | [optional] [readonly] 
**BackupServerIp** | **String** | Backup server where backup images are maintained. | [optional] [readonly] 
**BackupSize** | **Int64** | Size of the backup image in bytes. | [optional] [readonly] 
**Connectors** | [**UcsdConnectorPack[]**](UcsdConnectorPack.md) |  | [optional] 
**Duration** | **Int64** | Time taken for the backup to be completed. | [optional] [readonly] 
**EncryptionKey** | **String** | The key used for encrypting the backup file. | [optional] 
**FailureReason** | **String** | Reason for backup failure. | [optional] [readonly] 
**IsPurged** | **Boolean** | Backup image got purged or not. The backup images get purged based on the retention count set by the user in the backup config policy. | [optional] [readonly] 
**LastModified** | **System.DateTime** | Last modified time when this backup record got updated. | [optional] [readonly] 
**PercentageCompletion** | **Int64** | Backup current precentage completion status information. | [optional] [readonly] 
**ProductVersion** | **String** | The end device product version when the backup image was taken. | [optional] 
**Protocol** | **String** | Protocol used for the remote backup. possible values are FTP, SCP and SFTP. Not applicable for the localhost (127.0.0.1). | [optional] [readonly] 
**StageCompletion** | **String** | Backup current status stage information. | [optional] [readonly] 
**StartTime** | **System.DateTime** | Start time of backup when it got initiated. | [optional] [readonly] 
**Status** | **String** | Current status of Backup current. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUcsdBackupInfo  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -RegisteredDevice null `
 -BackupFileName null `
 -BackupLocation null `
 -BackupServerIp null `
 -BackupSize null `
 -Connectors null `
 -Duration null `
 -EncryptionKey null `
 -FailureReason null `
 -IsPurged null `
 -LastModified null `
 -PercentageCompletion null `
 -ProductVersion null `
 -Protocol null `
 -StageCompletion null `
 -StartTime null `
 -Status null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

