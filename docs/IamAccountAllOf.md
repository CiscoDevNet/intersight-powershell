# IamAccountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Account"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Account"]
**Name** | **String** | Name of the Intersight account. By default, name is same as the MoID of the account. | [optional] 
**Status** | **String** | Status of the account. To activate the Intersight account, claim a device to the account. | [optional] [readonly] 
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
$IamAccountAllOf = Initialize-IntersightIamAccountAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Status null `
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
$IamAccountAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

