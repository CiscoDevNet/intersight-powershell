---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightAssetDeviceRegistration

## SYNOPSIS
Remove the AssetDeviceRegistration

## SYNTAX

```
Remove-IntersightAssetDeviceRegistration -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Deletes the resource representing the device connector. All associated REST resources will be deleted. In particular, inventory and operational data associated with this device will be deleted.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightAssetDeviceRegistration -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified AssetDeviceRegistration 

### Example 2
```powershell
PS C:\>Get-IntersightAssetDeviceRegistration -Name "MoName"|  Remove-IntersightAssetDeviceRegistration
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of AssetDeviceRegistration.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS

[Set-IntersightAssetDeviceRegistration](./Set-IntersightAssetDeviceRegistration.md)

[Get-IntersightAssetDeviceRegistration](./Get-IntersightAssetDeviceRegistration.md)

