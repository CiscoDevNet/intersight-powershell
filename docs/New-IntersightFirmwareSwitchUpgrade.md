---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFirmwareSwitchUpgrade

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFirmwareSwitchUpgrade [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DirectDownload< FirmwareDirectDownload>][-Distributable< FirmwareDistributableRelationship>][-EnableFabricEvacuation< bool>][-FileServer< SoftwarerepositoryFileServer>][-Moid< string>][-NetworkElements< System.Collections.Generic.List`1[NetworkElementRelationship]>][-NetworkShare< FirmwareNetworkShare>][-Release< SoftwarerepositoryReleaseRelationship>][-SkipEstimateImpact< bool>][-Status< FirmwareSwitchUpgrade.StatusEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UpgradeType< FirmwareSwitchUpgrade.UpgradeTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FirmwareSwitchUpgrade&apos; resource.

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

### -DirectDownload
Direct download options in case the upgradeType is direct download based upgrade.

Note :- Use Initialize-IntersightFirmwareDirectDownload to create the object of complex type FirmwareDirectDownload

```yaml
Type: FirmwareDirectDownload
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
Type: FirmwareDistributableRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableFabricEvacuation
The flag to enable or disable fabric evacuation during the switch firmware upgrade. In case of IMM, it is mandatory to have the Fabric Interconnects associated with domain profile for fabric evacuation to happen.

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

### -FileServer
Location of the image in user software repository.

Note :- Use Initialize-IntersightSoftwarerepositoryFileServer to create the object of complex type SoftwarerepositoryFileServer

```yaml
Type: SoftwarerepositoryFileServer
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

### -NetworkElements
An array of relationships to networkElement resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkElementRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NetworkShare
Deprecated (Use &apos;fileServer&apos; property). Network share options in case of the upgradeType is network share based upgrade.

Note :- Use Initialize-IntersightFirmwareNetworkShare to create the object of complex type FirmwareNetworkShare

```yaml
Type: FirmwareNetworkShare
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Release
A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: SoftwarerepositoryReleaseRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SkipEstimateImpact
User has the option to skip the estimate impact calculation.

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

### -Status
Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated.

```yaml
Type: FirmwareSwitchUpgrade.StatusEnum
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

### -UpgradeType
Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade.

```yaml
Type: FirmwareSwitchUpgrade.UpgradeTypeEnum
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
PS C:\> New-IntersightFirmwareSwitchUpgrade
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFirmwareSwitchUpgrade](./Get-IntersightFirmwareSwitchUpgrade.md)

[Remove-IntersightFirmwareSwitchUpgrade](./Remove-IntersightFirmwareSwitchUpgrade.md)

[Initialize-IntersightFirmwareDirectDownload](./Initialize-IntersightFirmwareDirectDownload.md)

[Initialize-IntersightSoftwarerepositoryFileServer](./Initialize-IntersightSoftwarerepositoryFileServer.md)

[Initialize-IntersightFirmwareNetworkShare](./Initialize-IntersightFirmwareNetworkShare.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
