# ApplianceNodeInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **String** | Cluster node&#39;s FQDN or IP address. | [optional] [readonly] 
**NodeId** | **Int64** | System assigned unique ID of the Intersight Appliance node. The system incrementally assigns identifiers to each node in the Intersight Appliance cluster starting with a value of 1. | [optional] [readonly] 
**NodeIpV4Config** | [**CommIpV4Interface**](CommIpV4Interface.md) |  | [optional] 
**OperationalStatus** | **String** | Operational status of the Intersight Appliance node. | [optional] [readonly] [default to "Unknown"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceNodeInfoAllOf  -Hostname null `
 -NodeId null `
 -NodeIpV4Config null `
 -OperationalStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

