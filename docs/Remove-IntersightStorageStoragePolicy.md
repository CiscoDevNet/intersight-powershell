---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightStorageStoragePolicy

## SYNOPSIS
Remove the StorageStoragePolicy

## SYNTAX

```
Remove-IntersightStorageStoragePolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;StorageStoragePolicy&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightStorageStoragePolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified StorageStoragePolicy 

### Example 2
```powershell
PS C:\>Get-IntersightStorageStoragePolicy -Name "MoName"|  Remove-IntersightStorageStoragePolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of StorageStoragePolicy.

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

[Get-IntersightStorageStoragePolicy](./Get-IntersightStorageStoragePolicy.md)

[New-IntersightStorageStoragePolicy](./New-IntersightStorageStoragePolicy.md)

[Set-IntersightStorageStoragePolicy](./Set-IntersightStorageStoragePolicy.md)

