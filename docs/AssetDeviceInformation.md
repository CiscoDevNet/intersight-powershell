# AssetDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceInformation"]
**ApplicationName** | **String** | Application name reported by Cisco Install Base. | [optional] [readonly] 
**DeviceTransactions** | [**AssetDeviceTransaction[]**](AssetDeviceTransaction.md) |  | [optional] 
**EndCustomer** | [**AssetCustomerInformation**](AssetCustomerInformation.md) |  | [optional] 
**InstanceId** | **String** | Instance number of the device. example &quot;&quot;917280220&quot;&quot;. | [optional] [readonly] 
**ItemType** | **String** | Item type flag. example ATO, Child, Standalone. ATO - refers to Cisco Block based major device. Child - refers to Child device part of an ATO block. Standalone - refers to a device that is managed and configured as an individual entity with limited capacity. | [optional] [readonly] 
**MlbOfferType** | **String** | Identifier for consumption based pricing. MLB refers to MultiLine Bundle. | [optional] [readonly] 
**MlbProductId** | **Int64** | Identifier corresponding to MLB Product Name. MLB refers to MultiLine Bundle. | [optional] [readonly] 
**MlbProductName** | **String** | Product Name for the device. It is used to determine if the server is to be billed as a UCS compute device or a storage cluster. MLB refers to MultiLine Bundle. | [optional] [readonly] 
**OldDeviceId** | **String** | Unique identifier of old Cisco device. It is the device ID of old Cisco device, which got replaced by the new device. | [optional] [readonly] 
**OldDeviceStatusDescription** | **String** | Description of status of old Cisco device, which got replaced by the new device. | [optional] [readonly] 
**OldDeviceStatusId** | **Int32** | Status ID of old Cisco device, which got replaced by the new device. * &#x60;0&#x60; - A default value to catch cases where device status is not correctly detected. * &#x60;10000&#x60; - Device is installed successfully. * &#x60;1010041&#x60; - Device is currently in Return Material Authorization process. * &#x60;10005&#x60; - Device is replaced successfully with another device. * &#x60;10007&#x60; - Device is returned succcessfuly. * &#x60;10009&#x60; - Device is terminated at customer&#39;s end. | [optional] [readonly] [default to 0]
**OldInstanceId** | **String** | Instance number of the old device, which got replaced by the new device. | [optional] [readonly] 
**ProductFamily** | **String** | Product Family is the field used to identify the hypervisor type. example &quot;&quot;ESXi&quot;&quot;. | [optional] [readonly] 
**ProductType** | **String** | Product type helps to determine if device has to be billed using consumption metering. example &quot;&quot;SERVER&quot;&quot;. | [optional] [readonly] 
**UnitOfMeasure** | **String** | Unit of Measure is flag used to identify the type of metric being pushed. example - &quot;&quot;STORAGE&quot;&quot; for hardware metrics , &quot;&quot;VM&quot;&quot; - for hypervisor metrics. * &#x60;None&#x60; - A default value to catch cases where unit of measure is not correctly detected. * &#x60;STORAGE&#x60; - The metric type of the device is a storage metric. * &#x60;NODE&#x60; - The metric type of the device is a hardware metric. * &#x60;VM&#x60; - The metric type of the device is a hypervisor metric. | [optional] [readonly] [default to "None"]

## Examples

- Prepare the resource
```powershell
$AssetDeviceInformation = Initialize-IntersightAssetDeviceInformation  -ClassId null `
 -ObjectType null `
 -ApplicationName null `
 -DeviceTransactions null `
 -EndCustomer null `
 -InstanceId null `
 -ItemType null `
 -MlbOfferType null `
 -MlbProductId null `
 -MlbProductName null `
 -OldDeviceId null `
 -OldDeviceStatusDescription null `
 -OldDeviceStatusId null `
 -OldInstanceId null `
 -ProductFamily null `
 -ProductType null `
 -UnitOfMeasure null
```

- Convert the resource to JSON
```powershell
$AssetDeviceInformation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

