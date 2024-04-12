---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightMarketplaceUseCase

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightMarketplaceUseCase [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Dependencies< System.Collections.Generic.List`1[MarketplaceUseCaseDependency]>][-Locales< System.Collections.Generic.List`1[MarketplaceUseCaseLocale]>][-Moid< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;MarketplaceUseCase&apos; resource.

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

### -Dependencies


Note :- Use Initialize-IntersightMarketplaceUseCaseDependency to create the object of complex type MarketplaceUseCaseDependency

```yaml
Type: System.Collections.Generic.List`1[MarketplaceUseCaseDependency]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Locales


Note :- Use Initialize-IntersightMarketplaceUseCaseLocale to create the object of complex type MarketplaceUseCaseLocale

```yaml
Type: System.Collections.Generic.List`1[MarketplaceUseCaseLocale]
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
PS C:\> New-IntersightMarketplaceUseCase
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightMarketplaceUseCase](./Get-IntersightMarketplaceUseCase.md)

[Initialize-IntersightMarketplaceUseCaseDependency](./Initialize-IntersightMarketplaceUseCaseDependency.md)

[Initialize-IntersightMarketplaceUseCaseLocale](./Initialize-IntersightMarketplaceUseCaseLocale.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightMarketplaceUseCase](./Remove-IntersightMarketplaceUseCase.md)

[Set-IntersightMarketplaceUseCase](./Set-IntersightMarketplaceUseCase.md)
