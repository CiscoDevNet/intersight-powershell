---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightMoTag

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightMoTag [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Key< string>][-Type< MoTag.TypeEnum>][-Value< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Key
The string representation of a tag key.

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

### -Type
An enum that defines the type of tag. Supported values are PathTag and KeyValue.\nWhen omitted on create, the server infers the type from the tag shape or an existing TagDefinition.\nOn update, Type distinguishes PathTag and KeyValue tags that share the same key. If an\nempty tag could refer to either type based on stored tags or TagDefinitions, the request\nmust supply enough Type information to make the intended sibling unambiguous.\n* `KeyValue` - KeyValue type of tag. Key is required for these tags. Value is optional.\n* `PathTag` - Key contain path information. Value is not present for these tags. The path is created by using the &apos;/&apos; character as a delimiter.For example, if the tag is \&quot;A/B/C\&quot;, then \&quot;A\&quot; is the parent tag, \&quot;B\&quot; is the child tag of \&quot;A\&quot; and \&quot;C\&quot; is the child tag of \&quot;B\&quot;.

```yaml
Type: MoTag.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
The string representation of a tag value.

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
PS C:\> Initialize-IntersightMoTag
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
