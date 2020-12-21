# AssetDeviceContractInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceContractInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceContractInformation"]
**Contract** | [**AssetContractInformation**](AssetContractInformation.md) |  | [optional] 
**ContractStatus** | **String** | Calculated contract status that is derived based on the service line status and contract end date. It is different from serviceLineStatus property. serviceLineStatus gives us ACTIVE, OVERDUE, EXPIRED. These are transformed into Active, Expiring Soon and Not Covered. * &#x60;Not Covered&#x60; - The Cisco device does not have a valid support contract. * &#x60;Active&#x60; - The Cisco device is covered under a active support contract. * &#x60;Expiring Soon&#x60; - The contract for this Cisco device is going to expire in the next 30 days. | [optional] [readonly] [default to "Not Covered"]
**CoveredProductLineEndDate** | **String** | End date of the covered product line. The coverage end date is fetched from Cisco SN2INFO API. | [optional] [readonly] 
**DeviceId** | **String** | Unique identifier of the Cisco device. This information is used to query Cisco APIx SN2INFO and CCWR databases. | [optional] [readonly] 
**DeviceType** | **String** | Type used to classify the device in Cisco Intersight. Currently supported values are Server and FabricInterconnect. This will be expanded to support more types in future. * &#x60;None&#x60; - A default value to catch cases where device type is not correctly detected. * &#x60;CiscoUcsServer&#x60; - A device of type server. It includes Cisco IMC and UCS Managed servers. * &#x60;CiscoUcsFI&#x60; - A device of type Fabric Interconnect. It includes the various types of Cisco Fabric Interconnects supported by Cisco Intersight. * &#x60;CiscoUcsChassis&#x60; - A device of type Chassis. It includes various UCS chassis supported by Cisco Intersight. * &#x60;CiscoNexusSwitch&#x60; - A device of type Nexus switch. It includes various Nexus switches supported by Cisco Intersight. | [optional] [readonly] [default to "None"]
**EndCustomer** | [**AssetCustomerInformation**](AssetCustomerInformation.md) |  | [optional] 
**EndUserGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**IsValid** | **Boolean** | Validates if the device is a genuine Cisco device. Validated is done using the Cisco SN2INFO APIs. | [optional] [readonly] 
**ItemType** | **String** | Item type of this specific Cisco device. example &quot;&quot;Chassis&quot;&quot;. | [optional] [readonly] 
**MaintenancePurchaseOrderNumber** | **String** | Maintenance purchase order number for the Cisco device. | [optional] [readonly] 
**MaintenanceSalesOrderNumber** | **String** | Maintenance sales order number for the Cisco device. | [optional] [readonly] 
**PlatformType** | **String** | The platform type of the Cisco device. * &#x60;&#x60; - The device reported an empty or unrecognized platform type. * &#x60;APIC&#x60; - An Application Policy Infrastructure Controller cluster. * &#x60;DCNM&#x60; - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center. * &#x60;UCSFI&#x60; - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM). * &#x60;UCSFIISM&#x60; - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight. * &#x60;IMC&#x60; - A standalone UCS Server Integrated Management Controller. * &#x60;IMCM4&#x60; - A standalone UCS M4 Server. * &#x60;IMCM5&#x60; - A standalone UCS M5 server. * &#x60;UCSIOM&#x60; - An UCS Chassis IO module. * &#x60;HX&#x60; - A HyperFlex storage controller. * &#x60;HyperFlexAP&#x60; - A HyperFlex Application Platform. * &#x60;UCSD&#x60; - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware. * &#x60;IntersightAppliance&#x60; - A Cisco Intersight Connected Virtual Appliance. * &#x60;IntersightAssist&#x60; - A Cisco Intersight Assist. * &#x60;PureStorageFlashArray&#x60; - A Pure Storage FlashArray device. * &#x60;NetAppOntap&#x60; - A NetApp ONTAP storage system. * &#x60;EmcScaleIo&#x60; - An EMC ScaleIO storage system. * &#x60;EmcVmax&#x60; - An EMC VMAX storage system. * &#x60;EmcVplex&#x60; - An EMC VPLEX storage system. * &#x60;EmcXtremIo&#x60; - An EMC XtremIO storage system. * &#x60;VmwareVcenter&#x60; - A VMware vCenter device that manages Virtual Machines. * &#x60;MicrosoftHyperV&#x60; - A Microsoft HyperV system that manages Virtual Machines. * &#x60;AppDynamics&#x60; - An AppDynamics controller that monitors applications. * &#x60;Dynatrace&#x60; - A Dynatrace controller that monitors applications. * &#x60;MicrosoftSqlServer&#x60; - A Microsoft SQL database server. * &#x60;Kubernetes&#x60; - A Kubernetes cluster that runs containerized applications. * &#x60;AmazonWebService&#x60; - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost. * &#x60;AmazonWebServiceBilling&#x60; - A Amazon web service billing target to retrieve billing information stored in S3 bucket. * &#x60;MicrosoftAzureServicePrincipal&#x60; - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions. * &#x60;MicrosoftAzureEnterpriseAgreement&#x60; - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs. * &#x60;ServiceEngine&#x60; - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications. * &#x60;HitachiVirtualStoragePlatform&#x60; - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers. * &#x60;IMCBlade&#x60; - An Intersight managed UCS Blade Server. * &#x60;CustomTarget&#x60; - An external endpoint added as Target that can be accessed through its REST API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic. * &#x60;CiscoCatalyst&#x60; - A Cisco Catalyst networking switch device. | [optional] [readonly] [default to ""]
**Product** | [**AssetProductInformation**](AssetProductInformation.md) |  | [optional] 
**PurchaseOrderNumber** | **String** | Purchase order number for the Cisco device. It is a unique number assigned for every purchase. | [optional] [readonly] 
**ResellerGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**SalesOrderNumber** | **String** | Sales order number for the Cisco device. It is a unique number assigned for every sale. | [optional] [readonly] 
**ServiceDescription** | **String** | The type of service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceEndDate** | **System.DateTime** | End date for the Cisco service contract that covers this Cisco device. | [optional] [readonly] 
**ServiceLevel** | **String** | The type of service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceSku** | **String** | The SKU of the service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceStartDate** | **System.DateTime** | Start date for the Cisco service contract that covers this Cisco device. | [optional] [readonly] 
**StateContract** | **String** | Internal property used for triggering and tracking actions for contract information. * &#x60;Update&#x60; - Sn2Info/Contract information needs to be updated. * &#x60;OK&#x60; - Sn2Info/Contract information was fetched succcessfuly and updated. * &#x60;Failed&#x60; - Sn2Info/Contract information was not available  or failed while fetching. * &#x60;Retry&#x60; - Sn2Info/Contract information update failed and will be retried later. | [optional] [default to "Update"]
**WarrantyEndDate** | **String** | End date for the warranty that covers the Cisco device. | [optional] [readonly] 
**WarrantyType** | **String** | Type of warranty that covers the Cisco device. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceContractInformationAllOf = Initialize-IntersightAssetDeviceContractInformationAllOf  -ClassId null `
 -ObjectType null `
 -Contract null `
 -ContractStatus null `
 -CoveredProductLineEndDate null `
 -DeviceId null `
 -DeviceType null `
 -EndCustomer null `
 -EndUserGlobalUltimate null `
 -IsValid null `
 -ItemType null `
 -MaintenancePurchaseOrderNumber null `
 -MaintenanceSalesOrderNumber null `
 -PlatformType null `
 -Product null `
 -PurchaseOrderNumber null `
 -ResellerGlobalUltimate null `
 -SalesOrderNumber null `
 -ServiceDescription null `
 -ServiceEndDate null `
 -ServiceLevel null `
 -ServiceSku null `
 -ServiceStartDate null `
 -StateContract null `
 -WarrantyEndDate null `
 -WarrantyType null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AssetDeviceContractInformationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

