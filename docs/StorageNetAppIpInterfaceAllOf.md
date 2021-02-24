# StorageNetAppIpInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppIpInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppIpInterface"]
**Enabled** | **String** | IP interface is enabled or not. | [optional] [readonly] 
**HomeNode** | **String** | Name of home node of IP interface. | [optional] [readonly] 
**HomePort** | **String** | Name of home port of IP interface. | [optional] [readonly] 
**IpAddress** | **String** | IP address of inteface. | [optional] [readonly] 
**IpFamily** | **String** | IP address family of inteface. * &#x60;IPv4&#x60; - IPv4 Address type. * &#x60;IPv6&#x60; - IPv6 Address type. | [optional] [readonly] [default to "IPv4"]
**Name** | **String** | Name of IP interface. | [optional] [readonly] 
**Netmask** | **String** | Netmask of Interface. | [optional] [readonly] 
**ServicePolicyName** | **String** | Services of IP interface. | [optional] [readonly] 
**ServicePolicyUuid** | **String** | Services of IP interface. | [optional] [readonly] 
**Services** | **String[]** |  | [optional] 
**State** | **String** | State of IP interface. * &#x60;down&#x60; - An inactive port is listed as Down. * &#x60;up&#x60; - An active port is listed as Up. * &#x60;present&#x60; - An active port is listed as present. | [optional] [readonly] [default to "down"]
**Uuid** | **String** | Uuid of  NetApp IP Interface. | [optional] [readonly] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 
**NetAppEthernetPort** | [**StorageNetAppEthernetPortRelationship**](StorageNetAppEthernetPortRelationship.md) |  | [optional] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppIpInterfaceAllOf = Initialize-IntersightStorageNetAppIpInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -HomeNode null `
 -HomePort null `
 -IpAddress null `
 -IpFamily null `
 -Name null `
 -Netmask null `
 -ServicePolicyName null `
 -ServicePolicyUuid null `
 -Services null `
 -State null `
 -Uuid null `
 -ArrayController null `
 -NetAppEthernetPort null `
 -Tenant null
```

- Convert the resource to JSON
```powershell
$StorageNetAppIpInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

