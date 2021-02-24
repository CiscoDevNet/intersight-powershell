# ApplianceAppStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.AppStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.AppStatus"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
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
$ApplianceAppStatus = Initialize-IntersightApplianceAppStatus  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
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
$ApplianceAppStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

