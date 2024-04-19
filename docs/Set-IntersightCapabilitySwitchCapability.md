---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightCapabilitySwitchCapability

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightCapabilitySwitchCapability [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][[-Moid]< string>][-Name< string>][-Pid< CapabilitySwitchCapability.PidEnum>][-Sku< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Vid< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;CapabilitySwitchCapability&apos; resource.

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
An unique identifer for a capability descriptor.

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

### -Pid
Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `UCSX-S9108-100G` - Cisco UCS Fabric Interconnect 9108 100G with 8 ports.\n* `unknown` - Unknown device type, usage is TBD.

```yaml
Type: CapabilitySwitchCapability.PidEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sku
SKU information for Switch/Fabric-Interconnect.

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

### -Vid
VID information for Switch/Fabric-Interconnect.

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
PS C:\> Set-IntersightCapabilitySwitchCapability
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightCapabilitySwitchCapability](./Get-IntersightCapabilitySwitchCapability.md)

[Initialize-IntersightCapabilityPortRange](./Initialize-IntersightCapabilityPortRange.md)

[Initialize-IntersightCapabilitySwitchNetworkLimits](./Initialize-IntersightCapabilitySwitchNetworkLimits.md)

[Initialize-IntersightCapabilitySwitchStorageLimits](./Initialize-IntersightCapabilitySwitchStorageLimits.md)

[Initialize-IntersightCapabilitySwitchSystemLimits](./Initialize-IntersightCapabilitySwitchSystemLimits.md)

[Initialize-IntersightCapabilitySwitchingModeCapability](./Initialize-IntersightCapabilitySwitchingModeCapability.md)

[Initialize-IntersightFirmwareVersionMap](./Initialize-IntersightFirmwareVersionMap.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightCapabilitySwitchCapability](./New-IntersightCapabilitySwitchCapability.md)

[Remove-IntersightCapabilitySwitchCapability](./Remove-IntersightCapabilitySwitchCapability.md)
