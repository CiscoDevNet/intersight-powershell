---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexExtFcStoragePolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexExtFcStoragePolicy [-AdditionalProperties< Dictionary<string,object>>][-AdminState< bool>][-ClusterProfiles< List<HyperflexClusterProfileRelationship>>][-Description< string>][-ExtaTraffic< HyperflexNamedVsan>][-ExtbTraffic< HyperflexNamedVsan>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< List<MoTag>>][-WwxnPrefixRange< HyperflexWwxnPrefixRange>]

```

## DESCRIPTION
Create a &amp;apos;HyperflexExtFcStoragePolicy&amp;apos; resource.

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

### -AdminState
Enables or disables external FC storage configuration.

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

### -ExtaTraffic
VSAN for the primary Fabric Interconnect external FC storage traffic.

Note :- Use Initialize-IntersightHyperflexNamedVsan to create the object of complex type HyperflexNamedVsan

```yaml
Type: HyperflexNamedVsan
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExtbTraffic
VSAN for the secondary Fabric Interconnect external FC storage traffic.

Note :- Use Initialize-IntersightHyperflexNamedVsan to create the object of complex type HyperflexNamedVsan

```yaml
Type: HyperflexNamedVsan
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

### -WwxnPrefixRange
The range of WWxN addresses to use for the FC storage configuration.

Note :- Use Initialize-IntersightHyperflexWwxnPrefixRange to create the object of complex type HyperflexWwxnPrefixRange

```yaml
Type: HyperflexWwxnPrefixRange
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
PS C:\> New-IntersightHyperflexExtFcStoragePolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightHyperflexExtFcStoragePolicy](./Set-IntersightHyperflexExtFcStoragePolicy.md)

[Remove-IntersightHyperflexExtFcStoragePolicy](./Remove-IntersightHyperflexExtFcStoragePolicy.md)

[Get-IntersightHyperflexExtFcStoragePolicy](./Get-IntersightHyperflexExtFcStoragePolicy.md)

[Initialize-IntersightHyperflexNamedVsan](./Initialize-IntersightHyperflexNamedVsan.md)

[Initialize-IntersightHyperflexWwxnPrefixRange](./Initialize-IntersightHyperflexWwxnPrefixRange.md)
