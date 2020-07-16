# IaasUcsdManagedInfraAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdvancedCatalogCount** | **Int64** | Total advanced catalogs in UCSD. | [optional] [readonly] 
**BmCatalogCount** | **Int64** | Total bare metal catalogs in UCSD. | [optional] [readonly] 
**ContainerCatalogCount** | **Int64** | Total service container catalogs in UCSD. | [optional] [readonly] 
**EsxiHostCount** | **Int64** | Total ESXi hosts in UCSD. | [optional] [readonly] 
**ExternalGroupCount** | **Int64** | Total external (Ldap) groups in UCSD. | [optional] [readonly] 
**HypervHostCount** | **Int64** | Total HyperV hosts in UCSD. | [optional] [readonly] 
**LocalGroupCount** | **Int64** | Total local groups in UCSD. | [optional] [readonly] 
**StandardCatalogCount** | **Int64** | Total standard catalogs in UCSD. | [optional] [readonly] 
**UserCount** | **Int64** | Total user accounts in UCSD. | [optional] [readonly] 
**VdcCount** | **Int64** | Total virtual datacenters in UCSD. | [optional] [readonly] 
**VmCount** | **Int64** | Total Virtual machines in UCSD. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIaasUcsdManagedInfraAllOf  -AdvancedCatalogCount null `
 -BmCatalogCount null `
 -ContainerCatalogCount null `
 -EsxiHostCount null `
 -ExternalGroupCount null `
 -HypervHostCount null `
 -LocalGroupCount null `
 -StandardCatalogCount null `
 -UserCount null `
 -VdcCount null `
 -VmCount null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

