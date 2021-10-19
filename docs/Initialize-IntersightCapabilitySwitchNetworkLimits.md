---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCapabilitySwitchNetworkLimits

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCapabilitySwitchNetworkLimits [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< CapabilitySwitchNetworkLimits.ClassIdEnum>][-MaxCompressedPortVlanCount< long>][-MaxUncompressedPortVlanCount< long>][-MaximumActiveTrafficMonitoringSessions< long>][-MaximumEthernetPortChannels< long>][-MaximumEthernetUplinkPorts< long>][-MaximumFcPortChannelMembers< long>][-MaximumFcPortChannels< long>][-MaximumIgmpGroups< long>][-MaximumPortChannelMembers< long>][-MaximumPrimaryVlan< long>][-MaximumSecondaryVlan< long>][-MaximumSecondaryVlanPerPrimary< long>][-MaximumVifs< long>][-MaximumVlans< long>][-MinimumActiveFans< long>][-ObjectType< CapabilitySwitchNetworkLimits.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: CapabilitySwitchNetworkLimits.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MaxCompressedPortVlanCount
Maximum Compressed configurable VLANs on Switch/Fabric-Interconnect.

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

### -MaxUncompressedPortVlanCount
Maximum configurable VLANs on Switch/Fabric-Interconnect.

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

### -MaximumActiveTrafficMonitoringSessions
Maximum configured and enabled Traffic Monitoring sessions on this Switch/Fabric-Interconnect.

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

### -MaximumEthernetPortChannels
Maximum configurable Ethernet port-channels on Switch/Fabric-Interconnect.

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

### -MaximumEthernetUplinkPorts
Maximum configurable Ethernet Uplink ports on Switch/Fabric-Interconnect.

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

### -MaximumFcPortChannelMembers
Maximum configurable Fibre Channel port-channel member ports on Switch/Fabric-Interconnect.

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

### -MaximumFcPortChannels
Maximum configurable Fibre Channel port-channels on Switch/Fabric-Interconnect.

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

### -MaximumIgmpGroups
Maximum configurable IGMP Groups on Switch/Fabric-Interconnect.

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

### -MaximumPortChannelMembers
Maximum configurable ports per each port-channel on Switch/Fabric-Interconnect.

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

### -MaximumPrimaryVlan
Maximum configurable Primary Private VLANs on Switch/Fabric-Interconnect.

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

### -MaximumSecondaryVlan
Maximum configurable Secondary Private VLANs on Switch/Fabric-Interconnect.

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

### -MaximumSecondaryVlanPerPrimary
Maximum configurable Secondary VLANs per each Primary VLAN on Switch/Fabric-Interconnect.

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

### -MaximumVifs
Maximum allowes VIFs on Switch/Fabric-Interconnect.

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

### -MaximumVlans
Maximum configurable VLANs on Switch/Fabric-Interconnect.

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

### -MinimumActiveFans
Minimum required fans in &apos;active&apos; state for this Switch/Fabric-Interconnect.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: CapabilitySwitchNetworkLimits.ObjectTypeEnum
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
PS C:\> Initialize-IntersightCapabilitySwitchNetworkLimits
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
