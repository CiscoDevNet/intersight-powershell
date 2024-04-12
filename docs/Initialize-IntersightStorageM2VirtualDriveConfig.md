---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageM2VirtualDriveConfig

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageM2VirtualDriveConfig [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< StorageM2VirtualDriveConfig.ClassIdEnum>][-ControllerSlot< StorageM2VirtualDriveConfig.ControllerSlotEnum>][-Enable< bool>][-Name< string>][-ObjectType< StorageM2VirtualDriveConfig.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: StorageM2VirtualDriveConfig.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ControllerSlot
Select the M.2 RAID controller slot on which the virtual drive is to be created. Select &apos;MSTOR-RAID-1&apos; to create virtual drive on the M.2 RAID controller in the first slot or in the MSTOR-RAID slot, &apos;MSTOR-RAID-2&apos; for second slot, &apos;MSTOR-RAID-1, MSTOR-RAID-2&apos; for both slots or either slot.\n* `MSTOR-RAID-1` - Virtual drive  will be created on the M.2 RAID controller in the first slot.\n* `MSTOR-RAID-2` - Virtual drive  will be created on the M.2 RAID controller in the second slot, if available.\n* `MSTOR-RAID-1,MSTOR-RAID-2` - Virtual drive  will be created on the M.2 RAID controller in both the slots, if available.

```yaml
Type: StorageM2VirtualDriveConfig.ControllerSlotEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enable
If enabled, this will create a virtual drive on the M.2 RAID controller.

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
The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed. This field will be pre-populated with the default or user configured value which can be edited.

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
Type: StorageM2VirtualDriveConfig.ObjectTypeEnum
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
PS C:\> Initialize-IntersightStorageM2VirtualDriveConfig
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
