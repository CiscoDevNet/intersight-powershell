---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightMgmtConfigBackupOperation

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightMgmtConfigBackupOperation [-Account< IamAccountRelationship>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-Destination< MgmtConfigBackupOperation.DestinationEnum>][[-Moid]< string>][-Name< string>][-Options< MgmtBackupOptions>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UserBackupFile< MgmtConfigBackupFileRelationship>][-UserPassword< string>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;MgmtConfigBackupOperation&apos; resource.

## PARAMETERS

### -Account
A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamAccountRelationship
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

### -Description
Description of the backup operation.

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

### -Destination
Indicates whether the backup was created locally or imported.\n* `Local` - A local Intersight location.\n* `Uploaded` - A local location where the backup file is uploaded as mgmt.ConfigBackupFile MO. Intersight creates the backup from the uploaded location when this location type is set.\n* `Remote` - A remote location hosted in the user&apos;s datacenter.

```yaml
Type: MgmtConfigBackupOperation.DestinationEnum
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
User provided identifier for the backup operation.

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

### -Options
Options to control the behavior of the backup operation.

Note :- Use Initialize-IntersightMgmtBackupOptions to create the object of complex type MgmtBackupOptions

```yaml
Type: MgmtBackupOptions
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

### -UserBackupFile
A reference to a mgmtConfigBackupFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MgmtConfigBackupFileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UserPassword
The password provided by the user to decrypt a password encrypted backup file during import operation. \nThis password is used to decrypt the backup archive before validation when importing a password encrypted backup.\nThis field is optional and only required when importing a password encrypted backup file.

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
PS C:\> Set-IntersightMgmtConfigBackupOperation
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightMgmtConfigBackupOperation](./Get-IntersightMgmtConfigBackupOperation.md)

[Initialize-IntersightMgmtBackupOptions](./Initialize-IntersightMgmtBackupOptions.md)

[Initialize-IntersightMgmtCategoryExportData](./Initialize-IntersightMgmtCategoryExportData.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightMgmtConfigBackupOperation](./New-IntersightMgmtConfigBackupOperation.md)

[Remove-IntersightMgmtConfigBackupOperation](./Remove-IntersightMgmtConfigBackupOperation.md)
