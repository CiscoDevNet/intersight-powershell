# NiatelemetryNexusDashboardsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NexusDashboards"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NexusDashboards"]
**ClusterName** | **String** | Nexus Dashboard can onboard multiple APIC clusters/sites. | [optional] 
**IsClusterHealthy** | **String** | Health of Nexus Dashboard cluster. | [optional] 
**NdClusterSize** | **Int64** | Number of nodes in Nexus Dashboard cluster. | [optional] 
**NdType** | **String** | Node type in Nexus Dashboard cluster. | [optional] 
**NdVersion** | **String** | Version running on Nexus Dashboard. | [optional] 
**NumberOfApps** | **Int64** | Number of applications installed in the Nexus Dashboard. | [optional] 
**NumberOfSchemasInMso** | **Int64** | Number of total schemas in Multi-Site Orchestrator. | [optional] 
**NumberOfSitesInMso** | **Int64** | Number of sites in Multi-Site Orchestrator. | [optional] 
**NumberOfSitesServiced** | **Int64** | Number of sites serviced by ND. | [optional] 
**NumberOfTenantsInMso** | **Int64** | Number of total tenants in Multi-Site Orchestrator. | [optional] 
**TypeOfSiteInMso** | **String** | Type of site added to Multi-Site Orchestrator. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNexusDashboardsAllOf = Initialize-IntersightNiatelemetryNexusDashboardsAllOf  -ClassId null `
 -ObjectType null `
 -ClusterName null `
 -IsClusterHealthy null `
 -NdClusterSize null `
 -NdType null `
 -NdVersion null `
 -NumberOfApps null `
 -NumberOfSchemasInMso null `
 -NumberOfSitesInMso null `
 -NumberOfSitesServiced null `
 -NumberOfTenantsInMso null `
 -TypeOfSiteInMso null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNexusDashboardsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

