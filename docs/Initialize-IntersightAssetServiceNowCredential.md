---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAssetServiceNowCredential

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAssetServiceNowCredential [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< AssetServiceNowCredential.ClassIdEnum>][-OauthAuthenticationCredential< Model.AssetOauthClientIdSecretCredential>][-ObjectType< AssetServiceNowCredential.ObjectTypeEnum>][-UserPasswordCredential< Model.AssetUsernamePasswordCredential>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: AssetServiceNowCredential.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OauthAuthenticationCredential
Optional client id/secret credential used for oAuth authentication with ServiceNow target. ServiceNow requires this to be used for oAuth authentication combining with user/password credential.

Note :- Use Initialize-IntersightAssetOauthClientIdSecretCredential to create the object of complex type AssetOauthClientIdSecretCredential

```yaml
Type: Model.AssetOauthClientIdSecretCredential
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
Type: AssetServiceNowCredential.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UserPasswordCredential
Minimum required user/password credential to validate and discover ServiceNow target.

Note :- Use Initialize-IntersightAssetUsernamePasswordCredential to create the object of complex type AssetUsernamePasswordCredential

```yaml
Type: Model.AssetUsernamePasswordCredential
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
PS C:\> Initialize-IntersightAssetServiceNowCredential
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightAssetOauthClientIdSecretCredential](./Initialize-IntersightAssetOauthClientIdSecretCredential.md)

[Initialize-IntersightAssetUsernamePasswordCredential](./Initialize-IntersightAssetUsernamePasswordCredential.md)
