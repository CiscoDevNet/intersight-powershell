# ApplianceCertRenewalPhaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.CertRenewalPhase"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.CertRenewalPhase"]
**EndTime** | **System.DateTime** | End date of the cert renewal phase. | [optional] [readonly] 
**Failed** | **Boolean** | Indicates if the cert renewal phase has failed or not. | [optional] [readonly] 
**Message** | **String** | Status message set during the cert renewal phase. | [optional] [readonly] 
**Name** | **String** | Name of the cert renewal phase phase. * &#x60;Init&#x60; - New certificate detected, cleanup the old process if any running. * &#x60;ScheduleCertificateAddOperation&#x60; - Certificate Add Operation Schedulled. * &#x60;WaitForCertCollectionByEndpoint&#x60; - Monitor cert collection by endpoint. * &#x60;Success&#x60; - Certificate Renewal Task Success. * &#x60;Fail&#x60; - Certificate Renewal Task Fail. * &#x60;Cancel&#x60; - Certificate Renewal Task Cancel. | [optional] [readonly] [default to "Init"]
**StartTime** | **System.DateTime** | Start date of the cert renewal phase. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceCertRenewalPhaseAllOf = Initialize-IntersightApplianceCertRenewalPhaseAllOf  -ClassId null `
 -ObjectType null `
 -EndTime null `
 -Failed null `
 -Message null `
 -Name null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$ApplianceCertRenewalPhaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

