# PkixSubjectAlternateNameAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pkix.SubjectAlternateName"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pkix.SubjectAlternateName"]
**DnsName** | **String[]** |  | [optional] 
**EmailAddress** | **String[]** |  | [optional] 
**IpAddress** | **String[]** |  | [optional] 
**Uri** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PkixSubjectAlternateNameAllOf = Initialize-IntersightPkixSubjectAlternateNameAllOf  -ClassId null `
 -ObjectType null `
 -DnsName null `
 -EmailAddress null `
 -IpAddress null `
 -Uri null
```

- Convert the resource to JSON
```powershell
$PkixSubjectAlternateNameAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

