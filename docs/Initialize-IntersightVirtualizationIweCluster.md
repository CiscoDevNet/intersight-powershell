---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationIweCluster

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationIweCluster [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssociatedProfile< Model.PolicyAbstractProfileRelationship>][-ClassId< VirtualizationIweCluster.ClassIdEnum>][-ConfiguredCpuOverSubFactor< double>][-CpuAllocation< Model.VirtualizationCpuAllocation>][-CurrentCpuOverSubFactor< double>][-DatacenterName< string>][-FailureReason< string>][-HypervisorBuild< string>][-HypervisorType< VirtualizationIweCluster.HypervisorTypeEnum>][-Identity< string>][-ManagementIpAddress< string>][-MemoryAllocation< Model.VirtualizationMemoryAllocation>][-MemoryCapacity< Model.VirtualizationMemoryCapacity>][-Moid< string>][-ObjectType< VirtualizationIweCluster.ObjectTypeEnum>][-ProcessorCapacity< Model.VirtualizationComputeCapacity>][-RegisteredDevice< Model.AssetDeviceRegistrationRelationship>][-StorageClusters< System.Collections.Generic.List`1[Model.StorageBaseClusterRelationship]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TotalCores< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AssociatedProfile
A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.PolicyAbstractProfileRelationship
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
Type: VirtualizationIweCluster.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfiguredCpuOverSubFactor
CPU oversubscription factor configured on the cluster.

```yaml
Type: double
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuAllocation
CPU allocation details of the cluster.

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

### -CurrentCpuOverSubFactor
Current oversubscription factor of the cluster.

```yaml
Type: double
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DatacenterName
Datacenter to which the cluster belongs.

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

### -FailureReason
Reason for the failure when cluster is in failed state.

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

### -HypervisorBuild
Hypervisor version of HyperFlex compute cluster along with build number.

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

### -HypervisorType
Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor of the virtualization platform is Cisco HyperFlex Application Platform.\n* `IWE` - The hypervisor of the virtualization platform is Cisco Intersight Workload Engine.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known.

```yaml
Type: VirtualizationIweCluster.HypervisorTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Identity
The internally generated identity of this cluster. This entity is not manipulated by users.

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

### -ManagementIpAddress
Management IP Address of the cluster.

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

### -MemoryAllocation
Memory allocation details of the cluster.

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
The capacity and usage information for memory on this cluster.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: VirtualizationIweCluster.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorCapacity
The capacity and usage information for CPU power on this cluster.

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

### -StorageClusters
An array of relationships to storageBaseCluster resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[Model.StorageBaseClusterRelationship]
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

### -TotalCores
Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster.

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
PS C:\> Initialize-IntersightVirtualizationIweCluster
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightVirtualizationCpuAllocation](./Initialize-IntersightVirtualizationCpuAllocation.md)

[Initialize-IntersightVirtualizationMemoryAllocation](./Initialize-IntersightVirtualizationMemoryAllocation.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)
