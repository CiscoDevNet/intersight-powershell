# KubernetesActionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ActionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ActionInfo"]
**FailureReason** | **String** | Description of failure i.e. derived from the workflow failure message. | [optional] [readonly] 
**Name** | **String** | Name of the Action performed on a resource like VM, Disk etc. | [optional] [readonly] 
**Status** | **String** | Status of the Action like InProgress, Success, Failure etc. * &#x60;None&#x60; - A place holder for the default value. * &#x60;InProgress&#x60; - Action triggered on the resource is still running. * &#x60;Success&#x60; - Action triggered on the resource is completed successfully. * &#x60;Failure&#x60; - Action triggered on the resource is failed. | [optional] [readonly] [default to "None"]

## Examples

- Prepare the resource
```powershell
$KubernetesActionInfo = Initialize-IntersightKubernetesActionInfo  -ClassId null `
 -ObjectType null `
 -FailureReason null `
 -Name null `
 -Status null
```

- Convert the resource to JSON
```powershell
$KubernetesActionInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

