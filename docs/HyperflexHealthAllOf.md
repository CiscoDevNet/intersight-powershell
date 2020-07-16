# HyperflexHealthAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArbitrationServiceState** | **String** |  | [optional] [readonly] [default to "NOT_AVAILABLE"]
**DataReplicationCompliance** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**ResiliencyDetails** | [**HyperflexHxResiliencyInfoDt**](HyperflexHxResiliencyInfoDt.md) |  | [optional] 
**State** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**Uuid** | **String** |  | [optional] [readonly] 
**ZkHealth** | **String** |  | [optional] [readonly] [default to "NOT_AVAILABLE"]
**ZoneResiliencyList** | [**HyperflexHxZoneResiliencyInfoDt[]**](HyperflexHxZoneResiliencyInfoDt.md) |  | [optional] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexHealthAllOf  -ArbitrationServiceState null `
 -DataReplicationCompliance null `
 -ResiliencyDetails null `
 -State null `
 -Uuid null `
 -ZkHealth null `
 -ZoneResiliencyList null `
 -Cluster null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

