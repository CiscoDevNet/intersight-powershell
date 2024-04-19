---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightMarketplaceUseCaseVersion

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightMarketplaceUseCaseVersion [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Catalog< MarketplaceCatalogRelationship>][-Locales< System.Collections.Generic.List`1[MarketplaceUseCaseVersionLocale]>][[-Moid]< string>][-Resources< System.Collections.Generic.List`1[MarketplaceUseCaseVersionResources]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UseCase< MarketplaceUseCaseRelationship>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;MarketplaceUseCaseVersion&apos; resource.

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

### -Catalog
A reference to a marketplaceCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MarketplaceCatalogRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Locales


Note :- Use Initialize-IntersightMarketplaceUseCaseVersionLocale to create the object of complex type MarketplaceUseCaseVersionLocale

```yaml
Type: System.Collections.Generic.List`1[MarketplaceUseCaseVersionLocale]
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

### -Resources


Note :- Use Initialize-IntersightMarketplaceUseCaseVersionResources to create the object of complex type MarketplaceUseCaseVersionResources

```yaml
Type: System.Collections.Generic.List`1[MarketplaceUseCaseVersionResources]
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

### -UseCase
A reference to a marketplaceUseCase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MarketplaceUseCaseRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
A string version for each use case.

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
PS C:\> Set-IntersightMarketplaceUseCaseVersion
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightMarketplaceUseCaseVersion](./Get-IntersightMarketplaceUseCaseVersion.md)

[Initialize-IntersightMarketplaceUseCaseVersionLocale](./Initialize-IntersightMarketplaceUseCaseVersionLocale.md)

[Initialize-IntersightMarketplaceUseCaseVersionResources](./Initialize-IntersightMarketplaceUseCaseVersionResources.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightMarketplaceUseCaseVersion](./New-IntersightMarketplaceUseCaseVersion.md)

[Remove-IntersightMarketplaceUseCaseVersion](./Remove-IntersightMarketplaceUseCaseVersion.md)
