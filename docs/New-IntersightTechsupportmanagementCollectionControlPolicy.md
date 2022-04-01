---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightTechsupportmanagementCollectionControlPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightTechsupportmanagementCollectionControlPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Moid< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TechSupportCollection< TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;TechsupportmanagementCollectionControlPolicy&apos; resource.

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

### -TechSupportCollection
Enable or Disable techsupport collection for a specific account.\n* `Enable` - Enable techsupport collection.\n* `Disable` - Disable techsupport collection.

```yaml
Type: TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum
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
PS C:\> New-IntersightTechsupportmanagementCollectionControlPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightTechsupportmanagementCollectionControlPolicy](./Get-IntersightTechsupportmanagementCollectionControlPolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightTechsupportmanagementCollectionControlPolicy](./Remove-IntersightTechsupportmanagementCollectionControlPolicy.md)

[Set-IntersightTechsupportmanagementCollectionControlPolicy](./Set-IntersightTechsupportmanagementCollectionControlPolicy.md)
