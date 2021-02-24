# VirtualizationActionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.ActionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.ActionInfo"]
**FailureReason** | **String** | Description of reason for failure. Derived from the workflow failure message. | [optional] [readonly] 
**Name** | **String** | Name of the Action performed on a resource like Virtual Machine, Disk etc. | [optional] [readonly] 
**Status** | **String** | Status of the Action like InProgress, Success, Failure etc. * &#x60;None&#x60; - A place holder for the default value. * &#x60;InProgress&#x60; - Previous action triggered on the resource is still running. * &#x60;Success&#x60; - Previous action triggered on the resource has completed successfully. * &#x60;Failure&#x60; - Previous action triggered on the resource has failed. | [optional] [readonly] [default to "None"]

## Examples

- Prepare the resource
```powershell
$VirtualizationActionInfo = Initialize-IntersightVirtualizationActionInfo  -ClassId null `
 -ObjectType null `
 -FailureReason null `
 -Name null `
 -Status null
```

- Convert the resource to JSON
```powershell
$VirtualizationActionInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

