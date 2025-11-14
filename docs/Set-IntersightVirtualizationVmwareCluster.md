---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVirtualizationVmwareCluster

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVirtualizationVmwareCluster [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CpuOverCommitment< long>][-DatastoreCount< long>][-HypervisorType< VirtualizationVmwareCluster.HypervisorTypeEnum>][-HypervisorVersion< string>][-Identity< string>][-InventoryPath< string>][-MemoryCapacity< VirtualizationMemoryCapacity>][[-Moid]< string>][-ProcessorCapacity< VirtualizationComputeCapacity>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-StorageClusters< System.Collections.Generic.List`1[StorageBaseClusterRelationship]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TotalCores< long>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;VirtualizationVmwareCluster&apos; resource.

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

### -CpuOverCommitment
CPU over commitment associated with this cluster.

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

### -DatastoreCount
Count of all datastores associated with this cluster.

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

### -HypervisorType
Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known.

```yaml
Type: VirtualizationVmwareCluster.HypervisorTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HypervisorVersion
Identifies the version of the hypervisor running on this cluster. Keeping the hypervisor version in the cluster makes it convenient for applications to validate their deployment needs. Defaults to an empty string.

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

### -InventoryPath
Inventory path of the cluster.

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

### -StorageClusters
An array of relationships to storageBaseCluster resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[StorageBaseClusterRelationship]
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

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightVirtualizationVmwareCluster
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationVmwareCluster](./Get-IntersightVirtualizationVmwareCluster.md)

[Initialize-IntersightCondAlarmSummary](./Initialize-IntersightCondAlarmSummary.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVirtualizationComputeCapacity](./Initialize-IntersightVirtualizationComputeCapacity.md)

[Initialize-IntersightVirtualizationMemoryCapacity](./Initialize-IntersightVirtualizationMemoryCapacity.md)

[Initialize-IntersightVirtualizationVmwareAttachedResourceTag](./Initialize-IntersightVirtualizationVmwareAttachedResourceTag.md)
