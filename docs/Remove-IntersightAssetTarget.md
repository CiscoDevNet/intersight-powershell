---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightAssetTarget

## SYNOPSIS
Remove the AssetTarget

## SYNTAX

```
Remove-IntersightAssetTarget -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;AssetTarget&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightAssetTarget -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified AssetTarget 

### Example 2
```powershell
PS C:\>Get-IntersightAssetTarget -Name "MoName"|  Remove-IntersightAssetTarget
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of AssetTarget.

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

[New-IntersightAssetTarget](./New-IntersightAssetTarget.md)

[Get-IntersightAssetTarget](./Get-IntersightAssetTarget.md)

[Set-IntersightAssetTarget](./Set-IntersightAssetTarget.md)

