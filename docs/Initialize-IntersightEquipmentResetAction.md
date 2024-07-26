---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightEquipmentResetAction

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightEquipmentResetAction [-Action< EquipmentResetAction.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< EquipmentResetAction.ClassIdEnum>][-EnableFabricEvacuation< bool>][-ObjectType< EquipmentResetAction.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -Action
The reboot behavior for the Fabric Interconnect. Reboot - An action to reset the Fabric Interconnect by initiating its reboot. ForceReboot - Forces an immediate reboot of the Fabric Interconnect, overriding normal reboot validation checks. None - No reboot action should be triggered on the the Fabric Interconnect.\n* `None` - No action to be triggered on the Fabric Interconnect.\n* `Reboot` - An action to reset the Fabric Interconnect by initiating its reboot.\n* `ForceReboot` - An action to enforce an immediate reboot of the Fabric Interconnect regardless of existing validation checks.By default, a reset action is not allowed on an Fabric Interconnect if Domain Profile deployment, Manual Data Evacuation, or a reset action on the peer FI is already in progress. The force option allows users to override this check and perform the reset action on the FI.

```yaml
Type: EquipmentResetAction.ActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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
Type: EquipmentResetAction.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableFabricEvacuation
The flag to enable or disable fabric evacuation before rebooting the Fabric Interconnect.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: EquipmentResetAction.ObjectTypeEnum
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
PS C:\> Initialize-IntersightEquipmentResetAction
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
