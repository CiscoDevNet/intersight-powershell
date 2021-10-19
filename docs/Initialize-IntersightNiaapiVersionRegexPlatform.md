---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNiaapiVersionRegexPlatform

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNiaapiVersionRegexPlatform [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Anyllregex< string>][-ClassId< NiaapiVersionRegexPlatform.ClassIdEnum>][-Currentlltrain< Model.NiaapiSoftwareRegex>][-Latestsltrain< Model.NiaapiSoftwareRegex>][-ObjectType< NiaapiVersionRegexPlatform.ObjectTypeEnum>][-Sltrain< System.Collections.Generic.List`1[Model.NiaapiSoftwareRegex]>][-Upcominglltrain< Model.NiaapiSoftwareRegex>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Anyllregex
All long live version Regex pattern.

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
Type: NiaapiVersionRegexPlatform.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Currentlltrain
Current long live version Regex pattern.

Note :- Use Initialize-IntersightNiaapiSoftwareRegex to create the object of complex type NiaapiSoftwareRegex

```yaml
Type: Model.NiaapiSoftwareRegex
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Latestsltrain
Latest short live version Regex pattern.

Note :- Use Initialize-IntersightNiaapiSoftwareRegex to create the object of complex type NiaapiSoftwareRegex

```yaml
Type: Model.NiaapiSoftwareRegex
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: NiaapiVersionRegexPlatform.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sltrain


Note :- Use Initialize-IntersightNiaapiSoftwareRegex to create the object of complex type NiaapiSoftwareRegex

```yaml
Type: System.Collections.Generic.List`1[Model.NiaapiSoftwareRegex]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Upcominglltrain
Upcoming short live version Regex pattern.

Note :- Use Initialize-IntersightNiaapiSoftwareRegex to create the object of complex type NiaapiSoftwareRegex

```yaml
Type: Model.NiaapiSoftwareRegex
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
PS C:\> Initialize-IntersightNiaapiVersionRegexPlatform
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightNiaapiSoftwareRegex](./Initialize-IntersightNiaapiSoftwareRegex.md)
