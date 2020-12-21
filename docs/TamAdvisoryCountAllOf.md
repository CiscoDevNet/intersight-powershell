# TamAdvisoryCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.AdvisoryCount"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.AdvisoryCount"]
**AdvisoryCount** | **Int64** | Total number of advisories affecting the account. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TamAdvisoryCountAllOf = Initialize-IntersightTamAdvisoryCountAllOf  -ClassId null `
 -ObjectType null `
 -AdvisoryCount null `
 -Account null
```

- Convert the resource to JSON
```powershell
$TamAdvisoryCountAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

