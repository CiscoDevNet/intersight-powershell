---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationVmwareVirtualMachine

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationVmwareVirtualMachine [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Annotation< string>][-BootTime< DateTime>][-Capacity< Model.InfraHardwareInfo>][-ClassId< VirtualizationVmwareVirtualMachine.ClassIdEnum>][-ConfigName< string>][-ConnectionState< string>][-CpuHotAddEnabled< bool>][-CpuShares< Model.VirtualizationVmwareVmCpuShareInfo>][-CpuSocketInfo< Model.VirtualizationVmwareVmCpuSocketInfo>][-CpuUtilization< float>][-CustomAttributes< System.Collections.Generic.List`1[string]>][-DefaultPowerOffType< string>][-DhcpEnabled< bool>][-DiskCommitInfo< Model.VirtualizationVmwareVmDiskCommitInfo>][-DnsServerList< System.Collections.Generic.List`1[string]>][-DnsSuffixList< System.Collections.Generic.List`1[string]>][-Folder< string>][-GuestInfo< Model.VirtualizationGuestInfo>][-GuestState< VirtualizationVmwareVirtualMachine.GuestStateEnum>][-HypervisorType< VirtualizationVmwareVirtualMachine.HypervisorTypeEnum>][-Identity< string>][-InstanceUuid< string>][-InventoryPath< string>][-IpAddress< System.Collections.Generic.List`1[string]>][-IsTemplate< bool>][-MacAddress< System.Collections.Generic.List`1[string]>][-MemShares< Model.VirtualizationVmwareVmMemoryShareInfo>][-MemoryCapacity< Model.VirtualizationMemoryCapacity>][-MemoryHotAddEnabled< bool>][-MemoryUtilization< float>][-Moid< string>][-Name< string>][-NetworkCount< long>][-ObjectType< VirtualizationVmwareVirtualMachine.ObjectTypeEnum>][-ParentFolder< Model.VirtualizationVmwareFolderRelationship>][-PortGroups< System.Collections.Generic.List`1[string]>][-PowerState< VirtualizationVmwareVirtualMachine.PowerStateEnum>][-ProcessorCapacity< Model.VirtualizationComputeCapacity>][-ProtectedVm< bool>][-Provider< VirtualizationVmwareVirtualMachine.ProviderEnum>][-RegisteredDevice< Model.AssetDeviceRegistrationRelationship>][-RemoteDisplayInfo< Model.VirtualizationVmwareRemoteDisplayInfo>][-RemoteDisplayVncEnabled< bool>][-ResourcePool< string>][-ResourcePoolOwner< string>][-ResourcePoolParent< string>][-State< VirtualizationVmwareVirtualMachine.StateEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-ToolRunningStatus< string>][-ToolsVersion< string>][-Uuid< string>][-VmCreationTime< DateTime>][-VmDiskCount< long>][-VmOverallStatus< string>][-VmPath< string>][-VmVersion< string>][-VmVnicCount< long>][-VnicDeviceConfigId< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Annotation
List of annotations provided to this VM by user. Can be long.

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

### -BootTime
Time when this VM booted up.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Capacity
Provisioned CPU and memory information for this virtual machine.

Note :- Use Initialize-IntersightInfraHardwareInfo to create the object of complex type InfraHardwareInfo

```yaml
Type: Model.InfraHardwareInfo
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
Type: VirtualizationVmwareVirtualMachine.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigName
The configuration name for this VM. This maybe the same as the guest hostname.

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

### -ConnectionState
Shows if virtual machine is connected to vCenter. Values are Connected, Disconnected, Orphaned, Inaccessible, and Invalid.

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

### -CpuHotAddEnabled
Indicates if the capability to add CPUs to a running VM is enabled.

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

### -CpuShares
Shows the relative importance of a VM and its CPU limits.

Note :- Use Initialize-IntersightVirtualizationVmwareVmCpuShareInfo to create the object of complex type VirtualizationVmwareVmCpuShareInfo

```yaml
Type: Model.VirtualizationVmwareVmCpuShareInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuSocketInfo
Details of CPUs/sockets of this VM.

Note :- Use Initialize-IntersightVirtualizationVmwareVmCpuSocketInfo to create the object of complex type VirtualizationVmwareVmCpuSocketInfo

```yaml
Type: Model.VirtualizationVmwareVmCpuSocketInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuUtilization
Average CPU utilization percentage derived as a ratio of CPU used to CPU allocated. The value is calculated whenever inventory is performed.

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

### -CustomAttributes


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultPowerOffType
Indicates how the VM will be powered off (soft, hard etc.).

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

### -DhcpEnabled
Shows if DHCP is used for IP/DNS on this VM.

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

### -DiskCommitInfo
Information about the virtual machine&apos;s disk commits, sharing and limits.

Note :- Use Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo to create the object of complex type VirtualizationVmwareVmDiskCommitInfo

```yaml
Type: Model.VirtualizationVmwareVmDiskCommitInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DnsServerList


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DnsSuffixList


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Folder
The folder name associated with this VM.

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

### -GuestInfo
Guest operating system details running on this machine.

Note :- Use Initialize-IntersightVirtualizationGuestInfo to create the object of complex type VirtualizationGuestInfo

```yaml
Type: Model.VirtualizationGuestInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -GuestState
The state of the guest OS running on this VM. Could be running, not running etc.\n* `Unknown` - Indicates that the guest OS state cannot be determined.\n* `NotRunning` - Indicates that the guest OS is not running.\n* `Resetting` - Indicates that the guest OS is resetting.\n* `Running` - Indicates that the guest OS is running normally.\n* `ShuttingDown` - Indicates that the guest OS is shutting down.\n* `Standby` - Indicates that the guest OS is in standby mode.

```yaml
Type: VirtualizationVmwareVirtualMachine.GuestStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HypervisorType
Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor of the virtualization platform is Cisco HyperFlex Application Platform.\n* `IWE` - The hypervisor of the virtualization platform is Cisco Intersight Workload Engine.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known.

```yaml
Type: VirtualizationVmwareVirtualMachine.HypervisorTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Identity
The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference).

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

### -InstanceUuid
UUID assigned by vCenter to every VM.

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

### -InventoryPath
Inventory path to the VM. Example - /DC/vm/folder/VMName.

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

### -IpAddress


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsTemplate
If true, indicates that the entity refers to a template of a virtual machine and not a real virtual machine.

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

### -MacAddress


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemShares
Similar to CPU Shares but applicable to memory.

Note :- Use Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo to create the object of complex type VirtualizationVmwareVmMemoryShareInfo

```yaml
Type: Model.VirtualizationVmwareVmMemoryShareInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryCapacity
The capacity and usage information for memory on this virtual machine.

Note :- Use Initialize-IntersightVirtualizationMemoryCapacity to create the object of complex type VirtualizationMemoryCapacity

```yaml
Type: Model.VirtualizationMemoryCapacity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryHotAddEnabled
Adding memory to a running VM.

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

### -MemoryUtilization
Average memory utilization percentage derived as a ratio of memory used to available memory. The value is calculated whenever inventory is performed.

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
User-provided name to identify the virtual machine.

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

### -NetworkCount
Indicates how many networks are used by this VM.

```yaml
Type: long
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
Type: VirtualizationVmwareVirtualMachine.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ParentFolder
A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.VirtualizationVmwareFolderRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortGroups


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PowerState
Power state of the virtual machine.\n* `Unknown` - The entity&apos;s power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity&apos;s power state is not available.

```yaml
Type: VirtualizationVmwareVirtualMachine.PowerStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorCapacity
The capacity and usage information for CPU power on this virtual machine.

Note :- Use Initialize-IntersightVirtualizationComputeCapacity to create the object of complex type VirtualizationComputeCapacity

```yaml
Type: Model.VirtualizationComputeCapacity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProtectedVm
Shows if this is a protected VM. VMs can be in protection groups.

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

### -Provider
Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform.\n* `CiscoIntersightWorkloadEngine` - Cloud provider named Cisco Intersight Workload Engine.

```yaml
Type: VirtualizationVmwareVirtualMachine.ProviderEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RegisteredDevice
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteDisplayInfo
Applies only when remoteDisplayvnc is enabled.

Note :- Use Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo to create the object of complex type VirtualizationVmwareRemoteDisplayInfo

```yaml
Type: Model.VirtualizationVmwareRemoteDisplayInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteDisplayVncEnabled
Shows if support for a remote VNC access is enabled.

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

### -ResourcePool
Name of the resource pool to which this VM belongs (optional).

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

### -ResourcePoolOwner
Who owns the resource pool.

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

### -ResourcePoolParent
The parent of the current resource pool to which this VM belongs.

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

### -State
The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state.

```yaml
Type: VirtualizationVmwareVirtualMachine.StateEnum
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

### -ToolRunningStatus
Indicates if guest tools are running on this VM. Could be set to guestToolNotRunning or guestToolsRunning.

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

### -ToolsVersion
The version of the guest tools, usually not specified.

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

### -Uuid
The uuid of this virtual machine. The uuid is internally generated and not user specified.

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

### -VmCreationTime
Time when this virtualmachine is created.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmDiskCount
Shows the number of disks assigned to this VM.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmOverallStatus
The operational state of the VM. Could be Available, Provisioned, Maintenance mode, Deleting, etc.

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

### -VmPath
Path to the vmx file of the VM. Example - [datastore3] VCSA-134/VCSA-134.vmx.

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

### -VmVersion
Information about the version of this VM (vmx-09, vmx-11 etc.).

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

### -VmVnicCount
How many vnics are present.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VnicDeviceConfigId
Information related to the guest info&apos;s VNIC virtual device. It is a comma-separated list.

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
PS C:\> Initialize-IntersightVirtualizationVmwareVirtualMachine
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightInfraHardwareInfo](./Initialize-IntersightInfraHardwareInfo.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightVirtualizationGuestInfo](./Initialize-IntersightVirtualizationGuestInfo.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)

[Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo](./Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo.md)

[Initialize-IntersightVirtualizationVmwareVmCpuShareInfo](./Initialize-IntersightVirtualizationVmwareVmCpuShareInfo.md)

[Initialize-IntersightVirtualizationVmwareVmCpuSocketInfo](./Initialize-IntersightVirtualizationVmwareVmCpuSocketInfo.md)

[Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo](./Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo.md)

[Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo](./Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo.md)
