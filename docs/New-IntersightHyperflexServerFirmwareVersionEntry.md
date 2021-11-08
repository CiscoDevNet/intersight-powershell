---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexServerFirmwareVersionEntry

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexServerFirmwareVersionEntry [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Constraint< HyperflexAppSettingConstraint>][-Moid< string>][-ServerFirmwareVersion< HyperflexServerFirmwareVersionRelationship>][-ServerPlatform< HyperflexServerFirmwareVersionEntry.ServerPlatformEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;HyperflexServerFirmwareVersionEntry&apos; resource.

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

### -Constraint
The conditions that must be satisfied before applying the AppSetting.

Note :- Use Initialize-IntersightHyperflexAppSettingConstraint to create the object of complex type HyperflexAppSettingConstraint

```yaml
Type: HyperflexAppSettingConstraint
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

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

### -ServerFirmwareVersion
A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: HyperflexServerFirmwareVersionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerPlatform
The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server.

```yaml
Type: HyperflexServerFirmwareVersionEntry.ServerPlatformEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
The server firmware bundle version.

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
PS C:\> New-IntersightHyperflexServerFirmwareVersionEntry
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightHyperflexServerFirmwareVersionEntry](./Get-IntersightHyperflexServerFirmwareVersionEntry.md)

[Set-IntersightHyperflexServerFirmwareVersionEntry](./Set-IntersightHyperflexServerFirmwareVersionEntry.md)

[Remove-IntersightHyperflexServerFirmwareVersionEntry](./Remove-IntersightHyperflexServerFirmwareVersionEntry.md)

[Initialize-IntersightHyperflexAppSettingConstraint](./Initialize-IntersightHyperflexAppSettingConstraint.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
