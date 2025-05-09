---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightStorageStoragePolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightStorageStoragePolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ControllerAttachedNvmeSlots< string>][-DefaultDriveMode< StorageStoragePolicy.DefaultDriveModeEnum>][-Description< string>][-DirectAttachedNvmeSlots< string>][-DriveGroup< System.Collections.Generic.List`1[StorageDriveGroupRelationship]>][-GlobalHotSpares< string>][-M2VirtualDrive< StorageM2VirtualDriveConfig>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]>][-Raid0Drive< StorageR0Drive>][-RaidAttachedNvmeSlots< string>][-SecureJbods< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UnusedDisksState< StorageStoragePolicy.UnusedDisksStateEnum>][-UseJbodForVdCreation< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;StorageStoragePolicy&apos; resource.

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

### -ControllerAttachedNvmeSlots
Only U.3 NVMe drives need to be specified, entered slots will be moved to controller attached mode. Allowed slots are 1-9, 21-24, 101-104. Allowed value is a comma or hyphen separated number ranges.

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

### -DefaultDriveMode
All unconfigured drives will move to the selected state on deployment. Newly inserted drives will move to the selected state. Select Unconfigured Good option to retain the existing configuration. Select JBOD to move the unconfigured drives to JBOD state. Select RAID0 to create a RAID0 virtual drive on each of the unconfigured drives. If JBOD is selected, unconfigured drives will move to JBOD state on host reboot. This setting is applicable only to selected set of controllers on FI attached servers.\n* `UnconfiguredGood` - Newly inserted drives or on reboot, drives will remain the same state.\n* `Jbod` - Newly inserted drives or on reboot, drives will automatically move to JBOD state if drive state was UnconfiguredGood.\n* `RAID0` - Newly inserted drives or on reboot, virtual drives will be created, respective drives will move to Online state.

```yaml
Type: StorageStoragePolicy.DefaultDriveModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the policy.

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

### -DirectAttachedNvmeSlots
Only U.3 NVMe drives need to be specified, entered slots will be moved to Direct attached mode. Allowed slots are 1-9, 21-24, 101-104. Allowed value is a comma or hyphen separated number ranges.

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

### -DriveGroup
An array of relationships to storageDriveGroup resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[StorageDriveGroupRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -GlobalHotSpares
A collection of disks that is to be used as hot spares, globally, for all the RAID groups. Allowed value is a number range separated by a comma or a hyphen.

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

### -M2VirtualDrive
Virtual Drive configuration for M.2 RAID controller.

Note :- Use Initialize-IntersightStorageM2VirtualDriveConfig to create the object of complex type StorageM2VirtualDriveConfig

```yaml
Type: StorageM2VirtualDriveConfig
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
Name of the concrete policy.

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

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Profiles
An array of relationships to policyAbstractConfigProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Raid0Drive
The list of disks where RAID0 virtual drives must be created on each individual drive.

Note :- Use Initialize-IntersightStorageR0Drive to create the object of complex type StorageR0Drive

```yaml
Type: StorageR0Drive
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RaidAttachedNvmeSlots
Only U.3 NVMe drives need to be specified, entered slots will be moved to RAID attached mode. Allowed slots are 1-4, 101-104. Allowed value is a comma or hyphen separated number ranges. Deprecated in favor of controllerAttachedNvmeSlots.

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

### -SecureJbods
JBOD drives specified in this slot range will be encrypted. Allowed values are &apos;ALL&apos;, or a comma or hyphen separated number range. Sample format is ALL or 1, 3 or 4-6, 8. Setting the value to &apos;ALL&apos; will encrypt all the unused UnconfigureGood/JBOD disks.

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

### -UnusedDisksState
State to which drives, not used in this policy, are to be moved. NoChange will not change the drive state. No Change must be selected if Default Drive State is set to JBOD or RAID0.\n* `NoChange` - Drive state will not be modified by Storage Policy.\n* `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group.\n* `Jbod` - JBOD state where the disks start showing up to Host OS.

```yaml
Type: StorageStoragePolicy.UnusedDisksStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UseJbodForVdCreation
Disks in JBOD State are used to create virtual drives. This setting must be disabled if Default Drive State is set to JBOD.

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
PS C:\> Set-IntersightStorageStoragePolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightStorageStoragePolicy](./Get-IntersightStorageStoragePolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightStorageM2VirtualDriveConfig](./Initialize-IntersightStorageM2VirtualDriveConfig.md)

[Initialize-IntersightStorageR0Drive](./Initialize-IntersightStorageR0Drive.md)

[New-IntersightStorageStoragePolicy](./New-IntersightStorageStoragePolicy.md)

[Remove-IntersightStorageStoragePolicy](./Remove-IntersightStorageStoragePolicy.md)
