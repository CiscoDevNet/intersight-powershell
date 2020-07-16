# HyperflexClusterRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**CapacityRunway** | **Int64** | The number of days remaining before the cluster&#39;s storage utilization reaches the recommended capacity limit of 76%. Default value is math.MaxInt32 to indicate that the capacity runway is &quot;&quot;Unknown&quot;&quot; for a cluster that is not connected or with not sufficient data. | [optional] [readonly] 
**ClusterName** | **String** | The name of this HyperFlex cluster. | [optional] [readonly] 
**ClusterType** | **Int64** | The storage type of this cluster (All Flash or Hybrid). | [optional] [readonly] 
**ClusterUuid** | **String** | The unique identifier for this HyperFlex cluster. | [optional] [readonly] 
**ComputeNodeCount** | **Int64** | The number of compute nodes that belong to this cluster. | [optional] [readonly] 
**ConvergedNodeCount** | **Int64** | The number of converged nodes that belong to this cluster. | [optional] [readonly] 
**DeploymentType** | **String** | The deployment type of the HyperFlex cluster. The cluster can have one of the following configurations: 1. Datacenter: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes on a single site. 2. Stretched Cluster: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes distributed across multiple sites. 3. Edge: The HyperFlex cluster consists of 2-4 standalone nodes. If the cluster is running a HyperFlex Data Platform version less than 4.0 or if the deployment type cannot be determined, the deployment type is set as &#39;NA&#39; (not available). | [optional] [readonly] [default to "NA"]
**DeviceId** | **String** | The unique identifier of the device registration that represents this HyperFlex cluster&#39;s connection to Intersight. | [optional] [readonly] 
**FltAggr** | **Int64** | The number of yellow (warning) and red (critical) alarms stored as an aggregate. The first 16 bits indicate the number of red alarms, and the last 16 bits contain the number of yellow alarms. | [optional] [readonly] 
**HxVersion** | **String** | The HyperFlex Data Platform version of this cluster. | [optional] [readonly] 
**HxdpBuildVersion** | **String** | The version and build number of the HyperFlex Data Platform for this cluster. After a cluster upgrade, this version string will be updated on the next inventory cycle to reflect the newly installed version. | [optional] [readonly] 
**HypervisorType** | **String** | The type of hypervisor running on this cluster. | [optional] [readonly] [default to "ESXi"]
**HypervisorVersion** | **String** | The version of hypervisor running on this cluster. | [optional] [readonly] 
**Summary** | [**HyperflexSummary**](HyperflexSummary.md) |  | [optional] 
**UtilizationPercentage** | **Double** | The storage utilization percentage is computed based on total capacity and current capacity utilization. | [optional] [readonly] 
**UtilizationTrendPercentage** | **Double** | The storage utilization trend percentage represents the trend in percentage computed using the first and last point from historical data. | [optional] [readonly] 
**VmCount** | **Int64** | The number of virtual machines present on this cluster. | [optional] [readonly] 
**Alarm** | [**HyperflexAlarmRelationship[]**](HyperflexAlarmRelationship.md) | An array of relationships to hyperflexAlarm resources. | [optional] [readonly] 
**Health** | [**HyperflexHealthRelationship**](HyperflexHealthRelationship.md) |  | [optional] 
**Nodes** | [**HyperflexNodeRelationship[]**](HyperflexNodeRelationship.md) | An array of relationships to hyperflexNode resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexClusterRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -CapacityRunway null `
 -ClusterName null `
 -ClusterType null `
 -ClusterUuid null `
 -ComputeNodeCount null `
 -ConvergedNodeCount null `
 -DeploymentType null `
 -DeviceId null `
 -FltAggr null `
 -HxVersion null `
 -HxdpBuildVersion null `
 -HypervisorType null `
 -HypervisorVersion null `
 -Summary null `
 -UtilizationPercentage null `
 -UtilizationTrendPercentage null `
 -VmCount null `
 -Alarm null `
 -Health null `
 -Nodes null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

