# VnicEthAdapterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdvancedFilter** | **Boolean** | Enables advanced filtering on the interface. | [optional] 
**ArfsSettings** | [**VnicArfsSettings**](VnicArfsSettings.md) |  | [optional] 
**CompletionQueueSettings** | [**VnicCompletionQueueSettings**](VnicCompletionQueueSettings.md) |  | [optional] 
**InterruptScaling** | **Boolean** | Enables Interrupt Scaling on the interface. | [optional] 
**InterruptSettings** | [**VnicEthInterruptSettings**](VnicEthInterruptSettings.md) |  | [optional] 
**NvgreSettings** | [**VnicNvgreSettings**](VnicNvgreSettings.md) |  | [optional] 
**RoceSettings** | [**VnicRoceSettings**](VnicRoceSettings.md) |  | [optional] 
**RssHashSettings** | [**VnicRssHashSettings**](VnicRssHashSettings.md) |  | [optional] 
**RssSettings** | **Boolean** | Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores. | [optional] 
**RxQueueSettings** | [**VnicEthRxQueueSettings**](VnicEthRxQueueSettings.md) |  | [optional] 
**TcpOffloadSettings** | [**VnicTcpOffloadSettings**](VnicTcpOffloadSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicEthTxQueueSettings**](VnicEthTxQueueSettings.md) |  | [optional] 
**UplinkFailbackTimeout** | **Int64** | Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC. | [optional] 
**VxlanSettings** | [**VnicVxlanSettings**](VnicVxlanSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicEthAdapterPolicyAllOf  -AdvancedFilter null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

