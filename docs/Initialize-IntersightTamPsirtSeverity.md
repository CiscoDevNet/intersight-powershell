---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightTamPsirtSeverity

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightTamPsirtSeverity [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< TamPsirtSeverity.ClassIdEnum>][-Level< TamPsirtSeverity.LevelEnum>][-ObjectType< TamPsirtSeverity.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: TamPsirtSeverity.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Level
Severity level associated with the security advisory.\n* `critical` - &amp;lt; If applicable, it may expose users to critical failures and it needs to be addressed immediately. For e.g. a PSIRT advisory with a corresponding CVSS score of above 9.0.\n* `high` - &amp;lt; If applicable, it may expose the users to critical failure and it needs to be addressed immediately. For e.g. a PSIRT advisory with a corresponding CVSS score between 7.0-8.9. These may be the vulnerabilities that are more difficult to exploit than the ones deemed critical but once exploited, the will cause critical failures.\n* `medium` - &amp;lt; If applicable, it may expose the users to failure of certain functions. for e.g. a PSIRT advisory with a corresponding CVSS score between 4.0-6.9. These may be the vulnerabilities that are mitigated to a large extent but that may still be exploited in certain restricted cases.\n* `info` - &amp;lt; If applicable, it may have some minimal impact for certain functions in the user environment. For e.g. a PSIRT advisory with a corresponding CVSS score below 4.0.

```yaml
Type: TamPsirtSeverity.LevelEnum
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
Type: TamPsirtSeverity.ObjectTypeEnum
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
PS C:\> Initialize-IntersightTamPsirtSeverity
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
