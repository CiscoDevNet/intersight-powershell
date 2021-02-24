# KubernetesAddonAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.Addon"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.Addon"]
**InstallStrategy** | **String** | Addon install strategy to determine whether an addon is installed if not present. * &#x60;InstallOnly&#x60; - Only install in green field. No action in case of failure or removal. * &#x60;NoAction&#x60; - No install action performed. * &#x60;Always&#x60; - Attempt install if chart is not already installed. | [optional] [default to "InstallOnly"]
**Name** | **String** | Name of addon to be installed on a Kubernetes cluster. | [optional] 
**OverrideSets** | [**KubernetesKeyValue[]**](KubernetesKeyValue.md) |  | [optional] 
**Overrides** | **String** | Properties that can be overridden for an addon. | [optional] 
**UpgradeStrategy** | **String** | Addon upgrade strategy to determine whether an addon configuration is overwritten on upgrade. * &#x60;UpgradeOnly&#x60; - Attempt upgrade if chart or overrides options change, no action on upgrade failure. * &#x60;NoAction&#x60; - This choice enables No upgrades to be performed. * &#x60;ReinstallOnFailure&#x60; - Attempt upgrade first. Remove and install on upgrade failure. * &#x60;AlwaysReinstall&#x60; - Always remove older release and reinstall. | [optional] [default to "UpgradeOnly"]
**AddonDefinition** | [**KubernetesAddonDefinitionRelationship**](KubernetesAddonDefinitionRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAddonAllOf = Initialize-IntersightKubernetesAddonAllOf  -ClassId null `
 -ObjectType null `
 -InstallStrategy null `
 -Name null `
 -OverrideSets null `
 -Overrides null `
 -UpgradeStrategy null `
 -AddonDefinition null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$KubernetesAddonAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

