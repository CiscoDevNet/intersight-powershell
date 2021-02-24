# IaasUcsdInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.UcsdInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.UcsdInfo"]
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
**DeviceId** | **String** | Moid of the UCS Director device connector&#39;s asset.DeviceRegistration. | [optional] [readonly] 
**Guid** | **String** | Unique ID of UCS Director getting registerd with Intersight. | [optional] [readonly] 
**HostName** | **String** | The UCS Director hostname for management. | [optional] [readonly] 
**Ip** | **String** | The UCS Director IP address for management. | [optional] [readonly] 
**LastBackup** | **System.DateTime** | Last successful backup created for this UCS Director appliance if backup is configured. | [optional] [readonly] 
**NodeType** | **String** | NodeType specifies if UCS Director is deployed in Stand-alone or Multi Node. | [optional] [readonly] 
**ProductName** | **String** | The UCS Director product name. | [optional] [readonly] 
**ProductVendor** | **String** | The UCS Director product vendor. | [optional] [readonly] 
**ProductVersion** | **String** | The UCS Director product/platform version. | [optional] [readonly] 
**Status** | **String** | The UCS Director status. Possible values are Active, Inactive, Unknown. | [optional] [readonly] 
**ConnectorPack** | [**IaasConnectorPackRelationship[]**](IaasConnectorPackRelationship.md) | An array of relationships to iaasConnectorPack resources. | [optional] [readonly] 
**DeviceStatus** | [**IaasDeviceStatusRelationship[]**](IaasDeviceStatusRelationship.md) | An array of relationships to iaasDeviceStatus resources. | [optional] [readonly] 
**LicenseInfo** | [**IaasLicenseInfoRelationship**](IaasLicenseInfoRelationship.md) |  | [optional] 
**MostRunTasks** | [**IaasMostRunTasksRelationship[]**](IaasMostRunTasksRelationship.md) | An array of relationships to iaasMostRunTasks resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**UcsdManagedInfra** | [**IaasUcsdManagedInfraRelationship**](IaasUcsdManagedInfraRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasUcsdInfo = Initialize-IntersightIaasUcsdInfo  -ClassId null `
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
 -DeviceId null `
 -Guid null `
 -HostName null `
 -Ip null `
 -LastBackup null `
 -NodeType null `
 -ProductName null `
 -ProductVendor null `
 -ProductVersion null `
 -Status null `
 -ConnectorPack null `
 -DeviceStatus null `
 -LicenseInfo null `
 -MostRunTasks null `
 -RegisteredDevice null `
 -UcsdManagedInfra null
```

- Convert the resource to JSON
```powershell
$IaasUcsdInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

