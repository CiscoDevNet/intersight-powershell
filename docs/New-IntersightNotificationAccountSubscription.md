---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightNotificationAccountSubscription

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightNotificationAccountSubscription [-Actions< System.Collections.Generic.List`1[NotificationAction]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Conditions< System.Collections.Generic.List`1[NotificationAbstractCondition]>][-Enabled< bool>][-Moid< string>][[-Name]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;NotificationAccountSubscription&apos; resource.

## PARAMETERS

### -Actions


Note :- Use Initialize-IntersightNotificationAction to create the object of complex type NotificationAction

```yaml
Type: System.Collections.Generic.List`1[NotificationAction]
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

### -Conditions


Note :- Use Initialize-IntersightNotificationAbstractCondition to create the object of complex type NotificationAbstractCondition

```yaml
Type: System.Collections.Generic.List`1[NotificationAbstractCondition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enabled
Subscription can be switched on/off with out necessity to change the subscription\nsettings: notification methods, conditions etc.\nEx.: Subscription MO can be configured, but switched off.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The subscription name.

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
PS C:\> New-IntersightNotificationAccountSubscription
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightNotificationAccountSubscription](./Get-IntersightNotificationAccountSubscription.md)

[Set-IntersightNotificationAccountSubscription](./Set-IntersightNotificationAccountSubscription.md)

[Remove-IntersightNotificationAccountSubscription](./Remove-IntersightNotificationAccountSubscription.md)

[Initialize-IntersightNotificationAction](./Initialize-IntersightNotificationAction.md)

[Initialize-IntersightNotificationAbstractCondition](./Initialize-IntersightNotificationAbstractCondition.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
