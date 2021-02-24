# HyperflexDatastoreInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.DatastoreInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.DatastoreInfo"]
**DsBackendId** | **String** | This datastore&#39;s backend unique id. | [optional] [readonly] 
**DsFrontendId** | **String** | This datastore&#39;s frontend id. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexDatastoreInfoAllOf = Initialize-IntersightHyperflexDatastoreInfoAllOf  -ClassId null `
 -ObjectType null `
 -DsBackendId null `
 -DsFrontendId null
```

- Convert the resource to JSON
```powershell
$HyperflexDatastoreInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

