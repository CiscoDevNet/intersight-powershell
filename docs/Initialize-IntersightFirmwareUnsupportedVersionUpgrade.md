---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareUnsupportedVersionUpgrade

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareUnsupportedVersionUpgrade [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Checksum< Model.ConnectorFileChecksum>][-ClassId< FirmwareUnsupportedVersionUpgrade.ClassIdEnum>][-Distributable< Model.FirmwareDistributableRelationship>][-DownloadError< string>][-DownloadProgress< long>][-DownloadRetries< long>][-Moid< string>][-ObjectType< FirmwareUnsupportedVersionUpgrade.ObjectTypeEnum>][-PhysicalIdentity< Model.EquipmentPhysicalIdentityRelationship>][-Sha256checksum< byte[]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-UpgradeStatus< FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Checksum
The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file.

Note :- Use Initialize-IntersightConnectorFileChecksum to create the object of complex type ConnectorFileChecksum

```yaml
Type: Model.ConnectorFileChecksum
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
Type: FirmwareUnsupportedVersionUpgrade.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Distributable
A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.FirmwareDistributableRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DownloadError
Any error encountered. Set to empty when download is in progress or completed.

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

### -DownloadProgress
The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent.

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

### -DownloadRetries
The number of retries the plugin attempted before succeeding or failing the download.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: FirmwareUnsupportedVersionUpgrade.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PhysicalIdentity
A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.EquipmentPhysicalIdentityRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sha256checksum
The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file.

Note :- Use Initialize-Intersightbyte[] to create the object of complex type byte[]

```yaml
Type: byte[]
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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UpgradeStatus
Workflow status of firmware upgrade.\n* `None` - Upgrade status is none when upgrade is in progress.\n* `Completed` - Upgrade completed successfully.\n* `Failed` - Upgrade status is failed when upgrade has failed.

```yaml
Type: FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum
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
PS C:\> Initialize-IntersightFirmwareUnsupportedVersionUpgrade
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightConnectorFileChecksum](./Initialize-IntersightConnectorFileChecksum.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-Intersightbyte[]](./Initialize-Intersightbyte[].md)
