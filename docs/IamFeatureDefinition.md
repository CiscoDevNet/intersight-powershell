# IamFeatureDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.FeatureDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.FeatureDefinition"]
**Feature** | **String** | The beta feature that will be enabled for specific account. * &#x60;IWO&#x60; - Intersight Workflow Optimizer. * &#x60;WebAPITarget&#x60; - An external endpoint added as Target within Intersight that can be accessed through its REST APIin Intersight Orchestrator automation workflow.Supported HTTP Authentication scheme - Basic Authentication. * &#x60;Hitachi&#x60; - Support to claim Hitachi Storage arrays using the Intersight Orchestrator framework. * &#x60;Kubernetes&#x60; - Enables ability to create and manage Kubernetes clusters. * &#x60;NetAppIO&#x60; - Support to claim NetApp Storage arrays as IO targets. * &#x60;IvsPublicCloud&#x60; - Enables virtualization service for public clouds. * &#x60;TerraformCloud&#x60; - Enables an ability to create Terraform Cloud. | [optional] [default to "IWO"]

## Examples

- Prepare the resource
```powershell
$IamFeatureDefinition = Initialize-IntersightIamFeatureDefinition  -ClassId null `
 -ObjectType null `
 -Feature null
```

- Convert the resource to JSON
```powershell
$IamFeatureDefinition | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

