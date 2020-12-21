# OnpremUpgradeNoteAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "onprem.UpgradeNote"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "onprem.UpgradeNote"]
**Message** | **String** | The change description, such as explanations of a new feature or defect resolution. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$OnpremUpgradeNoteAllOf = Initialize-IntersightOnpremUpgradeNoteAllOf  -ClassId null `
 -ObjectType null `
 -Message null
```

- Convert the resource to JSON
```powershell
$OnpremUpgradeNoteAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

