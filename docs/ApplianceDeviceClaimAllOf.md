# ApplianceDeviceClaimAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | **String** | Device identifier of the endpoint device. | [optional] [readonly] 
**Hostname** | **String** | Hostname or IP address of the endpoint device the user wants to claim. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Message** | **String** | Message set by the device claim process. | [optional] [readonly] 
**Password** | **String** | Password to be used to login to the endpoint device. | [optional] 
**PlatformType** | **String** | Platform type of the endpoint device. | [optional] [default to ""]
**RequestId** | **String** | User defined claim request identifier set by the UI. The RequestId field is not a mandatory. The Intersight Appliance will assign a unique value automatically if the field is not set. | [optional] 
**SecurityToken** | **String** | Device security token of the endpoint device. | [optional] [readonly] 
**Status** | **String** | Status of the device claim process. | [optional] [readonly] [default to "started"]
**Username** | **String** | Username to log in to the endpoint device. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceDeviceClaimAllOf  -DeviceId null `
 -Hostname null `
 -IsPasswordSet null `
 -Message null `
 -Password null `
 -PlatformType null `
 -RequestId null `
 -SecurityToken null `
 -Status null `
 -Username null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

