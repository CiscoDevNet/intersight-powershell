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

Set-IntersightFabricSwitchControlPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AesPrimaryKey< string>][-Description< string>][-EthernetSwitchingMode< FabricSwitchControlPolicy.EthernetSwitchingModeEnum>][-FabricPcVhbaReset< FabricSwitchControlPolicy.FabricPcVhbaResetEnum>][-FcSwitchingMode< FabricSwitchControlPolicy.FcSwitchingModeEnum>][-MacAgingSettings< FabricMacAgingSettings>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[FabricBaseSwitchProfileRelationship]>][-ReservedVlanStartId< long>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UdldSettings< FabricUdldGlobalSettings>][-VlanPortOptimizationEnabled< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;FabricSwitchControlPolicy&apos; resource.

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

### -AesPrimaryKey
Encrypts MACsec keys in type-6 format. If a MACsec key is already provided in a type-6 format, the primary key decrypts it.

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

### -EthernetSwitchingMode
Enable or Disable Ethernet End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode.

```yaml
Type: FabricSwitchControlPolicy.EthernetSwitchingModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FabricPcVhbaReset
When enabled, a Registered State Change Notification (RSCN) is sent to the VIC adapter when any member port within the fabric port-channel goes down and vHBA would reset to restore the connection immediately. When disabled (default), vHBA reset is done only when all the members of a fabric port-channel are down.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State.

```yaml
Type: FabricSwitchControlPolicy.FabricPcVhbaResetEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcSwitchingMode
Enable or Disable FC End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode.

```yaml
Type: FabricSwitchControlPolicy.FcSwitchingModeEnum
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
An array of relationships to fabricBaseSwitchProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[FabricBaseSwitchProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReservedVlanStartId
The starting ID for VLANs reserved for internal use within the Fabric Interconnect. This VLAN ID is the starting ID of\na contiguous block of 128 VLANs that cannot be configured for user data.  This range of VLANs cannot be configured in\nVLAN policy.\nIf this property is not configured, VLAN range 3915 - 4042 is reserved for internal use by default.

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
To enable or disable the VLAN port count optimization. This feature will always be enabled for\nCisco UCS Fabric Interconnect 9108 100G and also enabled on the IMM 6.x Bundle version and onwards.

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

[Get-IntersightFabricSwitchControlPolicy](./Get-IntersightFabricSwitchControlPolicy.md)

[Initialize-IntersightFabricMacAgingSettings](./Initialize-IntersightFabricMacAgingSettings.md)

[Initialize-IntersightFabricUdldGlobalSettings](./Initialize-IntersightFabricUdldGlobalSettings.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightFabricSwitchControlPolicy](./New-IntersightFabricSwitchControlPolicy.md)

[Remove-IntersightFabricSwitchControlPolicy](./Remove-IntersightFabricSwitchControlPolicy.md)
