# VnicEthInterruptSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CoalescingTime** | **Int64** | The time to wait between interrupts or the idle period that must be encountered before an interrupt is sent. To turn off interrupt coalescing, enter 0 (zero) in this field. | [optional] 
**CoalescingType** | **String** | Interrupt Coalescing Type. This can be one of the following:- MIN  — The system waits for the time specified in the Coalescing Time field before sending another interrupt event IDLE — The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field. | [optional] [default to "MIN"]
**Count** | **Int64** | The number of interrupt resources to allocate. Typical value is be equal to the number of completion queue resources. | [optional] 
**Mode** | **String** | Preferred driver interrupt mode. This can be one of the following:- MSIx — Message Signaled Interrupts (MSI) with the optional extension. MSI   — MSI only. INTx  — PCI INTx interrupts. MSIx is the recommended option. | [optional] [default to "MSIx"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicEthInterruptSettingsAllOf  -CoalescingTime null `
 -CoalescingType null `
 -Count null `
 -Mode null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

