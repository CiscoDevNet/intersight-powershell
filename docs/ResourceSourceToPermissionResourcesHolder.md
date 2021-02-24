# ResourceSourceToPermissionResourcesHolder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.SourceToPermissionResourcesHolder"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.SourceToPermissionResourcesHolder"]
**SourceToPermissionResources** | [**ResourceSourceToPermissionResources[]**](ResourceSourceToPermissionResources.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceSourceToPermissionResourcesHolder = Initialize-IntersightResourceSourceToPermissionResourcesHolder  -ClassId null `
 -ObjectType null `
 -SourceToPermissionResources null
```

- Convert the resource to JSON
```powershell
$ResourceSourceToPermissionResourcesHolder | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

