# AssetOrchestrationHitachiVirtualStoragePlatformOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.OrchestrationHitachiVirtualStoragePlatformOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.OrchestrationHitachiVirtualStoragePlatformOptions"]
**OpsCenterManagementAddress** | **String** | The DNS hostname or IP address of the Hitachi Ops Center API Configuration Manager used to manage the Hitachi Virtual Storage Platform. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetOrchestrationHitachiVirtualStoragePlatformOptions = Initialize-IntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions  -ClassId null `
 -ObjectType null `
 -OpsCenterManagementAddress null
```

- Convert the resource to JSON
```powershell
$AssetOrchestrationHitachiVirtualStoragePlatformOptions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

