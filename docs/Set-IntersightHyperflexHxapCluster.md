---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightHyperflexHxapCluster

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightHyperflexHxapCluster [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssociatedProfile< PolicyAbstractProfileRelationship>][-ChildClusters< System.Collections.Generic.List`1[HyperflexBaseClusterRelationship]>][-ClusterPurpose< HyperflexHxapCluster.ClusterPurposeEnum>][-ConfiguredCpuOverSubFactor< double>][-CpuAllocation< VirtualizationCpuAllocation>][-CurrentCpuOverSubFactor< double>][-DatacenterName< string>][-FailureReason< string>][-HypervisorBuild< string>][-HypervisorType< HyperflexHxapCluster.HypervisorTypeEnum>][-ManagementIpAddress< string>][-MemoryAllocation< VirtualizationMemoryAllocation>][-MemoryCapacity< VirtualizationMemoryCapacity>][[-Moid]< string>][-ParentCluster< HyperflexBaseClusterRelationship>][-ProcessorCapacity< VirtualizationComputeCapacity>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TotalCores< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;HyperflexHxapCluster&apos; resource.

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
Type: PolicyAbstractProfileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ChildClusters
An array of relationships to hyperflexBaseCluster resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[HyperflexBaseClusterRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClusterPurpose
This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values.

```yaml
Type: HyperflexHxapCluster.ClusterPurposeEnum
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
Type: VirtualizationCpuAllocation
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
Type: HyperflexHxapCluster.HypervisorTypeEnum
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
Type: VirtualizationMemoryAllocation
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
Type: VirtualizationMemoryCapacity
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

### -ParentCluster
A reference to a hyperflexBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: HyperflexBaseClusterRelationship
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
Type: VirtualizationComputeCapacity
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
PS C:\> Set-IntersightHyperflexHxapCluster
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightHyperflexHxapCluster](./Remove-IntersightHyperflexHxapCluster.md)

[Get-IntersightHyperflexHxapCluster](./Get-IntersightHyperflexHxapCluster.md)

[Initialize-IntersightHyperflexAlarmSummary](./Initialize-IntersightHyperflexAlarmSummary.md)

[Initialize-IntersightVirtualizationCpuAllocation](./Initialize-IntersightVirtualizationCpuAllocation.md)

[Initialize-IntersightVirtualizationMemoryAllocation](./Initialize-IntersightVirtualizationMemoryAllocation.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
