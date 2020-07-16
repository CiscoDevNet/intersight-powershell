# Intersight.Intersight/Api.IntersightTelemetryApi

All URIs are relative to *https://intersight.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-IntersightQueryTelemetryTimeSeries**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryTimeSeries) | **POST** /api/v1/telemetry/TimeSeries | Perform a Druid time series aggregation request.


<a name="Invoke-IntersightQueryTelemetryTimeSeries"></a>
# **Invoke-IntersightQueryTelemetryTimeSeries**
> TelemetryDruidIntervalResult[] Invoke-IntersightQueryTelemetryTimeSeries<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidAggregateRequest] <PSCustomObject><br>

Perform a Druid time series aggregation request.

Endpoint that exposes Druid requests for time series data. This endpoint exposes multiple requests, including Time series, Top N, GroupBy, Scan, Time Boundary, Segment meta-data and datasource meta-data.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"
# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";
# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

$TelemetryDruidAggregateRequest = (Initialize-telemetry.DruidAggregateRequest-QueryType "QueryType_example" -DataSource (Initialize-telemetry.DruidDataSource-Type "Type_example" -Name "Name_example" -DataSources @("DataSources_example") -Query (Initialize-telemetry.DruidGroupByRequest-QueryType "QueryType_example" -DataSource (Initialize-telemetry.DruidDataSource-Type "Type_example" -Name "Name_example" -DataSources @("DataSources_example") -Query (Initialize-telemetry.DruidGroupByRequest-QueryType "QueryType_example" -DataSource  -Dimensions @((Initialize-telemetry.DruidDimensionSpec-Type "Type_example" -Dimension "Dimension_example" -OutputName "OutputName_example" -OutputType "OutputType_example" -ExtractionFn "TODO")) -LimitSpec (Initialize-telemetry.DruidDefaultLimitSpec-Type "Type_example" -Limit 123 -Columns @((Initialize-telemetry.DruidOrderByColumnSpec-Dimension "Dimension_example" -Direction "Direction_example" -DimensionOrder "DimensionOrder_example"))) -Having (Initialize-telemetry.DruidHavingFilter-Type "Type_example" -VarFilter (Initialize-telemetry.DruidFilter-Type "Type_example" -ExtractionFn "TODO" -Dimension "Dimension_example" -Value "Value_example" -Dimensions @((Initialize-telemetry.DruidDimensionSpec-Type "Type_example" -Dimension "Dimension_example" -OutputName "OutputName_example" -OutputType "OutputType_example" -ExtractionFn "TODO")) -Pattern "Pattern_example" -Fields @((Initialize-telemetry.DruidFilter-Type "Type_example" -ExtractionFn "TODO" -Dimension "Dimension_example" -Value "Value_example" -Dimensions @() -Pattern "Pattern_example" -Fields @() -Field )) -Field ) -Aggregation "Aggregation_example" -Value 123 -Dimension "Dimension_example") -Granularity (Initialize-telemetry.DruidGranularity-Type "Type_example" -Duration 123 -Origin Get-Date -Period "Period_example" -TimeZone "TimeZone_example") -VarFilter  -Aggregations @((Initialize-telemetry.DruidAggregator-Type "Type_example" -Name "Name_example" -FieldName "FieldName_example" -MaxStringBytes 123 -Size 123 -VarFilter  -Aggregator (Initialize-telemetry.DruidAggregator-Type "Type_example" -Name "Name_example" -FieldName "FieldName_example" -MaxStringBytes 123 -Size 123 -VarFilter  -Aggregator ))) -PostAggregations @((Initialize-telemetry.DruidPostAggregator-Type "Type_example" -Name "Name_example" -Fn "Fn_example" -Fields @("Fields_example") -Ordering "Ordering_example" -FieldName "FieldName_example" -Value 123 -Field "Field_example" -Func "Func_example" -Size 123)) -Intervals @("Intervals_example") -SubtotalsSpec "TODO" -Context (Initialize-telemetry.DruidQueryContext-GrandTotal $false -SkipEmptyBuckets $false -Timeout 123 -Priority 123 -QueryId "QueryId_example" -UseCache $false -PopulateCache $false -UseResultLevelCache $false -PopulateResultLevelCache $false -BySegment $false -Finalize $false -ChunkPeriod "ChunkPeriod_example" -MaxScatterGatherBytes 123 -MaxQueuedBytes 123 -SerializeDateTimeAsLong $false -SerializeDateTimeAsLongInner $false -EnableParallelMerge $false -ParallelMergeParallelism 123 -ParallelMergeInitialYieldRows 123 -ParallelMergeSmallBatchRows 123)) -Lookup "Lookup_example" -Left "Left_example" -Right "Right_example" -RightPrefix "RightPrefix_example" -Condition "Condition_example" -JoinType "JoinType_example" -ColumnNames @("ColumnNames_example") -Rows @(@("Rows_example"))) -Dimensions @() -LimitSpec (Initialize-telemetry.DruidDefaultLimitSpec-Type "Type_example" -Limit 123 -Columns @((Initialize-telemetry.DruidOrderByColumnSpec-Dimension "Dimension_example" -Direction "Direction_example" -DimensionOrder "DimensionOrder_example"))) -Having (Initialize-telemetry.DruidHavingFilter-Type "Type_example" -VarFilter  -Aggregation "Aggregation_example" -Value 123 -Dimension "Dimension_example") -Granularity (Initialize-telemetry.DruidGranularity-Type "Type_example" -Duration 123 -Origin Get-Date -Period "Period_example" -TimeZone "TimeZone_example") -VarFilter  -Aggregations @() -PostAggregations @((Initialize-telemetry.DruidPostAggregator-Type "Type_example" -Name "Name_example" -Fn "Fn_example" -Fields @("Fields_example") -Ordering "Ordering_example" -FieldName "FieldName_example" -Value 123 -Field "Field_example" -Func "Func_example" -Size 123)) -Intervals @("Intervals_example") -SubtotalsSpec "TODO" -Context (Initialize-telemetry.DruidQueryContext-GrandTotal $false -SkipEmptyBuckets $false -Timeout 123 -Priority 123 -QueryId "QueryId_example" -UseCache $false -PopulateCache $false -UseResultLevelCache $false -PopulateResultLevelCache $false -BySegment $false -Finalize $false -ChunkPeriod "ChunkPeriod_example" -MaxScatterGatherBytes 123 -MaxQueuedBytes 123 -SerializeDateTimeAsLong $false -SerializeDateTimeAsLongInner $false -EnableParallelMerge $false -ParallelMergeParallelism 123 -ParallelMergeInitialYieldRows 123 -ParallelMergeSmallBatchRows 123)) -Lookup "Lookup_example" -Left "Left_example" -Right "Right_example" -RightPrefix "RightPrefix_example" -Condition "Condition_example" -JoinType "JoinType_example" -ColumnNames @("ColumnNames_example") -Rows @(@("Rows_example"))) -Descending $false -Intervals @("Intervals_example") -Granularity  -VarFilter  -Aggregations @() -PostAggregations @() -Limit 123 -Context  -Dimension  -Threshold 123 -Metric (Initialize-telemetry.DruidTopNMetricSpec-Type "Type_example" -Metric (Initialize-telemetry.DruidTopNMetricSpec-Type "Type_example" -Metric  -Ordering "Ordering_example" -PreviousStop "PreviousStop_example") -Ordering "Ordering_example" -PreviousStop "PreviousStop_example") -Dimensions @() -LimitSpec  -Having  -SubtotalsSpec "TODO" -ResultFormat "ResultFormat_example" -Columns @("Columns_example") -BatchSize 123 -Order "Order_example" -Legacy $false -Bound "Bound_example" -ToInclude "TODO" -Merge $false -AnalysisTypes @("AnalysisTypes_example") -LenientAggregatorMerge $false) # TelemetryDruidAggregateRequest | The Druid request schema for time series queries.

# Perform a Druid time series aggregation request.
try {
    TelemetryDruidIntervalResult[] $Result = Invoke-IntersightQueryTelemetryTimeSeries -TelemetryDruidAggregateRequest $TelemetryDruidAggregateRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryTimeSeries: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidAggregateRequest** | [**TelemetryDruidAggregateRequest**](TelemetryDruidAggregateRequest.md)| The Druid request schema for time series queries. | 

### Return type

[**TelemetryDruidIntervalResult[]**](TelemetryDruidIntervalResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

