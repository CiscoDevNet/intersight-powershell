# ApplianceAppStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.AppStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.AppStatus"]
**ApiStatuses** | [**ApplianceApiStatus[]**](ApplianceApiStatus.md) |  | [optional] 
**AppLabel** | **String** | Unique label to identify the application. | [optional] [readonly] 
**OperationalStatus** | **String** | Operational status of the application. Operational status is based on the result of the status checks. If result of any check is Critical, then its value is Impaired. Otherwise, if result of any check is Warning, then its value is AttentionNeeded. If all checks are OK, then its value is Operational. * &#x60;Unknown&#x60; - Operational status of the Intersight Appliance entity is Unknown. * &#x60;Operational&#x60; - Operational status of the Intersight Appliance entity is Operational. * &#x60;Impaired&#x60; - Operational status of the Intersight Appliance entity is Impaired. * &#x60;AttentionNeeded&#x60; - Operational status of the Intersight Appliance entity is AttentionNeeded. | [optional] [readonly] [default to "Unknown"]
**ReadyCount** | **Int64** | Number of replicas ready.  The number of instances of the application currently ready to perform its intended functions. | [optional] [readonly] 
**ReplicaCount** | **Int64** | Number of replicas provisioned. The number of instances of the application provisioned to run on the Intersight appliance. | [optional] [readonly] 
**RestartCount1Hour** | **Int64** | Number of instance restarts in the last hour. | [optional] [readonly] 
**RestartCount24Hours** | **Int64** | Number of instance restarts in the last 24 hours. | [optional] [readonly] 
**RestartCount5Mins** | **Int64** | Number of instance restarts in the last 5 minutes. | [optional] [readonly] 
**RestartCountTotal** | **Int64** | Total number of restarts since last deployment. | [optional] [readonly] 
**RunningCount** | **Int64** | Number of replicas running. The number of instances of the application currently running. | [optional] [readonly] 
**StatusChecks** | [**ApplianceStatusCheck[]**](ApplianceStatusCheck.md) |  | [optional] 
**GroupStatus** | [**ApplianceGroupStatusRelationship**](ApplianceGroupStatusRelationship.md) |  | [optional] 
**SystemStatus** | [**ApplianceSystemStatusRelationship**](ApplianceSystemStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceAppStatusAllOf = Initialize-IntersightApplianceAppStatusAllOf  -ClassId null `
 -ObjectType null `
 -ApiStatuses null `
 -AppLabel null `
 -OperationalStatus null `
 -ReadyCount null `
 -ReplicaCount null `
 -RestartCount1Hour null `
 -RestartCount24Hours null `
 -RestartCount5Mins null `
 -RestartCountTotal null `
 -RunningCount null `
 -StatusChecks null `
 -GroupStatus null `
 -SystemStatus null
```

- Convert the resource to JSON
```powershell
$ApplianceAppStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

