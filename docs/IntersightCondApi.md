# Intersight.Intersight/Api.IntersightCondApi

All URIs are relative to *https://intersight.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-IntersightCondAlarmByMoid**](IntersightCondApi.md#Get-IntersightCondAlarmByMoid) | **GET** /api/v1/cond/Alarms/{Moid} | Read a &#39;cond.Alarm&#39; resource.
[**Get-IntersightCondAlarmList**](IntersightCondApi.md#Get-IntersightCondAlarmList) | **GET** /api/v1/cond/Alarms | Read a &#39;cond.Alarm&#39; resource.
[**Get-IntersightCondHclStatusByMoid**](IntersightCondApi.md#Get-IntersightCondHclStatusByMoid) | **GET** /api/v1/cond/HclStatuses/{Moid} | Read a &#39;cond.HclStatus&#39; resource.
[**Get-IntersightCondHclStatusDetailByMoid**](IntersightCondApi.md#Get-IntersightCondHclStatusDetailByMoid) | **GET** /api/v1/cond/HclStatusDetails/{Moid} | Read a &#39;cond.HclStatusDetail&#39; resource.
[**Get-IntersightCondHclStatusDetailList**](IntersightCondApi.md#Get-IntersightCondHclStatusDetailList) | **GET** /api/v1/cond/HclStatusDetails | Read a &#39;cond.HclStatusDetail&#39; resource.
[**Get-IntersightCondHclStatusJobByMoid**](IntersightCondApi.md#Get-IntersightCondHclStatusJobByMoid) | **GET** /api/v1/cond/HclStatusJobs/{Moid} | Read a &#39;cond.HclStatusJob&#39; resource.
[**Get-IntersightCondHclStatusJobList**](IntersightCondApi.md#Get-IntersightCondHclStatusJobList) | **GET** /api/v1/cond/HclStatusJobs | Read a &#39;cond.HclStatusJob&#39; resource.
[**Get-IntersightCondHclStatusList**](IntersightCondApi.md#Get-IntersightCondHclStatusList) | **GET** /api/v1/cond/HclStatuses | Read a &#39;cond.HclStatus&#39; resource.


<a name="Get-IntersightCondAlarmByMoid"></a>
# **Get-IntersightCondAlarmByMoid**
> CondAlarm Get-IntersightCondAlarmByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'cond.Alarm' resource.

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

$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'cond.Alarm' resource.
try {
    CondAlarm $Result = Get-IntersightCondAlarmByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondAlarmByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type

[**CondAlarm**](CondAlarm.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondAlarmList"></a>
# **Get-IntersightCondAlarmList**
> CondAlarmResponse Get-IntersightCondAlarmList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'cond.Alarm' resource.

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

$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'cond.Alarm' resource.
try {
    CondAlarmResponse $Result = Get-IntersightCondAlarmList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondAlarmList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type

[**CondAlarmResponse**](CondAlarmResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusByMoid"></a>
# **Get-IntersightCondHclStatusByMoid**
> CondHclStatus Get-IntersightCondHclStatusByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'cond.HclStatus' resource.

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

$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'cond.HclStatus' resource.
try {
    CondHclStatus $Result = Get-IntersightCondHclStatusByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type

[**CondHclStatus**](CondHclStatus.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusDetailByMoid"></a>
# **Get-IntersightCondHclStatusDetailByMoid**
> CondHclStatusDetail Get-IntersightCondHclStatusDetailByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'cond.HclStatusDetail' resource.

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

$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'cond.HclStatusDetail' resource.
try {
    CondHclStatusDetail $Result = Get-IntersightCondHclStatusDetailByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusDetailByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type

[**CondHclStatusDetail**](CondHclStatusDetail.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusDetailList"></a>
# **Get-IntersightCondHclStatusDetailList**
> CondHclStatusDetailResponse Get-IntersightCondHclStatusDetailList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'cond.HclStatusDetail' resource.

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

$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'cond.HclStatusDetail' resource.
try {
    CondHclStatusDetailResponse $Result = Get-IntersightCondHclStatusDetailList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusDetailList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type

[**CondHclStatusDetailResponse**](CondHclStatusDetailResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusJobByMoid"></a>
# **Get-IntersightCondHclStatusJobByMoid**
> CondHclStatusJob Get-IntersightCondHclStatusJobByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'cond.HclStatusJob' resource.

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

$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'cond.HclStatusJob' resource.
try {
    CondHclStatusJob $Result = Get-IntersightCondHclStatusJobByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusJobByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type

[**CondHclStatusJob**](CondHclStatusJob.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusJobList"></a>
# **Get-IntersightCondHclStatusJobList**
> CondHclStatusJobResponse Get-IntersightCondHclStatusJobList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'cond.HclStatusJob' resource.

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

$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'cond.HclStatusJob' resource.
try {
    CondHclStatusJobResponse $Result = Get-IntersightCondHclStatusJobList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusJobList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type

[**CondHclStatusJobResponse**](CondHclStatusJobResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightCondHclStatusList"></a>
# **Get-IntersightCondHclStatusList**
> CondHclStatusResponse Get-IntersightCondHclStatusList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'cond.HclStatus' resource.

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

$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'cond.HclStatus' resource.
try {
    CondHclStatusResponse $Result = Get-IntersightCondHclStatusList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightCondHclStatusList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type

[**CondHclStatusResponse**](CondHclStatusResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

