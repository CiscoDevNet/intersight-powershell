---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightHyperflexSnapshotFiles

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightHyperflexSnapshotFiles [-AdditionalProperties< Dictionary<string,object>>][-ClassId< HyperflexSnapshotFiles.ClassIdEnum>][-NameTrackedFiles< List<Model.HyperflexFilePath>>][-ObjectType< HyperflexSnapshotFiles.ObjectTypeEnum>][-UuidTrackedDisksMap< List<Model.HyperflexMapUuidToTrackedDisk>>]

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
Type: HyperflexSnapshotFiles.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NameTrackedFiles


Note :- Use Initialize-IntersightHyperflexFilePath to create the object of complex type HyperflexFilePath

```yaml
Type: System.Collections.Generic.List`1[Model.HyperflexFilePath]
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
Type: HyperflexSnapshotFiles.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UuidTrackedDisksMap


Note :- Use Initialize-IntersightHyperflexMapUuidToTrackedDisk to create the object of complex type HyperflexMapUuidToTrackedDisk

```yaml
Type: System.Collections.Generic.List`1[Model.HyperflexMapUuidToTrackedDisk]
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
PS C:\> Initialize-IntersightHyperflexSnapshotFiles
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightHyperflexFilePath](./Initialize-IntersightHyperflexFilePath.md)

[Initialize-IntersightHyperflexMapUuidToTrackedDisk](./Initialize-IntersightHyperflexMapUuidToTrackedDisk.md)
