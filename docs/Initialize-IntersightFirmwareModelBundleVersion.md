---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareModelBundleVersion

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareModelBundleVersion [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BundleVersion< string>][-ClassId< FirmwareModelBundleVersion.ClassIdEnum>][-ModelFamily< FirmwareModelBundleVersion.ModelFamilyEnum>][-ObjectType< FirmwareModelBundleVersion.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -BundleVersion
The bundle version to which the server will be upgraded.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: FirmwareModelBundleVersion.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ModelFamily
The server family that will be impacted by this upgrade.\n* `UCSC-C220-M5` - The upgrade on all C220-M5 servers claimed in setup.\n* `UCSC-C220-M4` - The upgrade on all C220-M4 servers claimed in setup.\n* `UCSC-C240-M4` - The upgrade on all C240-M4 servers claimed in setup.\n* `UCSC-C460-M4` - The upgrade on all C460-M4 servers claimed in setup.\n* `UCSC-C240-M5` - The upgrade on all C240-M5 servers claimed in setup.\n* `UCSC-C480-M5` - The upgrade on all C480-M5 servers claimed in setup.\n* `UCSB-B200-M5` - The upgrade on all B200-M5 servers claimed in setup.\n* `UCSB-B480-M5` - The upgrade on all B480-M5 servers claimed in setup.\n* `UCSC-C220-M6` - The upgrade on all C220-M6 servers claimed in setup.\n* `UCSC-C240-M6` - The upgrade on all C240-M6 servers claimed in setup.\n* `UCSC-C225-M6` - The upgrade on all C225-M6 servers claimed in setup.\n* `UCSC-C245-M6` - The upgrade on all C245-M6 servers claimed in setup.\n* `UCSB-B200-M6` - The upgrade on all B200-M6 servers claimed in setup.\n* `UCSX-210C-M6` - The upgrade on all 210C-M6 servers claimed in setup.\n* `UCSX-210C-M7` - The upgrade on all 210C-M7 servers claimed in setup.\n* `UCSC-C220-M7` - The upgrade on all C220-M7 servers claimed in setup.\n* `UCSC-C240-M7` - The upgrade on all C240-M7 servers claimed in setup.\n* `UCSC-C125` - The upgrade on all C125 servers claimed in setup.\n* `UCSX-410C-M7` - The upgrade on all 410C-M7 servers claimed in setup.\n* `UCSC-C245-M8` - The upgrade on all UCSC-C245-M8 servers claimed in setup.\n* `UCSC-C225-M8` - The upgrade on all UCSC-C225-M8 servers claimed in setup.\n* `UCSX-215C-M8` - The upgrade on all UCSX-215C-M8 servers claimed in setup.\n* `UCSX-210C-M8` - The upgrade on all UCSX-210C-M8 servers claimed in setup.\n* `UCSX-410C-M8` - The upgrade on all UCSX-410C-M8 servers claimed in setup.\n* `UCSXE-130C-M8` - The upgrade on all UCSXE-130C-M8 servers claimed in setup.\n* `UCSC-C220-M8` - The upgrade on all UCSC-C220-M8 servers claimed in setup.\n* `UCSC-C240-M8` - The upgrade on all UCSC-C240-M8 servers claimed in setup.

```yaml
Type: FirmwareModelBundleVersion.ModelFamilyEnum
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
Type: FirmwareModelBundleVersion.ObjectTypeEnum
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
PS C:\> Initialize-IntersightFirmwareModelBundleVersion
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
