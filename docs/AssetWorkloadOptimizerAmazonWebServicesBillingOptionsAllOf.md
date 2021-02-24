# AssetWorkloadOptimizerAmazonWebServicesBillingOptionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.WorkloadOptimizerAmazonWebServicesBillingOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.WorkloadOptimizerAmazonWebServicesBillingOptions"]
**CostAndUsageReportBucket** | **String** | Name of S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend. | [optional] 
**CostAndUsageReportPath** | **String** | Report path prefix for the Amazon web service cost and usage report to get cloud service spend. | [optional] 
**CostAndUsageReportRegion** | **String** | Region for S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetWorkloadOptimizerAmazonWebServicesBillingOptionsAllOf = Initialize-IntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptionsAllOf  -ClassId null `
 -ObjectType null `
 -CostAndUsageReportBucket null `
 -CostAndUsageReportPath null `
 -CostAndUsageReportRegion null
```

- Convert the resource to JSON
```powershell
$AssetWorkloadOptimizerAmazonWebServicesBillingOptionsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

