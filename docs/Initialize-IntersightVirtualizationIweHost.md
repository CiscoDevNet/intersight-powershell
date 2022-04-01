---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationIweHost

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationIweHost [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Age< string>][-ChassisVersion< string>][-ClassId< VirtualizationIweHost.ClassIdEnum>][-ClusterUuid< string>][-CpuAllocation< Model.VirtualizationCpuAllocation>][-CpuInfo< Model.VirtualizationCpuInfo>][-FailureReason< string>][-HardwareInfo< Model.InfraHardwareInfo>][-HwPowerState< VirtualizationIweHost.HwPowerStateEnum>][-HypervisorType< VirtualizationIweHost.HypervisorTypeEnum>][-Identity< string>][-InternalIpAddress< string>][-MaintenanceMode< bool>][-ManagementIpAddress< string>][-MasterRole< bool>][-MemoryAllocation< Model.VirtualizationMemoryAllocation>][-MemoryCapacity< Model.VirtualizationMemoryCapacity>][-Model< string>][-Moid< string>][-Name< string>][-ObjectType< VirtualizationIweHost.ObjectTypeEnum>][-ProcessorCapacity< Model.VirtualizationComputeCapacity>][-ProductInfo< Model.VirtualizationProductInfo>][-RegisteredDevice< Model.AssetDeviceRegistrationRelationship>][-Serial< string>][-Status< VirtualizationIweHost.StatusEnum>][-StorageCapacity< Model.VirtualizationStorageCapacity>][-StorageVmPowerState< VirtualizationIweHost.StorageVmPowerStateEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-UpTime< string>][-Uuid< string>][-Vendor< string>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Age
Denotes age or life time of the Host in nano seconds.

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

### -ChassisVersion
Chassis version of the Host.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: VirtualizationIweHost.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClusterUuid
The UUID of the cluster to which this Host belongs to.

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

### -CpuAllocation
CPU allocation details of the host.

Note :- Use Initialize-IntersightVirtualizationCpuAllocation to create the object of complex type VirtualizationCpuAllocation

```yaml
Type: Model.VirtualizationCpuAllocation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuInfo
Details about the CPUs installed on this host are represented here.

Note :- Use Initialize-IntersightVirtualizationCpuInfo to create the object of complex type VirtualizationCpuInfo

```yaml
Type: Model.VirtualizationCpuInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FailureReason
Reason of the failure when host is in failed state.

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

### -HardwareInfo
The hardware details of this host. It includes capacity, manufacturer, and model information.

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

### -HwPowerState
Is the host Powered-up or Powered-down.\n* `Unknown` - The entity&apos;s power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity&apos;s power state is not available.

```yaml
Type: VirtualizationIweHost.HwPowerStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HypervisorType
Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor of the virtualization platform is Cisco HyperFlex Application Platform.\n* `IWE` - The hypervisor of the virtualization platform is Cisco Intersight Workload Engine.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known.

```yaml
Type: VirtualizationIweHost.HypervisorTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Identity
The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference).

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

### -InternalIpAddress
Internal IP Address of the Host.

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

### -MaintenanceMode
Is this host in maintenance mode. Set to true or false.

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

### -ManagementIpAddress
Management IP Address of the Host.

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

### -MasterRole
Is the role of this host is master in the cluster? true or false.

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

### -MemoryAllocation
Memory allocation details of the host.

Note :- Use Initialize-IntersightVirtualizationMemoryAllocation to create the object of complex type VirtualizationMemoryAllocation

```yaml
Type: Model.VirtualizationMemoryAllocation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryCapacity
The memory capacity and usage information on this host.

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

### -Model
Commercial model information about this hardware.

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
Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations.

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
Type: VirtualizationIweHost.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorCapacity
The capacity and usage information for CPU power on this host.

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

### -ProductInfo
Details of this product, such as vendor, model, etc. are represented here.

Note :- Use Initialize-IntersightVirtualizationProductInfo to create the object of complex type VirtualizationProductInfo

```yaml
Type: Model.VirtualizationProductInfo
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

### -Serial
Serial number of this host (internally generated).

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

### -Status
Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally.

```yaml
Type: VirtualizationIweHost.StatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StorageCapacity
Storage capacity details of the host.

Note :- Use Initialize-IntersightVirtualizationStorageCapacity to create the object of complex type VirtualizationStorageCapacity

```yaml
Type: Model.VirtualizationStorageCapacity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StorageVmPowerState
Is the Storage Controller VM on the host Powered-up or Powered-down.\n* `Unknown` - The entity&apos;s power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity&apos;s power state is not available.

```yaml
Type: VirtualizationIweHost.StorageVmPowerStateEnum
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

### -UpTime
The uptime of the host, stored as Duration (from w3c).

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
Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated.

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

### -Vendor
Commercial vendor details of this hardware.

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

### -Version
Product version of the Host.

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
PS C:\> Initialize-IntersightVirtualizationIweHost
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightInfraHardwareInfo](./Initialize-IntersightInfraHardwareInfo.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightVirtualizationCpuAllocation](./Initialize-IntersightVirtualizationCpuAllocation.md)

[Initialize-IntersightVirtualizationCpuInfo](./Initialize-IntersightVirtualizationCpuInfo.md)

[Initialize-IntersightVirtualizationMemoryAllocation](./Initialize-IntersightVirtualizationMemoryAllocation.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)

[Initialize-IntersightVirtualizationProductInfo](./Initialize-IntersightVirtualizationProductInfo.md)

[Initialize-IntersightVirtualizationStorageCapacity](./Initialize-IntersightVirtualizationStorageCapacity.md)
