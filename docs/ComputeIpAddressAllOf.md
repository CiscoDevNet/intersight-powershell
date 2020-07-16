# ComputeIpAddressAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **String** | IP Address to be used for KVM. | [optional] [readonly] 
**Category** | **String** | Category of the Kvm IP Address. | [optional] [readonly] [default to "Equipment"]
**DefaultGateway** | **String** | Default gateway property of KVM IP Address. | [optional] [readonly] 
**Dn** | **String** | The distinguished name for this managed object. | [optional] [readonly] 
**HttpPort** | **Int64** | HTTP port of an IP Address. | [optional] [readonly] 
**HttpsPort** | **Int64** | Secured HTTP port of an IP Address. | [optional] [readonly] 
**KvmPort** | **Int64** | Port number on which the KVM is running and used for connecting to KVM console. | [optional] [readonly] 
**KvmVlan** | **Int64** | VLAN Identifier of Inband IP Address. | [optional] [readonly] 
**Name** | **String** | Name to identify the KVM IP Address. | [optional] [readonly] [default to "Outband"]
**Subnet** | **String** | Subnet detail of a KVM IP Address. | [optional] [readonly] 
**Type** | **String** | Type of the KVM IP Address. | [optional] [readonly] [default to "MgmtInterface"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeIpAddressAllOf  -Address null `
 -Category null `
 -DefaultGateway null `
 -Dn null `
 -HttpPort null `
 -HttpsPort null `
 -KvmPort null `
 -KvmVlan null `
 -Name null `
 -Subnet null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

