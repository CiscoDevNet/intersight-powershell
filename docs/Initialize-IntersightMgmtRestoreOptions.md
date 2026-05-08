---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightMgmtRestoreOptions

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightMgmtRestoreOptions [-ActionOnError< MgmtRestoreOptions.ActionOnErrorEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< MgmtRestoreOptions.ClassIdEnum>][-ObjectType< MgmtRestoreOptions.ObjectTypeEnum>][-OrgsToRestore< System.Collections.Generic.List`1[string]>][-RestoreAction< MgmtRestoreOptions.RestoreActionEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -ActionOnError
The action to be taken if an error is encountered during the restore operation.\n* `Continue` - The restore operation will continue on encountering an error.Any failure will be tagged as incomplete and the operation will continue importing other configurations.User shall review the partially imported configuration and fix later.\n* `Stop` - The restore operation will stop on encountering an error.Configurations that were changed as part of the restore operation till the error was encountered will remain in the system.\n* `Rollback` - Configurations that were changed as part of the restore operation till the error was encountered will be rolled back.

```yaml
Type: MgmtRestoreOptions.ActionOnErrorEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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
Type: MgmtRestoreOptions.ClassIdEnum
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
Type: MgmtRestoreOptions.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OrgsToRestore


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RestoreAction
Mechanism to be used for updating configurations as part of a restore operation.\n* `Merge` - Configurations in the backup will be merged with existing configurations in the target system.\n* `Replace` - Configurations in the target system will be replaced with the configurations in the backup.Configurations that are present only in the target system and not in the backup will be removed.

```yaml
Type: MgmtRestoreOptions.RestoreActionEnum
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
PS C:\> Initialize-IntersightMgmtRestoreOptions
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
