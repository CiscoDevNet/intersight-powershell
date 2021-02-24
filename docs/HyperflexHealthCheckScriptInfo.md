# HyperflexHealthCheckScriptInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HealthCheckScriptInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HealthCheckScriptInfo"]
**AggregateScriptName** | **String** | Health check aggregate script that runs in the HyperFlex Leader Node. | It aggregates the output of all HyperFlex nodes and provides the health check result. | [optional] [readonly] 
**HyperflexVersion** | **String** | HyperFlex Data Platform version running on the target device. | [optional] [readonly] 
**ScriptExecuteLocation** | **String** | Location of the health check script&#39;s execution on the HyperFlex device. | [optional] [readonly] 
**ScriptName** | **String** | Name of the health check script to be executed. | [optional] [readonly] 
**Version** | **String** | Version of the health check script associated with the health check definition. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealthCheckScriptInfo = Initialize-IntersightHyperflexHealthCheckScriptInfo  -ClassId null `
 -ObjectType null `
 -AggregateScriptName null `
 -HyperflexVersion null `
 -ScriptExecuteLocation null `
 -ScriptName null `
 -Version null
```

- Convert the resource to JSON
```powershell
$HyperflexHealthCheckScriptInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

