# IaasUcsdInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
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
Initialize-IntersightIaasUcsdInfo  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

