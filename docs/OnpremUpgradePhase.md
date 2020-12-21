# OnpremUpgradePhase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "onprem.UpgradePhase"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "onprem.UpgradePhase"]
**ElapsedTime** | **Int64** | Elapsed time in seconds to complete the current upgrade phase. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date of the software upgrade phase. | [optional] [readonly] 
**Failed** | **Boolean** | Indicates if the upgrade phase has failed or not. | [optional] [readonly] 
**Message** | **String** | Status message set during the upgrade phase. | [optional] [readonly] 
**Name** | **String** | Name of the upgrade phase. * &#x60;init&#x60; - Upgrade service initialization phase. * &#x60;Prepare&#x60; - Upgrade service prepares folders and templated files. * &#x60;ServiceLoad&#x60; - Upgrade service loads the service images into the local docker cache. * &#x60;UiLoad&#x60; - Upgrade service loads the UI packages into the local cache. * &#x60;GenerateConfig&#x60; - Upgrade service generates the Kubernetes configuration files. * &#x60;DeployService&#x60; - Upgrade service deploys the Kubernetes services. * &#x60;Success&#x60; - Upgrade completed successfully. * &#x60;Fail&#x60; - Indicates that the upgrade process has failed. * &#x60;Cancel&#x60; - Indicates that the upgrade was canceled by the Intersight Appliance. * &#x60;Telemetry&#x60; - Upgrade service sends basic telemetry data to the Intersight. | [optional] [readonly] [default to "init"]
**StartTime** | **System.DateTime** | Start date of the software upgrade phase. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$OnpremUpgradePhase = Initialize-IntersightOnpremUpgradePhase  -ClassId null `
 -ObjectType null `
 -ElapsedTime null `
 -EndTime null `
 -Failed null `
 -Message null `
 -Name null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$OnpremUpgradePhase | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

