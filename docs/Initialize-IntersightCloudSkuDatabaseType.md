---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCloudSkuDatabaseType

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCloudSkuDatabaseType [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BasePrice< float>][-ClassId< CloudSkuDatabaseType.ClassIdEnum>][-Currency< CloudSkuDatabaseType.CurrencyEnum>][-CustomAttributes< System.Collections.Generic.List`1[Model.CloudCustomAttributes]>][-DatabaseEdition< string>][-DatabaseEngine< string>][-Description< string>][-IsActive< bool>][-IsAutoDiscovered< bool>][-LicenseModel< string>][-Moid< string>][-Name< string>][-NetworkPerformance< string>][-ObjectType< CloudSkuDatabaseType.ObjectTypeEnum>][-PlatformType< CloudSkuDatabaseType.PlatformTypeEnum>][-Region< Model.CloudRegionsRelationship>][-RegionId< string>][-ServiceCategory< CloudSkuDatabaseType.ServiceCategoryEnum>][-ServiceFamily< string>][-ServiceName< string>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Target< Model.AssetTargetRelationship>][-Unit< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BasePrice
The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: CloudSkuDatabaseType.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Currency
The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union.

```yaml
Type: CloudSkuDatabaseType.CurrencyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CustomAttributes


Note :- Use Initialize-IntersightCloudCustomAttributes to create the object of complex type CloudCustomAttributes

```yaml
Type: System.Collections.Generic.List`1[Model.CloudCustomAttributes]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DatabaseEdition
The database edition. For e.g. standard or enterprise.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DatabaseEngine
The database engine. For e.g. SQL Server, Oracle, PostgreSQL.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Any additional description for the instance type.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsActive
Flag to indicate if this SKU is active or not.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsAutoDiscovered
Flag to indicate if SKU is discovered during inventory collection.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LicenseModel
The licensing option for the database. For e.g. license required or not.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The display name for instance type.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NetworkPerformance
Network performance of this instance type.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: CloudSkuDatabaseType.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PlatformType
The platformType for this SKU.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `CAPIC` - An Application Policy Infrastructure Controller cloud instance.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `IWE` - An Intersight Workload Engine.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `NexusDevice` - A generic platform type to support Nexus Network Device. This can also be extended to support all network devices later on.\n* `ACISwitch` - A platform type to support ACI Switches.\n* `NexusSwitch` - A platform type to support Cisco Nexus Switches.\n* `MDSDevice` - A platform type to support MDS devices.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `NewRelic` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `MySqlServer` - An instance of either Oracle MySQL Database or the open source MariaDB.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `AnsibleEndpoint` - An external endpoint added as Target that can be accessed through Ansible in Intersight Cloud Orchestrator automation workflow.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic, Bearer Token.\n* `SSHEndpoint` - An external endpoint added as Target that can be accessed through SSH in Intersight Cloud Orchestrator automation workflow.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows machine on which PowerShell scripts can be executed remotely.

```yaml
Type: CloudSkuDatabaseType.PlatformTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Region
A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.CloudRegionsRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RegionId
The region to which this Sku belongs to.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServiceCategory
Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider.

```yaml
Type: CloudSkuDatabaseType.ServiceCategoryEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServiceFamily
Property to identify the family of service that the sku belongs to.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServiceName
Any display name for the ServiceCategory if available.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Target
A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.AssetTargetRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Unit
The pricing associated with this Sku. Can be hourly, per minute.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightCloudSkuDatabaseType
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightCloudCustomAttributes](./Initialize-IntersightCloudCustomAttributes.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
