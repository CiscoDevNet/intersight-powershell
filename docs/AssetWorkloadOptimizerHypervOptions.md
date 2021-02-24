# AssetWorkloadOptimizerHypervOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.WorkloadOptimizerHypervOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.WorkloadOptimizerHypervOptions"]
**DiscoverHostCluster** | **Boolean** | When enabled, all HyperV hosts in the same cluster of specified HyperV host target will be discovered Each server must still be configured to allow remote management (for example, configuring WinRM using a GPO). | [optional] 
**FullDomainName** | **String** | Fully qualified domain name of the HyperV target. It is used to get the name of the Hyper-V cluster node and do Active Directory authentication process through Kerberos scheme. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetWorkloadOptimizerHypervOptions = Initialize-IntersightAssetWorkloadOptimizerHypervOptions  -ClassId null `
 -ObjectType null `
 -DiscoverHostCluster null `
 -FullDomainName null
```

- Convert the resource to JSON
```powershell
$AssetWorkloadOptimizerHypervOptions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

