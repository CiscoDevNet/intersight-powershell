---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsCmnMemDramScrubTimeC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsCmnMemDramScrubTimeC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsCmnMemDramScrubTimeC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsCmnMemDramScrubTimeC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsCmnMemDramScrubTimeC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsCmnMemDramScrubTimeC845BiosToken.ClassIdEnum
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
Type: BiosCbsCmnMemDramScrubTimeC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
Provide a value that is the number of hours to scrub memory.\n* `24 hours` - Value -- 24 hours for configuring CbsCmnMemDramScrubTime token.\n* `Disabled` - Value -- Disabled for configuring CbsCmnMemDramScrubTime token.\n* `1 hour` - Value -- 1 hour for configuring CbsCmnMemDramScrubTime token.\n* `4 hours` - Value -- 4 hours for configuring CbsCmnMemDramScrubTime token.\n* `6 hours` - Value -- 6 hours for configuring CbsCmnMemDramScrubTime token.\n* `8 hours` - Value -- 8 hours for configuring CbsCmnMemDramScrubTime token.\n* `12 hours` - Value -- 12 hours for configuring CbsCmnMemDramScrubTime token.\n* `16 hours` - Value -- 16 hours for configuring CbsCmnMemDramScrubTime token.\n* `48 hours` - Value -- 48 hours for configuring CbsCmnMemDramScrubTime token.

```yaml
Type: BiosCbsCmnMemDramScrubTimeC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsCmnMemDramScrubTimeC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
