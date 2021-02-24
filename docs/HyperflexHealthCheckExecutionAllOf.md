# HyperflexHealthCheckExecutionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HealthCheckExecution"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HealthCheckExecution"]
**Category** | **String** | Category that the HyperFlex health check Definition belongs to. | [optional] [readonly] 
**Cause** | **String** | Information detailing the possible cause of the healthcheck failure, if the check fails. | [optional] 
**CompletionTime** | **System.DateTime** | Health check execution completion time. | [optional] [readonly] 
**HealthCheckDetails** | **String** | Details of the health check execution result. | [optional] [readonly] 
**HealthCheckExecutionErrorDetails** | **String** | Error details of a script execution failure. | [optional] [readonly] 
**HealthCheckExecutionErrorSummary** | **String** | Error summary of a script execution failure. | [optional] [readonly] 
**HealthCheckExecutionStatus** | **String** | Status of the health check execution. * &#x60;UNKNOWN&#x60; - Indicates that the health heck execution results are unknown. * &#x60;SUCCEEDED&#x60; - Indicates that the health check execution succeeded. * &#x60;FAILED&#x60; - Indicates that the health check execution failed. * &#x60;TIMED_OUT&#x60; - Indicates that the health check execution timed out before completion. | [optional] [readonly] [default to "UNKNOWN"]
**HealthCheckResult** | **String** | Health check execution result. Valid only if HealthCheckExecutionStatus is SUCCEEDED. * &#x60;UNKNOWN&#x60; - Indicates that the health check results could not be determined. * &#x60;PASS&#x60; - Indicates that the health check passed. * &#x60;FAIL&#x60; - Indicates that the health check failed. * &#x60;WARN&#x60; - Indicates that the health check completed with a warning. * &#x60;NOT_APPLICABLE&#x60; - Indicates that the health check is either unsupported, or not applicable on the Cluster. | [optional] [readonly] [default to "UNKNOWN"]
**HealthCheckSummary** | **String** | A brief summary of health check results. | [optional] [readonly] 
**HxDeviceName** | **String** | HyperFlex Device Name where the healthcheck is executed. | [optional] [readonly] 
**Uuid** | **String** | UUID of an instance of health check execution. | [optional] [readonly] 
**HealthCheckDefinition** | [**HyperflexHealthCheckDefinitionRelationship**](HyperflexHealthCheckDefinitionRelationship.md) |  | [optional] 
**HxCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealthCheckExecutionAllOf = Initialize-IntersightHyperflexHealthCheckExecutionAllOf  -ClassId null `
 -ObjectType null `
 -Category null `
 -Cause null `
 -CompletionTime null `
 -HealthCheckDetails null `
 -HealthCheckExecutionErrorDetails null `
 -HealthCheckExecutionErrorSummary null `
 -HealthCheckExecutionStatus null `
 -HealthCheckResult null `
 -HealthCheckSummary null `
 -HxDeviceName null `
 -Uuid null `
 -HealthCheckDefinition null `
 -HxCluster null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$HyperflexHealthCheckExecutionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

