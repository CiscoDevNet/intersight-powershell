# PolicyAbstractConfigChangeDetailAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Changes** | **String[]** |  | [optional] 
**ConfigChangeContext** | [**PolicyConfigResultContext**](PolicyConfigResultContext.md) |  | [optional] 
**ConfigChangeFlag** | **String** | Config change flag to differentiate Pending-changes and Config-drift. * &#x60;Pending-changes&#x60; - Config change flag represents changes are due to not deployed changes from Intersight. * &#x60;Drift-changes&#x60; - Config change flag represents changes are due to endpoint configuration changes. | [optional] [default to "Pending-changes"]
**Disruptions** | **String[]** |  | [optional] 
**Message** | **String** | Detailed description of the config change. | [optional] 
**ModStatus** | **String** | Modification status of the mo in this config change. * &#x60;None&#x60; - The &#39;none&#39; operation/state.Indicates a configuration profile has been deployed, and the desired configuration matches the actual device configuration. * &#x60;Created&#x60; - The &#39;create&#39; operation/state.Indicates a configuration profile has been created and associated with a device, but the configuration specified in the profilehas not been applied yet. For example, this could happen when the user creates a server profile and has not deployed the profile yet. * &#x60;Modified&#x60; - The &#39;update&#39; operation/state.Indicates some of the desired configuration changes specified in a profile have not been been applied to the associated device.This happens when the user has made changes to a profile and has not deployed the changes yet, or when the workflow to applythe configuration changes has not completed succesfully. * &#x60;Deleted&#x60; - The &#39;delete&#39; operation/state.Indicates a configuration profile has been been disassociated from a device and the user has not undeployed these changes yet. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$PolicyAbstractConfigChangeDetailAllOf = Initialize-IntersightPolicyAbstractConfigChangeDetailAllOf  -ClassId null `
 -ObjectType null `
 -Changes null `
 -ConfigChangeContext null `
 -ConfigChangeFlag null `
 -Disruptions null `
 -Message null `
 -ModStatus null
```

- Convert the resource to JSON
```powershell
$PolicyAbstractConfigChangeDetailAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

