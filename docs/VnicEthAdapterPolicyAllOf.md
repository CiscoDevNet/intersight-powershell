# VnicEthAdapterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthAdapterPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthAdapterPolicy"]
**AdvancedFilter** | **Boolean** | Enables advanced filtering on the interface. | [optional] [default to $false]
**ArfsSettings** | [**VnicArfsSettings**](VnicArfsSettings.md) |  | [optional] 
**CompletionQueueSettings** | [**VnicCompletionQueueSettings**](VnicCompletionQueueSettings.md) |  | [optional] 
**InterruptScaling** | **Boolean** | Enables Interrupt Scaling on the interface. | [optional] [default to $false]
**InterruptSettings** | [**VnicEthInterruptSettings**](VnicEthInterruptSettings.md) |  | [optional] 
**NvgreSettings** | [**VnicNvgreSettings**](VnicNvgreSettings.md) |  | [optional] 
**RoceSettings** | [**VnicRoceSettings**](VnicRoceSettings.md) |  | [optional] 
**RssHashSettings** | [**VnicRssHashSettings**](VnicRssHashSettings.md) |  | [optional] 
**RssSettings** | **Boolean** | Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores. | [optional] [default to $true]
**RxQueueSettings** | [**VnicEthRxQueueSettings**](VnicEthRxQueueSettings.md) |  | [optional] 
**TcpOffloadSettings** | [**VnicTcpOffloadSettings**](VnicTcpOffloadSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicEthTxQueueSettings**](VnicEthTxQueueSettings.md) |  | [optional] 
**UplinkFailbackTimeout** | **Int64** | Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC. | [optional] [default to 5]
**VxlanSettings** | [**VnicVxlanSettings**](VnicVxlanSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicEthAdapterPolicyAllOf = Initialize-IntersightVnicEthAdapterPolicyAllOf  -ClassId null `
 -ObjectType null `
 -AdvancedFilter null `
 -ArfsSettings null `
 -CompletionQueueSettings null `
 -InterruptScaling null `
 -InterruptSettings null `
 -NvgreSettings null `
 -RoceSettings null `
 -RssHashSettings null `
 -RssSettings null `
 -RxQueueSettings null `
 -TcpOffloadSettings null `
 -TxQueueSettings null `
 -UplinkFailbackTimeout null `
 -VxlanSettings null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$VnicEthAdapterPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

