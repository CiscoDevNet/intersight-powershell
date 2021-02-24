# TechsupportmanagementPlatformParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "techsupportmanagement.PlatformParam"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "techsupportmanagement.PlatformParam"]
**CollectionType** | **Int32** | CollectionType specifies if basic or detailed techsupport needs to be collected. * &#x60;1&#x60; - Collect basic techsupport. * &#x60;2&#x60; - Collect detailed techsupport. | [optional] [default to 1]
**IncludeCore** | **Boolean** | Controls whether to include core file in the techsupport bundle. | [optional] 

## Examples

- Prepare the resource
```powershell
$TechsupportmanagementPlatformParam = Initialize-IntersightTechsupportmanagementPlatformParam  -ClassId null `
 -ObjectType null `
 -CollectionType null `
 -IncludeCore null
```

- Convert the resource to JSON
```powershell
$TechsupportmanagementPlatformParam | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

