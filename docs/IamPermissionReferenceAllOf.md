# IamPermissionReferenceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.PermissionReference"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.PermissionReference"]
**PermissionIdentifier** | **String** | MOID of the permission which user has access to. | [optional] [readonly] 
**PermissionName** | **String** | Name of the permission which user has access to. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IamPermissionReferenceAllOf = Initialize-IntersightIamPermissionReferenceAllOf  -ClassId null `
 -ObjectType null `
 -PermissionIdentifier null `
 -PermissionName null
```

- Convert the resource to JSON
```powershell
$IamPermissionReferenceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

