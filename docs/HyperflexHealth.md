# HyperflexHealth
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.Health"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.Health"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**ArbitrationServiceState** | **String** | The status of the HyperFlex cluster&#39;s connection to the Intersight arbitration service. The arbitration service state is only applicable to 2-node edge clusters. * &#x60;NOT_AVAILABLE&#x60; - The cluster does not require a connection to the arbitration service. * &#x60;UNKNOWN&#x60; - The cluster&#39;s connection state to the arbitration service cannot be determined. * &#x60;ONLINE&#x60; - The cluster is connected to the arbitration service. * &#x60;OFFLINE&#x60; - The cluster is disconnected from the arbitration service. | [optional] [readonly] [default to "NOT_AVAILABLE"]
**DataReplicationCompliance** | **String** | The HyperFlex cluster&#39;s compliance to the configured replication factor. It indicates that the compliance has degraded if the number of copies of data is reduced. * &#x60;UNKNOWN&#x60; - The replication compliance of the HyperFlex cluster is not known. * &#x60;COMPLIANT&#x60; - The HyperFlex cluster is compliant with the replication policy. All data on the cluster is replicated according to the configured replication factor. * &#x60;NON_COMPLIANT&#x60; - The HyperFlex cluster is not compliant with the replication policy. Some data on the cluster is not replicated in accordance with the configured replication factor. | [optional] [readonly] [default to "UNKNOWN"]
**ResiliencyDetails** | [**HyperflexHxResiliencyInfoDt**](HyperflexHxResiliencyInfoDt.md) |  | [optional] 
**State** | **String** | The operational status of the HyperFlex cluster. * &#x60;UNKNOWN&#x60; - The operational status of the cluster cannot be determined. * &#x60;ONLINE&#x60; - The HyperFlex cluster is online and is performing IO operations. * &#x60;OFFLINE&#x60; - The HyperFlex cluster is offline and is not ready to perform IO operations. * &#x60;ENOSPACE&#x60; - The HyperFlex cluster is out of available storage capacity and cannot perform write transactions. * &#x60;READONLY&#x60; - The HyperFlex cluster is not accepting write transactions, but can still display static cluster information. | [optional] [readonly] [default to "UNKNOWN"]
**Uuid** | **String** | The unique identifier for the cluster. | [optional] [readonly] 
**ZkHealth** | **String** | The health status of the HyperFlex cluster&#39;s zookeeper ensemble. * &#x60;NOT_AVAILABLE&#x60; - The operational status of the ZK ensemble is not provided by the HyperFlex cluster. * &#x60;UNKNOWN&#x60; - The operational status of the ZK ensemble cannot be determined. * &#x60;ONLINE&#x60; - The ZK ensemble is online and operational. * &#x60;OFFLINE&#x60; - The ZK ensemble is offline and not operational. | [optional] [readonly] [default to "NOT_AVAILABLE"]
**ZoneResiliencyList** | [**HyperflexHxZoneResiliencyInfoDt[]**](HyperflexHxZoneResiliencyInfoDt.md) |  | [optional] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealth = Initialize-IntersightHyperflexHealth  -ClassId null `
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
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -ArbitrationServiceState null `
 -DataReplicationCompliance null `
 -ResiliencyDetails null `
 -State null `
 -Uuid null `
 -ZkHealth null `
 -ZoneResiliencyList null `
 -Cluster null
```

- Convert the resource to JSON
```powershell
$HyperflexHealth | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

