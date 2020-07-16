# BootPxeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InterfaceName** | **String** | The name of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**InterfaceSource** | **String** | Lists the supported Interface Source for PXE device. Supported values are &quot;&quot;name&quot;&quot; and &quot;&quot;mac&quot;&quot;. | [optional] [default to "name"]
**IpType** | **String** | The IP Address family type to use during the PXE Boot process. | [optional] [default to "None"]
**MacAddress** | **String** | The MAC Address of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**Port** | **Int64** | The Port ID of the adapter on which the underlying virtual ethernet interface is present. If no port is specified, the default value is -1. Supported values are -1 to 255. | [optional] 
**Slot** | **String** | The slot ID of the adapter on which the underlying virtual ethernet interface is present. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot;, &quot;&quot;OCP&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootPxeAllOf  -InterfaceName null `
 -InterfaceSource null `
 -IpType null `
 -MacAddress null `
 -Port null `
 -Slot null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

