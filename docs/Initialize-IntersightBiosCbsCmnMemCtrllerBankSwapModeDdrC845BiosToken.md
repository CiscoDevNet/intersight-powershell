---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ClassIdEnum
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
Type: BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
BankSwapMode value: 0=Disabled, 1=SwapCPU.\n* `Auto` - Value -- Auto for configuring CbsCmnMemCtrllerBankSwapModeDdr token.\n* `Disabled` - Value -- Disabled for configuring CbsCmnMemCtrllerBankSwapModeDdr token.\n* `Swap CPU` - Value -- Swap CPU for configuring CbsCmnMemCtrllerBankSwapModeDdr token.

```yaml
Type: BiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsCmnMemCtrllerBankSwapModeDdrC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
