---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageKeySetting

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageKeySetting [-AdditionalProperties< Dictionary<string,object>>][-ClassId< StorageKeySetting.ClassIdEnum>][-KeyType< StorageKeySetting.KeyTypeEnum>][-ManualKey< Model.StorageLocalKeySetting>][-ObjectType< StorageKeySetting.ObjectTypeEnum>][-RemoteKey< Model.StorageRemoteKeySetting>]

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
Type: StorageKeySetting.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -KeyType
Method to be used for fetching the encryption key.\n* `None` - Drive encryption not configured.\n* `Manual` - Drive encryption using manual key.\n* `Kmip` - Remote encryption using KMIP.

```yaml
Type: StorageKeySetting.KeyTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ManualKey
Manual key configuration.

Note :- Use Initialize-IntersightStorageLocalKeySetting to create the object of complex type StorageLocalKeySetting

```yaml
Type: Model.StorageLocalKeySetting
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
Type: StorageKeySetting.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteKey
Remote key encryption using KMIP configuraiton.

Note :- Use Initialize-IntersightStorageRemoteKeySetting to create the object of complex type StorageRemoteKeySetting

```yaml
Type: Model.StorageRemoteKeySetting
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
PS C:\> Initialize-IntersightStorageKeySetting
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightStorageLocalKeySetting](./Initialize-IntersightStorageLocalKeySetting.md)

[Initialize-IntersightStorageRemoteKeySetting](./Initialize-IntersightStorageRemoteKeySetting.md)
