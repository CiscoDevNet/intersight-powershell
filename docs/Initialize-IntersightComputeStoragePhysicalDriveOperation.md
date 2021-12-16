---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightComputeStoragePhysicalDriveOperation

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightComputeStoragePhysicalDriveOperation [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdminAction< ComputeStoragePhysicalDriveOperation.AdminActionEnum>][-ClassId< ComputeStoragePhysicalDriveOperation.ClassIdEnum>][-ControllerId< string>][-ObjectType< ComputeStoragePhysicalDriveOperation.ObjectTypeEnum>][-PhysicalDrives< System.Collections.Generic.List`1[Model.ComputeStoragePhysicalDrive]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AdminAction
Administrative actions that can be performed on the Storage Physical Drives.\n* `None` - No action on the selected Storage Physical Drives.\n* `SetJbod` - Set Jbod action state on the selected Storage Physical Drives.\n* `SetUnconfiguredGood` - Set Unconfigured Good action state on the selected Storage Physical Drives.

```yaml
Type: ComputeStoragePhysicalDriveOperation.AdminActionEnum
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
Type: ComputeStoragePhysicalDriveOperation.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ControllerId
Storage Controller Id of the storage Physical Drives of the server.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: ComputeStoragePhysicalDriveOperation.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PhysicalDrives


Note :- Use Initialize-IntersightComputeStoragePhysicalDrive to create the object of complex type ComputeStoragePhysicalDrive

```yaml
Type: System.Collections.Generic.List`1[Model.ComputeStoragePhysicalDrive]
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
PS C:\> Initialize-IntersightComputeStoragePhysicalDriveOperation
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightComputeStoragePhysicalDrive](./Initialize-IntersightComputeStoragePhysicalDrive.md)
