---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightSoftwarerepositoryCategoryUnsupportedModels

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightSoftwarerepositoryCategoryUnsupportedModels [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-MdfId< string>][-ModelConstraint< System.Collections.Generic.List`1[SoftwarerepositoryUnsupportedModelConstraint]>][-Moid< string>][[-Name]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;SoftwarerepositoryCategoryUnsupportedModels&apos; resource.

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

### -MdfId
Cisco software repository image category identifier.

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

### -ModelConstraint


Note :- Use Initialize-IntersightSoftwarerepositoryUnsupportedModelConstraint to create the object of complex type SoftwarerepositoryUnsupportedModelConstraint

```yaml
Type: System.Collections.Generic.List`1[SoftwarerepositoryUnsupportedModelConstraint]
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
An unique identifer for a capability descriptor.

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
PS C:\> New-IntersightSoftwarerepositoryCategoryUnsupportedModels
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightSoftwarerepositoryCategoryUnsupportedModels](./Get-IntersightSoftwarerepositoryCategoryUnsupportedModels.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightSoftwarerepositoryUnsupportedModelConstraint](./Initialize-IntersightSoftwarerepositoryUnsupportedModelConstraint.md)

[Remove-IntersightSoftwarerepositoryCategoryUnsupportedModels](./Remove-IntersightSoftwarerepositoryCategoryUnsupportedModels.md)

[Set-IntersightSoftwarerepositoryCategoryUnsupportedModels](./Set-IntersightSoftwarerepositoryCategoryUnsupportedModels.md)
