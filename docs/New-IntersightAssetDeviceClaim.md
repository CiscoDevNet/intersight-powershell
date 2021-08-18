---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightAssetDeviceClaim

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightAssetDeviceClaim [-AdditionalProperties< Dictionary<string,object>>][-DeviceUpdates< List<AssetConnectionControlMessage>>][-Moid< string>][-SecurityToken< string>][-SerialNumber< string>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &amp;apos;AssetDeviceClaim&amp;apos; resource.

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

### -DeviceUpdates


Note :- Use Initialize-IntersightAssetConnectionControlMessage to create the object of complex type AssetConnectionControlMessage

```yaml
Type: System.Collections.Generic.List`1[AssetConnectionControlMessage]
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

### -SecurityToken
Obtained from the device connector management UI or API (REST endpoint &apos;/connector/SecurityTokens&apos;).

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

### -SerialNumber
Obtained from the device connector management UI or API (REST endpoint &amp;apos;/connector/DeviceIdentifiers&amp;apos;).

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightAssetDeviceClaim
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightAssetDeviceClaim](./Remove-IntersightAssetDeviceClaim.md)

[Initialize-IntersightAssetConnectionControlMessage](./Initialize-IntersightAssetConnectionControlMessage.md)
