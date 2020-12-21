# ApplianceReleaseNoteAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.ReleaseNote"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.ReleaseNote"]
**Notes** | [**OnpremUpgradeNote[]**](OnpremUpgradeNote.md) |  | [optional] 
**Version** | **String** | Version number of the pending upgrade. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceReleaseNoteAllOf = Initialize-IntersightApplianceReleaseNoteAllOf  -ClassId null `
 -ObjectType null `
 -Notes null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ApplianceReleaseNoteAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

