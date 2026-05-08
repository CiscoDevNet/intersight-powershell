---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ClassIdEnum
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
Type: BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
Maximum frequency used for XGMI PState in a 3-link topology.\n* `Auto` - Value -- Auto for configuring CbsDfCmn3LinkMaxXgmiSpeed token.\n* `20Gbps` - Value -- 20Gbps for configuring CbsDfCmn3LinkMaxXgmiSpeed token.\n* `25Gbps` - Value -- 25Gbps for configuring CbsDfCmn3LinkMaxXgmiSpeed token.\n* `32Gbps` - Value -- 32Gbps for configuring CbsDfCmn3LinkMaxXgmiSpeed token.

```yaml
Type: BiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsDfCmn3LinkMaxXgmiSpeedC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
