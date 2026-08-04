---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNotificationTriggerWebhook

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNotificationTriggerWebhook [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Authentication< Model.AssetCredential>][-ClassId< NotificationTriggerWebhook.ClassIdEnum>][-ClearSecret< bool>][-CustomHeaders< System.Collections.Generic.List`1[Model.NotificationHttpHeader]>][-ObjectType< NotificationTriggerWebhook.ObjectTypeEnum>][-Secret< string>][-Url< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Authentication
The credential used to authenticate webhook delivery requests. When set to a\nreal credential, the appropriate authentication header (Basic, Bearer, or Splunk)\nis attached to each outgoing notification. If not set or if\nasset.NoAuthenticationCredential is used, requests use HMAC-SHA256 via the secret\nfield when secret is set; otherwise the request is sent without Authorization\nsigning or headers.

Note :- Use Initialize-IntersightAssetCredential to create the object of complex type AssetCredential

```yaml
Type: Model.AssetCredential
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
Type: NotificationTriggerWebhook.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClearSecret
When set to true on update, the HMAC shared secret is not carried over from the previous\nstored action when the request omits the write-only ``secret`` field. Use this to clear\nthe signing key without re-sending a secret value. When false or not set, the prior\nbehavior applies: the previous secret is preserved on PATCH if ``secret`` is omitted.

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

### -CustomHeaders


Note :- Use Initialize-IntersightNotificationHttpHeader to create the object of complex type NotificationHttpHeader

```yaml
Type: System.Collections.Generic.List`1[Model.NotificationHttpHeader]
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
Type: NotificationTriggerWebhook.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Secret
Prefer the Authentication property to configure how webhook deliveries are authenticated, including the Authorization header.\nThis field holds the shared secret used for HMAC-SHA256 signing when no credential is configured, and remains supported for existing integrations.\nBy this header developers of the webhooks servers can make sure that events are received from the trusted source - Intersight.

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

### -Url
Payload URL of the recipient app, which is intended to serve the events that happens in Intersight.

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
PS C:\> Initialize-IntersightNotificationTriggerWebhook
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightAssetCredential](./Initialize-IntersightAssetCredential.md)

[Initialize-IntersightNotificationHttpHeader](./Initialize-IntersightNotificationHttpHeader.md)
