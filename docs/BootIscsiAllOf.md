# BootIscsiAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Port** | **Int64** | Port ID of the ISCSI boot device. | [optional] 
**Slot** | **String** | The slot id of the device. Supported values are (1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot;, &quot;&quot;OCP&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootIscsiAllOf  -Port null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

