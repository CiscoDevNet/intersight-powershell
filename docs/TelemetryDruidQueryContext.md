# TelemetryDruidQueryContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrandTotal** | **Boolean** | Druid can include an extra &quot;&quot;grand totals&quot;&quot; row as the last row of a timeseries result set. To enable this, set &quot;&quot;grandTotal&quot;&quot; to true. The grand totals row will appear as the last row in the result array, and will have no timestamp. It will be the last row even if the query is run in &quot;&quot;descending&quot;&quot; mode. Post-aggregations in the grand totals row will be computed based upon the grand total aggregations. | [optional] 
**SkipEmptyBuckets** | **Boolean** | Timeseries queries normally fill empty interior time buckets with zeroes. Time buckets that lie completely outside the data interval are not zero-filled. You can disable all zero-filling with this flag. In this mode, the data point for empty buckets are omitted from the results. | [optional] 
**Timeout** | **Int32** | Query timeout in milliseconds, beyond which unfinished queries will be cancelled. 0 timeout means no timeout. | [optional] 
**Priority** | **Int32** | Query Priority. Queries with higher priority get precedence for computational resources. | [optional] 
**QueryId** | **String** | Unique identifier given to this query. If a query ID is set or known, this can be used to cancel the query. | [optional] 
**UseCache** | **Boolean** | Flag indicating whether to leverage the query cache for this query. When set to false, it disables reading from the query cache for this query. When set to true, Apache Druid uses druid.broker.cache.useCache or druid.historical.cache.useCache to determine whether or not to read from the query cache. | [optional] 
**PopulateCache** | **Boolean** | Flag indicating whether to save the results of the query to the query cache. Primarily used for debugging. When set to false, it disables saving the results of this query to the query cache. When set to true, Druid uses druid.broker.cache.populateCache or druid.historical.cache.populateCache to determine whether or not to save the results of this query to the query cache. | [optional] 
**UseResultLevelCache** | **Boolean** | Flag indicating whether to leverage the result level cache for this query. When set to false, it disables reading from the query cache for this query. When set to true, Druid uses druid.broker.cache.useResultLevelCache to determine whether or not to read from the result-level query cache. | [optional] 
**PopulateResultLevelCache** | **Boolean** | Flag indicating whether to save the results of the query to the result level cache. Primarily used for debugging. When set to false, it disables saving the results of this query to the query cache. When set to true, Druid uses druid.broker.cache.populateResultLevelCache to determine whether or not to save the results of this query to the result-level query cache. | [optional] 
**BySegment** | **Boolean** | Return &quot;&quot;by segment&quot;&quot; results. Primarily used for debugging, setting it to true returns results associated with the data segment they came from. | [optional] 
**Finalize** | **Boolean** | Flag indicating whether to &quot;&quot;finalize&quot;&quot; aggregation results. Primarily used for debugging. For instance, the hyperUnique aggregator will return the full HyperLogLog sketch instead of the estimated cardinality when this flag is set to false. | [optional] 
**ChunkPeriod** | **String** | At the Broker process level, long interval queries (of any type) may be broken into shorter interval queries to parallelize merging more than normal. Broken up queries will use a larger share of cluster resources, but, if you use groupBy &quot;&quot;v1, it may be able to complete faster as a result. Use ISO 8601 periods. For example, if this property is set to P1M (one month), then a query covering a year would be broken into 12 smaller queries. The broker uses its query processing executor service to initiate processing for query chunks, so make sure druid.processing.numThreads is configured appropriately on the broker. groupBy queries do not support chunkPeriod by default, although they do if using the legacy &quot;&quot;v1&quot;&quot; engine. This context is deprecated since it&#39;s only useful for groupBy &quot;&quot;v1&quot;&quot;, and will be removed in the future releases. | [optional] 
**MaxScatterGatherBytes** | **Int32** | Maximum number of bytes gathered from data processes such as Historicals and realtime processes to execute a query. This parameter can be used to further reduce maxScatterGatherBytes limit at query time. | [optional] 
**MaxQueuedBytes** | **Int32** | Maximum number of bytes queued per query before exerting backpressure on the channel to the data server. Similar to maxScatterGatherBytes, except unlike that configuration, this one will trigger backpressure rather than query failure. Zero means disabled. | [optional] 
**SerializeDateTimeAsLong** | **Boolean** | If true, DateTime is serialized as long in the result returned by Broker and the data transportation between Broker and compute process. | [optional] 
**SerializeDateTimeAsLongInner** | **Boolean** | If true, DateTime is serialized as long in the data transportation between Broker and compute process. | [optional] 
**EnableParallelMerge** | **Boolean** | Enable parallel result merging on the Broker. Note that druid.processing.merge.useParallelMergePool must be enabled for this setting to be set to true. | [optional] 
**ParallelMergeParallelism** | **Int32** | Maximum number of parallel threads to use for parallel result merging on the Broker. | [optional] 
**ParallelMergeInitialYieldRows** | **Int32** | Number of rows to yield per ForkJoinPool merge task for parallel result merging on the Broker, before forking off a new task to continue merging sequences. | [optional] 
**ParallelMergeSmallBatchRows** | **Int32** | Size of result batches to operate on in ForkJoinPool merge tasks for parallel result merging on the Broker. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidQueryContext = Initialize-IntersightTelemetryDruidQueryContext  -GrandTotal null `
 -SkipEmptyBuckets null `
 -Timeout null `
 -Priority null `
 -QueryId null `
 -UseCache null `
 -PopulateCache null `
 -UseResultLevelCache null `
 -PopulateResultLevelCache null `
 -BySegment null `
 -Finalize null `
 -ChunkPeriod null `
 -MaxScatterGatherBytes null `
 -MaxQueuedBytes null `
 -SerializeDateTimeAsLong null `
 -SerializeDateTimeAsLongInner null `
 -EnableParallelMerge null `
 -ParallelMergeParallelism null `
 -ParallelMergeInitialYieldRows null `
 -ParallelMergeSmallBatchRows null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidQueryContext | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

