# VnicFcInterruptSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.FcInterruptSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.FcInterruptSettings"]
**Mode** | **String** | The preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option. * &#x60;MSIx&#x60; - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option. * &#x60;MSI&#x60; - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts. * &#x60;INTx&#x60; - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems. | [optional] [default to "MSIx"]

## Examples

- Prepare the resource
```powershell
$VnicFcInterruptSettings = Initialize-IntersightVnicFcInterruptSettings  -ClassId null `
 -ObjectType null `
 -Mode null
```

- Convert the resource to JSON
```powershell
$VnicFcInterruptSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

