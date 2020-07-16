# TamSecurityAdvisoryDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseScore** | **Decimal** | CVSS version 3 base score for the security Advisory. | [optional] 
**CveIds** | **String[]** |  | [optional] 
**EnvironmentalScore** | **Decimal** | CVSS version 3 environmental score for the security Advisory. | [optional] 
**Status** | **String** | Cisco assigned status of the published advisory. Depends on whether the investigation is complete or on-going. | [optional] [default to "interim"]
**TemporalScore** | **Decimal** | CVSS version 3 temporal score for the security Advisory. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamSecurityAdvisoryDetailsAllOf  -BaseScore null `
 -CveIds null `
 -EnvironmentalScore null `
 -Status null `
 -TemporalScore null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

