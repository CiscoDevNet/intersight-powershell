# IamAccountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name of the Intersight account. By default, name is same as the MoID of the account. | [optional] 
**Status** | **String** | Status of the account. To activate the Intersight account, claim a device to the account. | [optional] [readonly] 
**Var0LicenseReservationOp** | [**LicenseLicenseReservationOpRelationship**](LicenseLicenseReservationOpRelationship.md) |  | [optional] 
**AppRegistrations** | [**IamAppRegistrationRelationship[]**](IamAppRegistrationRelationship.md) | An array of relationships to iamAppRegistration resources. | [optional] [readonly] 
**DomainGroups** | [**IamDomainGroupRelationship[]**](IamDomainGroupRelationship.md) | An array of relationships to iamDomainGroup resources. | [optional] [readonly] 
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**Idpreferences** | [**IamIdpReferenceRelationship[]**](IamIdpReferenceRelationship.md) | An array of relationships to iamIdpReference resources. | [optional] [readonly] 
**Idps** | [**IamIdpRelationship[]**](IamIdpRelationship.md) | An array of relationships to iamIdp resources. | [optional] [readonly] 
**Permissions** | [**IamPermissionRelationship[]**](IamPermissionRelationship.md) | An array of relationships to iamPermission resources. | [optional] [readonly] 
**PrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] [readonly] 
**Privileges** | [**IamPrivilegeRelationship[]**](IamPrivilegeRelationship.md) | An array of relationships to iamPrivilege resources. | [optional] [readonly] 
**ResourceLimits** | [**IamResourceLimitsRelationship**](IamResourceLimitsRelationship.md) |  | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] [readonly] 
**SecurityHolder** | [**IamSecurityHolderRelationship**](IamSecurityHolderRelationship.md) |  | [optional] 
**SessionLimits** | [**IamSessionLimitsRelationship**](IamSessionLimitsRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamAccountAllOf  -Name null `
 -Status null `
 -Var0LicenseReservationOp null `
 -AppRegistrations null `
 -DomainGroups null `
 -EndPointRoles null `
 -Idpreferences null `
 -Idps null `
 -Permissions null `
 -PrivilegeSets null `
 -Privileges null `
 -ResourceLimits null `
 -Roles null `
 -SecurityHolder null `
 -SessionLimits null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

