---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightApplianceDeviceUpgradePolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightApplianceDeviceUpgradePolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AutoUpgrade< bool>][-BlackoutDatesEnabled< bool>][-BlackoutEndDate< DateTime>][-BlackoutStartDate< DateTime>][-EnableMetaDataSync< bool>][[-Moid]< string>][-Schedule< OnpremSchedule>][-SoftwareDownloadType< ApplianceDeviceUpgradePolicy.SoftwareDownloadTypeEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;ApplianceDeviceUpgradePolicy&apos; resource.

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

### -AutoUpgrade
Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored.

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

### -BlackoutDatesEnabled
If enabled, allows the user to define a blackout period during which the appliance will not be upgraded.

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

### -BlackoutEndDate
End date of the black out period.

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

### -BlackoutStartDate
Start date of the black out period. The appliance will not be upgraded during this period.

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

### -EnableMetaDataSync
Indicates if the updated metadata files should be synced immediately or at the next upgrade.

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

### -Schedule
User defined schedule for upgrading the Intersight Appliance software.

Note :- Use Initialize-IntersightOnpremSchedule to create the object of complex type OnpremSchedule

```yaml
Type: OnpremSchedule
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SoftwareDownloadType
UpgradeType is used to indicate the kink of software upload to upgrade.\n* `unknown` - Indicates user setting of upgrade service to unknown.\n* `connected` - Indicates if the upgrade service is set to upload software to latest version automatically.\n* `manual` - Indicates if the upgrade service is set to upload software to user picked verison manually.

```yaml
Type: ApplianceDeviceUpgradePolicy.SoftwareDownloadTypeEnum
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
PS C:\> Set-IntersightApplianceDeviceUpgradePolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightApplianceDeviceUpgradePolicy](./Get-IntersightApplianceDeviceUpgradePolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightOnpremSchedule](./Initialize-IntersightOnpremSchedule.md)
