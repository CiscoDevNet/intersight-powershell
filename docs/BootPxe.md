# BootPxe
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "boot.Pxe"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "boot.Pxe"]
**Enabled** | **Boolean** | Specifies if the boot device is enabled or disabled. | [optional] [default to $false]
**Name** | **String** | A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. | [optional] 
**InterfaceName** | **String** | The name of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**InterfaceSource** | **String** | Lists the supported Interface Source for PXE device. Supported values are &quot;&quot;name&quot;&quot; and &quot;&quot;mac&quot;&quot;. * &#x60;name&#x60; - Use interface name to select virtual ethernet interface. * &#x60;mac&#x60; - Use MAC address to select virtual ethernet interface. * &#x60;port&#x60; - Use port to select virtual ethernet interface. | [optional] [default to "name"]
**IpType** | **String** | The IP Address family type to use during the PXE Boot process. * &#x60;None&#x60; - Default value if IpType is not specified. * &#x60;IPv4&#x60; - The IPv4 address family type. * &#x60;IPv6&#x60; - The IPv6 address family type. | [optional] [default to "None"]
**MacAddress** | **String** | The MAC Address of the underlying virtual ethernet interface used by the PXE boot device. | [optional] 
**Port** | **Int64** | The Port ID of the adapter on which the underlying virtual ethernet interface is present. If no port is specified, the default value is -1. Supported values are -1 to 255. | [optional] [default to -1]
**Slot** | **String** | The slot ID of the adapter on which the underlying virtual ethernet interface is present. Supported values are ( 1 - 255, &quot;&quot;MLOM&quot;&quot;, &quot;&quot;L&quot;&quot;, &quot;&quot;L1&quot;&quot;, &quot;&quot;L2&quot;&quot;, &quot;&quot;OCP&quot;&quot;). | [optional] 

## Examples

- Prepare the resource
```powershell
$BootPxe = Initialize-IntersightBootPxe  -ClassId null `
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
$BootPxe | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

