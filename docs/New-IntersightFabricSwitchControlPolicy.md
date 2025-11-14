---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFabricSwitchControlPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFabricSwitchControlPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AesPrimaryKey< string>][-Description< string>][-EnableJumboFrame< bool>][-EthernetSwitchingMode< FabricSwitchControlPolicy.EthernetSwitchingModeEnum>][-FabricPcVhbaReset< FabricSwitchControlPolicy.FabricPcVhbaResetEnum>][-FcSwitchingMode< FabricSwitchControlPolicy.FcSwitchingModeEnum>][-MacAgingSettings< FabricMacAgingSettings>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[FabricBaseSwitchProfileRelationship]>][-ReservedVlanStartId< long>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TargetPlatform< FabricSwitchControlPolicy.TargetPlatformEnum>][-UdldSettings< FabricUdldGlobalSettings>][-VlanPortOptimizationEnabled< bool>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FabricSwitchControlPolicy&apos; resource.

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
Encrypts MACsec keys in type-6 format. If a MACsec key is already provided in a type-6 format, the primary key decrypts it. MACSec is not supported on Unified Edge, so the primary key cannot be configured.

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

### -EnableJumboFrame
To enable or disable Jumbo Frames on the switch. On Fabric Interconnects, Jumbo Frames are controlled by the System QoS policy, so this setting is ignored.

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

### -EthernetSwitchingMode
Enable or Disable Ethernet End Host Switching Mode. Ethernet End Host Switching Mode is not applicable for Unified Edge; the value defaults to Ethernet Switch Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode.

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
When enabled, a Registered State Change Notification (RSCN) is sent to the VIC adapter when any member port within the fabric port-channel goes down and vHBA would reset to restore the connection immediately. When disabled (default), vHBA reset is done only when all the members of a fabric port-channel are down. Fabric port-channel vHBA reset is not supported on Unified Edge and cannot be enabled.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State.

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
Enable or Disable FC End Host Switching Mode. FC is not supported on Unified Edge, so this setting cannot be configured and is ignored.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode.

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
The starting ID for VLANs reserved for internal use within the Fabric Interconnect. This VLAN ID is the starting ID of\na contiguous block of 128 VLANs that cannot be configured for user data.  This range of VLANs cannot be configured in\nVLAN policy.\nIf this property is not configured, VLAN range 3915 - 4042 is reserved for internal use by default.\nThe reserved VLAN range is fixed for Unified Edge, so this setting cannot be configured and is ignored.

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

### -TargetPlatform
The target platform type of the Switch Control policy.\n* `UCS Domain` - Profile/policy type for network and management configuration on UCS Fabric Interconnect.\n* `Unified Edge` - Profile/policy type for network, management and chassis configuration on Unified Edge.

```yaml
Type: FabricSwitchControlPolicy.TargetPlatformEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UdldSettings
This specifies the UDLD Global configurations for this switch. UDLD is not supported on Unified Edge, so these settings cannot be configured.

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
To enable or disable the VLAN port count optimization. This feature will always be enabled for\nCisco UCS Fabric Interconnect 9108 100G and also enabled on the IMM 6.x Bundle version and onwards.\nVLAN Port Count Optimization is not applicable for Unified Edge, so this setting cannot be configured.

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

### -IfNoneMatch
For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&apos;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&apos;s ETag doesn&apos;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&apos;t have to be identical byte for byte.

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
PS C:\> New-IntersightFabricSwitchControlPolicy
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

[Remove-IntersightFabricSwitchControlPolicy](./Remove-IntersightFabricSwitchControlPolicy.md)

[Set-IntersightFabricSwitchControlPolicy](./Set-IntersightFabricSwitchControlPolicy.md)
