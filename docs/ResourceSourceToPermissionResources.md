# ResourceSourceToPermissionResources
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.SourceToPermissionResources"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.SourceToPermissionResources"]
**PermissionResources** | [**CmrfCmRf[]**](CmrfCmRf.md) |  | [optional] 
**SourceObject** | [**CmrfCmRf**](CmrfCmRf.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceSourceToPermissionResources = Initialize-IntersightResourceSourceToPermissionResources  -ClassId null `
 -ObjectType null `
 -PermissionResources null `
 -SourceObject null
```

- Convert the resource to JSON
```powershell
$ResourceSourceToPermissionResources | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

