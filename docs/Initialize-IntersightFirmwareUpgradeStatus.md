---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareUpgradeStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareUpgradeStatus [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Checksum< Model.ConnectorFileChecksum>][-ClassId< FirmwareUpgradeStatus.ClassIdEnum>][-DownloadError< string>][-DownloadMessage< string>][-DownloadPercentage< long>][-DownloadProgress< long>][-DownloadRetries< long>][-DownloadStage< string>][-EpPowerStatus< FirmwareUpgradeStatus.EpPowerStatusEnum>][-Moid< string>][-ObjectType< FirmwareUpgradeStatus.ObjectTypeEnum>][-OverallError< string>][-OverallPercentage< long>][-Overallstatus< FirmwareUpgradeStatus.OverallstatusEnum>][-PendingType< FirmwareUpgradeStatus.PendingTypeEnum>][-SdCardDownloadError< string>][-Sha256checksum< byte[]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: FirmwareUpgradeStatus.ClassIdEnum
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

### -DownloadMessage
The message from the endpoint during the download.

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

### -DownloadPercentage
The percentage of the image downloaded in the endpoint.

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

### -DownloadStage
The image download stages. Example:downloading, flashing.

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

### -EpPowerStatus
The server power status after the upgrade request is submitted in the endpoint.\n* `none` - Server power status is none.\n* `powered on` - Server power status is powered on.\n* `powered off` - Server power status is powered off.

```yaml
Type: FirmwareUpgradeStatus.EpPowerStatusEnum
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
Type: FirmwareUpgradeStatus.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OverallError
The reason for the operation failure.

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

### -OverallPercentage
The overall percentage of the operation.

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

### -Overallstatus
The overall status of the operation.\n* `none` - Upgrade stage is no upgrade stage.\n* `started` - Upgrade stage is started.\n* `prepare initiating` - Upgrade configuration is being prepared.\n* `prepare initiated` - Upgrade configuration is initiated.\n* `prepared` - Upgrade configuration is prepared.\n* `download initiating` - Upgrade stage is download initiating.\n* `download initiated` - Upgrade stage is download initiated.\n* `downloading` - Upgrade stage is downloading.\n* `downloaded` - Upgrade stage is downloaded.\n* `upgrade initiating on fabric A` - Upgrade stage is in upgrade initiating when upgrade is being started in endopint.\n* `upgrade initiated on fabric A` - Upgrade stage is in upgrade initiated when the upgrade has started in endpoint.\n* `upgrading fabric A` - Upgrade stage is in upgrading when the upgrade requires reboot to complete.\n* `rebooting fabric A` - Upgrade is in rebooting when the endpoint is being rebooted.\n* `upgraded fabric A` - Upgrade stage is in upgraded when the corresponding endpoint has completed.\n* `upgrade initiating on fabric B` - Upgrade stage is in upgrade initiating when upgrade is being started in endopint.\n* `upgrade initiated on fabric B` - Upgrade stage is in upgrade initiated when upgrade has started in endpoint.\n* `upgrading fabric B` - Upgrade stage is in upgrading when the upgrade requires reboot to complete.\n* `rebooting fabric B` - Upgrade is in rebooting when the endpoint is being rebooted.\n* `upgraded fabric B` - Upgrade stage is in upgraded when the corresponding endpoint has completed.\n* `upgrade initiating` - Upgrade stage is upgrade initiating.\n* `upgrade initiated` - Upgrade stage is upgrade initiated.\n* `upgrading` - Upgrade stage is upgrading.\n* `oob images staging` - Out-of-band component images staging.\n* `oob images staged` - Out-of-band component images staged.\n* `rebooting` - Upgrade is rebooting the endpoint.\n* `upgraded` - Upgrade stage is upgraded.\n* `success` - Upgrade stage is success.\n* `failed` - Upgrade stage is upgrade failed.\n* `terminated` - Upgrade stage is terminated.\n* `pending` - Upgrade stage is pending.\n* `ReadyForCache` - The image is ready to be cached into the Intersight Appliance.\n* `Caching` - The image will be cached into Intersight Appliance or an endpoint cache.\n* `Cached` - The image has been cached into the Intersight Appliance or endpoint cache.\n* `CachingFailed` - The image caching into the Intersight Appliance failed or endpoint cache.

```yaml
Type: FirmwareUpgradeStatus.OverallstatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PendingType
Pending reason for the upgrade waiting.\n* `none` - Upgrade pending reason is none.\n* `pending for next reboot` - Upgrade pending reason is pending for next reboot.

```yaml
Type: FirmwareUpgradeStatus.PendingTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SdCardDownloadError
The error message from the endpoint during the SD card download.

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
PS C:\> Initialize-IntersightFirmwareUpgradeStatus
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

[Initialize-Intersightbyte[]](./Initialize-Intersightbyte[].md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
