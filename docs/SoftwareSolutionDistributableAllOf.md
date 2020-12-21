# SoftwareSolutionDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "software.SolutionDistributable"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "software.SolutionDistributable"]
**FilePath** | **String** | The path of the file in S3/minio bucket. | [optional] [readonly] 
**SolutionName** | **String** | The name of the solution in which the image belongs. | [optional] 
**SubType** | **String** | The type of the file like OS image, Script etc. * &#x60;osimage&#x60; - The solution OS image for deployment. * &#x60;script&#x60; - The Python script for the solution VM configuration and deployment. | [optional] [default to "osimage"]
**Var0Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 
**Var1Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 
**Var2Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 
**Var3Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwareSolutionDistributableAllOf = Initialize-IntersightSoftwareSolutionDistributableAllOf  -ClassId null `
 -ObjectType null `
 -FilePath null `
 -SolutionName null `
 -SubType null `
 -Var0Version null `
 -Var1Version null `
 -Var2Version null `
 -Var3Version null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$SoftwareSolutionDistributableAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

