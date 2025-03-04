---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightNotificationAccountSubscription

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightNotificationAccountSubscription [-Actions< System.Collections.Generic.List`1[NotificationAction]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Conditions< System.Collections.Generic.List`1[NotificationAbstractCondition]>][-Enabled< bool>][[-Moid]< string>][-Name< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Type< NotificationAccountSubscription.TypeEnum>][-Verify< NotificationAccountSubscription.VerifyEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;NotificationAccountSubscription&apos; resource.

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
Subscription can be switched on/off without necessity to change the subscription\nsettings: notification methods, conditions, etc.\nEx.: Subscription MO can be configured, but switched off.

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

### -Name
The name of the subscription.

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

### -Type
The chosen subscription type imposes it is own validation rules.\nWhen &apos;email&apos; type is chosen, actions array can contain only one entry and it is entry should be of can\nbe only notification.SendEmail; conditions can contain only notification.AlarmMoCondition and condition\ntypes should be unique.\nWhen the &apos;webhook&apos; type is chosen, the actions array can contain only one entry and it is entry should be of can\nbe only notification.TriggerWebhook; conditions can contain up to a limited amount of entries and all of them\nshould be of type notification.MoCondition.\nWhen the &apos;workflow&apos; type is chosen, the actions array can contain only one entry and it is entry should \nbe of type notification.TriggerWorkflow notification.TriggerWorkflow; conditions can contain up to a \nlimited amount of entries and all of them should be of type notification.WebhookEventMoCondition.\n* `email` - Email type requires usage of notification.SendEmail complex types for actionsand notification.AlarmMoCondition complex types for conditions.\n* `webhook` - Webhook type requires usage of notification.TriggerWebhook complex types for actionsand notification.MoCondition complex types for conditions.\n* `workflow` - Workflow type requires usage of notification.TriggerWorkflow complex types for actionsand notification.WebhookEventMoCondition complex types for conditions.

```yaml
Type: NotificationAccountSubscription.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Verify
Used to verify the actions of the Subscription MO. For a &apos;webhook&apos; type Ping event is sent to verify\nthat the webhook server is accessible. For an &apos;email&apos; type there will be a verification email sent.\n* `none` - No actions will be verified. Default value.\n* `all` - All actions will be re-verified. The previous state of the verification will be preserved.

```yaml
Type: NotificationAccountSubscription.VerifyEnum
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
PS C:\> Set-IntersightNotificationAccountSubscription
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

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightNotificationAbstractCondition](./Initialize-IntersightNotificationAbstractCondition.md)

[Initialize-IntersightNotificationAction](./Initialize-IntersightNotificationAction.md)

[New-IntersightNotificationAccountSubscription](./New-IntersightNotificationAccountSubscription.md)

[Remove-IntersightNotificationAccountSubscription](./Remove-IntersightNotificationAccountSubscription.md)
