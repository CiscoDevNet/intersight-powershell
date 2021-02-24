# IamIpAddressAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.IpAddress"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.IpAddress"]
**Address** | **String** | The Trusted IP range&#39;s address. IP address, CIDR range, and IP address range formats are supported. For example &#39;12.13.14.15&#39;, &#39;12.13.14.0/24&#39;, and &#39;12.13.14.15-12.13.14.200&#39;. Reserved IP ranges &#39;127.0.0.1&#39;, &#39;10.0.0.0/8&#39;, &#39;172.16.0.0/12&#39;, and &#39;192.168.0.0/16&#39; are not allowed. | [optional] 
**Description** | **String** | Description of Trusted IP address range. | [optional] 
**IpAccessManagement** | [**IamIpAccessManagementRelationship**](IamIpAccessManagementRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamIpAddressAllOf = Initialize-IntersightIamIpAddressAllOf  -ClassId null `
 -ObjectType null `
 -Address null `
 -Description null `
 -IpAccessManagement null
```

- Convert the resource to JSON
```powershell
$IamIpAddressAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

