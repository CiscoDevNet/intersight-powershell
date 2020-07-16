# TechsupportmanagementTechSupportStatus
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
**FileName** | **String** | The name of the Techsupport bundle file. | [optional] 
**Reason** | **String** | Reason for techsupport failure, if any. | [optional] 
**RelayReason** | **String** | Reason for status relay failure, if any. | [optional] [readonly] 
**RelayStatus** | **String** | Status of techsupport status relay. Valid values are NoRelay, Pending, Completed, and Failed. | [optional] [readonly] 
**RequestTs** | **System.DateTime** | The time at which the techsupport request was initiated. | [optional] 
**Status** | **String** | Status of techsupport collection. Valid values are Pending, CollectionInProgress, CollectionFailed, CollectionComplete, UploadPending, UploadInProgress, UploadPartsComplete, UploadFailed and Completed. The final status will be either CollectionFailed or UploadFailed if there is a failure and Completed if the request completed successfully and the file was uploaded to Intersight Storage Service. All the remaining status values indicates the progress of techsupport collection. | [optional] 
**TechsupportDownloadUrl** | **String** | The Url to download the techsupport file. | [optional] 
**ClusterMember** | [**AssetClusterMemberRelationship**](AssetClusterMemberRelationship.md) |  | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**OriginResource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**TechSupportRequest** | [**TechsupportmanagementTechSupportBundleRelationship**](TechsupportmanagementTechSupportBundleRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTechsupportmanagementTechSupportStatus  -AccountMoid null `
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
 -FileName null `
 -Reason null `
 -RelayReason null `
 -RelayStatus null `
 -RequestTs null `
 -Status null `
 -TechsupportDownloadUrl null `
 -ClusterMember null `
 -DeviceRegistration null `
 -OriginResource null `
 -TechSupportRequest null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

