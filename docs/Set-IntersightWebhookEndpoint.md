---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWebhookEndpoint

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWebhookEndpoint [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AppCredentials< IamAppCredentials>][-AppRegistration< IamAppRegistrationRelationship>][-AuthType< WebhookEndpoint.AuthTypeEnum>][-CredentialsAction< WebhookEndpoint.CredentialsActionEnum>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Schemas< System.Collections.Generic.List`1[WebhookSchemaRelationship]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WebhookEndpoint&apos; resource.

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

### -AppCredentials
Stores the credentials for the specified authentication type.

Note :- Use Initialize-IntersightIamAppCredentials to create the object of complex type IamAppCredentials

```yaml
Type: IamAppCredentials
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AppRegistration
A reference to a iamAppRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamAppRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AuthType
Type of authentication used by the clientApp.\n* `basic` - The client uses basic username/password authentication. The password is expected to be a JWT token.\n* `none` - No authentication method specified by the client.\n* `bearer-token` - The client uses a long-lived bearer token to authenticate.\n* `auth-code` - The client uses OAuth Authorization Grant Flow without PKCE for authentication.\n* `client-credentials` - The client uses OAuth Client Credentials Flow for authentication.

```yaml
Type: WebhookEndpoint.AuthTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CredentialsAction
An action to be performed on the credentials.\n* `none` - No action to be performed.\n* `regenerateCredentials` - Allows for revocation and regeneration of a token. The old token associated with the client application. will not be usable and a new token will be generated.

```yaml
Type: WebhookEndpoint.CredentialsActionEnum
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
The name of the Endpoint.

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

### -Schemas
An array of relationships to webhookSchema resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[WebhookSchemaRelationship]
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
PS C:\> Set-IntersightWebhookEndpoint
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWebhookEndpoint](./Get-IntersightWebhookEndpoint.md)

[Initialize-IntersightIamAppCredentials](./Initialize-IntersightIamAppCredentials.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightWebhookEndpoint](./New-IntersightWebhookEndpoint.md)

[Remove-IntersightWebhookEndpoint](./Remove-IntersightWebhookEndpoint.md)
