# LicenseAccountLicenseData
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
**AccountId** | **String** | Root user&#39;s ID of the account. | [optional] [readonly] 
**AgentData** | **String** | Agent trusted store data. | [optional] [readonly] 
**AuthExpireTime** | **String** | Authorization expiration time. | [optional] [readonly] 
**AuthInitialTime** | **String** | Intial authorization time. | [optional] [readonly] 
**AuthNextTime** | **String** | Next time for the authorization. | [optional] [readonly] 
**Category** | **String** | Account license data category name. | [optional] [readonly] 
**DefaultLicenseType** | **String** | Default license tier set by user. | [optional] [default to "Base"]
**ErrorDesc** | **String** | The detailed error message when there is any error related to license sync of this account. | [optional] [readonly] 
**Group** | **String** | Account license data group name. | [optional] [readonly] 
**HighestCompliantLicenseTier** | **String** | The highest license tier which is in compliant of this account. | [optional] [readonly] [default to "Base"]
**LastSync** | **System.DateTime** | Specifies last sync time with SA. | [optional] [readonly] 
**LastUpdatedTime** | **System.DateTime** | Record&#39;s last update datetime. | [optional] [readonly] 
**LicenseState** | **String** | Aggregrated mode for the agent. | [optional] [readonly] 
**LicenseTechSupportInfo** | **String** | Tech-support info of a smart-agent. | [optional] [readonly] 
**RegisterExpireTime** | **String** | Registration exipiration time. | [optional] [readonly] 
**RegisterInitialTime** | **String** | Initial time of registration. | [optional] [readonly] 
**RegisterNextTime** | **String** | Next time for the license registration. | [optional] [readonly] 
**RegistrationStatus** | **String** | Registration status of a smart-agent. | [optional] [readonly] 
**RenewFailureString** | **String** | License renewal failure message. | [optional] [readonly] 
**SmartAccount** | **String** | Name of the smart account. | [optional] [readonly] 
**SyncStatus** | **String** | Current sync status for the account. | [optional] [readonly] 
**VirtualAccount** | **String** | Name of the virtual account. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**CustomerOp** | [**LicenseCustomerOpRelationship**](LicenseCustomerOpRelationship.md) |  | [optional] 
**Licenseinfos** | [**LicenseLicenseInfoRelationship[]**](LicenseLicenseInfoRelationship.md) | An array of relationships to licenseLicenseInfo resources. | [optional] 
**SmartlicenseToken** | [**LicenseSmartlicenseTokenRelationship**](LicenseSmartlicenseTokenRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightLicenseAccountLicenseData  -AccountMoid null `
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
 -AccountId null `
 -AgentData null `
 -AuthExpireTime null `
 -AuthInitialTime null `
 -AuthNextTime null `
 -Category null `
 -DefaultLicenseType null `
 -ErrorDesc null `
 -Group null `
 -HighestCompliantLicenseTier null `
 -LastSync null `
 -LastUpdatedTime null `
 -LicenseState null `
 -LicenseTechSupportInfo null `
 -RegisterExpireTime null `
 -RegisterInitialTime null `
 -RegisterNextTime null `
 -RegistrationStatus null `
 -RenewFailureString null `
 -SmartAccount null `
 -SyncStatus null `
 -VirtualAccount null `
 -Account null `
 -CustomerOp null `
 -Licenseinfos null `
 -SmartlicenseToken null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

