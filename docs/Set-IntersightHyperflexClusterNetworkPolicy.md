---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightHyperflexClusterNetworkPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightHyperflexClusterNetworkPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClusterProfiles< System.Collections.Generic.List`1[HyperflexClusterProfileRelationship]>][-Description< string>][-JumboFrame< bool>][-KvmIpRange< HyperflexIpAddrRange>][-MacPrefixRange< HyperflexMacAddrPrefixRange>][-MgmtVlan< HyperflexNamedVlan>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UplinkSpeed< HyperflexClusterNetworkPolicy.UplinkSpeedEnum>][-VmMigrationVlan< HyperflexNamedVlan>][-VmNetworkVlans< System.Collections.Generic.List`1[HyperflexNamedVlan]>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;HyperflexClusterNetworkPolicy&apos; resource.

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
Enable or disable Jumbo Frames (MTU=9000). Jumbo Frames are used by Storage Network, VM Migration Network.

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

Required: true
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
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
PS C:\> Set-IntersightHyperflexClusterNetworkPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightHyperflexClusterNetworkPolicy](./Get-IntersightHyperflexClusterNetworkPolicy.md)

[Initialize-IntersightHyperflexIpAddrRange](./Initialize-IntersightHyperflexIpAddrRange.md)

[Initialize-IntersightHyperflexMacAddrPrefixRange](./Initialize-IntersightHyperflexMacAddrPrefixRange.md)

[Initialize-IntersightHyperflexNamedVlan](./Initialize-IntersightHyperflexNamedVlan.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightHyperflexClusterNetworkPolicy](./New-IntersightHyperflexClusterNetworkPolicy.md)

[Remove-IntersightHyperflexClusterNetworkPolicy](./Remove-IntersightHyperflexClusterNetworkPolicy.md)
