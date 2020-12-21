# ApplianceNodeInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.NodeInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.NodeInfo"]
**Hostname** | **String** | Cluster node&#39;s FQDN or IP address. | [optional] [readonly] 
**NodeId** | **Int64** | System assigned unique ID of the Intersight Appliance node. The system incrementally assigns identifiers to each node in the Intersight Appliance cluster starting with a value of 1. | [optional] [readonly] 
**NodeIpV4Config** | [**CommIpV4Interface**](CommIpV4Interface.md) |  | [optional] 
**NodeIpV6Config** | [**CommIpV6Interface**](CommIpV6Interface.md) |  | [optional] 
**OperationalStatus** | **String** | Operational status of the Intersight Appliance node. * &#x60;Unknown&#x60; - Operational status of the Intersight Appliance entity is Unknown. * &#x60;Operational&#x60; - Operational status of the Intersight Appliance entity is Operational. * &#x60;Impaired&#x60; - Operational status of the Intersight Appliance entity is Impaired. * &#x60;AttentionNeeded&#x60; - Operational status of the Intersight Appliance entity is AttentionNeeded. | [optional] [readonly] [default to "Unknown"]

## Examples

- Prepare the resource
```powershell
$ApplianceNodeInfoAllOf = Initialize-IntersightApplianceNodeInfoAllOf  -ClassId null `
 -ObjectType null `
 -Hostname null `
 -NodeId null `
 -NodeIpV4Config null `
 -NodeIpV6Config null `
 -OperationalStatus null
```

- Convert the resource to JSON
```powershell
$ApplianceNodeInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

