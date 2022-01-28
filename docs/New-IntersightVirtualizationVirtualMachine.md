---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightVirtualizationVirtualMachine

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightVirtualizationVirtualMachine [-Action< VirtualizationVirtualMachine.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AffinitySelectors< System.Collections.Generic.List`1[InfraMetaData]>][-AntiAffinitySelectors< System.Collections.Generic.List`1[InfraMetaData]>][-CloudInitConfig< VirtualizationCloudInitConfig>][-Cluster< VirtualizationBaseClusterRelationship>][-ClusterEsxi< string>][-Cpu< long>][-Disk< System.Collections.Generic.List`1[VirtualizationVirtualMachineDisk]>][-ForceDelete< bool>][-GuestOs< VirtualizationVirtualMachine.GuestOsEnum>][-Host< VirtualizationBaseHostRelationship>][-HostEsxi< string>][-Interfaces< System.Collections.Generic.List`1[VirtualizationNetworkInterface]>][-Labels< System.Collections.Generic.List`1[InfraMetaData]>][-Memory< long>][-Moid< string>][[-Name]< string>][-PowerState< VirtualizationVirtualMachine.PowerStateEnum>][-ProvisionType< VirtualizationVirtualMachine.ProvisionTypeEnum>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VmConfig< VirtualizationBaseVmConfiguration>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;VirtualizationVirtualMachine&apos; resource.

## PARAMETERS

### -Action
Action to be performed on a virtual machine (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `PowerState` - Power action is performed on the virtual machine.\n* `Migrate` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor.\n* `Create` - The virtual machine will be created on the specified hypervisor. This action is also useful if the virtual machine creation failed during first POST operation on VirtualMachine managed object. User can set this action to retry the virtual machine creation.\n* `Delete` - The virtual machine will be deleted from the specified hypervisor. User can either set this action or can do a DELETE operation on the VirtualMachine managed object.

```yaml
Type: VirtualizationVirtualMachine.ActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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

### -AffinitySelectors


Note :- Use Initialize-IntersightInfraMetaData to create the object of complex type InfraMetaData

```yaml
Type: System.Collections.Generic.List`1[InfraMetaData]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AntiAffinitySelectors


Note :- Use Initialize-IntersightInfraMetaData to create the object of complex type InfraMetaData

```yaml
Type: System.Collections.Generic.List`1[InfraMetaData]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CloudInitConfig
Cloud init configuration data for virtual machine.

Note :- Use Initialize-IntersightVirtualizationCloudInitConfig to create the object of complex type VirtualizationCloudInitConfig

```yaml
Type: VirtualizationCloudInitConfig
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Cluster
A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VirtualizationBaseClusterRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClusterEsxi
Cluster where virtual machine is deployed.

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

### -Cpu
Number of vCPUs allocated to virtual machine.

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

### -Disk


Note :- Use Initialize-IntersightVirtualizationVirtualMachineDisk to create the object of complex type VirtualizationVirtualMachineDisk

```yaml
Type: System.Collections.Generic.List`1[VirtualizationVirtualMachineDisk]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ForceDelete
Normally any virtual machine that is still powered on cannot be deleted. The expected sequence from a user is to first power off the virtual machine and then invoke the delete operation. However, in special circumstances, the owner of the virtual machine may know very well that the virtual machine is no longer needed and just wants to dispose it off. In such situations a delete operation of a virtual machine object is accepted only when this forceDelete attribute is set to true. Under normal circumstances (forceDelete is false), delete operation first confirms that the virtual machine is powered off and then proceeds to delete the virtual machine.

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

### -GuestOs
Guest operating system running on virtual machine.\n* `linux` - A Linux operating system.\n* `windows` - A Windows operating system.

```yaml
Type: VirtualizationVirtualMachine.GuestOsEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Host
A reference to a virtualizationBaseHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VirtualizationBaseHostRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HostEsxi
Host where virtual machine is deployed.

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

### -Interfaces


Note :- Use Initialize-IntersightVirtualizationNetworkInterface to create the object of complex type VirtualizationNetworkInterface

```yaml
Type: System.Collections.Generic.List`1[VirtualizationNetworkInterface]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Labels


Note :- Use Initialize-IntersightInfraMetaData to create the object of complex type InfraMetaData

```yaml
Type: System.Collections.Generic.List`1[InfraMetaData]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Memory
Virtual machine memory in mebi bytes (one mebibyte, 1MiB, is 1048576 bytes, and 1KiB is 1024 bytes). Input must be a whole number and scientific notation is not acceptable. For example, enter 1730 and not 1.73e03.

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
Virtual machine name that is unique. Hypervisors enforce platform specific limits and character sets. The name length limit, both min and max, vary among hypervisors. Therefore, the basic limits are set here and proper enforcement is done elsewhere.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -PowerState
Expected power state of virtual machine (PowerOn, PowerOff, Restart).\n* `PowerOff` - The virtual machine will be powered off if it is already not in powered off state. If it is already powered off, no side-effects are expected.\n* `PowerOn` - The virtual machine will be powered on if it is already not in powered on state. If it is already powered on, no side-effects are expected.\n* `Suspend` - The virtual machine will be put into  a suspended state.\n* `ShutDownGuestOS` - The guest operating system is shut down gracefully.\n* `RestartGuestOS` - It can either act as a reset switch and abruptly reset the guest operating system, or it can send a restart signal to the guest operating system so that it shuts down gracefully and restarts.\n* `Reset` - Resets the virtual machine abruptly, with no consideration for work in progress.\n* `Restart` - The virtual machine will be restarted only if it is in powered on state. If it is powered off, it will not be started up.\n* `Unknown` - Power state of the entity is unknown.

```yaml
Type: VirtualizationVirtualMachine.PowerStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProvisionType
Identifies the provision type to create a new virtual machine.\n* `OVA` - Deploy virtual machine using OVA/F file.\n* `Template` - Provision virtual machine using a template file.\n* `Discovered` - A virtual machine was &apos;discovered&apos; and not created from Intersight. No provisioning information is available.

```yaml
Type: VirtualizationVirtualMachine.ProvisionTypeEnum
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

### -VmConfig
Virtual machine configuration to provision.

Note :- Use Initialize-IntersightVirtualizationBaseVmConfiguration to create the object of complex type VirtualizationBaseVmConfiguration

```yaml
Type: VirtualizationBaseVmConfiguration
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
PS C:\> New-IntersightVirtualizationVirtualMachine
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationVirtualMachine](./Get-IntersightVirtualizationVirtualMachine.md)

[Set-IntersightVirtualizationVirtualMachine](./Set-IntersightVirtualizationVirtualMachine.md)

[Remove-IntersightVirtualizationVirtualMachine](./Remove-IntersightVirtualizationVirtualMachine.md)

[Initialize-IntersightVirtualizationActionInfo](./Initialize-IntersightVirtualizationActionInfo.md)

[Initialize-IntersightInfraMetaData](./Initialize-IntersightInfraMetaData.md)

[Initialize-IntersightVirtualizationCloudInitConfig](./Initialize-IntersightVirtualizationCloudInitConfig.md)

[Initialize-IntersightVirtualizationVirtualMachineDisk](./Initialize-IntersightVirtualizationVirtualMachineDisk.md)

[Initialize-IntersightVirtualizationNetworkInterface](./Initialize-IntersightVirtualizationNetworkInterface.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVirtualizationBaseVmConfiguration](./Initialize-IntersightVirtualizationBaseVmConfiguration.md)
