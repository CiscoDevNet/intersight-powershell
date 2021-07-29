---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexNodeConfigPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexNodeConfigPolicy [-AdditionalProperties< Dictionary<string,object>>][-ClusterProfiles< List<HyperflexClusterProfileRelationship>>][-DataIpRange< HyperflexIpAddrRange>][-Description< string>][-HxdpIpRange< HyperflexIpAddrRange>][-HypervisorControlIpRange< HyperflexIpAddrRange>][-MgmtIpRange< HyperflexIpAddrRange>][-Moid< string>][[-Name]< string>][-NodeNamePrefix< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &apos;HyperflexNodeConfigPolicy&apos; resource.

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

### -DataIpRange
The range of storage data IPs to be assigned to the nodes.

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

### -HxdpIpRange
The range of storage management IPs to be assigned to the nodes.

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

### -HypervisorControlIpRange
The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control.

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

### -MgmtIpRange
The range of management IPs to be assigned to the nodes.

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

### -NodeNamePrefix
The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightHyperflexNodeConfigPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightHyperflexNodeConfigPolicy](./Set-IntersightHyperflexNodeConfigPolicy.md)

[Remove-IntersightHyperflexNodeConfigPolicy](./Remove-IntersightHyperflexNodeConfigPolicy.md)

[Get-IntersightHyperflexNodeConfigPolicy](./Get-IntersightHyperflexNodeConfigPolicy.md)

[Initialize-IntersightHyperflexIpAddrRange](./Initialize-IntersightHyperflexIpAddrRange.md)
