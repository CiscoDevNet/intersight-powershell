# NiatelemetryMsoTenantDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.MsoTenantDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.MsoTenantDetails"]
**NumberOfSchemasAssignedPerTenantInMso** | **Int64** | Number of schemas assigned to each tenant in Multi-Site Orchestrator. | [optional] 
**SitesEachTenantIsDeployedToInMso** | **Int64** | Number of sites each tenant is deployed to. | [optional] 
**TenantId** | **String** | ID of tenant in Multi-Site Orchestrator. | [optional] 
**TenantName** | **String** | Name of the tenant in Multi-Site Orchestrator. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryMsoTenantDetailsAllOf = Initialize-IntersightNiatelemetryMsoTenantDetailsAllOf  -ClassId null `
 -ObjectType null `
 -NumberOfSchemasAssignedPerTenantInMso null `
 -SitesEachTenantIsDeployedToInMso null `
 -TenantId null `
 -TenantName null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryMsoTenantDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

