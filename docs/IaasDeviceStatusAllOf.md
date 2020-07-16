# IaasDeviceStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **String** | The UCSD infra account name. Account Name is created when UCSD admin adds any new infra account (Physical/Virtual/Compute/Network) to be managed by UCSD. | [optional] [readonly] 
**AccountType** | **String** | The UCSD Infra Account type. | [optional] [readonly] 
**ClaimStatus** | **String** | Describes if the device is claimed in Intersight or not. | [optional] [readonly] [default to "Unknown"]
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
Initialize-IntersightIaasDeviceStatusAllOf  -AccountName null `
 -AccountType null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

