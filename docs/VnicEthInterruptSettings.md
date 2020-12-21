# VnicEthInterruptSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthInterruptSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthInterruptSettings"]
**CoalescingTime** | **Int64** | The time to wait between interrupts or the idle period that must be encountered before an interrupt is sent. To turn off interrupt coalescing, enter 0 (zero) in this field. | [optional] [default to 125]
**CoalescingType** | **String** | Interrupt Coalescing Type. This can be one of the following:- MIN  - The system waits for the time specified in the Coalescing Time field before sending another interrupt event IDLE - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field. * &#x60;MIN&#x60; - The system waits for the time specified in the Coalescing Time field before sending another interrupt event. * &#x60;IDLE&#x60; - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field. | [optional] [default to "MIN"]
**Count** | **Int64** | The number of interrupt resources to allocate. Typical value is be equal to the number of completion queue resources. | [optional] [default to 8]
**Mode** | **String** | Preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option. * &#x60;MSIx&#x60; - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option. * &#x60;MSI&#x60; - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts. * &#x60;INTx&#x60; - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems. | [optional] [default to "MSIx"]

## Examples

- Prepare the resource
```powershell
$VnicEthInterruptSettings = Initialize-IntersightVnicEthInterruptSettings  -ClassId null `
 -ObjectType null `
 -CoalescingTime null `
 -CoalescingType null `
 -Count null `
 -Mode null
```

- Convert the resource to JSON
```powershell
$VnicEthInterruptSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

