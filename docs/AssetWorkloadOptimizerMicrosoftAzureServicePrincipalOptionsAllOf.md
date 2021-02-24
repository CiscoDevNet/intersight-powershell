# AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.WorkloadOptimizerMicrosoftAzureServicePrincipalOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.WorkloadOptimizerMicrosoftAzureServicePrincipalOptions"]
**AzureCloudType** | **String** | Azure has different endpoints for managing Germany subscriptions. Azure cloud type helps in differentiating between regular subscriptions and Germany subscriptions to manage the Azure services for workload optimization. Documentation for germany cloud [link](https://docs.microsoft.com/en-us/azure/germany/germany-manage-subscriptions). * &#x60;Global&#x60; - Global cloud type for Azure subscription. * &#x60;Germany&#x60; - Germany cloud type for Azure subscription. | [optional] [default to "Global"]
**TenantId** | **String** | Id of the tenant used while authenticating the managed target. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptionsAllOf = Initialize-IntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptionsAllOf  -ClassId null `
 -ObjectType null `
 -AzureCloudType null `
 -TenantId null
```

- Convert the resource to JSON
```powershell
$AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptionsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

