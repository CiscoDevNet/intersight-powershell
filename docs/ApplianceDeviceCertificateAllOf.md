# ApplianceDeviceCertificateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.DeviceCertificate"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.DeviceCertificate"]
**CaCertificate** | **String** | The base64 encoded certificate in PEM format. | [optional] [readonly] 
**CaCertificateExpiryTime** | **System.DateTime** | The expiry datetime of new ca certificate which need to be applied on device connector. | [optional] [readonly] 
**CertificateRenewalExpiryTime** | **System.DateTime** | The date time allocated till cert renewal will be executed. This time used here will be based on cert renewal plan. | [optional] [readonly] 
**CompletedPhases** | [**ApplianceCertRenewalPhase[]**](ApplianceCertRenewalPhase.md) |  | [optional] 
**ConfigurationMoId** | **String** | The operation configuration MOId. | [optional] 
**CurrentPhase** | [**ApplianceCertRenewalPhase**](ApplianceCertRenewalPhase.md) |  | [optional] 
**EndTime** | **System.DateTime** | End date of the certificate renewal. | [optional] [readonly] 
**LastSuccessPollTime** | **System.DateTime** | The last poll time when data collection was successfull. This time is used to collect data after this time in next cycle. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**StartTime** | **System.DateTime** | Start date of the certificate renewal. | [optional] 
**Status** | **String** | The status of ca certificate renewal. | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceDeviceCertificateAllOf = Initialize-IntersightApplianceDeviceCertificateAllOf  -ClassId null `
 -ObjectType null `
 -CaCertificate null `
 -CaCertificateExpiryTime null `
 -CertificateRenewalExpiryTime null `
 -CompletedPhases null `
 -ConfigurationMoId null `
 -CurrentPhase null `
 -EndTime null `
 -LastSuccessPollTime null `
 -Messages null `
 -StartTime null `
 -Status null
```

- Convert the resource to JSON
```powershell
$ApplianceDeviceCertificateAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

