---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightIamDomainNameInfo

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightIamDomainNameInfo [-Action< IamDomainNameInfo.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DomainName< string>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;IamDomainNameInfo&apos; resource.

## PARAMETERS

### -Action
Regenerate TXT record and validate TXT record.\n* `generate` - Generate TXT record for domain name ownership validation.\n* `verify` - Verify TXT record for domain name ownership validation.

```yaml
Type: IamDomainNameInfo.ActionEnum
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

### -DomainName
Email domain name. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication.

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
PS C:\> Set-IntersightIamDomainNameInfo
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightIamDomainNameInfo](./Get-IntersightIamDomainNameInfo.md)

[Initialize-IntersightIamFailureDetails](./Initialize-IntersightIamFailureDetails.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightIamDomainNameInfo](./New-IntersightIamDomainNameInfo.md)

[Remove-IntersightIamDomainNameInfo](./Remove-IntersightIamDomainNameInfo.md)
