---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightEquipmentSwitchOperation

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightEquipmentSwitchOperation [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdminEvacState< EquipmentSwitchOperation.AdminEvacStateEnum>][-AdminLocatorLedAction< EquipmentSwitchOperation.AdminLocatorLedActionEnum>][-AdminLocatorLedActionState< EquipmentSwitchOperation.AdminLocatorLedActionStateEnum>][-ConfigEvacState< EquipmentSwitchOperation.ConfigEvacStateEnum>][-DeviceRegistration< AssetDeviceRegistrationRelationship>][-ForceEvac< bool>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;EquipmentSwitchOperation&apos; resource.

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

### -AdminEvacState
Sets evacuation state of the switch. When evacuation is enabled, data traffic flowing through this switch will be suspended for all the servers. Fabric evacuation can be enabled during any maintenance activity on the switch in order to gracefully failover data flows to the peer switch.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State.

```yaml
Type: EquipmentSwitchOperation.AdminEvacStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdminLocatorLedAction
Action performed on the locator LED of the switch.\n* `None` - No operation action for the Locator Led of an equipment.\n* `TurnOn` - Turn on the Locator Led of an equipment.\n* `TurnOff` - Turn off the Locator Led of an equipment.

```yaml
Type: EquipmentSwitchOperation.AdminLocatorLedActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdminLocatorLedActionState
Defines status of action performed on AdminLocatorLedState.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied.

```yaml
Type: EquipmentSwitchOperation.AdminLocatorLedActionStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigEvacState
Captures the status of evacuation on this switch.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied.

```yaml
Type: EquipmentSwitchOperation.ConfigEvacStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DeviceRegistration
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ForceEvac
Evacuation is blocked by the system if it can cause a traffic outage in the domain. Select \&quot;Force Evacuation\&quot; only if system rejects the operation and you want to override that.

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
PS C:\> Set-IntersightEquipmentSwitchOperation
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightEquipmentSwitchOperation](./Get-IntersightEquipmentSwitchOperation.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
