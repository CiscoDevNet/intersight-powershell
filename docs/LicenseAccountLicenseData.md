# LicenseAccountLicenseData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.AccountLicenseData"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.AccountLicenseData"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**AccountId** | **String** | Root user&#39;s ID of the account. | [optional] [readonly] 
**AgentData** | **String** | Agent trusted store data. | [optional] [readonly] 
**AuthExpireTime** | **String** | Authorization expiration time. | [optional] [readonly] 
**AuthInitialTime** | **String** | Intial authorization time. | [optional] [readonly] 
**AuthNextTime** | **String** | Next time for the authorization. | [optional] [readonly] 
**Category** | **String** | Account license data category name. | [optional] [readonly] 
**DefaultLicenseType** | **String** | Default license tier set by user. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [default to "Base"]
**ErrorDesc** | **String** | The detailed error message when there is any error related to license sync of this account. | [optional] [readonly] 
**Group** | **String** | Account license data group name. | [optional] [readonly] 
**HighestCompliantLicenseTier** | **String** | The highest license tier which is in compliant of this account. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [readonly] [default to "Base"]
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
**IwoCustomerOp** | [**LicenseIwoCustomerOpRelationship**](LicenseIwoCustomerOpRelationship.md) |  | [optional] 
**IwoLicenseCount** | [**LicenseIwoLicenseCountRelationship**](LicenseIwoLicenseCountRelationship.md) |  | [optional] 
**Licenseinfos** | [**LicenseLicenseInfoRelationship[]**](LicenseLicenseInfoRelationship.md) | An array of relationships to licenseLicenseInfo resources. | [optional] 
**SmartlicenseToken** | [**LicenseSmartlicenseTokenRelationship**](LicenseSmartlicenseTokenRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseAccountLicenseData = Initialize-IntersightLicenseAccountLicenseData  -ClassId null `
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
 -Var0ClusterReplicationNetworkPolicy null `
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
 -IwoCustomerOp null `
 -IwoLicenseCount null `
 -Licenseinfos null `
 -SmartlicenseToken null
```

- Convert the resource to JSON
```powershell
$LicenseAccountLicenseData | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

