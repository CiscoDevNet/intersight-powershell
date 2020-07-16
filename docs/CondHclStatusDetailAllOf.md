# CondHclStatusDetailAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HardwareStatus** | **String** | The model is considered as part of the hardware profile for the component. This will provide the HCL validation status for the hardware profile. The reasons can be one of the following &quot;&quot;Incompatible-Server-With-Component&quot;&quot; - the server model and component combination is not listed in HCL &quot;&quot;Incompatible-Firmware&quot;&quot; - The server&#39;s firmware is not listed for this component&#39;s hardware profile &quot;&quot;Incompatible-Component&quot;&quot; - the component&#39;s model is not listed in the HCL &quot;&quot;Service-Unavailable&quot;&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating &quot;&quot;Not-Evaluated&quot;&quot; - the hardware profile was not evaulated for the component because the server&#39;s hw/sw status is not listed or server is exempted. &quot;&quot;Compatible&quot;&quot; - this component&#39;s hardware profile is listed in the HCL. | [optional] [default to "Missing-Os-Driver-Info"]
**HclCimcVersion** | **String** | The current CIMC version for the server normalized for querying HCL data. | [optional] 
**HclDriverName** | **String** | The current driver name of the component we are validating normalized for querying HCL data. | [optional] 
**HclDriverVersion** | **String** | The current driver version of the component we are validating normalized for querying HCL data. | [optional] 
**HclFirmwareVersion** | **String** | The current firmware version of the component model normalized for querying HCL data. | [optional] 
**HclModel** | **String** | The component model we are trying to validate normalized for querying HCL data. | [optional] 
**InvCimcVersion** | **String** | The current CIMC version for the server as received from inventory. | [optional] 
**InvDriverName** | **String** | The current driver name of the component we are validating as received from inventory. | [optional] 
**InvDriverVersion** | **String** | The current driver version of the component we are validating as received from inventory. | [optional] 
**InvFirmwareVersion** | **String** | The current firmware version of the component model as received from inventory. | [optional] 
**InvModel** | **String** | The component model we are trying to validate as received from inventory. | [optional] 
**Reason** | **String** | The reason for the status. The reason can be one of &quot;&quot;Incompatible-Server-With-Component&quot;&quot; - HCL validation has failed because the server model is not validated with this component &quot;&quot;Incompatible-Processor&quot;&quot; - HCL validation has failed because the processor is not validated with this server &quot;&quot;Incompatible-Os-Info&quot;&quot; - HCL validation has failed because the os vendor and version is not validated with this server &quot;&quot;Incompatible-Component-Model&quot;&quot; - HCL validation has failed because the component model is not validated &quot;&quot;Incompatible-Firmware&quot;&quot; - HCL validation has failed because the component or server firmware version is not validated &quot;&quot;Incompatible-Driver&quot;&quot; - HCL validation has failed because the driver version is not validated &quot;&quot;Incompatible-Firmware-Driver&quot;&quot; - HCL validation has failed because the firmware version and driver version is not validated &quot;&quot;Missing-Os-Driver-Info&quot;&quot; - HCL validation was not performed because we are missing os driver information form the inventory &quot;&quot;Service-Unavailable&quot;&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating &quot;&quot;Service-Error&quot;&quot; - HCL data service is available but an error occured when making the request or parsing the response &quot;&quot;Unrecognized-Protocol&quot;&quot; - This service does not recognize the reason code in the response from the HCL data service &quot;&quot;Compatible&quot;&quot; - this component&#39;s inventory data has &quot;&quot;Validated&quot;&quot; status with the HCL. &quot;&quot;Not-Evaluated&quot;&quot; - The component is not evaluated against the HCL because the server is exempted. | [optional] [default to "Missing-Os-Driver-Info"]
**SoftwareStatus** | **String** | The firmware, driver name and driver version are considered as part of the software profile for the component. This will provide the HCL validation status for the software profile. The reasons can be one of the following &quot;&quot;Incompatible-Firmware&quot;&quot; - the component&#39;s firmware is not listed under the server&#39;s hardware and software profile and the component&#39;s hardware profile &quot;&quot;Incompatible-Driver&quot;&quot; - the component&#39;s driver is not listed under the server&#39;s hardware and software profile and the component&#39;s hardware profile &quot;&quot;Incompatible-Firmware-Driver&quot;&quot; - the component&#39;s firmware and driver are not listed under the server&#39;s hardware and software profile and the component&#39;s hardware profile &quot;&quot;Service-Unavailable&quot;&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating &quot;&quot;Not-Evaluated&quot;&quot; - the component&#39;s hardware status was not evaluated because the server&#39;s hardware or software profile is not listed or server is exempted. &quot;&quot;Compatible&quot;&quot; - this component&#39;s hardware profile is listed in the HCL. | [optional] [default to "Missing-Os-Driver-Info"]
**Status** | **String** | The status for the component model, firmware version, driver name, and driver version after validating against the HCL. The status can be one of the following &quot;&quot;Unknown&quot;&quot; - we do not have enough information to evaluate against the HCL data &quot;&quot;Validated&quot;&quot; - we have validated this component against the HCL and it has &quot;&quot;Validated&quot;&quot; status &quot;&quot;Not-Validated&quot;&quot; - we have validated this component against the HCL and it has &quot;&quot;Not-Validated&quot;&quot; status. &quot;&quot;Not-Evaluated&quot;&quot; - The component is not evaluated against the HCL because the server is exempted. | [optional] [default to "Incomplete"]
**Component** | [**InventoryBaseRelationship**](InventoryBaseRelationship.md) |  | [optional] 
**HclStatus** | [**CondHclStatusRelationship**](CondHclStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCondHclStatusDetailAllOf  -HardwareStatus null `
 -HclCimcVersion null `
 -HclDriverName null `
 -HclDriverVersion null `
 -HclFirmwareVersion null `
 -HclModel null `
 -InvCimcVersion null `
 -InvDriverName null `
 -InvDriverVersion null `
 -InvFirmwareVersion null `
 -InvModel null `
 -Reason null `
 -SoftwareStatus null `
 -Status null `
 -Component null `
 -HclStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

