# KubernetesAddonRepositoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AddonRepository"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AddonRepository"]
**CaCert** | [**X509Certificate**](X509Certificate.md) |  | [optional] 
**InsecureSkipVerification** | **Boolean** | Allow connecting to http registries or https registries which do not have certificate signed by a well known CA. | [optional] [default to $false]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**IsTokenSet** | **Boolean** | Indicates whether the value of the &#39;token&#39; property has been set. | [optional] [readonly] [default to $false]
**Name** | **String** | Name of the addon repository or registry. | [optional] 
**RepositoryUrl** | **String** | URL for the repository where the addon is hosted. | [optional] 
**Username** | **String** | Username to authenticate to the addon registry. | [optional] 
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAddonRepositoryAllOf = Initialize-IntersightKubernetesAddonRepositoryAllOf  -ClassId null `
 -ObjectType null `
 -CaCert null `
 -InsecureSkipVerification null `
 -IsPasswordSet null `
 -IsTokenSet null `
 -Name null `
 -RepositoryUrl null `
 -Username null `
 -Catalog null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$KubernetesAddonRepositoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

