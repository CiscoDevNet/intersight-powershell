---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightCapabilitySwitchCapability

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightCapabilitySwitchCapability [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DefaultFcoeVlan< long>][-DynamicVifsSupported< bool>][-FanModulesSupported< bool>][-FcEndHostModeReservedVsans< System.Collections.Generic.List`1[CapabilityPortRange]>][-FcUplinkPortsAutoNegotiationSupported< bool>][-LocatorBeaconSupported< bool>][-MaxPorts< long>][-MaxSlots< long>][-Moid< string>][[-Name]< string>][-NetworkLimits< CapabilitySwitchNetworkLimits>][-Pid< CapabilitySwitchCapability.PidEnum>][-PortsSupporting100gSpeed< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupporting10gSpeed< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupporting1gSpeed< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupporting25gSpeed< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupporting40gSpeed< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupportingBreakout< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupportingFcoe< System.Collections.Generic.List`1[CapabilityPortRange]>][-PortsSupportingServerRole< System.Collections.Generic.List`1[CapabilityPortRange]>][-ReservedVsans< System.Collections.Generic.List`1[CapabilityPortRange]>][-SerenoNetflowSupported< bool>][-Sku< string>][-StorageLimits< CapabilitySwitchStorageLimits>][-SwitchingModeCapabilities< System.Collections.Generic.List`1[CapabilitySwitchingModeCapability]>][-SystemLimits< CapabilitySwitchSystemLimits>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UnifiedPorts< System.Collections.Generic.List`1[CapabilityPortRange]>][-UnifiedRule< string>][-Vid< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;CapabilitySwitchCapability&apos; resource.

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

### -DefaultFcoeVlan
Default Fcoe VLAN associated with this switch.

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

### -DynamicVifsSupported
Dynamic VIFs support on this switch.

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

### -FanModulesSupported
Fan Modules support on this switch.

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

### -FcEndHostModeReservedVsans


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcUplinkPortsAutoNegotiationSupported
Fc Uplink ports auto negotiation speed support on this switch.

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

### -LocatorBeaconSupported
Locator Beacon LED support on this switch.

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

### -MaxPorts
Maximum allowed physical ports on this switch.

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

### -MaxSlots
Maximum allowed physical slots on this switch.

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
An unique identifer for a capability descriptor.

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

### -NetworkLimits
List of network limitations for this switch.

Note :- Use Initialize-IntersightCapabilitySwitchNetworkLimits to create the object of complex type CapabilitySwitchNetworkLimits

```yaml
Type: CapabilitySwitchNetworkLimits
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Pid
Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `unknown` - Unknown device type, usage is TBD.

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

### -PortsSupporting100gSpeed


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupporting10gSpeed


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupporting1gSpeed


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupporting25gSpeed


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupporting40gSpeed


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupportingBreakout


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupportingFcoe


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortsSupportingServerRole


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReservedVsans


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SerenoNetflowSupported
Sereno Adaptor with Netflow support on this switch.

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

### -StorageLimits
List of storage limitations for this switch.

Note :- Use Initialize-IntersightCapabilitySwitchStorageLimits to create the object of complex type CapabilitySwitchStorageLimits

```yaml
Type: CapabilitySwitchStorageLimits
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SwitchingModeCapabilities


Note :- Use Initialize-IntersightCapabilitySwitchingModeCapability to create the object of complex type CapabilitySwitchingModeCapability

```yaml
Type: System.Collections.Generic.List`1[CapabilitySwitchingModeCapability]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemLimits
List of system limitations for this switch.

Note :- Use Initialize-IntersightCapabilitySwitchSystemLimits to create the object of complex type CapabilitySwitchSystemLimits

```yaml
Type: CapabilitySwitchSystemLimits
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

### -UnifiedPorts


Note :- Use Initialize-IntersightCapabilityPortRange to create the object of complex type CapabilityPortRange

```yaml
Type: System.Collections.Generic.List`1[CapabilityPortRange]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UnifiedRule
The Slider rule for Unified ports on this switch.

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
PS C:\> New-IntersightCapabilitySwitchCapability
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightCapabilitySwitchCapability](./Remove-IntersightCapabilitySwitchCapability.md)

[Set-IntersightCapabilitySwitchCapability](./Set-IntersightCapabilitySwitchCapability.md)

[Get-IntersightCapabilitySwitchCapability](./Get-IntersightCapabilitySwitchCapability.md)

[Initialize-IntersightCapabilityPortRange](./Initialize-IntersightCapabilityPortRange.md)

[Initialize-IntersightCapabilitySwitchNetworkLimits](./Initialize-IntersightCapabilitySwitchNetworkLimits.md)

[Initialize-IntersightCapabilitySwitchStorageLimits](./Initialize-IntersightCapabilitySwitchStorageLimits.md)

[Initialize-IntersightCapabilitySwitchingModeCapability](./Initialize-IntersightCapabilitySwitchingModeCapability.md)

[Initialize-IntersightCapabilitySwitchSystemLimits](./Initialize-IntersightCapabilitySwitchSystemLimits.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
