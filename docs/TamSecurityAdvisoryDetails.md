# TamSecurityAdvisoryDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.SecurityAdvisoryDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.SecurityAdvisoryDetails"]
**Description** | **String** | Brief description of details specified for an advisory type. | [optional] 
**BaseScore** | **Double** | CVSS version 3 base score for the security Advisory. | [optional] 
**CveIds** | **String[]** |  | [optional] 
**EnvironmentalScore** | **Double** | CVSS version 3 environmental score for the security Advisory. | [optional] 
**Status** | **String** | Cisco assigned status of the published advisory. Depends on whether the investigation is complete or on-going. * &#x60;interim&#x60; - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available. * &#x60;final&#x60; - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability. | [optional] [default to "interim"]
**TemporalScore** | **Double** | CVSS version 3 temporal score for the security Advisory. | [optional] 

## Examples

- Prepare the resource
```powershell
$TamSecurityAdvisoryDetails = Initialize-IntersightTamSecurityAdvisoryDetails  -ClassId null `
 -ObjectType null `
 -Description null `
 -BaseScore null `
 -CveIds null `
 -EnvironmentalScore null `
 -Status null `
 -TemporalScore null
```

- Convert the resource to JSON
```powershell
$TamSecurityAdvisoryDetails | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

