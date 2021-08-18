---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVirtualizationVmwareVirtualMachine

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVirtualizationVmwareVirtualMachine [-AdditionalProperties< Dictionary<string,object>>][-Annotation< string>][-BootTime< DateTime>][-Capacity< InfraHardwareInfo>][-ConfigName< string>][-ConnectionState< string>][-CpuHotAddEnabled< bool>][-CpuShares< VirtualizationVmwareVmCpuShareInfo>][-CpuSocketInfo< VirtualizationVmwareVmCpuSocketInfo>][-CustomAttributes< List<string>>][-DefaultPowerOffType< string>][-DhcpEnabled< bool>][-DiskCommitInfo< VirtualizationVmwareVmDiskCommitInfo>][-DnsServerList< List<string>>][-DnsSuffixList< List<string>>][-ExtraConfig< object>][-Folder< string>][-GuestInfo< VirtualizationGuestInfo>][-GuestState< VirtualizationVmwareVirtualMachine.GuestStateEnum>][-HypervisorType< VirtualizationVmwareVirtualMachine.HypervisorTypeEnum>][-Identity< string>][-InstanceUuid< string>][-InventoryPath< string>][-IpAddress< List<string>>][-IsTemplate< bool>][-MacAddress< List<string>>][-MemShares< VirtualizationVmwareVmMemoryShareInfo>][-MemoryCapacity< VirtualizationMemoryCapacity>][-MemoryHotAddEnabled< bool>][[-Moid]< string>][-Name< string>][-NetworkCount< long>][-ParentFolder< VirtualizationVmwareFolderRelationship>][-PortGroups< List<string>>][-PowerState< VirtualizationVmwareVirtualMachine.PowerStateEnum>][-ProcessorCapacity< VirtualizationComputeCapacity>][-ProtectedVm< bool>][-Provider< VirtualizationVmwareVirtualMachine.ProviderEnum>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-RemoteDisplayInfo< VirtualizationVmwareRemoteDisplayInfo>][-RemoteDisplayVncEnabled< bool>][-ResourcePool< string>][-ResourcePoolOwner< string>][-ResourcePoolParent< string>][-State< VirtualizationVmwareVirtualMachine.StateEnum>][-Tags< List<MoTag>>][-ToolRunningStatus< string>][-ToolsVersion< string>][-Uuid< string>][-VirtualDisks< List<long>>][-VirtualNetworkInterfaces< List<long>>][-VmCreationTime< DateTime>][-VmDiskCount< long>][-VmOverallStatus< string>][-VmPath< string>][-VmVersion< string>][-VmVnicCount< long>][-VnicDeviceConfigId< string>]

```

## DESCRIPTION
Update a &apos;VirtualizationVmwareVirtualMachine&apos; resource.

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
Type: InfraHardwareInfo
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
Type: VirtualizationVmwareVmCpuShareInfo
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
Type: VirtualizationVmwareVmCpuSocketInfo
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
Type: VirtualizationVmwareVmDiskCommitInfo
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

### -ExtraConfig
Additional custom configuration settings applied to this VM. It is a set of name-value pairs stored as json.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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
Type: VirtualizationGuestInfo
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
Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known.

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
Type: VirtualizationVmwareVmMemoryShareInfo
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
Type: VirtualizationMemoryCapacity
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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
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

### -ParentFolder
A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VirtualizationVmwareFolderRelationship
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
Type: VirtualizationComputeCapacity
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
Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform.

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
Type: AssetDeviceRegistrationRelationship
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
Type: VirtualizationVmwareRemoteDisplayInfo
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
The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.

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
Type: System.Collections.Generic.List`1[MoTag]
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

### -VirtualDisks


```yaml
Type: System.Collections.Generic.List`1[long]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualNetworkInterfaces


```yaml
Type: System.Collections.Generic.List`1[long]
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
Information related to the guest info&amp;apos;s VNIC virtual device. It is a comma-separated list.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightVirtualizationVmwareVirtualMachine
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationVmwareVirtualMachine](./Get-IntersightVirtualizationVmwareVirtualMachine.md)

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightInfraHardwareInfo](./Initialize-IntersightInfraHardwareInfo.md)

[Initialize-IntersightVirtualizationVmwareVmCpuShareInfo](./Initialize-IntersightVirtualizationVmwareVmCpuShareInfo.md)

[Initialize-IntersightVirtualizationVmwareVmCpuSocketInfo](./Initialize-IntersightVirtualizationVmwareVmCpuSocketInfo.md)

[Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo](./Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightVirtualizationGuestInfo](./Initialize-IntersightVirtualizationGuestInfo.md)

[Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo](./Initialize-IntersightVirtualizationVmwareVmMemoryShareInfo.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo](./Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo.md)
