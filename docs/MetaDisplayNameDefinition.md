# MetaDisplayNameDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "meta.DisplayNameDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "meta.DisplayNameDefinition"]
**Format** | **String** | A specification for constructing the displayname from the MO&#39;s properties. | [optional] [readonly] 
**IncludeAncestor** | **Boolean** | An indication of whether the displayname should be contructed &#39;recursively&#39; including the displayname of the first ancestor with a similarly named displayname. | [optional] [readonly] 
**Name** | **String** | The name of the displayname used as a key in the DisplayName map which is returned as part of an MO for a Rest request. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MetaDisplayNameDefinition = Initialize-IntersightMetaDisplayNameDefinition  -ClassId null `
 -ObjectType null `
 -Format null `
 -IncludeAncestor null `
 -Name null
```

- Convert the resource to JSON
```powershell
$MetaDisplayNameDefinition | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

