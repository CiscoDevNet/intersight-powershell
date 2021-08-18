---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFabricAppliancePcRole

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFabricAppliancePcRole [-AdditionalProperties< Dictionary<string,object>>][-AdminSpeed< FabricAppliancePcRole.AdminSpeedEnum>][-EthNetworkControlPolicy< FabricEthNetworkControlPolicyRelationship>][-EthNetworkGroupPolicy< FabricEthNetworkGroupPolicyRelationship>][-Mode< FabricAppliancePcRole.ModeEnum>][-Moid< string>][-PcId< long>][-PortPolicy< FabricPortPolicyRelationship>][-Ports< List<FabricPortIdentifier>>][-Priority< FabricAppliancePcRole.PriorityEnum>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &apos;FabricAppliancePcRole&apos; resource.

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

### -AdminSpeed
Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.

```yaml
Type: FabricAppliancePcRole.AdminSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthNetworkControlPolicy
A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricEthNetworkControlPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthNetworkGroupPolicy
A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricEthNetworkGroupPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Mode
Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type.

```yaml
Type: FabricAppliancePcRole.ModeEnum
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

### -PcId
Unique Identifier of the port-channel, local to this switch.

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

### -PortPolicy
A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricPortPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ports


Note :- Use Initialize-IntersightFabricPortIdentifier to create the object of complex type FabricPortIdentifier

```yaml
Type: System.Collections.Generic.List`1[FabricPortIdentifier]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Priority
The &apos;name&apos; of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic.

```yaml
Type: FabricAppliancePcRole.PriorityEnum
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
PS C:\> New-IntersightFabricAppliancePcRole
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightFabricAppliancePcRole](./Set-IntersightFabricAppliancePcRole.md)

[Remove-IntersightFabricAppliancePcRole](./Remove-IntersightFabricAppliancePcRole.md)

[Get-IntersightFabricAppliancePcRole](./Get-IntersightFabricAppliancePcRole.md)

[Initialize-IntersightFabricPortIdentifier](./Initialize-IntersightFabricPortIdentifier.md)
