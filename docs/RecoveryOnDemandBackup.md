# RecoveryOnDemandBackup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.OnDemandBackup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.OnDemandBackup"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | Description of the policy. | [optional] 
**Name** | **String** | Name of the concrete policy. | [optional] 
**FileNamePrefix** | **String** | The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**LocationType** | **String** | Specifies whether the backup will be stored locally or remotely. * &#x60;Network Share&#x60; - The backup is stored remotely on a separate server. * &#x60;Local Storage&#x60; - The backup is stored locally on the endpoint. | [optional] [default to "Network Share"]
**Password** | **String** | Password of Backup server. | [optional] 
**Path** | **String** | The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/. | [optional] 
**Protocol** | **String** | Protocol for transferring the backup image to the network share location. * &#x60;SCP&#x60; - Secure Copy Protocol (SCP) to access the file server. * &#x60;SFTP&#x60; - SSH File Transfer Protocol (SFTP) to access file server. * &#x60;FTP&#x60; - File Transfer Protocol (FTP) to access file server. | [optional] [default to "SCP"]
**RetentionCount** | **Int64** | Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner. | [optional] [default to 10]
**UserName** | **String** | Username for the backup server. | [optional] 
**ConfigResult** | [**RecoveryConfigResultRelationship**](RecoveryConfigResultRelationship.md) |  | [optional] 
**DeviceId** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryOnDemandBackup = Initialize-IntersightRecoveryOnDemandBackup  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -Name null `
 -FileNamePrefix null `
 -IsPasswordSet null `
 -LocationType null `
 -Password null `
 -Path null `
 -Protocol null `
 -RetentionCount null `
 -UserName null `
 -ConfigResult null `
 -DeviceId null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$RecoveryOnDemandBackup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

