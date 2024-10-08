---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightAdapterHostFcInterface

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightAdapterHostFcInterface [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][[-Moid]< string>][-OperReason< System.Collections.Generic.List`1[AdapterHostFcInterface.OperReasonEnum]>][-PinGroupName< string>][-PinnedInterface< InventoryInterfaceRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VfcAction< AdapterHostFcInterface.VfcActionEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;AdapterHostFcInterface&apos; resource.

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

### -OperReason


```yaml
Type: System.Collections.Generic.List`1[AdapterHostFcInterface.OperReasonEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PinGroupName
Name given for San PinGroup.

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

### -PinnedInterface
A reference to a inventoryInterface resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: InventoryInterfaceRelationship
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

### -VfcAction
Denotes the action to be performed on the vfc corresponding to the vHBA.\n* `None` - Default value for vif operation.\n* `ResetConnectivity` - Resets connectivity on both active and passive vif.\n* `ResetConnectivityActive` - Resets connectivity on the active vif.\n* `ResetConnectivityPassive` - Resets connectivity on the passive vif.\n* `Enable` - Enables the vif on both the FIs.\n* `Disable` - Disables the vif on both the FIs.\n* `EnableActive` - Enables the corresponding active vif.\n* `EnablePassive` - Enables the corresponding standby vif.\n* `DisableActive` - Disables the corresponding active vif.\n* `DisablePassive` - Disables the corresponding standby vif.

```yaml
Type: AdapterHostFcInterface.VfcActionEnum
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
PS C:\> Set-IntersightAdapterHostFcInterface
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightAdapterHostFcInterface](./Get-IntersightAdapterHostFcInterface.md)

[Initialize-IntersightAdapterHostFcInterface.OperReasonEnum](./Initialize-IntersightAdapterHostFcInterface.OperReasonEnum.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
