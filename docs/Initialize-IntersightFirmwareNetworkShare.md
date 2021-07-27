---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareNetworkShare

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareNetworkShare [-AdditionalProperties< Dictionary<string,object>>][-CifsServer< Model.FirmwareCifsServer>][-ClassId< FirmwareNetworkShare.ClassIdEnum>][-HttpServer< Model.FirmwareHttpServer>][-MapType< FirmwareNetworkShare.MapTypeEnum>][-NfsServer< Model.FirmwareNfsServer>][-ObjectType< FirmwareNetworkShare.ObjectTypeEnum>][-Password< string>][-Upgradeoption< FirmwareNetworkShare.UpgradeoptionEnum>][-Username< string>]

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

### -CifsServer
CIFS file server option for network share upgrade.

Note :- Use Initialize-IntersightFirmwareCifsServer to create the object of complex type FirmwareCifsServer

```yaml
Type: Model.FirmwareCifsServer
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
Type: FirmwareNetworkShare.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HttpServer
HTTP (for WWW) file server option for network share upgrade.

Note :- Use Initialize-IntersightFirmwareHttpServer to create the object of complex type FirmwareHttpServer

```yaml
Type: Model.FirmwareHttpServer
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MapType
File server protocols such as CIFS, NFS, WWW for HTTP (S) that hosts the image.\n* `nfs` - File server protocol used is NFS.\n* `cifs` - File server protocol used is CIFS.\n* `www` - File server protocol used is WWW.

```yaml
Type: FirmwareNetworkShare.MapTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NfsServer
NFS file server option for network share upgrade.

Note :- Use Initialize-IntersightFirmwareNfsServer to create the object of complex type FirmwareNfsServer

```yaml
Type: Model.FirmwareNfsServer
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
Type: FirmwareNetworkShare.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Password
Password as configured on the file server.

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

### -Upgradeoption
Option to control the upgrade operation. Some examples, 1) nw_upgrade_mount_only - mount the image from a file server and run the upgrade on the next server boot and 2) nw_upgrade_full - mount the image and immediately run the upgrade.\n* `nw_upgrade_full` - Network upgrade option for full upgrade.\n* `nw_upgrade_mount_only` - Network upgrade mount only.

```yaml
Type: FirmwareNetworkShare.UpgradeoptionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Username
Username as configured on the file server.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightFirmwareNetworkShare
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightFirmwareCifsServer](./Initialize-IntersightFirmwareCifsServer.md)

[Initialize-IntersightFirmwareHttpServer](./Initialize-IntersightFirmwareHttpServer.md)

[Initialize-IntersightFirmwareNfsServer](./Initialize-IntersightFirmwareNfsServer.md)
