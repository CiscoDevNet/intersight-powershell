---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightMemoryPersistentMemoryLogicalNamespace

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightMemoryPersistentMemoryLogicalNamespace [-AdditionalProperties< Dictionary<string,object>>][-Capacity< long>][-ClassId< MemoryPersistentMemoryLogicalNamespace.ClassIdEnum>][-Mode< MemoryPersistentMemoryLogicalNamespace.ModeEnum>][-Name< string>][-ObjectType< MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum>][-SocketId< MemoryPersistentMemoryLogicalNamespace.SocketIdEnum>][-SocketMemoryId< MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum>]

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

### -Capacity
Capacity of this Namespace that is created or modified.

```yaml
Type: long
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
Type: MemoryPersistentMemoryLogicalNamespace.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Mode
Mode of this Namespace that is created or modified.\n* `raw` - The raw mode of Persistent Memory Namespace.\n* `block` - The block mode of Persistent Memory Namespace.

```yaml
Type: MemoryPersistentMemoryLogicalNamespace.ModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of this Namespace to be created on the server.

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
Type: MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SocketId
Socket ID of the region on which this Namespace has to be created or modified.\n* `1` - The first CPU socket in a server.\n* `2` - The second CPU socket in a server.\n* `3` - The third CPU socket in a server.\n* `4` - The fourth CPU socket in a server.

```yaml
Type: MemoryPersistentMemoryLogicalNamespace.SocketIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SocketMemoryId
Socket Memory ID of the region on which this Namespace has to be created or modified.\n* `Not Applicable` - The socket memory ID is not applicable if app-direct persistent memory type is selected in the goal.\n* `2` - The second socket memory ID within a socket in a server.\n* `4` - The fourth socket memory ID within a socket in a server.\n* `6` - The sixth socket memory ID within a socket in a server.\n* `8` - The eighth socket memory ID within a socket in a server.\n* `10` - The tenth socket memory ID within a socket in a server.\n* `12` - The twelfth socket memory ID within a socket in a server.

```yaml
Type: MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum
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
PS C:\> Initialize-IntersightMemoryPersistentMemoryLogicalNamespace
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
