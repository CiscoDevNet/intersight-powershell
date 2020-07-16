# NiaapiSoftwareEol
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
**AffectedVersions** | **String** | String contains the Release versions affected by this notice, seperated by comma. | [optional] 
**AnnouncementDate** | **System.DateTime** | Date time of this notice Announced. | [optional] 
**AnnouncementDateEpoch** | **Int64** | Epoch time of this notice Announced. | [optional] 
**BulletinNo** | **String** | The bulletinno of this software release end of life notice. | [optional] 
**Description** | **String** | The description of this software release end of life notice. | [optional] 
**EndofNewServiceAttachmentDate** | **System.DateTime** | Date time of End of New service attachment . | [optional] 
**EndofNewServiceAttachmentDateEpoch** | **Int64** | Epoch time of End of New service attachment . | [optional] 
**EndofServiceContractRenewalDate** | **System.DateTime** | Date time of End of Renewal of service contract . | [optional] 
**EndofServiceContractRenewalDateEpoch** | **Int64** | Epoch time of End of Renewal of service contract . | [optional] 
**EndofSwMaintenanceDate** | **System.DateTime** | Date time of End of Maintenance. | [optional] 
**EndofSwMaintenanceDateEpoch** | **Int64** | Epoch time of End of Maintenance. | [optional] 
**Headline** | **String** | The title of this software release end of life notice. | [optional] 
**LastDateofSupport** | **System.DateTime** | Date time of Last day of Support . | [optional] 
**LastDateofSupportEpoch** | **Int64** | Epoch time of Last day of Support . | [optional] 
**LastShipDate** | **System.DateTime** | Date time of Lastship Date. | [optional] 
**LastShipDateEpoch** | **Int64** | Epoch time of Lastship Date. | [optional] 
**MigrationUrl** | **String** | The URL of this migration notice. | [optional] 
**SoftwareEolUrl** | **String** | Software end of life notice URL link to the notice webpage. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiSoftwareEol  -AccountMoid null `
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
 -AffectedVersions null `
 -AnnouncementDate null `
 -AnnouncementDateEpoch null `
 -BulletinNo null `
 -Description null `
 -EndofNewServiceAttachmentDate null `
 -EndofNewServiceAttachmentDateEpoch null `
 -EndofServiceContractRenewalDate null `
 -EndofServiceContractRenewalDateEpoch null `
 -EndofSwMaintenanceDate null `
 -EndofSwMaintenanceDateEpoch null `
 -Headline null `
 -LastDateofSupport null `
 -LastDateofSupportEpoch null `
 -LastShipDate null `
 -LastShipDateEpoch null `
 -MigrationUrl null `
 -SoftwareEolUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

