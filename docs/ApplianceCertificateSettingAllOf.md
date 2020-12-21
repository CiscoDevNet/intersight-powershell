# ApplianceCertificateSettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.CertificateSetting"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.CertificateSetting"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Certificate** | [**IamCertificateRelationship**](IamCertificateRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceCertificateSettingAllOf = Initialize-IntersightApplianceCertificateSettingAllOf  -ClassId null `
 -ObjectType null `
 -Account null `
 -Certificate null
```

- Convert the resource to JSON
```powershell
$ApplianceCertificateSettingAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

