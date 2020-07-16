# IaasUcsdInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightIaasUcsdInfoAllOf  -DeviceId null `
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

