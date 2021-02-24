# NiatelemetrySmartLicense
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.SmartLicense"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.SmartLicense"]
**ActiveMode** | **String** | Indicate the mode smart license is curerntly running. | [optional] 
**AuthStatus** | **String** | Authorization status of the smart license. | [optional] 
**LicenseUdi** | **String** | License Udi of the smart license. | [optional] 
**SmartAccount** | **String** | Smart licensing account name in CSSM and is retrieved from CSSM after regsitration. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetrySmartLicense = Initialize-IntersightNiatelemetrySmartLicense  -ClassId null `
 -ObjectType null `
 -ActiveMode null `
 -AuthStatus null `
 -LicenseUdi null `
 -SmartAccount null
```

- Convert the resource to JSON
```powershell
$NiatelemetrySmartLicense | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

