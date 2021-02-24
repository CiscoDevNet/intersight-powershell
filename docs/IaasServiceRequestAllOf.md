# IaasServiceRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.ServiceRequest"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.ServiceRequest"]
**Duration** | **String** | Service request duration. | [optional] [readonly] 
**InitiatingUser** | **String** | Service Request initiating user. | [optional] [readonly] 
**RequestEndTime** | **String** | Service request end time. | [optional] [readonly] 
**RequestId** | **String** | Service request id of an SR. | [optional] [readonly] 
**RequestStartTime** | **String** | Service request start time. | [optional] [readonly] 
**RequestType** | **String** | Service request type of an SR. | [optional] [readonly] 
**Status** | **String** | UCSD service request status. | [optional] [readonly] 
**WorkflowName** | **String** | Executed workflow name for an SR. | [optional] [readonly] 
**WorkflowSteps** | [**IaasWorkflowSteps[]**](IaasWorkflowSteps.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasServiceRequestAllOf = Initialize-IntersightIaasServiceRequestAllOf  -ClassId null `
 -ObjectType null `
 -Duration null `
 -InitiatingUser null `
 -RequestEndTime null `
 -RequestId null `
 -RequestStartTime null `
 -RequestType null `
 -Status null `
 -WorkflowName null `
 -WorkflowSteps null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$IaasServiceRequestAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

