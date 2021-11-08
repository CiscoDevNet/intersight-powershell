---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBootLocalDisk

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBootLocalDisk [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Bootloader< Model.BootBootloader>][-ClassId< BootLocalDisk.ClassIdEnum>][-Enabled< bool>][-Name< string>][-ObjectType< BootLocalDisk.ObjectTypeEnum>][-Slot< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Bootloader
Details of the bootloader to be used during boot from local disk.

Note :- Use Initialize-IntersightBootBootloader to create the object of complex type BootBootloader

```yaml
Type: Model.BootBootloader
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
Type: BootLocalDisk.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enabled
Specifies if the boot device is enabled or disabled.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: BootLocalDisk.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot
The slot id of the local disk device. Supported values for Standalone Rack servers are (1-205, \&quot;M\&quot;, \&quot;HBA\&quot;, \&quot;SAS\&quot;, \&quot;RAID\&quot;, \&quot;MRAID\&quot;, \&quot;MRAID1\&quot;, \&quot;MRAID2\&quot;, \&quot;MSTOR-RAID\&quot;). Supported values for FI-attached servers are (1-205, \&quot;MRAID\&quot;, \&quot;FMEZZ1-SAS\&quot;, \&quot;MRAID1\&quot;, \&quot;MRAID2\&quot;, \&quot;MSTOR-RAID\&quot;, \&quot;MSTOR-RAID-1\&quot;, \&quot;MSTOR-RAID-2\&quot;).

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
PS C:\> Initialize-IntersightBootLocalDisk
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightBootBootloader](./Initialize-IntersightBootBootloader.md)
