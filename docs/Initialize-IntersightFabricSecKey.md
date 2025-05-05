---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFabricSecKey

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFabricSecKey [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< FabricSecKey.ClassIdEnum>][-CryptographicAlgorithm< FabricSecKey.CryptographicAlgorithmEnum>][-Id< string>][-KeyType< FabricSecKey.KeyTypeEnum>][-ObjectType< FabricSecKey.ObjectTypeEnum>][-OctetString< string>][-SendLifetimeDuration< long>][-SendLifetimeEndTime< DateTime>][-SendLifetimeInfinite< bool>][-SendLifetimeStartTime< DateTime>][-SendLifetimeTimeZone< FabricSecKey.SendLifetimeTimeZoneEnum>][-SendLifetimeUnlimited< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: FabricSecKey.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CryptographicAlgorithm
The cryptographic algorithm that employs the cipher-based message authentication code (CMAC) mode of operation with advanced encryption standard (AES).\n* `AES_256_CMAC` - Uses the AES (Advanced Encryption Standard) algorithm with a 256-bit key to generate a CMAC.\n* `AES_128_CMAC` - Uses the AES (Advanced Encryption Standard) algorithm with a 128-bit key to generate a CMAC.

```yaml
Type: FabricSecKey.CryptographicAlgorithmEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Id
Must have an even number of hexadecimal characters (including 0-9 and A-F, only) with a length between 2 and 64 characters. For example, \&quot;10\&quot;, \&quot;2000\&quot;, \&quot;ABCD1234\&quot;.

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

### -KeyType
The type of encryption used for the specified key.\n* `Type-0` - No encryption for the specified octetString.\n* `Type-6` - Proprietary advanced encryption standard for the specified octetString.\n* `Type-7` - Proprietary insecure encryption for the specified octetString.

```yaml
Type: FabricSecKey.KeyTypeEnum
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
Type: FabricSecKey.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OctetString
The key octet string is a shared secret used in cryptographic operations. The valid size and format of the octet string depend on the selected KeyCryptographicAlgorithm and KeyEncryptionType. It should start with the character &apos;J&apos;.

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

### -SendLifetimeDuration
The key lifetime duration in seconds after the start time. If a non-zero value is configured for the duration, the end time configuration for the key lifetime is ignored.

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

### -SendLifetimeEndTime
The time of day and date when the key becomes inactive.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SendLifetimeInfinite
Indicates that the key remains active indefinitely after the specified start time. When this parameter is set, the end time and duration configurations for the key lifetime are ignored.

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

### -SendLifetimeStartTime
The time of day and date when the key becomes active.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SendLifetimeTimeZone
The time zone used for key lifetime configurations.\n* `UTC` - The Universal Time (UTC) for key lifetime configurations.\n* `Local` - The local time zone of the device for key lifetime configurations.

```yaml
Type: FabricSecKey.SendLifetimeTimeZoneEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SendLifetimeUnlimited
Indicates that the key is always active. When this parameter is set, all other key lifetime configurations are ignored.

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
PS C:\> Initialize-IntersightFabricSecKey
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)
