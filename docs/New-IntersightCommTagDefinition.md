---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightCommTagDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightCommTagDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AllowedValues< System.Collections.Generic.List`1[string]>][-EnablePropagation< bool>][-Key< string>][-Moid< string>][-RestrictValues< bool>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Type< CommTagDefinition.TypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;CommTagDefinition&apos; resource.

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

### -AllowedValues


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnablePropagation
If this flag is enabled, the tag will be propagated to related managed objects.\nPropagation is supported in a limited manner for path tags and it is not supported for key value. Rules for propagation are\nconfigured by Intersight and cannot be configured by user.

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

### -Key
The string representation of the tag key. If the tag is of path type, then \&quot;/\&quot; will be interpreted as path delimiters.\nThe tag key must be unique within the account. The tag key is case sensitive and must not be empty.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RestrictValues
If this flag is enabled, then values of the KeyValue tag is restricted to values present in the allowedValues list. RestrictValues is not applicable to path tags.

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
An enum type that defines the type of tag. Only path tags are supported for now, and the type is set to path by default.\n* `KeyValue` - KeyValue type of tag. Key is required for these tags. Value is optional.\n* `PathTag` - Key contain path information. Value is not present for these tags. The path is created by using the &apos;/&apos; character as a delimiter.For example, if the tag is \&quot;A/B/C\&quot;, then \&quot;A\&quot; is the parent tag, \&quot;B\&quot; is the child tag of \&quot;A\&quot; and \&quot;C\&quot; is the child tag of \&quot;B\&quot;.

```yaml
Type: CommTagDefinition.TypeEnum
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
PS C:\> New-IntersightCommTagDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightCommTagDefinition](./Get-IntersightCommTagDefinition.md)

[Initialize-IntersightCommTagUsage](./Initialize-IntersightCommTagUsage.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightCommTagDefinition](./Remove-IntersightCommTagDefinition.md)

[Set-IntersightCommTagDefinition](./Set-IntersightCommTagDefinition.md)
