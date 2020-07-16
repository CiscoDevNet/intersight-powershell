# BootPxe
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] 
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**InterfaceName** | **String** | The name of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**InterfaceSource** | **String** | Lists the supported Interface Source for PXE device. Supported values are &quot;&quot;name&quot;&quot; and &quot;&quot;mac&quot;&quot;. | [optional] [default to "name"]
**IpType** | **String** | The IP Address family type to use during the PXE Boot process. | [optional] [default to "None"]
**MacAddress** | **String** | The MAC Address of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**Port** | **Int64** | The Port ID of the adapter on which the underlying virtual ethernet interface is present. If no port is specified, the default value is -1. Supported values are -1 to 255. | [optional] 
**Slot** | **String** | The slot ID of the adapter on which the underlying virtual ethernet interface is present. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot;, &quot;&quot;OCP&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBootPxe  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Name null `
 -InterfaceName null `
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

