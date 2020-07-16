# StorageBaseReplicationSchedule
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
**Frequency** | **String** | Replication frequency. It is an interval at which replication is set to trigger. Examples:     PT2H, Snapshot is generated every 2 hours.     P30D, Snapshot is scheduled for every 30 days.     PT2H34M56.123S is 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 
**Name** | **String** | Replication schedule name. | [optional] [readonly] 
**ReplicationTime** | **String** | Preferred time of day at which to replicate the snapshots on target array. It is applicable only if the replication frequency is set for a day or more. Format: hh:mm:ss Example: 15:00:00, Replication is set for 3:00 PM. | [optional] [readonly] 
**RetentionTime** | **String** | Duration to keep the replicated snapshots on the targets. Replicated snapshots are deleted from target array once the retention period has elapsed. Examples: P30D, Snapshots are available for 30 days. PT2H34M56.123S, 2 hours, 34 minutes, 56 seconds and 123 milliseconds. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseReplicationSchedule  -AccountMoid null `
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
 -Frequency null `
 -Name null `
 -ReplicationTime null `
 -RetentionTime null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

