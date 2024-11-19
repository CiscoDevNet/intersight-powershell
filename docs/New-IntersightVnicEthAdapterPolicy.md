---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightVnicEthAdapterPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightVnicEthAdapterPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdvancedFilter< bool>][-ArfsSettings< VnicArfsSettings>][-CompletionQueueSettings< VnicCompletionQueueSettings>][-Description< string>][-EtherChannelPinningEnabled< bool>][-GeneveEnabled< bool>][-InterruptScaling< bool>][-InterruptSettings< VnicEthInterruptSettings>][-Moid< string>][[-Name]< string>][-NvgreSettings< VnicNvgreSettings>][-Organization< OrganizationOrganizationRelationship>][-PtpSettings< VnicPtpSettings>][-RoceSettings< VnicRoceSettings>][-RssHashSettings< VnicRssHashSettings>][-RssSettings< bool>][-RxQueueSettings< VnicEthRxQueueSettings>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TcpOffloadSettings< VnicTcpOffloadSettings>][-TxQueueSettings< VnicEthTxQueueSettings>][-UplinkFailbackTimeout< long>][-VxlanSettings< VnicVxlanSettings>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;VnicEthAdapterPolicy&apos; resource.

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

### -AdvancedFilter
Enables advanced filtering on the interface.

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

### -ArfsSettings
Settings for Accelerated Receive Flow Steering to reduce the network latency and increase CPU cache efficiency.

Note :- Use Initialize-IntersightVnicArfsSettings to create the object of complex type VnicArfsSettings

```yaml
Type: VnicArfsSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CompletionQueueSettings
Completion Queue resource settings.

Note :- Use Initialize-IntersightVnicCompletionQueueSettings to create the object of complex type VnicCompletionQueueSettings

```yaml
Type: VnicCompletionQueueSettings
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

### -EtherChannelPinningEnabled
Enables Ether Channel Pinning to combine multiple physical links between two network switches into a single logical link. Transmit Queue Count should be at least 2 to enable ether channel pinning.

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

### -GeneveEnabled
GENEVE offload protocol allows you to create logical networks that span physical network boundaries by allowing any information to be encoded in a packet and passed between tunnel endpoints.

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

### -InterruptScaling
Enables Interrupt Scaling on the interface.

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

### -InterruptSettings
Interrupt Settings for the virtual ethernet interface.

Note :- Use Initialize-IntersightVnicEthInterruptSettings to create the object of complex type VnicEthInterruptSettings

```yaml
Type: VnicEthInterruptSettings
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

### -NvgreSettings
Network Virtualization using Generic Routing Encapsulation Settings.

Note :- Use Initialize-IntersightVnicNvgreSettings to create the object of complex type VnicNvgreSettings

```yaml
Type: VnicNvgreSettings
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

### -PtpSettings
Settings for Precision Time Protocol which can provide precise time of day information and time-stampted inputs, as well as scheduled and/or synchronized outputs for a variety of systems.

Note :- Use Initialize-IntersightVnicPtpSettings to create the object of complex type VnicPtpSettings

```yaml
Type: VnicPtpSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RoceSettings
Settings for RDMA over Converged Ethernet.

Note :- Use Initialize-IntersightVnicRoceSettings to create the object of complex type VnicRoceSettings

```yaml
Type: VnicRoceSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RssHashSettings
Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores.

Note :- Use Initialize-IntersightVnicRssHashSettings to create the object of complex type VnicRssHashSettings

```yaml
Type: VnicRssHashSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RssSettings
Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores.

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

### -RxQueueSettings
Receive Queue resouce settings.

Note :- Use Initialize-IntersightVnicEthRxQueueSettings to create the object of complex type VnicEthRxQueueSettings

```yaml
Type: VnicEthRxQueueSettings
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

### -TcpOffloadSettings
The TCP offload settings decide whether to offload the TCP related network functions from the CPU to the network hardware or not.

Note :- Use Initialize-IntersightVnicTcpOffloadSettings to create the object of complex type VnicTcpOffloadSettings

```yaml
Type: VnicTcpOffloadSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TxQueueSettings
Transmit Queue resource settings.

Note :- Use Initialize-IntersightVnicEthTxQueueSettings to create the object of complex type VnicEthTxQueueSettings

```yaml
Type: VnicEthTxQueueSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UplinkFailbackTimeout
Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC.

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

### -VxlanSettings
Virtual Extensible LAN Protocol Settings.

Note :- Use Initialize-IntersightVnicVxlanSettings to create the object of complex type VnicVxlanSettings

```yaml
Type: VnicVxlanSettings
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
PS C:\> New-IntersightVnicEthAdapterPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVnicEthAdapterPolicy](./Get-IntersightVnicEthAdapterPolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVnicArfsSettings](./Initialize-IntersightVnicArfsSettings.md)

[Initialize-IntersightVnicCompletionQueueSettings](./Initialize-IntersightVnicCompletionQueueSettings.md)

[Initialize-IntersightVnicEthInterruptSettings](./Initialize-IntersightVnicEthInterruptSettings.md)

[Initialize-IntersightVnicEthRxQueueSettings](./Initialize-IntersightVnicEthRxQueueSettings.md)

[Initialize-IntersightVnicEthTxQueueSettings](./Initialize-IntersightVnicEthTxQueueSettings.md)

[Initialize-IntersightVnicNvgreSettings](./Initialize-IntersightVnicNvgreSettings.md)

[Initialize-IntersightVnicPtpSettings](./Initialize-IntersightVnicPtpSettings.md)

[Initialize-IntersightVnicRoceSettings](./Initialize-IntersightVnicRoceSettings.md)

[Initialize-IntersightVnicRssHashSettings](./Initialize-IntersightVnicRssHashSettings.md)

[Initialize-IntersightVnicTcpOffloadSettings](./Initialize-IntersightVnicTcpOffloadSettings.md)

[Initialize-IntersightVnicVxlanSettings](./Initialize-IntersightVnicVxlanSettings.md)

[Remove-IntersightVnicEthAdapterPolicy](./Remove-IntersightVnicEthAdapterPolicy.md)

[Set-IntersightVnicEthAdapterPolicy](./Set-IntersightVnicEthAdapterPolicy.md)
