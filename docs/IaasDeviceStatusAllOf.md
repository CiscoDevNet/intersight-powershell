# IaasDeviceStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.DeviceStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.DeviceStatus"]
**AccountName** | **String** | The UCSD infra account name. Account Name is created when UCSD admin adds any new infra account (Physical/Virtual/Compute/Network) to be managed by UCSD. | [optional] [readonly] 
**AccountType** | **String** | The UCSD Infra Account type. | [optional] [readonly] 
**Category** | **String** | The UCSD Infra Account category. | [optional] [readonly] 
**ClaimStatus** | **String** | Describes if the device is claimed in Intersight or not. * &#x60;Unknown&#x60; - If UCS Director managed account claim status information is unknown. * &#x60;Yes&#x60; - If UCS Director managed account is claimed in Intersight. * &#x60;No&#x60; - If UCS Director managed account is not claimed in Intersight. * &#x60;Not Applicable&#x60; - If UCS Director managed account is not capable of providing claim status information. | [optional] [readonly] [default to "Unknown"]
**ConnectionStatus** | **String** | Describes about the connection status between the UCSD and the actual end device. | [optional] [readonly] 
**DeviceModel** | **String** | Describes about the device model. | [optional] [readonly] 
**DeviceVendor** | **String** | Describes about the device vendor/manufacturer of the device. | [optional] [readonly] 
**DeviceVersion** | **String** | Describes about the current firmware version running on the device. | [optional] [readonly] 
**IpAddress** | **String** | The IPAddress of the device. | [optional] [readonly] 
**Pod** | **String** | Describes about the pod to which this device belongs to in UCSD. | [optional] [readonly] 
**PodType** | **String** | Describes about the podType of Pod to which this device belongs to in UCSD. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasDeviceStatusAllOf = Initialize-IntersightIaasDeviceStatusAllOf  -ClassId null `
 -ObjectType null `
 -AccountName null `
 -AccountType null `
 -Category null `
 -ClaimStatus null `
 -ConnectionStatus null `
 -DeviceModel null `
 -DeviceVendor null `
 -DeviceVersion null `
 -IpAddress null `
 -Pod null `
 -PodType null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$IaasDeviceStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

