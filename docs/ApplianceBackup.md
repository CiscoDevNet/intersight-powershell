# ApplianceBackup
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
**Filename** | **String** | Backup filename to backup or restore. | [optional] 
**Protocol** | **String** | Communication protocol used by the file server (e.g. scp or sftp). | [optional] [default to "scp"]
**RemoteHost** | **String** | Hostname of the remote file server. | [optional] 
**RemotePath** | **String** | File server directory to copy the file. | [optional] 
**RemotePort** | **Int64** | Remote TCP port on the file server (e.g. 22 for scp). | [optional] 
**Username** | **String** | Username to authenticate the fileserver. | [optional] 
**ElapsedTime** | **Int64** | Elapsed time in seconds since the backup process has started. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date and time of the backup process. | [optional] [readonly] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**Password** | **String** | Password to authenticate the fileserver. | [optional] 
**StartTime** | **System.DateTime** | Start date and time of the backup process. | [optional] [readonly] 
**Status** | **String** | Status of the backup managed object. | [optional] [readonly] [default to "Started"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceBackup  -AccountMoid null `
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
 -Filename null `
 -Protocol null `
 -RemoteHost null `
 -RemotePath null `
 -RemotePort null `
 -Username null `
 -ElapsedTime null `
 -EndTime null `
 -IsPasswordSet null `
 -Messages null `
 -Password null `
 -StartTime null `
 -Status null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

