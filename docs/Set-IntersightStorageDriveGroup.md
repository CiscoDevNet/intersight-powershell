---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightStorageDriveGroup

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightStorageDriveGroup [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AutomaticDriveGroup< StorageAutomaticDriveGroup>][-ManualDriveGroup< StorageManualDriveGroup>][[-Moid]< string>][-Name< string>][-RaidLevel< StorageDriveGroup.RaidLevelEnum>][-SecureDriveGroup< bool>][-StoragePolicy< StorageStoragePolicyRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VirtualDrives< System.Collections.Generic.List`1[StorageVirtualDriveConfiguration]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;StorageDriveGroup&apos; resource.

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

### -AutomaticDriveGroup
This drive group is created using automatic drive selection.

Note :- Use Initialize-IntersightStorageAutomaticDriveGroup to create the object of complex type StorageAutomaticDriveGroup

```yaml
Type: StorageAutomaticDriveGroup
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ManualDriveGroup
This drive group is created by specifying the drive slots to be used.

Note :- Use Initialize-IntersightStorageManualDriveGroup to create the object of complex type StorageManualDriveGroup

```yaml
Type: StorageManualDriveGroup
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

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the drive group. The name can be between 1 and 64 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed.

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

### -RaidLevel
The supported RAID level for the disk group.\n* `Raid0` - RAID 0 Stripe Raid Level.\n* `Raid1` - RAID 1 Mirror Raid Level.\n* `Raid5` - RAID 5 Mirror Raid Level.\n* `Raid6` - RAID 6 Mirror Raid Level.\n* `Raid10` - RAID 10 Mirror Raid Level.\n* `Raid50` - RAID 50 Mirror Raid Level.\n* `Raid60` - RAID 60 Mirror Raid Level.

```yaml
Type: StorageDriveGroup.RaidLevelEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SecureDriveGroup
Enables/disables the drive security on all the drives used in this policy. This flag just enables the drive security and only after Remote/Manual key setting configured, the actual security will be applied.

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

### -StoragePolicy
A reference to a storageStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: StorageStoragePolicyRelationship
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

### -VirtualDrives


Note :- Use Initialize-IntersightStorageVirtualDriveConfiguration to create the object of complex type StorageVirtualDriveConfiguration

```yaml
Type: System.Collections.Generic.List`1[StorageVirtualDriveConfiguration]
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
PS C:\> Set-IntersightStorageDriveGroup
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightStorageDriveGroup](./Get-IntersightStorageDriveGroup.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightStorageAutomaticDriveGroup](./Initialize-IntersightStorageAutomaticDriveGroup.md)

[Initialize-IntersightStorageManualDriveGroup](./Initialize-IntersightStorageManualDriveGroup.md)

[Initialize-IntersightStorageVirtualDriveConfiguration](./Initialize-IntersightStorageVirtualDriveConfiguration.md)

[New-IntersightStorageDriveGroup](./New-IntersightStorageDriveGroup.md)

[Remove-IntersightStorageDriveGroup](./Remove-IntersightStorageDriveGroup.md)
