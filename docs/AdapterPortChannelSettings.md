# AdapterPortChannelSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.PortChannelSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.PortChannelSettings"]
**Enabled** | **Boolean** | When Port Channel is enabled, two vNICs and two vHBAs are available for use on the adapter card. When disabled, four vNICs and four vHBAs are available for use on the adapter card. Disabling port channel reboots the server. Port Channel is supported only for Cisco VIC 1455/1457 adapters. | [optional] [default to $true]

## Examples

- Prepare the resource
```powershell
$AdapterPortChannelSettings = Initialize-IntersightAdapterPortChannelSettings  -ClassId null `
 -ObjectType null `
 -Enabled null
```

- Convert the resource to JSON
```powershell
$AdapterPortChannelSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

