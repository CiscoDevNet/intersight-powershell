# UcsdBackupInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ucsd.BackupInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ucsd.BackupInfo"]
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
$UcsdBackupInfoAllOf = Initialize-IntersightUcsdBackupInfoAllOf  -ClassId null `
 -ObjectType null `
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
$UcsdBackupInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

