# AssetDeviceRegistration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceRegistration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceRegistration"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**ApiVersion** | **Int64** | The version of the connector API, describes the capability of the connector&#39;s framework. If the version is lower than the current minimum supported version defined in the service managing the connection, the device connector will be connected with limited capabilities until the device connector is upgraded to a fully supported version. For example if a device connector that was released without delta inventory capabilities registers and connects to Intersight, inventory collection may be disabled until it has been upgraded. | [optional] [readonly] 
**AppPartitionNumber** | **Int64** | The partition number corresponding to the instance of the Proxy App which is managing the web-socket to the device connector. | [optional] [readonly] 
**ConnectionId** | **String** | The unique identifier for the current connection. The identifier persists across network connectivity loss and is reset on device connector process restart or platform administrator toggle of the Intersight connectivity. The connectionId can be used by services that need to interact with stateful plugins running in the device connector process. For example if a service schedules an inventory in a devices job scheduler plugin at registration it is not necessary to reschedule the job if the device loses network connectivity due to an Intersight service upgrade or intermittent network issues in the devices datacenter. | [optional] [readonly] 
**ConnectionReason** | **String** | If &#39;connectionStatus&#39; is not equal to Connected, connectionReason provides further details about why the device is not connected with Intersight. | [optional] [readonly] 
**ConnectionStatus** | **String** | The status of the persistent connection between the device connector and Intersight. * &#x60;&#x60; - The target details have been persisted but Intersight has not yet attempted to connect to the target. * &#x60;Connected&#x60; - Intersight is able to establish a connection to the target and initiate management activities. * &#x60;NotConnected&#x60; - Intersight is unable to establish a connection to the target. * &#x60;ClaimInProgress&#x60; - Claim of the target is in progress. A connection to the target has not been fully established. * &#x60;Unclaimed&#x60; - The device was un-claimed from the users account by an Administrator of the device. Also indicates the failure to claim Custom Target details in Intersight. * &#x60;Claimed&#x60; - Custom Target is successfully claimed in Intersight. Currently no validation is performed to verify the Target connectivity from Intersight at the time of creation. However invoking API from Intersight Orchestrator fails if this Target is not reachable from Intersight or if Target credentials are incorrect. | [optional] [readonly] [default to ""]
**ConnectionStatusLastChangeTime** | **System.DateTime** | The last time at which the &#39;connectionStatus&#39; property value changed. If connectionStatus is Connected, this time can be interpreted as the starting time since which a persistent connection has been maintained between Intersight and Device Connector. If connectionStatus is NotConnected, this time can be interpreted as the last time the device connector was connected with Intersight. | [optional] [readonly] 
**ConnectorVersion** | **String** | The version of the device connector running on the managed device. | [optional] [readonly] 
**DeviceExternalIpAddress** | **String** | The IP Address of the managed device as seen from Intersight at the time of registration. This could be the IP address of the managed device&#39;s interface which has a route to the internet or a NAT IP addresss when the managed device is deployed in a private network. | [optional] [readonly] 
**ProxyApp** | **String** | The name of the app which will proxy the messages to the device connector. | [optional] [readonly] 
**AccessKeyId** | **String** | An identifier for the credential used by the device connector to authenticate with the Intersight web socket gateway. | [optional] 
**ClaimedByUserName** | **String** | The name of the user who claimed the device for the account. | [optional] [readonly] 
**ClaimedTime** | **System.DateTime** | The date and time at which the device was claimed to this account. | [optional] [readonly] 
**DeviceHostname** | **String[]** |  | [optional] 
**DeviceIpAddress** | **String[]** |  | [optional] 
**ExecutionMode** | **String** | Indicates if the platform is an actual device or an emulated device for testing, demos, etc. Permitted values are [Normal, Emulator, ContainerEmulator]. * &#x60;&#x60; - The device reported an empty or unrecognized executionMode. * &#x60;Normal&#x60; - The device connector is running in normal mode, i.e. it is not a simulation. * &#x60;Emulator&#x60; - The device connector is running in simulation mode inside an emulated device. * &#x60;ContainerEmulator&#x60; - The device connector is running in simulation mode inside a containerized emulated device. | [optional] [default to ""]
**ParentSignature** | [**AssetParentConnectionSignature**](AssetParentConnectionSignature.md) |  | [optional] 
**VarPid** | **String[]** |  | [optional] 
**PlatformType** | **String** | The platform type on which device connector is executing. * &#x60;&#x60; - The device reported an empty or unrecognized platform type. * &#x60;APIC&#x60; - An Application Policy Infrastructure Controller cluster. * &#x60;DCNM&#x60; - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center. * &#x60;UCSFI&#x60; - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM). * &#x60;UCSFIISM&#x60; - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight. * &#x60;IMC&#x60; - A standalone UCS Server Integrated Management Controller. * &#x60;IMCM4&#x60; - A standalone UCS M4 Server. * &#x60;IMCM5&#x60; - A standalone UCS M5 server. * &#x60;UCSIOM&#x60; - An UCS Chassis IO module. * &#x60;HX&#x60; - A HyperFlex storage controller. * &#x60;HyperFlexAP&#x60; - A HyperFlex Application Platform. * &#x60;UCSD&#x60; - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware. * &#x60;IntersightAppliance&#x60; - A Cisco Intersight Connected Virtual Appliance. * &#x60;IntersightAssist&#x60; - A Cisco Intersight Assist. * &#x60;PureStorageFlashArray&#x60; - A Pure Storage FlashArray device. * &#x60;NetAppOntap&#x60; - A NetApp ONTAP storage system. * &#x60;EmcScaleIo&#x60; - An EMC ScaleIO storage system. * &#x60;EmcVmax&#x60; - An EMC VMAX storage system. * &#x60;EmcVplex&#x60; - An EMC VPLEX storage system. * &#x60;EmcXtremIo&#x60; - An EMC XtremIO storage system. * &#x60;VmwareVcenter&#x60; - A VMware vCenter device that manages Virtual Machines. * &#x60;MicrosoftHyperV&#x60; - A Microsoft HyperV system that manages Virtual Machines. * &#x60;AppDynamics&#x60; - An AppDynamics controller that monitors applications. * &#x60;Dynatrace&#x60; - A Dynatrace controller that monitors applications. * &#x60;MicrosoftSqlServer&#x60; - A Microsoft SQL database server. * &#x60;Kubernetes&#x60; - A Kubernetes cluster that runs containerized applications. * &#x60;AmazonWebService&#x60; - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost. * &#x60;AmazonWebServiceBilling&#x60; - A Amazon web service billing target to retrieve billing information stored in S3 bucket. * &#x60;MicrosoftAzureServicePrincipal&#x60; - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions. * &#x60;MicrosoftAzureEnterpriseAgreement&#x60; - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs. * &#x60;ServiceEngine&#x60; - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications. * &#x60;HitachiVirtualStoragePlatform&#x60; - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers. * &#x60;IMCBlade&#x60; - An Intersight managed UCS Blade Server. * &#x60;CustomTarget&#x60; - An external endpoint added as Target that can be accessed through its REST API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic. * &#x60;CiscoCatalyst&#x60; - A Cisco Catalyst networking switch device. | [optional] [default to ""]
**PublicAccessKey** | **String** | The device connector&#39;s public key used by Intersight to authenticate a connection from the device connector. The public key is used to verify that the signature a device connector sends on connect has been signed by the connector&#39;s private key stored on the device&#39;s filesystem. Must be a PEM encoded RSA public key string. | [optional] [readonly] 
**ReadOnly** | **Boolean** | Flag reported by devices to indicate an administrator of the device has disabled management operations of the device connector and only monitoring is permitted. | [optional] [readonly] 
**Serial** | **String[]** |  | [optional] 
**Vendor** | **String** | The vendor of the managed device. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ClaimedByUser** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 
**ClusterMembers** | [**AssetClusterMemberRelationship[]**](AssetClusterMemberRelationship.md) | An array of relationships to assetClusterMember resources. | [optional] [readonly] 
**DeviceClaim** | [**AssetDeviceClaimRelationship**](AssetDeviceClaimRelationship.md) |  | [optional] 
**DeviceConfiguration** | [**AssetDeviceConfigurationRelationship**](AssetDeviceConfigurationRelationship.md) |  | [optional] 
**DomainGroup** | [**IamDomainGroupRelationship**](IamDomainGroupRelationship.md) |  | [optional] 
**ParentConnection** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceRegistration = Initialize-IntersightAssetDeviceRegistration  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -ApiVersion null `
 -AppPartitionNumber null `
 -ConnectionId null `
 -ConnectionReason null `
 -ConnectionStatus null `
 -ConnectionStatusLastChangeTime null `
 -ConnectorVersion null `
 -DeviceExternalIpAddress null `
 -ProxyApp null `
 -AccessKeyId null `
 -ClaimedByUserName null `
 -ClaimedTime null `
 -DeviceHostname null `
 -DeviceIpAddress null `
 -ExecutionMode null `
 -ParentSignature null `
 -VarPid null `
 -PlatformType null `
 -PublicAccessKey null `
 -ReadOnly null `
 -Serial null `
 -Vendor null `
 -Account null `
 -ClaimedByUser null `
 -ClusterMembers null `
 -DeviceClaim null `
 -DeviceConfiguration null `
 -DomainGroup null `
 -ParentConnection null
```

- Convert the resource to JSON
```powershell
$AssetDeviceRegistration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

