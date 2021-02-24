# IamIpAccessManagementAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.IpAccessManagement"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.IpAccessManagement"]
**Enable** | **Boolean** | Flag stores the state of IP address based access management. Access management is enabled when it&#39;s true. | [optional] 
**LastRecoveryTime** | **System.DateTime** | The access to account gets locked out if wrong IP addresses are configured. Account Administrators have privilege to unblock the account. It stores the time when the account was last recovered from lock out. | [optional] [readonly] 
**Holder** | [**IamSecurityHolderRelationship**](IamSecurityHolderRelationship.md) |  | [optional] 
**IpAddresses** | [**IamIpAddressRelationship[]**](IamIpAddressRelationship.md) | An array of relationships to iamIpAddress resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IamIpAccessManagementAllOf = Initialize-IntersightIamIpAccessManagementAllOf  -ClassId null `
 -ObjectType null `
 -Enable null `
 -LastRecoveryTime null `
 -Holder null `
 -IpAddresses null
```

- Convert the resource to JSON
```powershell
$IamIpAccessManagementAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

