# HyperflexHealthCheckDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HealthCheckDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HealthCheckDefinition"]
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
**Category** | **String** | Category that the health check belongs to. | [optional] 
**CommonCauses** | **String** | Static information detailing the common causes for the health check failure. | [optional] 
**Configuration** | **String** | Execution configuration fo the health check script. | [optional] 
**DefaultHealthCheckScriptInfo** | [**HyperflexHealthCheckScriptInfo**](HyperflexHealthCheckScriptInfo.md) |  | [optional] 
**Description** | **String** | Description of the health check definition. | [optional] 
**HealthCheckScriptInfos** | [**HyperflexHealthCheckScriptInfo[]**](HyperflexHealthCheckScriptInfo.md) |  | [optional] 
**HealthImpact** | **String** | Static information detailing the health impact of the health check failure. | [optional] 
**InternalName** | **String** | Internal name of the health check definition. | [optional] 
**Name** | **String** | Name of the health check definition. | [optional] 
**Reference** | **String** | Static information containing additional reference for the health check. | [optional] 
**Resolution** | **String** | Static information detailing the possible remediation actions that can be taken to remedy the health check failure. | [optional] 
**ScriptExecutionMode** | **String** | Execution mode of the health script on the HyperFlex cluster. * &#x60;ON_DEMAND&#x60; - Execute the health check on-demand. * &#x60;SCHEDULED&#x60; - Execute the health check on a scheduled interval. | [optional] [default to "ON_DEMAND"]
**ScriptExecutionOnComputeNodes** | **Boolean** | Indicates if the script needs to be executed on HyperFlex compute nodes. | Typically, scripts are only executed on the storage Nodes. | [optional] 
**TargetExecutionType** | **String** | Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster. * &#x60;EXECUTE_ON_LEADER_NODE&#x60; - Execute the health check script only on the HyperFlex cluster&#39;s leader node. * &#x60;EXECUTE_ON_ALL_NODES&#x60; - Execute health check on all nodes and aggregate the results. * &#x60;EXECUTE_ON_ALL_NODES_AND_AGGREGATE&#x60; - Execute the health check on all Nodes and perform custom aggregation. | [optional] [default to "EXECUTE_ON_LEADER_NODE"]
**Timeout** | **Int64** | Health check script execution timeout. | [optional] 
**UnsupportedHyperFlexVersions** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealthCheckDefinition = Initialize-IntersightHyperflexHealthCheckDefinition  -ClassId null `
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
 -Category null `
 -CommonCauses null `
 -Configuration null `
 -DefaultHealthCheckScriptInfo null `
 -Description null `
 -HealthCheckScriptInfos null `
 -HealthImpact null `
 -InternalName null `
 -Name null `
 -Reference null `
 -Resolution null `
 -ScriptExecutionMode null `
 -ScriptExecutionOnComputeNodes null `
 -TargetExecutionType null `
 -Timeout null `
 -UnsupportedHyperFlexVersions null
```

- Convert the resource to JSON
```powershell
$HyperflexHealthCheckDefinition | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

