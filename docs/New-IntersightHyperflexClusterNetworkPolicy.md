---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexClusterNetworkPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexClusterNetworkPolicy [-AdditionalProperties< Dictionary<string,object>>][-ClusterProfiles< List<HyperflexClusterProfileRelationship>>][-Description< string>][-JumboFrame< bool>][-KvmIpRange< HyperflexIpAddrRange>][-MacPrefixRange< HyperflexMacAddrPrefixRange>][-MgmtVlan< HyperflexNamedVlan>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< List<MoTag>>][-UplinkSpeed< HyperflexClusterNetworkPolicy.UplinkSpeedEnum>][-VmMigrationVlan< HyperflexNamedVlan>][-VmNetworkVlans< List<HyperflexNamedVlan>>]

```

## DESCRIPTION
Create a &apos;HyperflexClusterNetworkPolicy&apos; resource.

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

### -ClusterProfiles
An array of relationships to hyperflexClusterProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[HyperflexClusterProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the policy.

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

### -JumboFrame
Enable or disable jumbo frames.

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

### -KvmIpRange
The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server.

Note :- Use Initialize-IntersightHyperflexIpAddrRange to create the object of complex type HyperflexIpAddrRange

```yaml
Type: HyperflexIpAddrRange
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MacPrefixRange
The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs.

Note :- Use Initialize-IntersightHyperflexMacAddrPrefixRange to create the object of complex type HyperflexMacAddrPrefixRange

```yaml
Type: HyperflexMacAddrPrefixRange
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MgmtVlan
The VLAN for the management network.

Note :- Use Initialize-IntersightHyperflexNamedVlan to create the object of complex type HyperflexNamedVlan

```yaml
Type: HyperflexNamedVlan
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
Name of the concrete policy.

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

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
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

### -UplinkSpeed
Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be &apos;1G&apos; or &apos;10G+&apos;. Use &apos;10G+&apos; for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be &apos;default&apos; only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above.

```yaml
Type: HyperflexClusterNetworkPolicy.UplinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmMigrationVlan
The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc.

Note :- Use Initialize-IntersightHyperflexNamedVlan to create the object of complex type HyperflexNamedVlan

```yaml
Type: HyperflexNamedVlan
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmNetworkVlans


Note :- Use Initialize-IntersightHyperflexNamedVlan to create the object of complex type HyperflexNamedVlan

```yaml
Type: System.Collections.Generic.List`1[HyperflexNamedVlan]
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
PS C:\> New-IntersightHyperflexClusterNetworkPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightHyperflexClusterNetworkPolicy](./Set-IntersightHyperflexClusterNetworkPolicy.md)

[Remove-IntersightHyperflexClusterNetworkPolicy](./Remove-IntersightHyperflexClusterNetworkPolicy.md)

[Get-IntersightHyperflexClusterNetworkPolicy](./Get-IntersightHyperflexClusterNetworkPolicy.md)

[Initialize-IntersightHyperflexIpAddrRange](./Initialize-IntersightHyperflexIpAddrRange.md)

[Initialize-IntersightHyperflexMacAddrPrefixRange](./Initialize-IntersightHyperflexMacAddrPrefixRange.md)

[Initialize-IntersightHyperflexNamedVlan](./Initialize-IntersightHyperflexNamedVlan.md)
