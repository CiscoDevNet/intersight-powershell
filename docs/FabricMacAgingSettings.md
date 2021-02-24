# FabricMacAgingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.MacAgingSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.MacAgingSettings"]
**MacAgingOption** | **String** | This specifies one of the option to configure the MAC address aging time. * &#x60;Default&#x60; - This option sets the default MAC address aging time to 14500 seconds for End Host mode. * &#x60;Custom&#x60; - This option allows the the user to configure the MAC address aging time on the switch. For Switch Model UCS-FI-6454 or higher, the valid range is 120 to 918000 seconds and the switch will set the lower multiple of 5 of the given time. * &#x60;Never&#x60; - This option disables the MAC address aging process and never allows the MAC address entries to get removed from the table. | [optional] [default to "Default"]
**MacAgingTime** | **Int32** | Define the MAC address aging time in seconds. This field is valid when the &quot;&quot;Custom&quot;&quot; MAC address aging option is selected. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricMacAgingSettings = Initialize-IntersightFabricMacAgingSettings  -ClassId null `
 -ObjectType null `
 -MacAgingOption null `
 -MacAgingTime null
```

- Convert the resource to JSON
```powershell
$FabricMacAgingSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

