---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageVirtualDrivePolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageVirtualDrivePolicy [-AccessPolicy< StorageVirtualDrivePolicy.AccessPolicyEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< StorageVirtualDrivePolicy.ClassIdEnum>][-DriveCache< StorageVirtualDrivePolicy.DriveCacheEnum>][-ObjectType< StorageVirtualDrivePolicy.ObjectTypeEnum>][-ReadPolicy< StorageVirtualDrivePolicy.ReadPolicyEnum>][-StripSize< StorageVirtualDrivePolicy.StripSizeEnum>][-WritePolicy< StorageVirtualDrivePolicy.WritePolicyEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AccessPolicy
Access policy that host has on this virtual drive.\n* `Default` - Use platform default access mode.\n* `ReadWrite` - Enables host to perform read-write on the VD.\n* `ReadOnly` - Host can only read from the VD.\n* `Blocked` - Host can neither read nor write to the VD.

```yaml
Type: StorageVirtualDrivePolicy.AccessPolicyEnum
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
Type: StorageVirtualDrivePolicy.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DriveCache
Disk cache policy for the virtual drive.\n* `Default` - Use platform default drive cache mode.\n* `NoChange` - Drive cache policy is unchanged.\n* `Enable` - Enables IO caching on the drive.\n* `Disable` - Disables IO caching on the drive.

```yaml
Type: StorageVirtualDrivePolicy.DriveCacheEnum
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
Type: StorageVirtualDrivePolicy.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReadPolicy
Read ahead mode to be used to read data from this virtual drive.\n* `Default` - Use platform default read ahead mode.\n* `ReadAhead` - Use read ahead mode for the policy.\n* `NoReadAhead` - Do not use read ahead mode for the policy.

```yaml
Type: StorageVirtualDrivePolicy.ReadPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StripSize
Desired strip size - Allowed values are 64KiB, 128KiB, 256KiB, 512KiB, 1024KiB.\n* `64` - Number of bytes in a strip is 64 Kibibytes.\n* `128` - Number of bytes in a strip is 128 Kibibytes.\n* `256` - Number of bytes in a strip is 256 Kibibytes.\n* `512` - Number of bytes in a strip is 512 Kibibytes.\n* `1024` - Number of bytes in a strip is 1024 Kibibytes or 1 Mebibyte.

```yaml
Type: StorageVirtualDrivePolicy.StripSizeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WritePolicy
Write mode to be used to write data to this virtual drive.\n* `Default` - Use platform default write mode.\n* `WriteThrough` - Data is written through the cache and to the physical drives. Performance is improved, because subsequent reads of that data can be satisfied from the cache.\n* `WriteBackGoodBbu` - Data is stored in the cache, and is only written to the physical drives when space in the cache is needed. Virtual drives requesting this policy fall back to Write Through caching when the battery backup unit (BBU) cannot guarantee the safety of the cache in the event of a power failure.\n* `AlwaysWriteBack` - With this policy, write caching remains Write Back even if the battery backup unit is defective or discharged.

```yaml
Type: StorageVirtualDrivePolicy.WritePolicyEnum
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
PS C:\> Initialize-IntersightStorageVirtualDrivePolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
