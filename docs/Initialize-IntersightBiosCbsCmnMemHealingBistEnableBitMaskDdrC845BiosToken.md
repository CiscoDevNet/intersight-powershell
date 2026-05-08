---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ClassIdEnum>][-ObjectType< BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ObjectTypeEnum>][-Value< BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ValueEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ClassIdEnum
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
Type: BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
This item enables a full memory test. Please note that this is a memory content test and is separate and distinct from the MBIST test of Interface and Data Eye.  PMU Mem BIST: this uses PMU firmware to test memory on all channels simultaneously. Failing memory will be repaired using soft or hard PPR depending on the PPR configuration.  Self-Healing Mem BIST: this runs the JEDEC DRAM self healing, if the device and DIMM support the feature. The DRAM will do a hard repair for failing memory.  PMU and Self-Healing Mem BIST: this option runs the PMU Mem BIST then the Self-Healing Mem BIST tests sequentially.\n* `Disabled` - Value -- Disabled for configuring CbsCmnMemHealingBistEnableBitMaskDdr token.\n* `PMU Mem BIST` - Value -- PMU Mem BIST for configuring CbsCmnMemHealingBistEnableBitMaskDdr token.\n* `Self-Healing Mem BIST` - Value -- Self-Healing Mem BIST for configuring CbsCmnMemHealingBistEnableBitMaskDdr token.\n* `PMU and Self-Healing Mem BIST` - Value -- PMU and Self-Healing Mem BIST for configuring CbsCmnMemHealingBistEnableBitMaskDdr token.

```yaml
Type: BiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken.ValueEnum
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
PS C:\> Initialize-IntersightBiosCbsCmnMemHealingBistEnableBitMaskDdrC845BiosToken
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
