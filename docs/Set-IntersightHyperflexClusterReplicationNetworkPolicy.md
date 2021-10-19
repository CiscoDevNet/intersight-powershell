---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightHyperflexClusterReplicationNetworkPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightHyperflexClusterReplicationNetworkPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClusterProfiles< System.Collections.Generic.List`1[HyperflexClusterProfileRelationship]>][-Description< string>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-ReplicationBandwidthMbps< long>][-ReplicationIpranges< System.Collections.Generic.List`1[HyperflexIpAddrRange]>][-ReplicationMtu< long>][-ReplicationVlan< HyperflexNamedVlan>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &amp;apos;HyperflexClusterReplicationNetworkPolicy&amp;apos; resource.

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

### -ReplicationBandwidthMbps
Bandwidth for the Replication network in Mbps.

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

### -ReplicationIpranges


Note :- Use Initialize-IntersightHyperflexIpAddrRange to create the object of complex type HyperflexIpAddrRange

```yaml
Type: System.Collections.Generic.List`1[HyperflexIpAddrRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReplicationMtu
MTU for the Replication network.

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

### -ReplicationVlan
VLAN for the Replication network.

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
PS C:\> Set-IntersightHyperflexClusterReplicationNetworkPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightHyperflexClusterReplicationNetworkPolicy](./Remove-IntersightHyperflexClusterReplicationNetworkPolicy.md)

[Get-IntersightHyperflexClusterReplicationNetworkPolicy](./Get-IntersightHyperflexClusterReplicationNetworkPolicy.md)

[New-IntersightHyperflexClusterReplicationNetworkPolicy](./New-IntersightHyperflexClusterReplicationNetworkPolicy.md)

[Initialize-IntersightHyperflexIpAddrRange](./Initialize-IntersightHyperflexIpAddrRange.md)

[Initialize-IntersightHyperflexNamedVlan](./Initialize-IntersightHyperflexNamedVlan.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
