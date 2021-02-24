# InfraMetaDataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "infra.MetaData"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "infra.MetaData"]
**Name** | **String** | Name of the meta property which identifies a specific resource. | [optional] [readonly] 
**Value** | **String** | Value of the meta property which identifies a specific resource. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$InfraMetaDataAllOf = Initialize-IntersightInfraMetaDataAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Value null
```

- Convert the resource to JSON
```powershell
$InfraMetaDataAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

