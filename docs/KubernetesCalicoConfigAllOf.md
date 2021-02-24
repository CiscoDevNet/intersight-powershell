# KubernetesCalicoConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.CalicoConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.CalicoConfig"]
**IpVersion** | **String** | IP version that can take on values v4 or v6. * &#x60;v4&#x60; - This refers to the IPv4 address. * &#x60;v6&#x60; - This refers to the IPv6 address. | [optional] [default to "v4"]
**Mtu** | **Int64** | Workload interface maximum transmission unit (MTU). | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesCalicoConfigAllOf = Initialize-IntersightKubernetesCalicoConfigAllOf  -ClassId null `
 -ObjectType null `
 -IpVersion null `
 -Mtu null
```

- Convert the resource to JSON
```powershell
$KubernetesCalicoConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

