---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVnicFcAdapterPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVnicFcAdapterPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-ErrorDetectionTimeout< long>][-ErrorRecoverySettings< VnicFcErrorRecoverySettings>][-FlogiSettings< VnicFlogiSettings>][-InterruptSettings< VnicFcInterruptSettings>][-IoThrottleCount< long>][-LunCount< long>][-LunQueueDepth< long>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-PlogiSettings< VnicPlogiSettings>][-ResourceAllocationTimeout< long>][-RxQueueSettings< VnicFcQueueSettings>][-ScsiQueueSettings< VnicScsiQueueSettings>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TxQueueSettings< VnicFcQueueSettings>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;VnicFcAdapterPolicy&apos; resource.

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

### -ErrorDetectionTimeout
Error Detection Timeout, also referred to as EDTOV, is the number of milliseconds to wait before the system assumes that an error has occurred.

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

### -ErrorRecoverySettings
Fibre Channel Error Recovery Settings.

Note :- Use Initialize-IntersightVnicFcErrorRecoverySettings to create the object of complex type VnicFcErrorRecoverySettings

```yaml
Type: VnicFcErrorRecoverySettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FlogiSettings
Fibre Channel Flogi Settings.

Note :- Use Initialize-IntersightVnicFlogiSettings to create the object of complex type VnicFlogiSettings

```yaml
Type: VnicFlogiSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InterruptSettings
Interrupt Settings for the virtual fibre channel interface.

Note :- Use Initialize-IntersightVnicFcInterruptSettings to create the object of complex type VnicFcInterruptSettings

```yaml
Type: VnicFcInterruptSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IoThrottleCount
The maximum number of data or control I/O operations that can be pending for the virtual interface at one time. If this value is exceeded, the additional I/O operations wait in the queue until the number of pending I/O operations decreases and the additional operations can be processed.

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

### -LunCount
The maximum number of LUNs that the Fibre Channel driver will export or show. The maximum number of LUNs is usually controlled by the operating system running on the server.

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

### -LunQueueDepth
The number of commands that the HBA can send and receive in a single transmission per LUN.

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

### -PlogiSettings
Fibre Channel Plogi Settings.

Note :- Use Initialize-IntersightVnicPlogiSettings to create the object of complex type VnicPlogiSettings

```yaml
Type: VnicPlogiSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceAllocationTimeout
Resource Allocation Timeout, also referred to as RATOV, is the number of milliseconds to wait before the system assumes that a resource cannot be properly allocated.

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

### -RxQueueSettings
Fibre Channel Receive Queue Settings.

Note :- Use Initialize-IntersightVnicFcQueueSettings to create the object of complex type VnicFcQueueSettings

```yaml
Type: VnicFcQueueSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScsiQueueSettings
SCSI Input/Output Queue Settings.

Note :- Use Initialize-IntersightVnicScsiQueueSettings to create the object of complex type VnicScsiQueueSettings

```yaml
Type: VnicScsiQueueSettings
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

### -TxQueueSettings
Fibre Channel Transmit Queue Settings.

Note :- Use Initialize-IntersightVnicFcQueueSettings to create the object of complex type VnicFcQueueSettings

```yaml
Type: VnicFcQueueSettings
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
PS C:\> Set-IntersightVnicFcAdapterPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVnicFcAdapterPolicy](./Get-IntersightVnicFcAdapterPolicy.md)

[New-IntersightVnicFcAdapterPolicy](./New-IntersightVnicFcAdapterPolicy.md)

[Remove-IntersightVnicFcAdapterPolicy](./Remove-IntersightVnicFcAdapterPolicy.md)

[Initialize-IntersightVnicFcErrorRecoverySettings](./Initialize-IntersightVnicFcErrorRecoverySettings.md)

[Initialize-IntersightVnicFlogiSettings](./Initialize-IntersightVnicFlogiSettings.md)

[Initialize-IntersightVnicFcInterruptSettings](./Initialize-IntersightVnicFcInterruptSettings.md)

[Initialize-IntersightVnicPlogiSettings](./Initialize-IntersightVnicPlogiSettings.md)

[Initialize-IntersightVnicFcQueueSettings](./Initialize-IntersightVnicFcQueueSettings.md)

[Initialize-IntersightVnicScsiQueueSettings](./Initialize-IntersightVnicScsiQueueSettings.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
