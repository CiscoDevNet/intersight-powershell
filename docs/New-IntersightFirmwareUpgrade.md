---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFirmwareUpgrade

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFirmwareUpgrade [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DirectDownload< FirmwareDirectDownload>][-Distributable< FirmwareDistributableRelationship>][-ExcludeComponentList< System.Collections.Generic.List`1[FirmwareUpgrade.ExcludeComponentListEnum]>][-ExcludeComponentPidList< FirmwareExcludeComponentPidListType>][-FileServer< SoftwarerepositoryFileServer>][-Moid< string>][-NetworkShare< FirmwareNetworkShare>][-Release< SoftwarerepositoryReleaseRelationship>][-Server< ComputePhysicalRelationship>][-SkipEstimateImpact< bool>][-Status< FirmwareUpgrade.StatusEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UpgradeTriggerMethod< FirmwareUpgrade.UpgradeTriggerMethodEnum>][-UpgradeType< FirmwareUpgrade.UpgradeTypeEnum>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FirmwareUpgrade&apos; resource.

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

### -ExcludeComponentList


```yaml
Type: System.Collections.Generic.List`1[FirmwareUpgrade.ExcludeComponentListEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExcludeComponentPidList
The components PIDs which are to be excluded for server firmware upgrade.

Note :- Use Initialize-IntersightFirmwareExcludeComponentPidListType to create the object of complex type FirmwareExcludeComponentPidListType

```yaml
Type: FirmwareExcludeComponentPidListType
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

### -Server
A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ComputePhysicalRelationship
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
Type: FirmwareUpgrade.StatusEnum
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

### -UpgradeTriggerMethod
The source that triggered the upgrade. Either via profile or traditional way.\n* `none` - Upgrade is invoked within the service.\n* `profileTrigger` - Upgrade is invoked from a profile deployment.

```yaml
Type: FirmwareUpgrade.UpgradeTriggerMethodEnum
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
Type: FirmwareUpgrade.UpgradeTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -IfNoneMatch
For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&apos;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&apos;s ETag doesn&apos;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&apos;t have to be identical byte for byte.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> New-IntersightFirmwareUpgrade
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFirmwareUpgrade](./Get-IntersightFirmwareUpgrade.md)

[Initialize-IntersightFirmwareDirectDownload](./Initialize-IntersightFirmwareDirectDownload.md)

[Initialize-IntersightFirmwareExcludeComponentPidListType](./Initialize-IntersightFirmwareExcludeComponentPidListType.md)

[Initialize-IntersightFirmwareNetworkShare](./Initialize-IntersightFirmwareNetworkShare.md)

[Initialize-IntersightFirmwareUpgrade.ExcludeComponentListEnum](./Initialize-IntersightFirmwareUpgrade.ExcludeComponentListEnum.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightSoftwarerepositoryFileServer](./Initialize-IntersightSoftwarerepositoryFileServer.md)

[Remove-IntersightFirmwareUpgrade](./Remove-IntersightFirmwareUpgrade.md)

[Set-IntersightFirmwareUpgrade](./Set-IntersightFirmwareUpgrade.md)
