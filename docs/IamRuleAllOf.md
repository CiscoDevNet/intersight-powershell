# IamRuleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Rule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Rule"]
**IpV6** | **Boolean** | The flag represents if IP addresses in the rule is IPv4 or IPv6. | [optional] 
**RuleType** | **String** | The type of the IP address. Currently three types are supported, ie IP, CIDR range and IP range. * &#x60;Ip&#x60; - The IP address rule type is IP. * &#x60;Cidr&#x60; - The IP address rule type is CIDR range. * &#x60;IpRange&#x60; - The IP address rule type is IP range. | [optional] [default to "Ip"]
**RuleValue** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamRuleAllOf = Initialize-IntersightIamRuleAllOf  -ClassId null `
 -ObjectType null `
 -IpV6 null `
 -RuleType null `
 -RuleValue null
```

- Convert the resource to JSON
```powershell
$IamRuleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

