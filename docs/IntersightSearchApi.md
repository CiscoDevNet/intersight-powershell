# Intersight.Intersight/Api.IntersightSearchApi

All URIs are relative to *https://intersight.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**New-IntersightSearchSuggestItem**](IntersightSearchApi.md#New-IntersightSearchSuggestItem) | **POST** /api/v1/search/SuggestItems | Create a &#39;search.SuggestItem&#39; resource.
[**Get-IntersightSearchSearchItemByMoid**](IntersightSearchApi.md#Get-IntersightSearchSearchItemByMoid) | **GET** /api/v1/search/SearchItems/{Moid} | Read a &#39;search.SearchItem&#39; resource.
[**Get-IntersightSearchSearchItemList**](IntersightSearchApi.md#Get-IntersightSearchSearchItemList) | **GET** /api/v1/search/SearchItems | Read a &#39;search.SearchItem&#39; resource.
[**Get-IntersightSearchTagItemByMoid**](IntersightSearchApi.md#Get-IntersightSearchTagItemByMoid) | **GET** /api/v1/search/TagItems/{Moid} | Read a &#39;search.TagItem&#39; resource.
[**Get-IntersightSearchTagItemList**](IntersightSearchApi.md#Get-IntersightSearchTagItemList) | **GET** /api/v1/search/TagItems | Read a &#39;search.TagItem&#39; resource.


<a name="New-IntersightSearchSuggestItem"></a>
# **New-IntersightSearchSuggestItem**
> SearchSuggestItem New-IntersightSearchSuggestItem<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SearchSuggestItem] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfNoneMatch] <String><br>

Create a 'search.SuggestItem' resource.

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

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$SearchSuggestItem = (Initialize-search.SuggestItem-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @((Initialize-mo.Tag-Key "Key_example" -Value "Value_example")) -VersionContext (Initialize-mo.VersionContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -InterestedMos @((Initialize-mo.MoRef-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example")) -RefMo (Initialize-mo.MoRef-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example") -Timestamp Get-Date -Version "Version_example" -VersionType "VersionType_example") -Ancestors @((Initialize-mo.BaseMo.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @((Initialize-mo.Tag-Key "Key_example" -Value "Value_example")) -VersionContext (Initialize-mo.VersionContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -InterestedMos @() -RefMo  -Timestamp Get-Date -Version "Version_example" -VersionType "VersionType_example") -Ancestors @((Initialize-mo.BaseMo.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO")) -Parent  -PermissionResources @() -DisplayNames "TODO")) -Parent  -PermissionResources @() -DisplayNames "TODO" -CompleteMo $false -Rawquery "Rawquery_example" -Skip 123 -SuggestTerm "SuggestTerm_example" -Top 123 -Type "Type_example") # SearchSuggestItem | The 'search.SuggestItem' resource to create.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)
$IfNoneMatch = "IfNoneMatch_example" # String | For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte. (optional)

# Create a 'search.SuggestItem' resource.
try {
     $Result = New-IntersightSearchSuggestItem -SearchSuggestItem $SearchSuggestItem -IfMatch $IfMatch -IfNoneMatch $IfNoneMatch
} catch {
    Write-Host ("Exception occured when calling New-IntersightSearchSuggestItem: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SearchSuggestItem** | [**SearchSuggestItem**](SearchSuggestItem.md)| The &#39;search.SuggestItem&#39; resource to create. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 
 **IfNoneMatch** | **String**| For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&#39;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&#39;s ETag doesn&#39;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&#39;t have to be identical byte for byte. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SearchSuggestItem**](SearchSuggestItem.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSearchSearchItemByMoid"></a>
# **Get-IntersightSearchSearchItemByMoid**
> SearchSearchItem Get-IntersightSearchSearchItemByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'search.SearchItem' resource.

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

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'search.SearchItem' resource.
try {
     $Result = Get-IntersightSearchSearchItemByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSearchSearchItemByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SearchSearchItem**](SearchSearchItem.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSearchSearchItemList"></a>
# **Get-IntersightSearchSearchItemList**
> SearchSearchItemResponse Get-IntersightSearchSearchItemList<br>
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

Read a 'search.SearchItem' resource.

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

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

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

# Read a 'search.SearchItem' resource.
try {
     $Result = Get-IntersightSearchSearchItemList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSearchSearchItemList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
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
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SearchSearchItemResponse**](SearchSearchItemResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSearchTagItemByMoid"></a>
# **Get-IntersightSearchTagItemByMoid**
> SearchTagItem Get-IntersightSearchTagItemByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'search.TagItem' resource.

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

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'search.TagItem' resource.
try {
     $Result = Get-IntersightSearchTagItemByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSearchTagItemByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SearchTagItem**](SearchTagItem.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSearchTagItemList"></a>
# **Get-IntersightSearchTagItemList**
> SearchTagItemResponse Get-IntersightSearchTagItemList<br>
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

Read a 'search.TagItem' resource.

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

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

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

# Read a 'search.TagItem' resource.
try {
     $Result = Get-IntersightSearchTagItemList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSearchTagItemList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
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
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SearchTagItemResponse**](SearchTagItemResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

