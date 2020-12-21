# HyperflexServerFirmwareVersionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ServerFirmwareVersion"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ServerFirmwareVersion"]
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 
**ServerFirmwareVersionEntries** | [**HyperflexServerFirmwareVersionEntryRelationship[]**](HyperflexServerFirmwareVersionEntryRelationship.md) | An array of relationships to hyperflexServerFirmwareVersionEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexServerFirmwareVersionAllOf = Initialize-IntersightHyperflexServerFirmwareVersionAllOf  -ClassId null `
 -ObjectType null `
 -AppCatalog null `
 -ServerFirmwareVersionEntries null
```

- Convert the resource to JSON
```powershell
$HyperflexServerFirmwareVersionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

