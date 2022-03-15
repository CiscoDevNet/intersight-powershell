---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightVirtualizationVirtualDisk

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightVirtualizationVirtualDisk [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BillingUnitId< string>][-Capacity< string>][-Cluster< VirtualizationBaseClusterRelationship>][-EncryptionKey< string>][-EncryptionType< string>][-Mode< VirtualizationVirtualDisk.ModeEnum>][-Moid< string>][[-Name]< string>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-SourceCerts< string>][-SourceDiskToClone< string>][-SourceFilePath< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VolumeIopsInfo< CloudVolumeIopsInfo>][-Zone< CloudAvailabilityZone>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;VirtualizationVirtualDisk&apos; resource.

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

### -BillingUnitId
Billing rate for this resource.

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

### -Capacity
Disk capacity to be provided with units example - 10Gi.

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

### -Cluster
A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VirtualizationBaseClusterRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EncryptionKey
Encryption key used if volume is encrypted.

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

### -EncryptionType
Encryption method used to encrypt the volume.

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

### -Mode
File mode of the disk  example - Filesystem, Block.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported.

```yaml
Type: VirtualizationVirtualDisk.ModeEnum
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

### -Name
Name of the storage disk. Name must be unique within a Datastore.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -RegisteredDevice
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SourceCerts
Base64 encoded CA certificates of the https source to check against.

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

### -SourceDiskToClone
Source disk from which the content is copied.

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

### -SourceFilePath
Image path used to import on the created disk.

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

### -VolumeIopsInfo
Iops (input-output operations per sec) info for the volume.

Note :- Use Initialize-IntersightCloudVolumeIopsInfo to create the object of complex type CloudVolumeIopsInfo

```yaml
Type: CloudVolumeIopsInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Zone
Aws specific availabilty zone in a region.

Note :- Use Initialize-IntersightCloudAvailabilityZone to create the object of complex type CloudAvailabilityZone

```yaml
Type: CloudAvailabilityZone
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
PS C:\> New-IntersightVirtualizationVirtualDisk
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationVirtualDisk](./Get-IntersightVirtualizationVirtualDisk.md)

[Set-IntersightVirtualizationVirtualDisk](./Set-IntersightVirtualizationVirtualDisk.md)

[Remove-IntersightVirtualizationVirtualDisk](./Remove-IntersightVirtualizationVirtualDisk.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightCloudVolumeIopsInfo](./Initialize-IntersightCloudVolumeIopsInfo.md)

[Initialize-IntersightCloudAvailabilityZone](./Initialize-IntersightCloudAvailabilityZone.md)
