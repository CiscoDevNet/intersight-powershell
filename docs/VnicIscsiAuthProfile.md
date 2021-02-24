# VnicIscsiAuthProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.IscsiAuthProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.IscsiAuthProfile"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | Password of Initiator/Target Interface. Enter between 12 and 16 characters, including special characters except spaces, tabs, line breaks. | [optional] 
**UserId** | **String** | User Id of Initiator/Target Interface. Enter between 1 and 128 characters, spaces, or special characters. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicIscsiAuthProfile = Initialize-IntersightVnicIscsiAuthProfile  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -Password null `
 -UserId null
```

- Convert the resource to JSON
```powershell
$VnicIscsiAuthProfile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

