---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageVirtualDriveConfig

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageVirtualDriveConfig [-AccessPolicy< StorageVirtualDriveConfig.AccessPolicyEnum>][-AdditionalProperties< Dictionary<string,object>>][-BootDrive< bool>][-ClassId< StorageVirtualDriveConfig.ClassIdEnum>][-DiskGroupPolicy< string>][-DriveCache< StorageVirtualDriveConfig.DriveCacheEnum>][-ExpandToAvailable< bool>][-IoPolicy< StorageVirtualDriveConfig.IoPolicyEnum>][-Name< string>][-ObjectType< StorageVirtualDriveConfig.ObjectTypeEnum>][-ReadPolicy< StorageVirtualDriveConfig.ReadPolicyEnum>][-Size< long>][-StripSize< StorageVirtualDriveConfig.StripSizeEnum>][-WritePolicy< StorageVirtualDriveConfig.WritePolicyEnum>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AccessPolicy
Access policy that host has on this virtual drive.\n* `Default` - Use platform default access mode.\n* `ReadWrite` - Enables host to perform read-write on the VD.\n* `ReadOnly` - Host can only read from the VD.\n* `Blocked` - Host can neither read nor write to the VD.

```yaml
Type: StorageVirtualDriveConfig.AccessPolicyEnum
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

### -BootDrive
The flag enables the use of this virtual drive as a boot drive.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: StorageVirtualDriveConfig.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DiskGroupPolicy
Disk group policy that has the disk group in which this virtual drive needs to be created.

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

### -DriveCache
Drive Cache property expect disk cache policy.\n* `Default` - Use platform default drive cache mode.\n* `NoChange` - Drive cache policy is unchanged.\n* `Enable` - Enables IO caching on the drive.\n* `Disable` - Disables IO caching on the drive.

```yaml
Type: StorageVirtualDriveConfig.DriveCacheEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExpandToAvailable
The flag enables this virtual drive to use all the available space in the disk group. When this flag is configured, the size property is ignored.

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

### -IoPolicy
Desired IO mode - direct IO or cached IO.\n* `Default` - Use platform default IO mode.\n* `Direct` - Use direct IO for writing directly into the disk.\n* `Cached` - Use cached IO for writing into cache and then to disk.

```yaml
Type: StorageVirtualDriveConfig.IoPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed.

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
Type: StorageVirtualDriveConfig.ObjectTypeEnum
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
Type: StorageVirtualDriveConfig.ReadPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Size
Virtual drive size in MB. Size is mandatory field unless the &apos;Expand to Available&apos; option is enabled.

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

### -StripSize
The strip size is the portion of a stripe that resides on a single drive in the drive group. The stripe consists of the data segments that the RAID controller writes across multiple drives, not including parity drives.\n* `Default` - Use platform default strip size for a virtual drive.\n* `32k` - Enables a strip size of 32k for a virtual drive.\n* `64k` - Enables a strip size of 64k for a virtual drive.\n* `128k` - Enables a strip size of 128k for a virtual drive.\n* `256k` - Enables a strip size of 256k for a virtual drive.\n* `512k` - Enables a strip size of 512k for a virtual drive.\n* `1024k` - Enables a strip size of 1024k for a virtual drive.

```yaml
Type: StorageVirtualDriveConfig.StripSizeEnum
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
Type: StorageVirtualDriveConfig.WritePolicyEnum
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
PS C:\> Initialize-IntersightStorageVirtualDriveConfig
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
