# NiatelemetryMsoSiteDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.MsoSiteDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.MsoSiteDetails"]
**IsCloudSecEnabled** | **String** | Status of cloudSec on Multi-Site Orchestrator site. | [optional] 
**NumberOfLeafsPerSiteInMso** | **Int64** | Number of leafs per site in Multi-Site Orchestrator. | [optional] 
**NumberOfPodsPerSiteInMso** | **Int64** | Number of pods per site in Multi-Site Orchestrator. | [optional] 
**NumberOfSpinesPerSiteInMso** | **Int64** | Number of spines per site in Multi-Site Orchestrator. | [optional] 
**SiteId** | **String** | ID of site in Multi-Site Orchestrator. | [optional] 
**SiteName** | **String** | Name of the site in Multi-Site Orchestrator. | [optional] 
**SiteVersion** | **String** | Version of the controller in the site. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryMsoSiteDetailsAllOf = Initialize-IntersightNiatelemetryMsoSiteDetailsAllOf  -ClassId null `
 -ObjectType null `
 -IsCloudSecEnabled null `
 -NumberOfLeafsPerSiteInMso null `
 -NumberOfPodsPerSiteInMso null `
 -NumberOfSpinesPerSiteInMso null `
 -SiteId null `
 -SiteName null `
 -SiteVersion null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryMsoSiteDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

