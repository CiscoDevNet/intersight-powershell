---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightComputeStorageVirtualDriveOperation

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightComputeStorageVirtualDriveOperation [-AdditionalProperties< Dictionary<string,object>>][-AdminAction< ComputeStorageVirtualDriveOperation.AdminActionEnum>][-ClassId< ComputeStorageVirtualDriveOperation.ClassIdEnum>][-ControllerId< string>][-ObjectType< ComputeStorageVirtualDriveOperation.ObjectTypeEnum>][-VirtualDrives< List<Model.ComputeStorageVirtualDrive>>]

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
Administrative actions that can be performed on the Storage Virtual Drives.\n* `None` - No action on the selected Storage virtual Drives.\n* `Delete` - Delete action on the selected Storage Virtual Drives.

```yaml
Type: ComputeStorageVirtualDriveOperation.AdminActionEnum
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
Type: ComputeStorageVirtualDriveOperation.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ControllerId
Storage Controller Id of the storage Virtual Drives of the server.

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
Type: ComputeStorageVirtualDriveOperation.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualDrives


Note :- Use Initialize-IntersightComputeStorageVirtualDrive to create the object of complex type ComputeStorageVirtualDrive

```yaml
Type: System.Collections.Generic.List`1[Model.ComputeStorageVirtualDrive]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightComputeStorageVirtualDriveOperation
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightComputeStorageVirtualDrive](./Initialize-IntersightComputeStorageVirtualDrive.md)
