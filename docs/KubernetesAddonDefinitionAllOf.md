# KubernetesAddonDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AddonDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AddonDefinition"]
**ChartUrl** | **String** | Description of the addon component. | [optional] 
**DefaultInstallStrategy** | **String** | Default installation strategy for the release. * &#x60;InstallOnly&#x60; - Only install in green field. No action in case of failure or removal. * &#x60;NoAction&#x60; - No install action performed. * &#x60;Always&#x60; - Attempt install if chart is not already installed. | [optional] [default to "InstallOnly"]
**DefaultNamespace** | **String** | Default namespace to install the release. | [optional] 
**DefaultUpgradeStrategy** | **String** | Default upgrade strategy for the release. * &#x60;UpgradeOnly&#x60; - Attempt upgrade if chart or overrides options change, no action on upgrade failure. * &#x60;NoAction&#x60; - This choice enables No upgrades to be performed. * &#x60;ReinstallOnFailure&#x60; - Attempt upgrade first. Remove and install on upgrade failure. * &#x60;AlwaysReinstall&#x60; - Always remove older release and reinstall. | [optional] [default to "UpgradeOnly"]
**Description** | **String** | Description of the addon component. | [optional] 
**Digest** | **String** | Digest used to verify the integrity of an addon. | [optional] 
**IconUrl** | **String** | Icon used to represent the addon in UI. | [optional] 
**Name** | **String** | Name of an addon component. | [optional] 
**Version** | **String** | Version of the addon component. | [optional] [readonly] 
**Catalog** | [**KubernetesCatalogRelationship**](KubernetesCatalogRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAddonDefinitionAllOf = Initialize-IntersightKubernetesAddonDefinitionAllOf  -ClassId null `
 -ObjectType null `
 -ChartUrl null `
 -DefaultInstallStrategy null `
 -DefaultNamespace null `
 -DefaultUpgradeStrategy null `
 -Description null `
 -Digest null `
 -IconUrl null `
 -Name null `
 -Version null `
 -Catalog null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$KubernetesAddonDefinitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

