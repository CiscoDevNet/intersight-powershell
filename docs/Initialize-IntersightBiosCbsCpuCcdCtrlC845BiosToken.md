---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsCpuCcdCtrlC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsCpuCcdCtrlC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsCpuCcdCtrlC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsCpuCcdCtrlC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsCpuCcdCtrlC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsCpuCcdCtrlC845BiosToken.ClassIdEnum
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
Type: BiosCbsCpuCcdCtrlC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
Sets the number of active CCDs.  Once this option has been used to remove any CCDs, a POWER CYCLE is required in order for future selections to take effect.\n* `Auto` - Value -- Auto for configuring CbsCpuCcdCtrl token.\n* `2 CCDs` - Value -- 2 CCDs for configuring CbsCpuCcdCtrl token.\n* `4 CCDs` - Value -- 4 CCDs for configuring CbsCpuCcdCtrl token.\n* `6 CCDs` - Value -- 6 CCDs for configuring CbsCpuCcdCtrl token.\n* `8 CCDs` - Value -- 8 CCDs for configuring CbsCpuCcdCtrl token.\n* `10 CCDs` - Value -- 10 CCDs for configuring CbsCpuCcdCtrl token.\n* `12 CCDs` - Value -- 12 CCDs for configuring CbsCpuCcdCtrl token.\n* `14 CCDs` - Value -- 14 CCDs for configuring CbsCpuCcdCtrl token.

```yaml
Type: BiosCbsCpuCcdCtrlC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsCpuCcdCtrlC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
