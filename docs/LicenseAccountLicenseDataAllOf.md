# LicenseAccountLicenseDataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightLicenseAccountLicenseDataAllOf  -AccountId null `
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

