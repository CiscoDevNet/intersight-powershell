# Intersight.Intersight/Api.IntersightTelemetryApi

All URIs are relative to *https://intersight.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-IntersightQueryTelemetryDatasourceMetadata**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryDatasourceMetadata) | **POST** /api/v1/telemetry/DataSourceMetadata | Perform a Druid DatasourceMetadata request.
[**Invoke-IntersightQueryTelemetryGroupBy**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryGroupBy) | **POST** /api/v1/telemetry/GroupBys | Perform a Druid GroupBy request.
[**Invoke-IntersightQueryTelemetryScan**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryScan) | **POST** /api/v1/telemetry/Scans | Perform a Druid Scan request.
[**Invoke-IntersightQueryTelemetrySearch**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetrySearch) | **POST** /api/v1/telemetry/Searches | Perform a Druid Search request.
[**Invoke-IntersightQueryTelemetrySegmentMetadata**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetrySegmentMetadata) | **POST** /api/v1/telemetry/SegmentMetadata | Perform a Druid SegmentMetadata request.
[**Invoke-IntersightQueryTelemetryTimeBoundary**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryTimeBoundary) | **POST** /api/v1/telemetry/TimeBoundaries | Perform a Druid TimeBoundary request.
[**Invoke-IntersightQueryTelemetryTimeSeries**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryTimeSeries) | **POST** /api/v1/telemetry/TimeSeries | Perform a Druid TimeSeries request.
[**Invoke-IntersightQueryTelemetryTopN**](IntersightTelemetryApi.md#Invoke-IntersightQueryTelemetryTopN) | **POST** /api/v1/telemetry/Topns | Perform a Druid TopN request.


<a name="Invoke-IntersightQueryTelemetryDatasourceMetadata"></a>
# **Invoke-IntersightQueryTelemetryDatasourceMetadata**
> TelemetryDruidDataSourceMetadataResult[] Invoke-IntersightQueryTelemetryDatasourceMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidDataSourceMetadataRequest] <PSCustomObject><br>

Perform a Druid DatasourceMetadata request.

Endpoint that exposes Druid DatasourceMetadata requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidDataSourceMetadataRequest = (Initialize-telemetry.DruidDataSourceMetadataRequest -QueryType "timeseries" -DataSource (Initialize-telemetry.DruidDataSource -Type "table" -Name "Name_example" -DataSources @("DataSources_example") -Query (Initialize-telemetry.DruidGroupByRequest -QueryType "timeseries" -DataSource (Initialize-telemetry.DruidDataSource -Type "table" -Name "Name_example" -DataSources @("DataSources_example") -Query (Initialize-telemetry.DruidGroupByRequest -QueryType "timeseries" -DataSource  -Dimensions @((Initialize-telemetry.DruidDimensionSpec -Type "default" -Dimension "Dimension_example" -OutputName "OutputName_example" -OutputType "STRING" -ExtractionFn "TODO")) -LimitSpec (Initialize-telemetry.DruidDefaultLimitSpec -Type "default" -Limit 123 -Columns @((Initialize-telemetry.DruidOrderByColumnSpec -Dimension "Dimension_example" -Direction "ascending" -DimensionOrder "lexicographic"))) -Having (Initialize-telemetry.DruidHavingFilter -Type "filter" -VarFilter (Initialize-telemetry.DruidFilter -Type "selector" -ExtractionFn "TODO" -Dimension "Dimension_example" -Value "Value_example" -Dimensions @((Initialize-telemetry.DruidDimensionSpec -Type "default" -Dimension "Dimension_example" -OutputName "OutputName_example" -OutputType "STRING" -ExtractionFn "TODO")) -Pattern "Pattern_example" -Fields @((Initialize-telemetry.DruidFilter -Type "selector" -ExtractionFn "TODO" -Dimension "Dimension_example" -Value "Value_example" -Dimensions @() -Pattern "Pattern_example" -Fields @() -Field )) -Field ) -Aggregation "Aggregation_example" -Value 123 -Dimension "Dimension_example") -Granularity (Initialize-telemetry.DruidGranularity -Type "duration" -Duration 123 -Origin Get-Date -Period "Period_example" -TimeZone "TimeZone_example") -VarFilter  -Aggregations @((Initialize-telemetry.DruidAggregator -Type "count" -Name "Name_example" -FieldName "FieldName_example" -MaxStringBytes 123 -Size 123 -VarFilter  -Aggregator (Initialize-telemetry.DruidAggregator -Type "count" -Name "Name_example" -FieldName "FieldName_example" -MaxStringBytes 123 -Size 123 -VarFilter  -Aggregator ))) -PostAggregations @((Initialize-telemetry.DruidPostAggregator -Type "arithmetic" -Name "Name_example" -Fn "+" -Fields @("Fields_example") -Ordering "Ordering_example" -FieldName "FieldName_example" -Value 123 -Field "Field_example" -Func "UNION" -Size 123)) -Intervals @("Intervals_example") -SubtotalsSpec "TODO" -Context (Initialize-telemetry.DruidQueryContext -GrandTotal $false -SkipEmptyBuckets $false -Timeout 123 -Priority 123 -QueryId "QueryId_example" -UseCache $false -PopulateCache $false -UseResultLevelCache $false -PopulateResultLevelCache $false -BySegment $false -Finalize $false -ChunkPeriod "ChunkPeriod_example" -MaxScatterGatherBytes 123 -MaxQueuedBytes 123 -SerializeDateTimeAsLong $false -SerializeDateTimeAsLongInner $false -EnableParallelMerge $false -ParallelMergeParallelism 123 -ParallelMergeInitialYieldRows 123 -ParallelMergeSmallBatchRows 123)) -Lookup "Lookup_example" -Left "Left_example" -Right "Right_example" -RightPrefix "RightPrefix_example" -Condition "Condition_example" -JoinType "INNER" -ColumnNames @("ColumnNames_example") -Rows @(@("Rows_example"))) -Dimensions @() -LimitSpec (Initialize-telemetry.DruidDefaultLimitSpec -Type "default" -Limit 123 -Columns @((Initialize-telemetry.DruidOrderByColumnSpec -Dimension "Dimension_example" -Direction "ascending" -DimensionOrder "lexicographic"))) -Having (Initialize-telemetry.DruidHavingFilter -Type "filter" -VarFilter  -Aggregation "Aggregation_example" -Value 123 -Dimension "Dimension_example") -Granularity (Initialize-telemetry.DruidGranularity -Type "duration" -Duration 123 -Origin Get-Date -Period "Period_example" -TimeZone "TimeZone_example") -VarFilter  -Aggregations @() -PostAggregations @((Initialize-telemetry.DruidPostAggregator -Type "arithmetic" -Name "Name_example" -Fn "+" -Fields @("Fields_example") -Ordering "Ordering_example" -FieldName "FieldName_example" -Value 123 -Field "Field_example" -Func "UNION" -Size 123)) -Intervals @("Intervals_example") -SubtotalsSpec "TODO" -Context (Initialize-telemetry.DruidQueryContext -GrandTotal $false -SkipEmptyBuckets $false -Timeout 123 -Priority 123 -QueryId "QueryId_example" -UseCache $false -PopulateCache $false -UseResultLevelCache $false -PopulateResultLevelCache $false -BySegment $false -Finalize $false -ChunkPeriod "ChunkPeriod_example" -MaxScatterGatherBytes 123 -MaxQueuedBytes 123 -SerializeDateTimeAsLong $false -SerializeDateTimeAsLongInner $false -EnableParallelMerge $false -ParallelMergeParallelism 123 -ParallelMergeInitialYieldRows 123 -ParallelMergeSmallBatchRows 123)) -Lookup "Lookup_example" -Left "Left_example" -Right "Right_example" -RightPrefix "RightPrefix_example" -Condition "Condition_example" -JoinType "INNER" -ColumnNames @("ColumnNames_example") -Rows @(@("Rows_example"))) -Context ) # TelemetryDruidDataSourceMetadataRequest | The Druid request schema for time series queries.

# Perform a Druid DatasourceMetadata request.
try {
     $Result = Invoke-IntersightQueryTelemetryDatasourceMetadata -TelemetryDruidDataSourceMetadataRequest $TelemetryDruidDataSourceMetadataRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryDatasourceMetadata: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidDataSourceMetadataRequest** | [**TelemetryDruidDataSourceMetadataRequest**](TelemetryDruidDataSourceMetadataRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidDataSourceMetadataResult[]**](TelemetryDruidDataSourceMetadataResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetryGroupBy"></a>
# **Invoke-IntersightQueryTelemetryGroupBy**
> TelemetryDruidGroupByResult[] Invoke-IntersightQueryTelemetryGroupBy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidGroupByRequest] <PSCustomObject><br>

Perform a Druid GroupBy request.

Endpoint that exposes Druid GroupBy requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidGroupByRequest =  # TelemetryDruidGroupByRequest | The Druid request schema for time series queries.

# Perform a Druid GroupBy request.
try {
     $Result = Invoke-IntersightQueryTelemetryGroupBy -TelemetryDruidGroupByRequest $TelemetryDruidGroupByRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryGroupBy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidGroupByRequest** | [**TelemetryDruidGroupByRequest**](TelemetryDruidGroupByRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidGroupByResult[]**](TelemetryDruidGroupByResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetryScan"></a>
# **Invoke-IntersightQueryTelemetryScan**
> TelemetryDruidScanResult[] Invoke-IntersightQueryTelemetryScan<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidScanRequest] <PSCustomObject><br>

Perform a Druid Scan request.

Endpoint that exposes Druid Scan requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidScanRequest = (Initialize-telemetry.DruidScanRequest -QueryType "timeseries" -DataSource  -Intervals @("Intervals_example") -ResultFormat "list" -VarFilter  -Columns @("Columns_example") -BatchSize 123 -Limit 123 -Order "none" -Legacy $false -Context ) # TelemetryDruidScanRequest | The Druid request schema for time series queries.

# Perform a Druid Scan request.
try {
     $Result = Invoke-IntersightQueryTelemetryScan -TelemetryDruidScanRequest $TelemetryDruidScanRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryScan: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidScanRequest** | [**TelemetryDruidScanRequest**](TelemetryDruidScanRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidScanResult[]**](TelemetryDruidScanResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetrySearch"></a>
# **Invoke-IntersightQueryTelemetrySearch**
> TelemetryDruidSearchResult[] Invoke-IntersightQueryTelemetrySearch<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidSearchRequest] <PSCustomObject><br>

Perform a Druid Search request.

Endpoint that exposes Druid Search requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidSearchRequest = (Initialize-telemetry.DruidSearchRequest -QueryType "timeseries" -DataSource  -Intervals @("Intervals_example") -Granularity  -VarFilter  -Aggregations @() -SearchDimensions @("SearchDimensions_example") -Query (Initialize-telemetry.DruidAggregateSearchSpec -Type "insensitive_contains" -Value "Value_example" -Values @("Values_example") -CaseSensitive $false -Regex "Regex_example") -Limit 123 -Context ) # TelemetryDruidSearchRequest | The Druid request schema for time series queries.

# Perform a Druid Search request.
try {
     $Result = Invoke-IntersightQueryTelemetrySearch -TelemetryDruidSearchRequest $TelemetryDruidSearchRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetrySearch: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidSearchRequest** | [**TelemetryDruidSearchRequest**](TelemetryDruidSearchRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidSearchResult[]**](TelemetryDruidSearchResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetrySegmentMetadata"></a>
# **Invoke-IntersightQueryTelemetrySegmentMetadata**
> TelemetryDruidSegmentMetadataResult[] Invoke-IntersightQueryTelemetrySegmentMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidSegmentMetadataRequest] <PSCustomObject><br>

Perform a Druid SegmentMetadata request.

Endpoint that exposes Druid SegmentMetadata requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidSegmentMetadataRequest = (Initialize-telemetry.DruidSegmentMetadataRequest -QueryType "timeseries" -DataSource  -Intervals @("Intervals_example") -ToInclude "TODO" -Merge $false -Context  -AnalysisTypes @("AnalysisTypes_example") -LenientAggregatorMerge $false) # TelemetryDruidSegmentMetadataRequest | The Druid request schema for time series queries.

# Perform a Druid SegmentMetadata request.
try {
     $Result = Invoke-IntersightQueryTelemetrySegmentMetadata -TelemetryDruidSegmentMetadataRequest $TelemetryDruidSegmentMetadataRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetrySegmentMetadata: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidSegmentMetadataRequest** | [**TelemetryDruidSegmentMetadataRequest**](TelemetryDruidSegmentMetadataRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidSegmentMetadataResult[]**](TelemetryDruidSegmentMetadataResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetryTimeBoundary"></a>
# **Invoke-IntersightQueryTelemetryTimeBoundary**
> TelemetryDruidTimeBoundaryResult[] Invoke-IntersightQueryTelemetryTimeBoundary<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidTimeBoundaryRequest] <PSCustomObject><br>

Perform a Druid TimeBoundary request.

Endpoint that exposes Druid TimeBoundary requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidTimeBoundaryRequest = (Initialize-telemetry.DruidTimeBoundaryRequest -QueryType "timeseries" -DataSource  -Bound "maxTime" -VarFilter  -Context ) # TelemetryDruidTimeBoundaryRequest | The Druid request schema for time series queries.

# Perform a Druid TimeBoundary request.
try {
     $Result = Invoke-IntersightQueryTelemetryTimeBoundary -TelemetryDruidTimeBoundaryRequest $TelemetryDruidTimeBoundaryRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryTimeBoundary: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidTimeBoundaryRequest** | [**TelemetryDruidTimeBoundaryRequest**](TelemetryDruidTimeBoundaryRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidTimeBoundaryResult[]**](TelemetryDruidTimeBoundaryResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetryTimeSeries"></a>
# **Invoke-IntersightQueryTelemetryTimeSeries**
> TelemetryDruidIntervalResult[] Invoke-IntersightQueryTelemetryTimeSeries<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidTimeSeriesRequest] <PSCustomObject><br>

Perform a Druid TimeSeries request.

Endpoint that exposes Druid requests for time series data. This endpoint exposes specifically TimeSeries requests and broker information.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidTimeSeriesRequest = (Initialize-telemetry.DruidTimeSeriesRequest -QueryType "timeseries" -DataSource  -Descending $false -Intervals @("Intervals_example") -Granularity  -VarFilter  -Aggregations @() -PostAggregations @() -Limit 123 -Context ) # TelemetryDruidTimeSeriesRequest | The Druid request schema for time series queries.

# Perform a Druid TimeSeries request.
try {
     $Result = Invoke-IntersightQueryTelemetryTimeSeries -TelemetryDruidTimeSeriesRequest $TelemetryDruidTimeSeriesRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryTimeSeries: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidTimeSeriesRequest** | [**TelemetryDruidTimeSeriesRequest**](TelemetryDruidTimeSeriesRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidIntervalResult[]**](TelemetryDruidIntervalResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IntersightQueryTelemetryTopN"></a>
# **Invoke-IntersightQueryTelemetryTopN**
> TelemetryDruidTopNResult[] Invoke-IntersightQueryTelemetryTopN<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TelemetryDruidTopNRequest] <PSCustomObject><br>

Perform a Druid TopN request.

Endpoint that exposes Druid TopN requests for time series data.

### Example
```powershell
# general setting of the PowerShell module, e.g. base URL, authentication, etc
$Configuration = Get-Configuration
# Configure API key authorization: cookieAuth
$Configuration.ApiKey.X-Starship-Token = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration.ApiKeyPrefix.X-Starship-Token = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration.Username = "YOUR_USERNAME"
$Configuration.Password = "YOUR_PASSWORD"
# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-ConfigurationHttpSigning $httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

# Configure OAuth2 access token for authorization: oAuth2
$Configuration.AccessToken = "YOUR_ACCESS_TOKEN"

$TelemetryDruidTopNRequest = (Initialize-telemetry.DruidTopNRequest -QueryType "timeseries" -DataSource  -Intervals @("Intervals_example") -Granularity  -VarFilter  -Aggregations @() -PostAggregations @() -Dimension  -Threshold 123 -Metric (Initialize-telemetry.DruidTopNMetricSpec -Type "numeric" -Metric (Initialize-telemetry.DruidTopNMetricSpec -Type "numeric" -Metric  -Ordering "lexicographic" -PreviousStop "PreviousStop_example") -Ordering "lexicographic" -PreviousStop "PreviousStop_example") -Context ) # TelemetryDruidTopNRequest | The Druid request schema for time series queries.

# Perform a Druid TopN request.
try {
     $Result = Invoke-IntersightQueryTelemetryTopN -TelemetryDruidTopNRequest $TelemetryDruidTopNRequest
} catch {
    Write-Host ("Exception occured when calling Invoke-IntersightQueryTelemetryTopN: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TelemetryDruidTopNRequest** | [**TelemetryDruidTopNRequest**](TelemetryDruidTopNRequest.md)| The Druid request schema for time series queries. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TelemetryDruidTopNResult[]**](TelemetryDruidTopNResult.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

