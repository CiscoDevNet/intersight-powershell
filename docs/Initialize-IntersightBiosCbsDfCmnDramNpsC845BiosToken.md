---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsDfCmnDramNpsC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsDfCmnDramNpsC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsDfCmnDramNpsC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsDfCmnDramNpsC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsDfCmnDramNpsC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsDfCmnDramNpsC845BiosToken.ClassIdEnum
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
Type: BiosCbsDfCmnDramNpsC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
The number of desired NUMA nodes per socket. Zero will attempt to interleave the two sockets together.\n* `Auto` - Value -- Auto for configuring CbsDfCmnDramNps token.\n* `NPS0` - Value -- NPS0 for configuring CbsDfCmnDramNps token.\n* `NPS1` - Value -- NPS1 for configuring CbsDfCmnDramNps token.\n* `NPS2` - Value -- NPS2 for configuring CbsDfCmnDramNps token.\n* `NPS4` - Value -- NPS4 for configuring CbsDfCmnDramNps token.

```yaml
Type: BiosCbsDfCmnDramNpsC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsDfCmnDramNpsC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
