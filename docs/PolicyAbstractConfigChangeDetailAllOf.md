# PolicyAbstractConfigChangeDetailAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Changes** | **String[]** |  | [optional] 
**ConfigChangeContext** | [**PolicyConfigResultContext**](PolicyConfigResultContext.md) |  | [optional] 
**ConfigChangeFlag** | **String** | Config change flag to differentiate Pending-changes and Config-drift. | [optional] [default to "Pending-changes"]
**Disruptions** | **String[]** |  | [optional] 
**Message** | [**AnyType**](.md) | Detailed description of the config change.} type: string | [optional] 
**ModStatus** | **String** | Modification status of the mo in this config change. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyAbstractConfigChangeDetailAllOf  -Changes null `
 -ConfigChangeContext null `
 -ConfigChangeFlag null `
 -Disruptions null `
 -Message null `
 -ModStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

