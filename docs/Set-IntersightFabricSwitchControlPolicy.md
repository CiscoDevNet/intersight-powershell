---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightFabricSwitchControlPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightFabricSwitchControlPolicy [-AdditionalProperties< Dictionary<string,object>>][-Description< string>][-MacAgingSettings< FabricMacAgingSettings>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< List<FabricSwitchProfileRelationship>>][-Tags< List<MoTag>>][-UdldSettings< FabricUdldGlobalSettings>][-VlanPortOptimizationEnabled< bool>]

```

## DESCRIPTION
Update a &amp;apos;FabricSwitchControlPolicy&amp;apos; resource.

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

### -MacAgingSettings
This specifies the MAC aging option and time settings.

Note :- Use Initialize-IntersightFabricMacAgingSettings to create the object of complex type FabricMacAgingSettings

```yaml
Type: FabricMacAgingSettings
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

### -Profiles
An array of relationships to fabricSwitchProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[FabricSwitchProfileRelationship]
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

### -UdldSettings
This specifies the UDLD Global configurations for this switch.

Note :- Use Initialize-IntersightFabricUdldGlobalSettings to create the object of complex type FabricUdldGlobalSettings

```yaml
Type: FabricUdldGlobalSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VlanPortOptimizationEnabled
To enable or disable the VLAN port count optimization.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightFabricSwitchControlPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightFabricSwitchControlPolicy](./Remove-IntersightFabricSwitchControlPolicy.md)

[New-IntersightFabricSwitchControlPolicy](./New-IntersightFabricSwitchControlPolicy.md)

[Get-IntersightFabricSwitchControlPolicy](./Get-IntersightFabricSwitchControlPolicy.md)

[Initialize-IntersightFabricMacAgingSettings](./Initialize-IntersightFabricMacAgingSettings.md)

[Initialize-IntersightFabricUdldGlobalSettings](./Initialize-IntersightFabricUdldGlobalSettings.md)
