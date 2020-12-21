# TechsupportmanagementNiaParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "techsupportmanagement.NiaParam"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "techsupportmanagement.NiaParam"]
**CollectionLevel** | **Int32** | CollectionLevel controls the size / depth of the tech support files collected. * &#x60;1&#x60; - Use cached data in the returned collection. * &#x60;2&#x60; - Use current data in the returned collection. | [optional] [default to 1]
**Filename** | **String** | Filename specifies an individual filename to collect from the endpoint. | [optional] 
**ForceFresh** | **Boolean** | ForceFresh controls whether to return pre-collected files or force the collection of new files. | [optional] 
**Pids** | **String[]** |  | [optional] 
**SerialNumbers** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TechsupportmanagementNiaParam = Initialize-IntersightTechsupportmanagementNiaParam  -ClassId null `
 -ObjectType null `
 -CollectionLevel null `
 -Filename null `
 -ForceFresh null `
 -Pids null `
 -SerialNumbers null
```

- Convert the resource to JSON
```powershell
$TechsupportmanagementNiaParam | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

